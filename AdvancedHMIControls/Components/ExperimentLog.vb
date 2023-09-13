Option Strict Off

Imports System.IO

Public Class ExperimentLog

    Private length As Integer = 1
    Private timeLog() As String
    Private dispLog() As Integer
    Private forceLog() As Integer

    Public Sub AddData(time As String, displacement As Integer, force As Integer)

        Try
            ReDim Preserve timeLog(length)
            ReDim Preserve dispLog(length)
            ReDim Preserve forceLog(length)

            timeLog(length) = time
            dispLog(length) = displacement
            forceLog(length) = force

            length += 1

            Debug.WriteLine(time)

        Catch ex As Exception

            Debug.WriteLine("Error recording data (possible datatype error).")

        End Try

    End Sub

    Public Sub ExportAsCSV(Optional file As String = Nothing)

        'If file.Equals("" Or Nothing) Then

        '    file = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "experiment_recording" & ".csv"

        'End If

        Try

            'Using writer As New StreamWriter(IO.File.OpenWrite(file))

            '    For Each currentLine In timeLog

            '        With writer

            '            .Write(ToString(timeLog(currentLine) & ","))
            '            .Write(ToString(dispLog(currentLine) & ","))
            '            .Write(ToString(forceLog(currentLine) & ","))
            '            .WriteLine()

            '        End With

            '    Next

            '    writer.Close()

            'End Using

            For i = 0 To length

                Debug.Write(timeLog(i) & ",")
                Debug.Write(dispLog(i) & ",")
                Debug.Write(forceLog(i) & ",")
                Debug.WriteLine("")

            Next


            Debug.WriteLine("Export successful. File saved at: " & file)

        Catch ex As Exception

            Debug.WriteLine("Error while attempting to write CSV file.")

        End Try

    End Sub

End Class
