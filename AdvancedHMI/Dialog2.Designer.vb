<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExperimentSetupWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.dispTarget = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.hzLabel = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TimeLeftLabel = New System.Windows.Forms.Label()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.recording = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.StartStopOnRecCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ForceCheckBox = New System.Windows.Forms.CheckBox()
        Me.DispCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.motion = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cruise = New System.Windows.Forms.NumericUpDown()
        Me.CruLbl = New System.Windows.Forms.Label()
        Me.Decel = New System.Windows.Forms.NumericUpDown()
        Me.Accel = New System.Windows.Forms.NumericUpDown()
        Me.AccLbl = New System.Windows.Forms.Label()
        Me.ManualMotionCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DecLbl = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.NumericUpDown6 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown7 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown8 = New System.Windows.Forms.NumericUpDown()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ControlForDisplacementCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.MovePointsTabs = New System.Windows.Forms.TabControl()
        Me.DispPage = New System.Windows.Forms.TabPage()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RecLinkToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.recording.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.motion.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.Cruise, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Decel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Accel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.MovePointsTabs.SuspendLayout()
        Me.DispPage.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 564)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(965, 35)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.OK_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.OK_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.ForeColor = System.Drawing.Color.White
        Me.OK_Button.Location = New System.Drawing.Point(394, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(85, 29)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Cancel_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.ForeColor = System.Drawing.Color.White
        Me.Cancel_Button.Location = New System.Drawing.Point(485, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(85, 29)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'dispTarget
        '
        Me.dispTarget.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dispTarget.AutoSize = True
        Me.dispTarget.ForeColor = System.Drawing.Color.White
        Me.dispTarget.Location = New System.Drawing.Point(815, 423)
        Me.dispTarget.Name = "dispTarget"
        Me.dispTarget.Size = New System.Drawing.Size(99, 13)
        Me.dispTarget.TabIndex = 40
        Me.dispTarget.Text = "Displacement (mm):"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.AllowDrop = True
        Me.NumericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NumericUpDown1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.NumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown1.DecimalPlaces = 1
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown1.Location = New System.Drawing.Point(828, 465)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {49, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(51, 16)
        Me.NumericUpDown1.TabIndex = 41
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {254, 0, 0, 65536})
        '
        'hzLabel
        '
        Me.hzLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.hzLabel.AutoSize = True
        Me.hzLabel.ForeColor = System.Drawing.Color.White
        Me.hzLabel.Location = New System.Drawing.Point(3, 6)
        Me.hzLabel.Name = "hzLabel"
        Me.hzLabel.Size = New System.Drawing.Size(157, 17)
        Me.hzLabel.TabIndex = 39
        Me.hzLabel.Text = "Data capture rate (Hz):"
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.AllowDrop = True
        Me.NumericUpDown3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NumericUpDown3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.NumericUpDown3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown3.DecimalPlaces = 2
        Me.NumericUpDown3.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown3.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown3.Location = New System.Drawing.Point(193, 4)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.NumericUpDown3.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(51, 21)
        Me.NumericUpDown3.TabIndex = 38
        Me.NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown3.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(537, 360)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Time remaining:"
        '
        'TimeLeftLabel
        '
        Me.TimeLeftLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TimeLeftLabel.AutoSize = True
        Me.TimeLeftLabel.ForeColor = System.Drawing.Color.White
        Me.TimeLeftLabel.Location = New System.Drawing.Point(760, 483)
        Me.TimeLeftLabel.Name = "TimeLeftLabel"
        Me.TimeLeftLabel.Size = New System.Drawing.Size(49, 13)
        Me.TimeLeftLabel.TabIndex = 43
        Me.TimeLeftLabel.Text = "00:00:00"
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "192.168.0.10"
        Me.EthernetIPforCLXCom1.PollRateOverride = 500
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'recording
        '
        Me.recording.Controls.Add(Me.TableLayoutPanel3)
        Me.recording.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.recording.ForeColor = System.Drawing.Color.White
        Me.recording.Location = New System.Drawing.Point(12, 5)
        Me.recording.Name = "recording"
        Me.recording.Size = New System.Drawing.Size(257, 142)
        Me.recording.TabIndex = 45
        Me.recording.TabStop = False
        Me.recording.Text = "Data / Recording"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.StartStopOnRecCheckBox, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.ForceCheckBox, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.DispCheckBox, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.hzLabel, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.NumericUpDown3, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 21)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(251, 118)
        Me.TableLayoutPanel3.TabIndex = 46
        '
        'StartStopOnRecCheckBox
        '
        Me.StartStopOnRecCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.StartStopOnRecCheckBox.AutoSize = True
        Me.StartStopOnRecCheckBox.Checked = True
        Me.StartStopOnRecCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StartStopOnRecCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartStopOnRecCheckBox.Location = New System.Drawing.Point(193, 97)
        Me.StartStopOnRecCheckBox.Name = "StartStopOnRecCheckBox"
        Me.StartStopOnRecCheckBox.Size = New System.Drawing.Size(12, 11)
        Me.StartStopOnRecCheckBox.TabIndex = 49
        Me.StartStopOnRecCheckBox.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 17)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Control with start/stop:"
        '
        'ForceCheckBox
        '
        Me.ForceCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ForceCheckBox.AutoSize = True
        Me.ForceCheckBox.Checked = True
        Me.ForceCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ForceCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ForceCheckBox.Location = New System.Drawing.Point(193, 67)
        Me.ForceCheckBox.Name = "ForceCheckBox"
        Me.ForceCheckBox.Size = New System.Drawing.Size(12, 11)
        Me.ForceCheckBox.TabIndex = 47
        Me.ForceCheckBox.UseVisualStyleBackColor = True
        '
        'DispCheckBox
        '
        Me.DispCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DispCheckBox.AutoSize = True
        Me.DispCheckBox.Checked = True
        Me.DispCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DispCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DispCheckBox.Location = New System.Drawing.Point(193, 38)
        Me.DispCheckBox.Name = "DispCheckBox"
        Me.DispCheckBox.Size = New System.Drawing.Size(12, 11)
        Me.DispCheckBox.TabIndex = 46
        Me.DispCheckBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Record displacment (mm):"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Record force (N):"
        '
        'motion
        '
        Me.motion.Controls.Add(Me.TableLayoutPanel2)
        Me.motion.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.motion.ForeColor = System.Drawing.Color.White
        Me.motion.Location = New System.Drawing.Point(12, 399)
        Me.motion.Name = "motion"
        Me.motion.Size = New System.Drawing.Size(252, 142)
        Me.motion.TabIndex = 47
        Me.motion.TabStop = False
        Me.motion.Text = "Motion Parameters"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Cruise, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.CruLbl, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Decel, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Accel, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.AccLbl, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ManualMotionCheckBox, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DecLbl, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 21)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(246, 118)
        Me.TableLayoutPanel2.TabIndex = 46
        '
        'Cruise
        '
        Me.Cruise.AllowDrop = True
        Me.Cruise.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Cruise.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Cruise.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Cruise.DecimalPlaces = 1
        Me.Cruise.Enabled = False
        Me.Cruise.ForeColor = System.Drawing.Color.White
        Me.Cruise.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Cruise.Location = New System.Drawing.Point(188, 92)
        Me.Cruise.Maximum = New Decimal(New Integer() {49, 0, 0, 0})
        Me.Cruise.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Cruise.Name = "Cruise"
        Me.Cruise.Size = New System.Drawing.Size(51, 21)
        Me.Cruise.TabIndex = 56
        Me.Cruise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Cruise.Value = New Decimal(New Integer() {254, 0, 0, 65536})
        '
        'CruLbl
        '
        Me.CruLbl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CruLbl.AutoSize = True
        Me.CruLbl.Enabled = False
        Me.CruLbl.ForeColor = System.Drawing.Color.White
        Me.CruLbl.Location = New System.Drawing.Point(3, 94)
        Me.CruLbl.Name = "CruLbl"
        Me.CruLbl.Size = New System.Drawing.Size(107, 17)
        Me.CruLbl.TabIndex = 55
        Me.CruLbl.Text = "Cruise (mm/s):"
        '
        'Decel
        '
        Me.Decel.AllowDrop = True
        Me.Decel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Decel.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Decel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Decel.DecimalPlaces = 1
        Me.Decel.Enabled = False
        Me.Decel.ForeColor = System.Drawing.Color.White
        Me.Decel.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Decel.Location = New System.Drawing.Point(188, 62)
        Me.Decel.Maximum = New Decimal(New Integer() {49, 0, 0, 0})
        Me.Decel.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Decel.Name = "Decel"
        Me.Decel.Size = New System.Drawing.Size(51, 21)
        Me.Decel.TabIndex = 54
        Me.Decel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Decel.Value = New Decimal(New Integer() {254, 0, 0, 65536})
        '
        'Accel
        '
        Me.Accel.AllowDrop = True
        Me.Accel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Accel.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Accel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Accel.DecimalPlaces = 1
        Me.Accel.Enabled = False
        Me.Accel.ForeColor = System.Drawing.Color.White
        Me.Accel.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Accel.Location = New System.Drawing.Point(188, 33)
        Me.Accel.Maximum = New Decimal(New Integer() {49, 0, 0, 0})
        Me.Accel.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Accel.Name = "Accel"
        Me.Accel.Size = New System.Drawing.Size(51, 21)
        Me.Accel.TabIndex = 53
        Me.Accel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Accel.Value = New Decimal(New Integer() {254, 0, 0, 65536})
        '
        'AccLbl
        '
        Me.AccLbl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.AccLbl.AutoSize = True
        Me.AccLbl.Enabled = False
        Me.AccLbl.ForeColor = System.Drawing.Color.White
        Me.AccLbl.Location = New System.Drawing.Point(3, 35)
        Me.AccLbl.Name = "AccLbl"
        Me.AccLbl.Size = New System.Drawing.Size(149, 17)
        Me.AccLbl.TabIndex = 51
        Me.AccLbl.Text = "Acceleration (mm/s²):"
        '
        'ManualMotionCheckBox
        '
        Me.ManualMotionCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ManualMotionCheckBox.AutoSize = True
        Me.ManualMotionCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ManualMotionCheckBox.Location = New System.Drawing.Point(188, 9)
        Me.ManualMotionCheckBox.Name = "ManualMotionCheckBox"
        Me.ManualMotionCheckBox.Size = New System.Drawing.Size(12, 11)
        Me.ManualMotionCheckBox.TabIndex = 50
        Me.ManualMotionCheckBox.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 17)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Manual motion profile:"
        '
        'DecLbl
        '
        Me.DecLbl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DecLbl.AutoSize = True
        Me.DecLbl.Enabled = False
        Me.DecLbl.ForeColor = System.Drawing.Color.White
        Me.DecLbl.Location = New System.Drawing.Point(3, 64)
        Me.DecLbl.Name = "DecLbl"
        Me.DecLbl.Size = New System.Drawing.Size(151, 17)
        Me.DecLbl.TabIndex = 52
        Me.DecLbl.Text = "Deceleration (mm/s²):"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(815, 494)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Target displacement:"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 335.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.NumericUpDown6, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.NumericUpDown7, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.NumericUpDown8, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(545, 127)
        Me.TableLayoutPanel4.TabIndex = 46
        '
        'NumericUpDown6
        '
        Me.NumericUpDown6.AllowDrop = True
        Me.NumericUpDown6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NumericUpDown6.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.NumericUpDown6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown6.DecimalPlaces = 1
        Me.NumericUpDown6.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown6.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown6.Location = New System.Drawing.Point(213, 99)
        Me.NumericUpDown6.Maximum = New Decimal(New Integer() {49, 0, 0, 0})
        Me.NumericUpDown6.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown6.Name = "NumericUpDown6"
        Me.NumericUpDown6.Size = New System.Drawing.Size(51, 18)
        Me.NumericUpDown6.TabIndex = 56
        Me.NumericUpDown6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown6.Value = New Decimal(New Integer() {254, 0, 0, 65536})
        '
        'NumericUpDown7
        '
        Me.NumericUpDown7.AllowDrop = True
        Me.NumericUpDown7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NumericUpDown7.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.NumericUpDown7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown7.DecimalPlaces = 1
        Me.NumericUpDown7.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown7.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown7.Location = New System.Drawing.Point(213, 63)
        Me.NumericUpDown7.Maximum = New Decimal(New Integer() {49, 0, 0, 0})
        Me.NumericUpDown7.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown7.Name = "NumericUpDown7"
        Me.NumericUpDown7.Size = New System.Drawing.Size(51, 18)
        Me.NumericUpDown7.TabIndex = 54
        Me.NumericUpDown7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown7.Value = New Decimal(New Integer() {254, 0, 0, 65536})
        '
        'NumericUpDown8
        '
        Me.NumericUpDown8.AllowDrop = True
        Me.NumericUpDown8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NumericUpDown8.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.NumericUpDown8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown8.DecimalPlaces = 1
        Me.NumericUpDown8.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown8.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown8.Location = New System.Drawing.Point(213, 28)
        Me.NumericUpDown8.Maximum = New Decimal(New Integer() {49, 0, 0, 0})
        Me.NumericUpDown8.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown8.Name = "NumericUpDown8"
        Me.NumericUpDown8.Size = New System.Drawing.Size(51, 18)
        Me.NumericUpDown8.TabIndex = 53
        Me.NumericUpDown8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown8.Value = New Decimal(New Integer() {254, 0, 0, 65536})
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel1.Controls.Add(Me.ControlForDisplacementCheckBox)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(204, 14)
        Me.FlowLayoutPanel1.TabIndex = 57
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(171, 17)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Control for displacement:"
        '
        'ControlForDisplacementCheckBox
        '
        Me.ControlForDisplacementCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ControlForDisplacementCheckBox.AutoSize = True
        Me.ControlForDisplacementCheckBox.Checked = True
        Me.ControlForDisplacementCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ControlForDisplacementCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ControlForDisplacementCheckBox.Location = New System.Drawing.Point(180, 3)
        Me.ControlForDisplacementCheckBox.Name = "ControlForDisplacementCheckBox"
        Me.ControlForDisplacementCheckBox.Size = New System.Drawing.Size(12, 11)
        Me.ControlForDisplacementCheckBox.TabIndex = 50
        Me.ControlForDisplacementCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel5)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(270, 399)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 142)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Force Profile"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.CheckBox2, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 21)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 4
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(246, 118)
        Me.TableLayoutPanel5.TabIndex = 46
        '
        'CheckBox2
        '
        Me.CheckBox2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.Location = New System.Drawing.Point(188, 9)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(12, 11)
        Me.CheckBox2.TabIndex = 50
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'MovePointsTabs
        '
        Me.MovePointsTabs.Controls.Add(Me.DispPage)
        Me.MovePointsTabs.Controls.Add(Me.TabPage2)
        Me.MovePointsTabs.Font = New System.Drawing.Font("Arial", 9.25!)
        Me.MovePointsTabs.Location = New System.Drawing.Point(320, 5)
        Me.MovePointsTabs.Multiline = True
        Me.MovePointsTabs.Name = "MovePointsTabs"
        Me.MovePointsTabs.SelectedIndex = 0
        Me.MovePointsTabs.Size = New System.Drawing.Size(559, 161)
        Me.MovePointsTabs.TabIndex = 50
        '
        'DispPage
        '
        Me.DispPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.DispPage.Controls.Add(Me.VScrollBar1)
        Me.DispPage.Controls.Add(Me.TableLayoutPanel4)
        Me.DispPage.Location = New System.Drawing.Point(4, 24)
        Me.DispPage.Name = "DispPage"
        Me.DispPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DispPage.Size = New System.Drawing.Size(551, 133)
        Me.DispPage.TabIndex = 0
        Me.DispPage.Text = "Displacement Control"
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar1.Location = New System.Drawing.Point(531, 3)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 127)
        Me.VScrollBar1.TabIndex = 51
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(551, 133)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RecLinkToolTip
        '
        Me.RecLinkToolTip.ToolTipTitle = "Control with start/stop:"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.AllowDrop = True
        Me.NumericUpDown2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NumericUpDown2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.NumericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown2.DecimalPlaces = 1
        Me.NumericUpDown2.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown2.Location = New System.Drawing.Point(409, 286)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {49, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(70, 16)
        Me.NumericUpDown2.TabIndex = 58
        Me.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown2.Value = New Decimal(New Integer() {254, 0, 0, 65536})
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.AllowDrop = True
        Me.NumericUpDown4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NumericUpDown4.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.NumericUpDown4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown4.DecimalPlaces = 1
        Me.NumericUpDown4.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown4.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown4.Location = New System.Drawing.Point(409, 308)
        Me.NumericUpDown4.Maximum = New Decimal(New Integer() {49, 0, 0, 0})
        Me.NumericUpDown4.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(70, 16)
        Me.NumericUpDown4.TabIndex = 59
        Me.NumericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown4.Value = New Decimal(New Integer() {254, 0, 0, 65536})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(357, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "time"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(357, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "dist"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(624, 360)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "1"
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.AllowDrop = True
        Me.NumericUpDown5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NumericUpDown5.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.NumericUpDown5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown5.DecimalPlaces = 1
        Me.NumericUpDown5.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown5.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown5.Location = New System.Drawing.Point(409, 330)
        Me.NumericUpDown5.Maximum = New Decimal(New Integer() {49, 0, 0, 0})
        Me.NumericUpDown5.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(70, 16)
        Me.NumericUpDown5.TabIndex = 63
        Me.NumericUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown5.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(357, 333)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "cycles"
        '
        'ExperimentSetupWindow
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(965, 599)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.NumericUpDown5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NumericUpDown4)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.MovePointsTabs)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.motion)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TimeLeftLabel)
        Me.Controls.Add(Me.dispTarget)
        Me.Controls.Add(Me.recording)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ExperimentSetupWindow"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Experiment Setup"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.recording.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.motion.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.Cruise, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Decel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Accel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.MovePointsTabs.ResumeLayout(False)
        Me.DispPage.ResumeLayout(False)
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents dispTarget As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents hzLabel As Label
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents TimeLeftLabel As Label
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents recording As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents DispCheckBox As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ForceCheckBox As CheckBox
    Friend WithEvents StartStopOnRecCheckBox As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents motion As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents AccLbl As Label
    Friend WithEvents ManualMotionCheckBox As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DecLbl As Label
    Friend WithEvents Cruise As NumericUpDown
    Friend WithEvents CruLbl As Label
    Friend WithEvents Decel As NumericUpDown
    Friend WithEvents Accel As NumericUpDown
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents NumericUpDown6 As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents NumericUpDown7 As NumericUpDown
    Friend WithEvents NumericUpDown8 As NumericUpDown
    Friend WithEvents ControlForDisplacementCheckBox As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents MovePointsTabs As TabControl
    Friend WithEvents DispPage As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents RecLinkToolTip As ToolTip
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NumericUpDown5 As NumericUpDown
    Friend WithEvents Label11 As Label
End Class
