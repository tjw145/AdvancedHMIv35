﻿Imports System.Diagnostics.Eventing.Reader
Imports System.Runtime.CompilerServices

Public Class ExperimentSetupWindow

    Private Function CheckInputErrors(Grid As DataGridView) As Boolean

        'Checks to see that at least two positions have been added to the list, all time vales are greater than zero, and that all cells contain a value.
        'Returns true if an error is present, false is no error is present.

        If Grid.RowCount > 1 Then

            For row As Integer = 1 To (Grid.RowCount - 1)

                For column As Integer = 1 To (Grid.ColumnCount - 1)

                    If Grid.Item(column, row) Is Nothing Then

                        InputFeedback.Text = "❌ Error: all cells must contain a value."
                        Return True

                    End If

                Next


            Next

            For timeInputs As Integer = 0 To (Grid.RowCount - 2)

                If CDec(Grid.Item(1, timeInputs).Value) <= CDec(0) Then

                    InputFeedback.Text = "❌ Error: all time values must be greater than 0."
                    Return True

                End If

            Next

            Return False

        Else Return True

            InputFeedback.Text = "❌ Error: user must input more than one motion step."

        End If

    End Function

    Private Sub StepsInput_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DisplacementStepsInput.CellValueChanged

        If CheckInputErrors(DisplacementStepsInput) = False Then

            If MotionController.GenerateSteps(DisplacementStepsInput, MovePoints) = False Then

                StartReady = False
                InputFeedback.Text = "❌ Error: Maximum acceleration rate exceeded."
                MainForm.StartButton.BackColor = BackgroundDarkColor

            Else

                StartReady = True
                InputFeedback.Text = "✔ Ready"
                MainForm.StartButton.BackColor = Color.Green

            End If

        Else

            StartReady = False
            MainForm.StartButton.BackColor = BackgroundDarkColor

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OKbutton.Click
        ExperimentSetupWindow.ActiveForm.Close()
    End Sub

    Private Sub MotionStepsInput_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DisplacementStepsInput.CellContentClick

        'If DisplacementStepsInput.CurrentCell.ColumnIndex = 4 Then

        '    DisplacementStepsInput.Rows.Remove(DisplacementStepsInput.CurrentRow)

        'End If

    End Sub

    Private Sub CyclesControl_ValueChanged(sender As Object, e As EventArgs) Handles CyclesControl.ValueChanged
        cycles = CInt(CyclesControl.Value)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ControlForDisp.CheckedChanged

        If ControlForDisp.Checked = True Then

            DisplacementStepsInput.Enabled = True
            DisplacementStepsInput.Visible = True
            ControlForForce.CheckState = CheckState.Unchecked

        Else

            DisplacementStepsInput.Enabled = False
            DisplacementStepsInput.Visible = False

        End If

    End Sub

    Private Sub RecordingRateHz_ValueChanged(sender As Object, e As EventArgs) Handles RecordingRateHz.ValueChanged

        MainForm.ExperimentRecordingTimer.Interval = (1 / RecordingRateHz.Value) * 1000 'Ticks are in ms, input is in Hz.

    End Sub

    Private Sub ControlForForce_CheckedChanged(sender As Object, e As EventArgs) Handles ControlForForce.CheckedChanged

        If ControlForForce.Checked = True Then

            ForceStepsInput.Enabled = True
            ForceStepsInput.Visible = True
            ControlForDisp.CheckState = CheckState.Unchecked

        Else

            ForceStepsInput.Enabled = False
            ForceStepsInput.Visible = False

        End If

    End Sub

End Class