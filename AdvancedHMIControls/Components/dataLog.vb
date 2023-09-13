
Imports System.ComponentModel
Imports System.IO

Public Class dataLog

    Private length As Integer
    Public filepath As String = Application.StartupPath & "\dataLog.csv"

    Private dataCaptureLog(3, length) As Double

    Public Function logData(dist, force, time, log)

        ReDim Preserve log(length)

        log(1, length) = time
        log(2, length) = dist
        log(3, length) = force

        length += 1
    End Function

    Public Function exportToCSV(path, log)

        Using log As New StreamWriter(path)
            For Each datum As Integer In log
                writer.WriteLine(datum)
            Next
        End Using

    End Function


End Class

