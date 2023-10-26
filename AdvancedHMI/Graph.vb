Option Strict On
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Graph

    Public Samples As Integer = 100
    Public SampleRateHz As Integer = 5
    Public UseRecordingData As Boolean = False

    Private rollingSampleData(Samples) As Integer
    Private rollingTimeData(Samples) As Integer

    Public Function CurrentData(sourceData As Double) As Series

        UpdateRollingGraph(sourceData)
        Dim OutputSeries As Series

        For i As Integer = 0 To rollingSampleData.Length

            OutputSeries.Points.AddY(rollingSampleData(i))

        Next

        Return OutputSeries

    End Function

    Public Sub UpdateRollingGraph(point As Double)

        For i As Integer = 0 To Samples

            'rollingTimeData(i) = 

        Next

        For Each ele In rollingSampleData

            rollingSampleData(ele) = rollingSampleData(ele + 1)

        Next

        ReDim Preserve rollingSampleData(Samples)

    End Sub

End Class
