<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExperimentSetupWindow
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DispControlPanel = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CyclesControl = New System.Windows.Forms.NumericUpDown()
        Me.ControlForDisp = New System.Windows.Forms.CheckBox()
        Me.DisplacementStepsInput = New System.Windows.Forms.DataGridView()
        Me.target = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dwell = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.hzLabel = New System.Windows.Forms.Label()
        Me.ForceCheckBox = New System.Windows.Forms.CheckBox()
        Me.DispCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RecordingRateHz = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OKbutton = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.InputFeedback = New System.Windows.Forms.Label()
        Me.DispControlPanel.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.CyclesControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplacementStepsInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.RecordingRateHz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DispControlPanel
        '
        Me.DispControlPanel.Controls.Add(Me.TabPage2)
        Me.DispControlPanel.Controls.Add(Me.TabPage3)
        Me.DispControlPanel.Controls.Add(Me.TabPage1)
        Me.DispControlPanel.HotTrack = True
        Me.DispControlPanel.Location = New System.Drawing.Point(12, 12)
        Me.DispControlPanel.Multiline = True
        Me.DispControlPanel.Name = "DispControlPanel"
        Me.DispControlPanel.SelectedIndex = 0
        Me.DispControlPanel.Size = New System.Drawing.Size(403, 245)
        Me.DispControlPanel.TabIndex = 86
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(395, 219)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Displacement Control"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DisplacementStepsInput)
        Me.SplitContainer1.Size = New System.Drawing.Size(389, 213)
        Me.SplitContainer1.SplitterDistance = 25
        Me.SplitContainer1.TabIndex = 91
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CyclesControl, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ControlForDisp, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(389, 25)
        Me.TableLayoutPanel1.TabIndex = 90
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(283, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 14)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Cycles:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CyclesControl
        '
        Me.CyclesControl.AllowDrop = True
        Me.CyclesControl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CyclesControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CyclesControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CyclesControl.ForeColor = System.Drawing.Color.White
        Me.CyclesControl.Location = New System.Drawing.Point(332, 3)
        Me.CyclesControl.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.CyclesControl.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CyclesControl.Name = "CyclesControl"
        Me.CyclesControl.Size = New System.Drawing.Size(51, 20)
        Me.CyclesControl.TabIndex = 90
        Me.CyclesControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CyclesControl.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ControlForDisp
        '
        Me.ControlForDisp.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ControlForDisp.AutoSize = True
        Me.ControlForDisp.Checked = True
        Me.ControlForDisp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ControlForDisp.ForeColor = System.Drawing.Color.White
        Me.ControlForDisp.Location = New System.Drawing.Point(3, 3)
        Me.ControlForDisp.Name = "ControlForDisp"
        Me.ControlForDisp.Size = New System.Drawing.Size(144, 18)
        Me.ControlForDisp.TabIndex = 90
        Me.ControlForDisp.Text = "Control for Displacement"
        Me.ControlForDisp.UseVisualStyleBackColor = True
        '
        'DisplacementStepsInput
        '
        Me.DisplacementStepsInput.AllowUserToResizeColumns = False
        Me.DisplacementStepsInput.AllowUserToResizeRows = False
        Me.DisplacementStepsInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DisplacementStepsInput.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.DisplacementStepsInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DisplacementStepsInput.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DisplacementStepsInput.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DisplacementStepsInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DisplacementStepsInput.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.target, Me.time, Me.dwell, Me.delete})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DisplacementStepsInput.DefaultCellStyle = DataGridViewCellStyle3
        Me.DisplacementStepsInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DisplacementStepsInput.EnableHeadersVisualStyles = False
        Me.DisplacementStepsInput.GridColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.DisplacementStepsInput.Location = New System.Drawing.Point(0, 0)
        Me.DisplacementStepsInput.Name = "DisplacementStepsInput"
        Me.DisplacementStepsInput.RowHeadersVisible = False
        Me.DisplacementStepsInput.Size = New System.Drawing.Size(389, 184)
        Me.DisplacementStepsInput.TabIndex = 0
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
        Me.TabPage3.Controls.Add(Me.SplitContainer2)
        Me.TabPage3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(395, 219)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Force Control"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TableLayoutPanel3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer2.Size = New System.Drawing.Size(389, 213)
        Me.SplitContainer2.SplitterDistance = 25
        Me.SplitContainer2.TabIndex = 92
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.NumericUpDown1, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.CheckBox2, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(389, 25)
        Me.TableLayoutPanel3.TabIndex = 90
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(283, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 14)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Cycles:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.AllowDrop = True
        Me.NumericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NumericUpDown1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.NumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown1.Location = New System.Drawing.Point(332, 3)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(51, 20)
        Me.NumericUpDown1.TabIndex = 90
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CheckBox2
        '
        Me.CheckBox2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.ForeColor = System.Drawing.Color.White
        Me.CheckBox2.Location = New System.Drawing.Point(3, 3)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(108, 18)
        Me.CheckBox2.TabIndex = 90
        Me.CheckBox2.Text = "Control for Force"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewButtonColumn1})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 8.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(389, 184)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.FillWeight = 112.3096!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Target Position (mm):"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.FillWeight = 112.3096!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Transition Time (Seconds):"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.FillWeight = 112.3096!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Dwell Time (Seconds):"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.DataGridViewButtonColumn1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewButtonColumn1.FillWeight = 50.76142!
        Me.DataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewButtonColumn1.HeaderText = ""
        Me.DataGridViewButtonColumn1.MinimumWidth = 20
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.Text = "X"
        Me.DataGridViewButtonColumn1.Width = 21
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(395, 219)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Recording Options"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.88921!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.11079!))
        Me.TableLayoutPanel2.Controls.Add(Me.hzLabel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ForceCheckBox, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.DispCheckBox, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.RecordingRateHz, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(389, 134)
        Me.TableLayoutPanel2.TabIndex = 48
        '
        'hzLabel
        '
        Me.hzLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.hzLabel.AutoSize = True
        Me.hzLabel.ForeColor = System.Drawing.Color.White
        Me.hzLabel.Location = New System.Drawing.Point(138, 10)
        Me.hzLabel.Name = "hzLabel"
        Me.hzLabel.Size = New System.Drawing.Size(115, 13)
        Me.hzLabel.TabIndex = 39
        Me.hzLabel.Text = "Data capture rate (Hz):"
        Me.hzLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ForceCheckBox
        '
        Me.ForceCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ForceCheckBox.AutoSize = True
        Me.ForceCheckBox.Checked = True
        Me.ForceCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ForceCheckBox.Location = New System.Drawing.Point(259, 75)
        Me.ForceCheckBox.Name = "ForceCheckBox"
        Me.ForceCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.ForceCheckBox.TabIndex = 47
        Me.ForceCheckBox.UseVisualStyleBackColor = True
        '
        'DispCheckBox
        '
        Me.DispCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DispCheckBox.AutoSize = True
        Me.DispCheckBox.Checked = True
        Me.DispCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DispCheckBox.Location = New System.Drawing.Point(259, 42)
        Me.DispCheckBox.Name = "DispCheckBox"
        Me.DispCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.DispCheckBox.TabIndex = 46
        Me.DispCheckBox.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(164, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Record force (N):"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RecordingRateHz
        '
        Me.RecordingRateHz.AllowDrop = True
        Me.RecordingRateHz.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RecordingRateHz.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.RecordingRateHz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RecordingRateHz.DecimalPlaces = 2
        Me.RecordingRateHz.Font = New System.Drawing.Font("Arial", 9.25!)
        Me.RecordingRateHz.ForeColor = System.Drawing.Color.White
        Me.RecordingRateHz.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.RecordingRateHz.Location = New System.Drawing.Point(259, 5)
        Me.RecordingRateHz.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.RecordingRateHz.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.RecordingRateHz.Name = "RecordingRateHz"
        Me.RecordingRateHz.Size = New System.Drawing.Size(51, 22)
        Me.RecordingRateHz.TabIndex = 38
        Me.RecordingRateHz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RecordingRateHz.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(124, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Record displacment (mm):"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OKbutton
        '
        Me.OKbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.OKbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.OKbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKbutton.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.OKbutton.ForeColor = System.Drawing.Color.White
        Me.OKbutton.Location = New System.Drawing.Point(340, 263)
        Me.OKbutton.Name = "OKbutton"
        Me.OKbutton.Size = New System.Drawing.Size(75, 23)
        Me.OKbutton.TabIndex = 89
        Me.OKbutton.Text = "OK"
        Me.OKbutton.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
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
        'InputFeedback
        '
        Me.InputFeedback.AutoSize = True
        Me.InputFeedback.ForeColor = System.Drawing.Color.White
        Me.InputFeedback.Location = New System.Drawing.Point(13, 268)
        Me.InputFeedback.Name = "InputFeedback"
        Me.InputFeedback.Size = New System.Drawing.Size(19, 13)
        Me.InputFeedback.TabIndex = 90
        Me.InputFeedback.Text = "❌"
        '
        'ExperimentSetupWindow
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(426, 292)
        Me.Controls.Add(Me.InputFeedback)
        Me.Controls.Add(Me.OKbutton)
        Me.Controls.Add(Me.DispControlPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ExperimentSetupWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Experiment Setup"
        Me.DispControlPanel.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.CyclesControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplacementStepsInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.RecordingRateHz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DispControlPanel As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DisplacementStepsInput As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents target As DataGridViewTextBoxColumn
    Friend WithEvents time As DataGridViewTextBoxColumn
    Friend WithEvents dwell As DataGridViewTextBoxColumn
    Friend WithEvents delete As DataGridViewButtonColumn
    Friend WithEvents ForceCheckBox As CheckBox
    Friend WithEvents DispCheckBox As CheckBox
    Friend WithEvents RecordingRateHz As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents hzLabel As Label
    Friend WithEvents OKbutton As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ControlForDisp As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CyclesControl As NumericUpDown
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As DataGridViewButtonColumn
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents InputFeedback As Label
End Class
