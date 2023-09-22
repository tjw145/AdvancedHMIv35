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

    Private Sub StartStopOnRecCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles StartStopOnRecCheckBox.CheckedChanged

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

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs)


    End Sub

    'Private Sub ExperimentSetupWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    With DataGridView1.ColumnHeadersDefaultCellStyle

    '        .ForeColor = Color.White
    '        .BackColor = Color.FromArgb(76, 78, 83)

    '    End With
    'End Sub
End Class
