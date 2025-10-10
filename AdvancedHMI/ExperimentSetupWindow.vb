Option Strict On

Public Class ExperimentSetupWindow

    Sub UpdateExperimentParameters()

        'Updates experiment parameters. Traverse time and displacement distance are multiplied by factors of 10 here
        'and divided back out internally by the PLC. This is because the PLC can only accept integers. I did this in
        'order to add extra decimal place(s) of precision, i.e. 10.54 seconds, 3.4mm, etc.

        'I still have not figured out a way to *write* a double instead of just read one. I genuinely suspect the
        'AdvancedHMI lib might just be trash and I can't tell if it even has a feature for that. But, much like with
        'my health insurance company, they have provided me with absolutely zero access to docs. So does it really
        'make a difference, even if it's there? ¯\_(ツ)_/¯

        Globals.numberOfCycles = CInt(CyclesInput.Value)
        Globals.traverseTime_s = CInt(TraverseTimeInput.Value * 100)
        Globals.displacement_mm = CInt(DisplacementInput.Value * 10)

        'Converts from Hz to ms.
        Globals.dataLogRate_ms = CInt(1000 / DataLogRateInput.Value)
        MainForm.ExperimentRecordingTimer.Interval = Globals.dataLogRate_ms

    End Sub

    Sub LoadExperimentParameters()

        'Reloads stored experiment parameters from memory in "Globals" class. 

        CyclesInput.Value = Globals.numberOfCycles
        TraverseTimeInput.Value = CDec(Globals.traverseTime_s / 100)
        DisplacementInput.Value = CDec(Globals.displacement_mm / 10)

        'Converts from ms to Hz.
        DataLogRateInput.Value = CDec(1000 / (Globals.dataLogRate_ms))

    End Sub

    Private Sub ExperimentSetupWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadExperimentParameters()
        CalculateRunTime()

    End Sub

    Private Sub CalculateRunTime()

        Globals.estRunTime_s = (CyclesInput.Value * TraverseTimeInput.Value * 2)
        EstTimeLabel.Text = TimeSpan.FromSeconds(Globals.estRunTime_s).ToString("hh\:mm\:ss")

    End Sub

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

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click

        UpdateExperimentParameters()

    End Sub

    Private Sub TraverseTimeInput_ValueChanged(sender As Object, e As EventArgs) Handles TraverseTimeInput.ValueChanged

        If Hardware.TestAccelProfile(TraverseTimeInput.Value, DisplacementInput.Value) = False Then

            DisplacementInput.Value = Hardware.AdjustDisplacement(TraverseTimeInput.Value, DisplacementInput.Value)

        End If

        CalculateRunTime()

    End Sub

    Private Sub DisplacementInput_ValueChanged(sender As Object, e As EventArgs) Handles DisplacementInput.ValueChanged

        If Hardware.TestAccelProfile(TraverseTimeInput.Value, DisplacementInput.Value) = False Then

            TraverseTimeInput.Value = Hardware.AdjustTime(TraverseTimeInput.Value, DisplacementInput.Value)

        End If

        CalculateRunTime()

    End Sub

    Private Sub CyclesInput_ValueChanged(sender As Object, e As EventArgs) Handles CyclesInput.ValueChanged

        CalculateRunTime()

    End Sub
End Class