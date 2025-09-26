Public Class ExperimentSetupWindow

    Private Sub CyclesHelp_Click(sender As Object, e As EventArgs) Handles CyclesHelp.Click
        CyclesHelpWindow.ShowDialog()
    End Sub

    Private Sub TraverseTimeHelp_Click(sender As Object, e As EventArgs) Handles TraverseTimeHelp.Click
        TraverseTimeHelpWindow.ShowDialog()
    End Sub

    Private Sub DisplacementHelp_Click(sender As Object, e As EventArgs) Handles DisplacementHelp.Click
        DisplacementHelpWindow.ShowDialog()
    End Sub

    Private Sub RadiiCompHelp_Click(sender As Object, e As EventArgs) Handles RadiiCompHelp.Click
        RadiiCompensationHelpWindow.ShowDialog()
    End Sub

    Private Sub ProgCompHelp_Click(sender As Object, e As EventArgs) Handles ProgCompHelp.Click
        ProgCompensationHelpWindow.ShowDialog()
    End Sub

    Private Sub DataLogRateHelp_Click(sender As Object, e As EventArgs) Handles DataLogRateHelp.Click
        DataLogRateHelpWindow.ShowDialog()
    End Sub
End Class