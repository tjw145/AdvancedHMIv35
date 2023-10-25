Option Strict On
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Graph

    Public Samples As Integer = 100
    Public UseRecordingData As Boolean = False

    Private rollingSampleData(Samples) As Integer

    Public Function CurrentData() As Integer()



    End Function

    Public Sub UpdateRollingGraph(point As Integer)

        For Each ele In rollingSampleData

            rollingSampleData(ele) = rollingSampleData(ele + 1)

        Next



    End Sub

End Class
