<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DispControlPanel = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MotionStepsInput = New System.Windows.Forms.DataGridView()
        Me.target = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dwell = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.recording = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel12 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ForceCheckBox = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel11 = New System.Windows.Forms.FlowLayoutPanel()
        Me.DispCheckBox = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel10 = New System.Windows.Forms.FlowLayoutPanel()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.FlowLayoutPanel8 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.hzLabel = New System.Windows.Forms.Label()
        Me.DispControlPanel.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.MotionStepsInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.recording.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel12.SuspendLayout()
        Me.FlowLayoutPanel11.SuspendLayout()
        Me.FlowLayoutPanel10.SuspendLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel8.SuspendLayout()
        Me.FlowLayoutPanel7.SuspendLayout()
        Me.FlowLayoutPanel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'DispControlPanel
        '
        Me.DispControlPanel.Controls.Add(Me.TabPage2)
        Me.DispControlPanel.Controls.Add(Me.TabPage3)
        Me.DispControlPanel.HotTrack = True
        Me.DispControlPanel.Location = New System.Drawing.Point(12, 12)
        Me.DispControlPanel.Name = "DispControlPanel"
        Me.DispControlPanel.SelectedIndex = 0
        Me.DispControlPanel.Size = New System.Drawing.Size(384, 245)
        Me.DispControlPanel.TabIndex = 86
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.MotionStepsInput)
        Me.TabPage2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(376, 219)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Displacement Control"
        '
        'MotionStepsInput
        '
        Me.MotionStepsInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MotionStepsInput.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.MotionStepsInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MotionStepsInput.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MotionStepsInput.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MotionStepsInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MotionStepsInput.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.target, Me.time, Me.dwell, Me.delete})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MotionStepsInput.DefaultCellStyle = DataGridViewCellStyle3
        Me.MotionStepsInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MotionStepsInput.EnableHeadersVisualStyles = False
        Me.MotionStepsInput.GridColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.MotionStepsInput.Location = New System.Drawing.Point(3, 3)
        Me.MotionStepsInput.Name = "MotionStepsInput"
        Me.MotionStepsInput.Size = New System.Drawing.Size(370, 213)
        Me.MotionStepsInput.TabIndex = 0
        '
        'target
        '
        Me.target.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.target.FillWeight = 112.3096!
        Me.target.HeaderText = "Target Position (mm):"
        Me.target.Name = "target"
        '
        'time
        '
        Me.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.time.FillWeight = 112.3096!
        Me.time.HeaderText = "Transition Time (Seconds):"
        Me.time.Name = "time"
        '
        'dwell
        '
        Me.dwell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dwell.FillWeight = 112.3096!
        Me.dwell.HeaderText = "Dwell Time (Seconds):"
        Me.dwell.Name = "dwell"
        Me.dwell.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dwell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'delete
        '
        Me.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.delete.DefaultCellStyle = DataGridViewCellStyle2
        Me.delete.FillWeight = 50.76142!
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete.HeaderText = ""
        Me.delete.MinimumWidth = 20
        Me.delete.Name = "delete"
        Me.delete.Text = "X"
        Me.delete.Width = 21
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TabPage3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(458, 219)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Force Control"
        '
        'recording
        '
        Me.recording.Controls.Add(Me.TableLayoutPanel3)
        Me.recording.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.recording.ForeColor = System.Drawing.Color.White
        Me.recording.Location = New System.Drawing.Point(406, 12)
        Me.recording.Name = "recording"
        Me.recording.Size = New System.Drawing.Size(268, 112)
        Me.recording.TabIndex = 88
        Me.recording.TabStop = False
        Me.recording.Text = "Data / Recording"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel12, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel11, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel10, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel8, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel7, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel6, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 21)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(262, 88)
        Me.TableLayoutPanel3.TabIndex = 46
        '
        'FlowLayoutPanel12
        '
        Me.FlowLayoutPanel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.FlowLayoutPanel12.Controls.Add(Me.ForceCheckBox)
        Me.FlowLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel12.Location = New System.Drawing.Point(192, 59)
        Me.FlowLayoutPanel12.Margin = New System.Windows.Forms.Padding(1)
        Me.FlowLayoutPanel12.Name = "FlowLayoutPanel12"
        Me.FlowLayoutPanel12.Size = New System.Drawing.Size(69, 28)
        Me.FlowLayoutPanel12.TabIndex = 73
        '
        'ForceCheckBox
        '
        Me.ForceCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ForceCheckBox.AutoSize = True
        Me.ForceCheckBox.Checked = True
        Me.ForceCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ForceCheckBox.Location = New System.Drawing.Point(3, 3)
        Me.ForceCheckBox.Name = "ForceCheckBox"
        Me.ForceCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.ForceCheckBox.TabIndex = 47
        Me.ForceCheckBox.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel11
        '
        Me.FlowLayoutPanel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.FlowLayoutPanel11.Controls.Add(Me.DispCheckBox)
        Me.FlowLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel11.Location = New System.Drawing.Point(192, 30)
        Me.FlowLayoutPanel11.Margin = New System.Windows.Forms.Padding(1)
        Me.FlowLayoutPanel11.Name = "FlowLayoutPanel11"
        Me.FlowLayoutPanel11.Size = New System.Drawing.Size(69, 27)
        Me.FlowLayoutPanel11.TabIndex = 72
        '
        'DispCheckBox
        '
        Me.DispCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DispCheckBox.AutoSize = True
        Me.DispCheckBox.Checked = True
        Me.DispCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DispCheckBox.Location = New System.Drawing.Point(3, 3)
        Me.DispCheckBox.Name = "DispCheckBox"
        Me.DispCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.DispCheckBox.TabIndex = 46
        Me.DispCheckBox.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel10
        '
        Me.FlowLayoutPanel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.FlowLayoutPanel10.Controls.Add(Me.NumericUpDown3)
        Me.FlowLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel10.Location = New System.Drawing.Point(192, 1)
        Me.FlowLayoutPanel10.Margin = New System.Windows.Forms.Padding(1)
        Me.FlowLayoutPanel10.Name = "FlowLayoutPanel10"
        Me.FlowLayoutPanel10.Size = New System.Drawing.Size(69, 27)
        Me.FlowLayoutPanel10.TabIndex = 71
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.AllowDrop = True
        Me.NumericUpDown3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NumericUpDown3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.NumericUpDown3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown3.DecimalPlaces = 2
        Me.NumericUpDown3.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown3.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown3.Location = New System.Drawing.Point(3, 3)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.NumericUpDown3.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(51, 21)
        Me.NumericUpDown3.TabIndex = 38
        Me.NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown3.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'FlowLayoutPanel8
        '
        Me.FlowLayoutPanel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.FlowLayoutPanel8.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel8.Location = New System.Drawing.Point(1, 30)
        Me.FlowLayoutPanel8.Margin = New System.Windows.Forms.Padding(1)
        Me.FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        Me.FlowLayoutPanel8.Size = New System.Drawing.Size(189, 27)
        Me.FlowLayoutPanel8.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Record displacment (mm):"
        '
        'FlowLayoutPanel7
        '
        Me.FlowLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.FlowLayoutPanel7.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(1, 59)
        Me.FlowLayoutPanel7.Margin = New System.Windows.Forms.Padding(1)
        Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        Me.FlowLayoutPanel7.Size = New System.Drawing.Size(189, 28)
        Me.FlowLayoutPanel7.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Record force (N):"
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.FlowLayoutPanel6.Controls.Add(Me.hzLabel)
        Me.FlowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(1, 1)
        Me.FlowLayoutPanel6.Margin = New System.Windows.Forms.Padding(1)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(189, 27)
        Me.FlowLayoutPanel6.TabIndex = 67
        '
        'hzLabel
        '
        Me.hzLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.hzLabel.AutoSize = True
        Me.hzLabel.ForeColor = System.Drawing.Color.White
        Me.hzLabel.Location = New System.Drawing.Point(3, 0)
        Me.hzLabel.Name = "hzLabel"
        Me.hzLabel.Size = New System.Drawing.Size(157, 17)
        Me.hzLabel.TabIndex = 39
        Me.hzLabel.Text = "Data capture rate (Hz):"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(686, 269)
        Me.Controls.Add(Me.recording)
        Me.Controls.Add(Me.DispControlPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Experiment Setup"
        Me.DispControlPanel.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.MotionStepsInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.recording.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel12.ResumeLayout(False)
        Me.FlowLayoutPanel12.PerformLayout()
        Me.FlowLayoutPanel11.ResumeLayout(False)
        Me.FlowLayoutPanel11.PerformLayout()
        Me.FlowLayoutPanel10.ResumeLayout(False)
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel8.ResumeLayout(False)
        Me.FlowLayoutPanel8.PerformLayout()
        Me.FlowLayoutPanel7.ResumeLayout(False)
        Me.FlowLayoutPanel7.PerformLayout()
        Me.FlowLayoutPanel6.ResumeLayout(False)
        Me.FlowLayoutPanel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DispControlPanel As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MotionStepsInput As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents target As DataGridViewTextBoxColumn
    Friend WithEvents time As DataGridViewTextBoxColumn
    Friend WithEvents dwell As DataGridViewTextBoxColumn
    Friend WithEvents delete As DataGridViewButtonColumn
    Friend WithEvents recording As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel12 As FlowLayoutPanel
    Friend WithEvents ForceCheckBox As CheckBox
    Friend WithEvents FlowLayoutPanel11 As FlowLayoutPanel
    Friend WithEvents DispCheckBox As CheckBox
    Friend WithEvents FlowLayoutPanel10 As FlowLayoutPanel
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents FlowLayoutPanel8 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents hzLabel As Label
End Class
