
Option Strict On
Public Module Hardware

    'This class contains information on the hardware of the flex rig.

    'This information is used to limit the commands that users can give to the
    'rig and prevent damage/failed experiments/weird stuff. It also includes
    'MODBUS data addresses that are hardcoded in the PLC for certain functions.

    'Thomas Waybright, 10/3/2025

    '================== MODBUS Addresses: ===================
    '(These var names correspond to the matching var names in the PLC's firmware)

    Public HOMING_ACTIVE As String = "016584"
    Public START_BIT As String = "017185"
    Public STOP_BIT As String = "017186"
    Public JOG_PLUS As String = "017187"
    Public JOG_MINUS As String = "017188"
    Public SET_ORIGIN As String = "017189"
    Public HOME As String = "017190"
    Public NO_OF_CYCLES_USER_INPUT As String = "400999"
    Public CYCLE_COMPLETE As String = "149162"
    Public DISPLACEMENT_USER_INPUT As String = "401000"
    Public TRAVERSE_TIME_USER_INPUT As String = "401001"
    Public CURRENT_DISPLACEMENT_ACCURATE As String = "400008"
    Public CURRENT_DISPLACEMENT_ROUGH As String = "400007"
    Public CURRENT_CYCLE_NUMBER As String = "449171"
    Public CONNECTION_TEST_BIT As String = "018384"

    '============== Maximum Physical Ratings: ===============

    Private maxRPM As Integer = 2400    ' motor sharft revolutions per minute
    Private maxAccel As Integer = 24    ' mm/s^2
    Private maxPPS As Integer = 100000  ' pulses per second

    '========== Physical Hardware Configurations: ===========

    Private stepsPerRev As Integer = 200
    Private uStepFactor As Integer = 8
    Private gearRatio As Integer = 5
    Private screwLead As Decimal = CDec(0.125) ' inches per revolution
    Private mmPerRev As Decimal = CDec(25.4 * (screwLead / gearRatio))
    Private maxVelocityMM As Decimal = maxRPM * mmPerRev / 60
    Private pulsesPerMM As Decimal = (1 * stepsPerRev / mmPerRev) * uStepFactor


    Public Function TestAccelProfile(moveTime As Decimal, distance As Decimal) As Boolean

        ' Tests the input motion parameters against the physical limits of the machine; if 
        ' within limits, returns true. If OOR, returns false.

        Dim accel As Double

        accel = (4.0 * distance) / (moveTime ^ 2)

        If accel <= maxAccel Then
            Return True
        Else Return False
        End If

        '<----------- needs max RPM testing as well, this may be an issue*

    End Function

    'Public Function TestVelocityProfile(moveTime As Decimal, distance As Decimal) As Boolean

    '    Dim velocity As Double
    '    Dim accel As Double

    '    accel = (4.0 * distance) / (moveTime ^ 2)
    '    velocity = moveTime * accel

    '    If velocity > maxVelocityMM Then
    '        Return False
    '    Else Return True
    '    End If

    'End Function


    Public Function AdjustTime(time As Decimal, displacement As Decimal) As Decimal
        'If the user adjusts displacement values out of range, this function will adjust the traverse time input
        'value to keep the motion profile within the limits of the machine.

        Dim newTime As Decimal
        If TestAccelProfile(time, displacement) = False Then

            newTime = CDec(Math.Sqrt(displacement * 4 / maxAccel))
            Return newTime

        End If

    End Function

    Public Function AdjustDisplacement(time As Decimal, displacement As Decimal) As Decimal
        'If the user adjusts traverse time values out of range, this function will adjust the displacement input
        'value to keep the motion profile within the limits of the machine.

        Dim newDisplacement As Decimal

        newDisplacement = CDec(maxAccel * (time ^ 2) / 4)
        Return newDisplacement

    End Function

End Module
