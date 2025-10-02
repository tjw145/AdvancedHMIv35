Option Strict On

Public Class ExperimentSetupWindow

    Sub UpdateExperimentParameters()

        'Updates experiment parameters. Traverse time and displacement distance are multiplied by 10 here
        'and divided by 10 internally by the PLC. This is because the PLC can only accept integers. I did
        'this in order to add an extra decimal place of precision, i.e. 10.5 seconds, 3.4mm, etc.

        Globals.numberOfCycles = CInt(CyclesInput.Value)
        Globals.traverseTime_s = CInt(TraverseTimeInput.Value * 10)
        Globals.displacement_mm = CInt(DisplacementInput.Value * 10)

        'Converts from Hz to ms.
        Globals.dataLogRate_ms = CInt(1000 / DataLogRateInput.Value)

    End Sub

    Private Function CalculateRunTime(cycles As Decimal, traverseTime As Decimal) As TimeSpan

        Dim totalTime As TimeSpan = TimeSpan.FromSeconds(cycles * traverseTime * 2)
        Return totalTime

    End Function

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

    Private Sub ExperimentSetupWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click

        UpdateExperimentParameters()

    End Sub

    Private Sub TraverseTimeInput_ValueChanged(sender As Object, e As EventArgs) Handles TraverseTimeInput.ValueChanged

        If HardwareLimits.TestProfile(TraverseTimeInput.Value, DisplacementInput.Value) = False Then

            DisplacementInput.Value = HardwareLimits.AdjustDisplacement(TraverseTimeInput.Value, DisplacementInput.Value)

        End If

        EstTimeLabel.Text = (CalculateRunTime(CyclesInput.Value, TraverseTimeInput.Value)).ToString()

    End Sub

    Private Sub DisplacementInput_ValueChanged(sender As Object, e As EventArgs) Handles DisplacementInput.ValueChanged

        If HardwareLimits.TestProfile(TraverseTimeInput.Value, DisplacementInput.Value) = False Then

            TraverseTimeInput.Value = HardwareLimits.AdjustTime(TraverseTimeInput.Value, DisplacementInput.Value)

        End If

        EstTimeLabel.Text = (CalculateRunTime(CyclesInput.Value, TraverseTimeInput.Value)).ToString()

    End Sub

    Private Sub CyclesInput_ValueChanged(sender As Object, e As EventArgs) Handles CyclesInput.ValueChanged

        EstTimeLabel.Text = (CalculateRunTime(CyclesInput.Value, TraverseTimeInput.Value)).ToString()

    End Sub
End Class