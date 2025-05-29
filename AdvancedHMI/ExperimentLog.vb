Option Strict On

Imports System.IO


' The entire data capture system here REALLY ought to be run on a separate thread. Right now it's being run on the UI thread (!!!!!!) which
' could potentially cause a catastrophic recording error if something jams up the UI scanning process. I mean, theoretically, all of the
' controls should be locked against inputs, but the samples cost like $50,000 or whatever and I cost $14/hr. so I might as well fix it.
'
' (if you are reading this, i did not, in fact, fix it)

Public Class ExperimentLog

    Private length As Integer = 0
    Private timeLog() As String
    Private dispLog() As Decimal
    Private forceLog() As Integer

    Public Sub AddData(time As String, displacement As Integer, force As Integer)

        Try
            ReDim Preserve timeLog(length)
            ReDim Preserve dispLog(length)
            ReDim Preserve forceLog(length)

            timeLog(length) = time
            dispLog(length) = CDec(displacement) / 1000 'Values sent from the PLC are *1000, so this rescales the incoming data.
            forceLog(length) = force

            length += 1

        Catch ex As Exception

            Debug.WriteLine("Error recording data (possible datatype error).")

        End Try

    End Sub

    Public Sub ExportAsCSV(Optional file As String = Nothing)

        If file Is "" Or Nothing Then

            file = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "experiment_recording" & ".csv"

        End If

        'Using writer As New StreamWriter(IO.File.OpenWrite(file))
        Dim writer As StreamWriter
        writer = My.Computer.FileSystem.OpenTextFileWriter(file, False)

        With writer

            'Writes experimental parameters as metadata
            .WriteLine("SoftwareVersion:" & CStr(GlobalInstances.CurrentVersion))
            .WriteLine("Time: " & CStr(System.DateTime.Now))
            .WriteLine()
            .WriteLine("#Data capture rate (hz): " & CStr(ExperimentSetupWindow.RecordingRateHz.Value) & "Hz")
            .WriteLine("No. of Cycles: " & CStr(ExperimentSetupWindow.CyclesControl.Value))
            .WriteLine()

            'Headers (for motion inputs)
            .Write("Command #:" & ",")
            .Write("Move Dist. (mm):" & ",")
            .Write("Move Time (s):" & ",")
            .Write("Accel./Decel. (mm/s^2):" & ",")
            .Write("Peak Vel. (mm/s):")
            .WriteLine()

            'Inputs
            For index As Integer = 0 To (GlobalInstances.MovePoints.Count - 1)

                .Write("#" & (index + 1) & ",")
                .Write(GlobalInstances.MovePoints(index).NewPosition & ",")
                .Write((GlobalInstances.MovePoints(index).TotalMoveTimeMS) / 1000 & ",") ' Milliseconds to seconds conv.
                .Write(GlobalInstances.MovePoints(index).AccelerationMM & ",")
                .Write(GlobalInstances.MovePoints(index).PeakVelocityMM & ",")
                .WriteLine()

            Next

            'Write "end of metadata" marker
            .WriteLine("/metadata")
            .WriteLine()

            'Writes column headers
            .Write("Time (s): " & ",")
            .Write("Displacement (mm): " & ",")
            .Write("Force (N): " & ",")
            .WriteLine()


        End With

        'Writes all datapoints
        For currentLine As Integer = 0 To timeLog.Length - 1

            With writer

                .Write(timeLog(currentLine) & ",")
                .Write(dispLog(currentLine) & ",")
                .Write(forceLog(currentLine) & ",")
                .WriteLine()

            End With

        Next

        writer.Close()

        Debug.WriteLine("Export successful. File saved at: " & file)

    End Sub

End Class
