Imports System.Windows.Forms

Public Class ExperimentSetupWindow

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel3.Paint

    End Sub

    Private Sub RecLinkToolTip_Popup(sender As Object, e As PopupEventArgs) Handles RecLinkToolTip.Popup
        Me.Text = "Link the data recording start & stop controls to the motion start & stop controls, so recording is handled automatically."
    End Sub

    Private Sub StartStopOnRecCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles StartStopOnRecCheckBox.CheckedChanged

    End Sub

    Private Sub StartStopOnRecCheckBox_MouseHover(sender As Object, e As EventArgs) Handles StartStopOnRecCheckBox.MouseHover
        Me.Show()
        Me.Activate()
        Me.Select()
        Me.CreateControl()
    End Sub

    Private Sub ManualMotionCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ManualMotionCheckBox.CheckedChanged

        If ManualMotionCheckBox.Checked = False Then

            Accel.Enabled = False
            Decel.Enabled = False
            Cruise.Enabled = False
            AccLbl.Enabled = False
            DecLbl.Enabled = False
            CruLbl.Enabled = False

        ElseIf ManualMotionCheckBox.Checked = True Then

            Accel.Enabled = True
            Decel.Enabled = True
            Cruise.Enabled = True
            AccLbl.Enabled = True
            DecLbl.Enabled = True
            CruLbl.Enabled = True


        End If

    End Sub

    Private Sub Accel_ValueChanged(sender As Object, e As EventArgs) Handles Accel.ValueChanged
        'MotionProfile.CalculateSteps(Accel.Value) <-------
        'these need to be sent to the PLC, not just generated like this
    End Sub

    Private Sub Decel_ValueChanged(sender As Object, e As EventArgs) Handles Decel.ValueChanged
        'MotionProfile.CalculateSteps(Decel.Value)
    End Sub

    Private Sub Cruise_ValueChanged(sender As Object, e As EventArgs) Handles Cruise.ValueChanged
        'MotionProfile.CalculateSteps(Cruise.Value)
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        GlobalInstances.MotionProfile1.GenerateProfile(NumericUpDown2.Value, NumericUpDown4.Value)

        Debug.WriteLine("A: " & GlobalInstances.MotionProfile1.AccelerationMM)
        Debug.WriteLine("D: " & GlobalInstances.MotionProfile1.DecelerationMM)
        Debug.WriteLine("C: " & GlobalInstances.MotionProfile1.CoastTime)
        Debug.WriteLine("TT: " & GlobalInstances.MotionProfile1.TotalMoveTime)

        Label9.Text = (GlobalInstances.MotionProfile1.TotalExperimentTime(NumericUpDown5.Value))

    End Sub

End Class
