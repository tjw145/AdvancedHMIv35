Imports System.Diagnostics.Eventing.Reader

Public Class ExperimentSetupWindow

    Private Sub GenerateSteps(Grid As DataGridView, stepList As List(Of MotionProfile))

        stepList.Clear() 'invalidate current list

        For currentRow As Integer = 0 To (Grid.RowCount - 2)

            'Generates motion profile for each row, then sends them to the master step list.

            Dim CurrentStep As New MotionProfile
            Dim distance As Decimal = CDec(Grid.Item(0, currentRow).Value)
            Dim time As Decimal = CDec(Grid.Item(1, currentRow).Value)
            Dim dwell As Decimal = CDec(Grid.Item(2, currentRow).Value)

            CurrentStep.GenerateProfile(time, distance, dwell)
            stepList.Add(CurrentStep)

        Next

    End Sub

    Private Function CheckInputErrors(Grid As DataGridView) As Boolean

        'Checks to see that at least two positions have been added to the list, all time vales are greater than zero, and that all cells contain a value.
        'Returns true if an error is present, false is no error is present.

        If Grid.RowCount <> 0 Or 1 Then

            For row As Integer = 1 To (Grid.RowCount - 1)

                For column As Integer = 1 To (Grid.ColumnCount - 1)

                    If Grid.Item(column, row) Is Nothing Then

                        Debug.WriteLine("Input error: all cells must contain a value.")
                        Return True

                    End If

                Next


            Next

            For timeInputs As Integer = 0 To (Grid.RowCount - 2)

                If CDec(Grid.Item(1, timeInputs).Value) <= CDec(0) Then

                    Debug.WriteLine("Input error: all time values must be greater than 0.")
                    Return True

                End If

            Next

            Return False

        Else Return True

            Debug.WriteLine("Input error: user must input more than one motion step.")

        End If

    End Function

    Private Sub StepsInput_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DisplacementStepsInput.CellValueChanged

        If CheckInputErrors(DisplacementStepsInput) = False Then

            GenerateSteps(DisplacementStepsInput, MovePoints)

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OKbutton.Click
        ExperimentSetupWindow.ActiveForm.Close()
    End Sub

    Private Sub MotionStepsInput_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DisplacementStepsInput.CellContentClick

        If DisplacementStepsInput.CurrentCell.ColumnIndex = 4 Then

            DisplacementStepsInput.CurrentCell.Dispose()

        End If

    End Sub

    Private Sub CyclesControl_ValueChanged(sender As Object, e As EventArgs) Handles CyclesControl.ValueChanged
        cycles = CInt(CyclesControl.Value)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ControlForDisp.CheckedChanged

        If ControlForDisp.Checked = True Then

            DisplacementStepsInput.Enabled = True

        Else

            DisplacementStepsInput.Enabled = False

        End If

    End Sub

    Private Sub RecordingRateHz_ValueChanged(sender As Object, e As EventArgs) Handles RecordingRateHz.ValueChanged

        MainForm.ExperimentRecordingTimer.Interval = (1 / RecordingRateHz.Value) * 1000 'Ticks are in ms, input is in Hz.

    End Sub

End Class