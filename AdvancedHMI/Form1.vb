Public Class DebugWindow
    Private Sub DebugWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refresh.Start()
    End Sub

    Private Sub Refresh_Tick(sender As Object, e As EventArgs) Handles Refresh.Tick

        If MainForm.MotionControlThread.IsBusy = True Then
            Label1.Text = "Y"
        Else Label1.Text = "N"
        End If

        If GlobalInstances.MotionController.MovesComplete = True Then
            Label2.Text = "Y"
        Else Label2.Text = "N"
        End If

        If MainForm.MotionControlThread.CancellationPending = True Then
            Label3.Text = "Y"
        Else Label3.Text = "N"
        End If

    End Sub
End Class