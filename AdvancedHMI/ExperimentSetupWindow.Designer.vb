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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExperimentSetupWindow))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataLogRateHelp = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataLogRateInput = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProgCompHelp = New System.Windows.Forms.Button()
        Me.RadiiCompHelp = New System.Windows.Forms.Button()
        Me.TraverseTimeHelp = New System.Windows.Forms.Button()
        Me.CyclesHelp = New System.Windows.Forms.Button()
        Me.DisplacementHelp = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.CyclesInput = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DisplacementInput = New System.Windows.Forms.NumericUpDown()
        Me.RadiiCompInput = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProgCompInput = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TraverseTimeInput = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EstTimeLabel = New System.Windows.Forms.Label()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataLogRateInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.CyclesInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplacementInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadiiCompInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraverseTimeInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataLogRateHelp)
        Me.GroupBox4.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(15, 424)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox4.Size = New System.Drawing.Size(493, 96)
        Me.GroupBox4.TabIndex = 37
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Recording Options"
        '
        'DataLogRateHelp
        '
        Me.DataLogRateHelp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DataLogRateHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataLogRateHelp.Location = New System.Drawing.Point(438, 40)
        Me.DataLogRateHelp.Name = "DataLogRateHelp"
        Me.DataLogRateHelp.Size = New System.Drawing.Size(35, 35)
        Me.DataLogRateHelp.TabIndex = 38
        Me.DataLogRateHelp.Text = "🛈"
        Me.DataLogRateHelp.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.47059!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.52941!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DataLogRateInput, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 37)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(419, 42)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(225, 59)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Data Log Rate (Hz):"
        '
        'DataLogRateInput
        '
        Me.DataLogRateInput.Location = New System.Drawing.Point(323, 3)
        Me.DataLogRateInput.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.DataLogRateInput.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DataLogRateInput.Name = "DataLogRateInput"
        Me.DataLogRateInput.Size = New System.Drawing.Size(93, 35)
        Me.DataLogRateInput.TabIndex = 2
        Me.DataLogRateInput.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ProgCompHelp)
        Me.GroupBox1.Controls.Add(Me.RadiiCompHelp)
        Me.GroupBox1.Controls.Add(Me.TraverseTimeHelp)
        Me.GroupBox1.Controls.Add(Me.CyclesHelp)
        Me.GroupBox1.Controls.Add(Me.DisplacementHelp)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(493, 398)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Motion Control"
        '
        'ProgCompHelp
        '
        Me.ProgCompHelp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ProgCompHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgCompHelp.Location = New System.Drawing.Point(438, 345)
        Me.ProgCompHelp.Name = "ProgCompHelp"
        Me.ProgCompHelp.Size = New System.Drawing.Size(35, 35)
        Me.ProgCompHelp.TabIndex = 38
        Me.ProgCompHelp.Text = "🛈"
        Me.ProgCompHelp.UseVisualStyleBackColor = True
        '
        'RadiiCompHelp
        '
        Me.RadiiCompHelp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadiiCompHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadiiCompHelp.Location = New System.Drawing.Point(438, 279)
        Me.RadiiCompHelp.Name = "RadiiCompHelp"
        Me.RadiiCompHelp.Size = New System.Drawing.Size(35, 35)
        Me.RadiiCompHelp.TabIndex = 38
        Me.RadiiCompHelp.Text = "🛈"
        Me.RadiiCompHelp.UseVisualStyleBackColor = True
        '
        'TraverseTimeHelp
        '
        Me.TraverseTimeHelp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.TraverseTimeHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TraverseTimeHelp.Location = New System.Drawing.Point(438, 115)
        Me.TraverseTimeHelp.Name = "TraverseTimeHelp"
        Me.TraverseTimeHelp.Size = New System.Drawing.Size(35, 35)
        Me.TraverseTimeHelp.TabIndex = 38
        Me.TraverseTimeHelp.Text = "🛈"
        Me.TraverseTimeHelp.UseVisualStyleBackColor = True
        '
        'CyclesHelp
        '
        Me.CyclesHelp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CyclesHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CyclesHelp.Location = New System.Drawing.Point(438, 43)
        Me.CyclesHelp.Name = "CyclesHelp"
        Me.CyclesHelp.Size = New System.Drawing.Size(35, 35)
        Me.CyclesHelp.TabIndex = 38
        Me.CyclesHelp.Text = "🛈"
        Me.CyclesHelp.UseVisualStyleBackColor = True
        '
        'DisplacementHelp
        '
        Me.DisplacementHelp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DisplacementHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplacementHelp.Location = New System.Drawing.Point(438, 185)
        Me.DisplacementHelp.Name = "DisplacementHelp"
        Me.DisplacementHelp.Size = New System.Drawing.Size(35, 35)
        Me.DisplacementHelp.TabIndex = 38
        Me.DisplacementHelp.Text = "🛈"
        Me.DisplacementHelp.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.60133!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.39866!))
        Me.TableLayoutPanel2.Controls.Add(Me.CyclesInput, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.DisplacementInput, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.RadiiCompInput, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.ProgCompInput, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TraverseTimeInput, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(9, 40)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.68696!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.17291!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.30836!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.66571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.52738!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(443, 347)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'CyclesInput
        '
        Me.CyclesInput.Location = New System.Drawing.Point(315, 3)
        Me.CyclesInput.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.CyclesInput.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CyclesInput.Name = "CyclesInput"
        Me.CyclesInput.Size = New System.Drawing.Size(104, 35)
        Me.CyclesInput.TabIndex = 2
        Me.CyclesInput.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(228, 72)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cycles to Complete:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(228, 67)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Displacement (mm):"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label4.Location = New System.Drawing.Point(3, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(306, 96)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Residual Radii of Curvature Compensation (mm):"
        '
        'DisplacementInput
        '
        Me.DisplacementInput.DecimalPlaces = 1
        Me.DisplacementInput.Location = New System.Drawing.Point(315, 145)
        Me.DisplacementInput.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.DisplacementInput.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DisplacementInput.Name = "DisplacementInput"
        Me.DisplacementInput.Size = New System.Drawing.Size(104, 35)
        Me.DisplacementInput.TabIndex = 2
        Me.DisplacementInput.Value = New Decimal(New Integer() {254, 0, 0, 65536})
        '
        'RadiiCompInput
        '
        Me.RadiiCompInput.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadiiCompInput.DecimalPlaces = 1
        Me.RadiiCompInput.Enabled = False
        Me.RadiiCompInput.Location = New System.Drawing.Point(315, 239)
        Me.RadiiCompInput.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.RadiiCompInput.Name = "RadiiCompInput"
        Me.RadiiCompInput.Size = New System.Drawing.Size(104, 35)
        Me.RadiiCompInput.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label5.Location = New System.Drawing.Point(3, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(306, 42)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Progressive Compensation:"
        '
        'ProgCompInput
        '
        Me.ProgCompInput.AutoSize = True
        Me.ProgCompInput.Enabled = False
        Me.ProgCompInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProgCompInput.Location = New System.Drawing.Point(315, 308)
        Me.ProgCompInput.Name = "ProgCompInput"
        Me.ProgCompInput.Size = New System.Drawing.Size(23, 22)
        Me.ProgCompInput.TabIndex = 4
        Me.ProgCompInput.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.Label6.Size = New System.Drawing.Size(203, 70)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Traverse Time (s):"
        '
        'TraverseTimeInput
        '
        Me.TraverseTimeInput.DecimalPlaces = 2
        Me.TraverseTimeInput.Location = New System.Drawing.Point(315, 75)
        Me.TraverseTimeInput.Maximum = New Decimal(New Integer() {900, 0, 0, 0})
        Me.TraverseTimeInput.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TraverseTimeInput.Name = "TraverseTimeInput"
        Me.TraverseTimeInput.Size = New System.Drawing.Size(104, 35)
        Me.TraverseTimeInput.TabIndex = 2
        Me.TraverseTimeInput.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.84179!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.15821!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.EstTimeLabel, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(15, 530)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(493, 57)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.Label7.Size = New System.Drawing.Size(207, 59)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Est. Total Run Time:"
        '
        'EstTimeLabel
        '
        Me.EstTimeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.EstTimeLabel.AutoSize = True
        Me.EstTimeLabel.ForeColor = System.Drawing.Color.White
        Me.EstTimeLabel.Location = New System.Drawing.Point(242, 0)
        Me.EstTimeLabel.Name = "EstTimeLabel"
        Me.EstTimeLabel.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.EstTimeLabel.Size = New System.Drawing.Size(234, 59)
        Me.EstTimeLabel.TabIndex = 3
        Me.EstTimeLabel.Text = "hours:minutes:seconds"
        '
        'ConfirmButton
        '
        Me.ConfirmButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ConfirmButton.Location = New System.Drawing.Point(189, 579)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(149, 46)
        Me.ConfirmButton.TabIndex = 38
        Me.ConfirmButton.Text = "Confirm"
        Me.ConfirmButton.UseVisualStyleBackColor = True
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
        'ExperimentSetupWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(523, 637)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ExperimentSetupWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Experimental Setup"
        Me.GroupBox4.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataLogRateInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.CyclesInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplacementInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadiiCompInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraverseTimeInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents CyclesInput As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DisplacementInput As NumericUpDown
    Friend WithEvents RadiiCompInput As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents ProgCompInput As CheckBox
    Friend WithEvents RadiiCompHelp As Button
    Friend WithEvents ProgCompHelp As Button
    Friend WithEvents CyclesHelp As Button
    Friend WithEvents DisplacementHelp As Button
    Friend WithEvents DataLogRateHelp As Button
    Friend WithEvents DataLogRateInput As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents TraverseTimeInput As NumericUpDown
    Friend WithEvents TraverseTimeHelp As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents EstTimeLabel As Label
    Friend WithEvents ConfirmButton As Button
End Class
