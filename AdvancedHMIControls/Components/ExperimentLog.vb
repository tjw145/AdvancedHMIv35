Option Strict On

Imports System.IO

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

            'If length = 1 Then

            '    time = "0"

            'End If

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

            'Writes column headers
            .Write("Time (s): " & ",")
            .Write("Displacement (mm): " & ",")
            .Write("Force (N): " & ",")
            .WriteLine()

        End With

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
