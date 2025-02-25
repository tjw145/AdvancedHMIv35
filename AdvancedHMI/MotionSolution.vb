Option Strict On

Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Media.Animation
Imports AdvancedHMIControls
Imports AdvancedHMIDrivers

Public Class MotionControlSolution

    'This class contains methods for sending commands to the flexure rig's programmable logic controller.
    '
    'Note: Our PLC cannot recieve direct commands from the PC -- the PC can only write values to a few selected
    'memory registers. Because of this, the only way to communicate a complete cycle's worth of move-commands
    'is to feed them from the PC to the PLC one move at a time. After each command has been executed, the next 
    'command is given. 
    '
    'Thomas Waybright, 2/12/2025

    '============== Hard-coded PLC memory address values: ===============

    Private plcACKaddress As String = "017384"                  'Move command acknowledgement bit address
    Private plcReceipt As String = "017383"                     'Sent to the PLC after data is transfered as a check
    Private plcRequestDataTrigger As String = "018287"          'Forces the PLC to ask for a command

    Private plcNextMoveTargetAddress As String = "416585"      'Memory addresss of next move command; current command handled internally by PLC /
    Private plcNextMoveAccelAddress As String = "416587"
    Private plcNextMoveDwellTimeAddress As String = "416589"   ' /
    Private plcRunAddress As String = "017183"                  '"Run" button
    Private plcStopAddress As String = "017186"                 '"Stop" button

    '====================================================================

    Public ProgressValue As Decimal
    Public MovesComplete As Boolean = False
    Private disposedValue As Boolean
    Public Event OnFinished()

    '====================================================================

    Public Function GenerateSteps(Grid As DataGridView, stepList As List(Of MotionProfile)) As Boolean

        stepList.Clear() 'invalidate current list

        For currentRow As Integer = 0 To (Grid.RowCount - 2)

            'Generates motion profile for each row, then sends them to the master step list.

            Dim CurrentStep As New MotionProfile
            Dim distance As Decimal = CDec(Grid.Item(0, currentRow).Value)
            Dim time As Decimal = CDec(Grid.Item(1, currentRow).Value)
            Dim dwell As Decimal = CDec(Grid.Item(2, currentRow).Value)

            If CurrentStep.GenerateProfile(time, distance, dwell) = False Then

                Return False

            End If

            stepList.Add(CurrentStep)

        Next

        Return True

    End Function

    Public Function MoveToStartPosition(modbusDriver As ModbusTCPCom, motionProfiles As List(Of MotionProfile)) As Boolean

        ' This function takes the difference between the platform's current position and its desired starting position,
        ' and commands the platform to move there using the user-defined experiment parameters. This move-command is 
        ' limited to an acceleration equal to that of the first step in the "experiment procedure" window.

        Dim currentPosition As Decimal = CDec(MainForm.ModbusTCPCom1.Read("400008")) ' Pulses
        Dim firstPosInCycle As Decimal = motionProfiles(0).TargetPositionPLC         ' Pulses
        Dim firstPointAccel As Decimal = motionProfiles(0).AccelerationPLC           ' Pulses/sec^2

        ' d = (1/4)at^2    - pulses
        ' a = 4d/t^2       - pulses/sec^2 
        ' t = sqrt(4d/a)   - seconds

        ' We're using 4 here rather than 2 (like in the typical kinnematic eq.) to account for both acceleration
        ' and deceleration of the platform.

        Dim distance As Decimal = Math.Abs(currentPosition - firstPosInCycle) ' The missile knows where it Is at all times. It knows this because it knows where it isn't. By subtracting where it is from where it isn't, or where it isn't from where it is (whichever is greater), it obtains a difference, or deviation. The guidance subsystem uses deviations to generate corrective commands to drive the missile from a position where it is to a position where it isn't, and arriving at a position where it wasn't, it now is. Consequently, the position where it is, is now the position that it wasn't, and it follows that the position that it was, is now the position that it isn't. In the event that the position that it Is in Is Not the position that it wasn't, the system has acquired a variation, the variation being the difference between where the missile is, and where it wasn't. If variation is considered to be a significant factor, it too may be corrected by the GEA. However, the missile must also know where it was. The missile guidance computer scenario works As follows. Because a variation has modified some Of the information the missile has obtained, it Is Not sure just where it Is. However, it Is sure where it isn't, within reason, and it knows where it was. It now subtracts where it should be from where it wasn't, or vice-versa, and by differentiating this from the algebraic sum of where it shouldn't be, and where it was, it is able to obtain the deviation and its variation, which is called error.
        Dim time As Decimal = CDec(Math.Sqrt(4 * distance / firstPointAccel))
        Dim dwell As Decimal = 0


        Dim moveCommand As New MotionProfile

        If moveCommand.GenerateProfile(time, distance, dwell) = False Then

            Return False

        End If

        StartMotionDataTransfer(modbusDriver)

        If CBool(modbusDriver.Read(plcACKaddress)) = False Then 'Checks if ACK reads low before sending

            If SendCommand(modbusDriver, moveCommand) = True Then 'And if we can successfully send over the command

                Return True

            Else

                Debug.WriteLine("Motion command procedure timeout")

            End If

        End If

    End Function

    Public Async Sub OutputMotionSolution(modbusDriver As ModbusTCPCom, motionProfiles As List(Of MotionProfile), cycles As Integer)

        'Gets all point-to-point motion profiles generated by the MotionProfile class and loads them into a private, untouchable list while operations are being run.
        'Probably unnecessary but I'm paranoid at this point.

        Dim StepList As List(Of MotionProfile)
        StepList = motionProfiles

        Dim totalNumberOfSteps As Integer = StepList.Count
        Dim currentStepNumber As Integer = 0
        Dim finalMoveTime As Integer = StepList(totalNumberOfSteps - 1).TotalMoveTimeMS

        For cycleNumber As Integer = 0 To cycles - 1

            While currentStepNumber < totalNumberOfSteps

                If cycleNumber = 0 Then

                    StartMotionDataTransfer(modbusDriver)

                End If

                If CBool(modbusDriver.Read(plcACKaddress)) = False Then 'Checks if ACK reads low before sending

                    If SendCommand(modbusDriver, StepList(currentStepNumber)) = True Then 'And if we can successfully send over the command

                        currentStepNumber += 1 'Then move to the next step
                        ProgressValue = CalculateProgress(cycleNumber + 1, cycles, currentStepNumber + 1, StepList.Count)

                    Else

                        Debug.WriteLine("Motion command procedure timeout")

                    End If

                End If

            End While

            currentStepNumber = 0 'Reset step counter for new cycle

        Next

        'Wait for the final move to finish, plus a little extra, before triggering "stop" bit.
        Thread.Sleep(finalMoveTime + 200)
        modbusDriver.BeginWrite(plcStopAddress, 1, New String() {"1"})

        MovesComplete = True
        RaiseEvent OnFinished()
        modbusDriver.BeginWrite(plcRunAddress, 1, New String() {"0"}) 'Turn "run" bit off 



    End Sub

    Private Function SendCommand(driver As ModbusTCPCom, profile As MotionProfile) As Boolean

        Dim ACK As Boolean = False 'AdvancedHMI returns a string of "0" "1" "False" or "True." No explaination. No documentation. Just magic. Converting to bool seems to work I guess?

        While ACK = False

            For i As Integer = 0 To 10

                Try

                    'Check for changes every (x)ms. Blocking function.
                    ACK = CBool(driver.Read(plcACKaddress))
                    Thread.Sleep(30)

                Catch ex As Exception

                    Debug.WriteLine("PLC connection error; could not check for ACK.")

                End Try

                Try

                    With driver

                        'Send motion profile data for current command
                        .Write(plcNextMoveTargetAddress, CStr(profile.TargetPositionPLC))
                        .Write(plcNextMoveAccelAddress, CStr(profile.AccelerationPLC))
                        .Write(plcNextMoveDwellTimeAddress, CStr(profile.DwellTime))

                        'Send PLC a data receipt after sending motion data
                        .BeginWrite(plcReceipt, 1, New String() {"1"})

                    End With

                Catch ex As Exception

                    Debug.WriteLine("PLC connection error; could not send data.")

                End Try

            Next


        End While

        'If acknowledged, break loop and return true
        Return True


    End Function

    Private Sub StartMotionDataTransfer(driver As ModbusTCPCom)

        driver.BeginWrite(plcRequestDataTrigger, 1, New String() {"1"})     'Triggers request before first command execution
        driver.BeginWrite(plcRunAddress, 1, New String() {"1"})             'Triggers "start" bit
        Thread.Sleep(30)                                                    'Blocked wait time for 30ms to allow for the PLC to catch up. Maybe unneeded?

    End Sub

    Private Function CalculateProgress(cycleCurrent As Integer, totalCycles As Integer, stepCurrent As Integer, totalSteps As Integer) As Decimal

        Return (CDec(cycleCurrent - 1) * totalSteps) / (totalCycles * totalSteps)

    End Function

End Class
