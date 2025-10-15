<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
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
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SetOrigin = New AdvancedHMIControls.BasicButton()
        Me.ModbusTCPCom1 = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DRO_N = New AdvancedHMIControls.SevenSegment2()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DRO_mm = New AdvancedHMIControls.SevenSegment2()
        Me.JogMinus = New AdvancedHMIControls.BasicButton()
        Me.JogPlus = New AdvancedHMIControls.BasicButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.HW_Zero = New AdvancedHMIControls.BasicButton()
        Me.DisplacementZero = New AdvancedHMIControls.BasicButton()
        Me.GraphPanel = New System.Windows.Forms.Panel()
        Me.LiveGraph = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ExperimentRecordingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SetupButton = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.CheckBox()
        Me.ConnectionCheckThread = New System.ComponentModel.BackgroundWorker()
        Me.ControlBlinker = New System.Windows.Forms.Timer(Me.components)
        Me.ConnectionCheckTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ConnectionIndicator = New System.Windows.Forms.Label()
        Me.GraphUpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GraphControlBox = New System.Windows.Forms.GroupBox()
        Me.DecorativeDivider = New System.Windows.Forms.GroupBox()
        Me.YMaxLabel = New System.Windows.Forms.Label()
        Me.UserSecondsButton = New System.Windows.Forms.RadioButton()
        Me.GraphYInputBox = New System.Windows.Forms.NumericUpDown()
        Me.UserSecondsInput = New System.Windows.Forms.NumericUpDown()
        Me.TwoCycleButton = New System.Windows.Forms.RadioButton()
        Me.HalfCycleButton = New System.Windows.Forms.RadioButton()
        Me.OneCycleButton = New System.Windows.Forms.RadioButton()
        Me.ConnectionStatusBox = New System.Windows.Forms.GroupBox()
        Me.StopButton = New AdvancedHMIControls.BasicButton()
        Me.ExperimentRecordingThread = New System.ComponentModel.BackgroundWorker()
        Me.GeneralCommsUpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressTable = New System.Windows.Forms.TableLayoutPanel()
        Me.TimeRemaingLabelTitle = New System.Windows.Forms.Label()
        Me.TimeRemainingLabel = New System.Windows.Forms.Label()
        Me.CurrentCycleLabel = New System.Windows.Forms.Label()
        Me.CurrentCycleLabelTitle = New System.Windows.Forms.Label()
        Me.EstTimeRemiainingCounter = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.ModbusTCPCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GraphPanel.SuspendLayout()
        CType(Me.LiveGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GraphControlBox.SuspendLayout()
        CType(Me.GraphYInputBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserSecondsInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConnectionStatusBox.SuspendLayout()
        Me.ProgressTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 1005)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "For Development Source Code Visit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://www.advancedhmi.com"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SetOrigin)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.JogMinus)
        Me.GroupBox2.Controls.Add(Me.JogPlus)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(11, 211)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(228, 281)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Manual Control / Jog"
        '
        'SetOrigin
        '
        Me.SetOrigin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SetOrigin.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.SetOrigin.ComComponent = Me.ModbusTCPCom1
        Me.SetOrigin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.SetOrigin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetOrigin.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetOrigin.ForeColor = System.Drawing.SystemColors.Window
        Me.SetOrigin.ForeColorAltername = System.Drawing.Color.Black
        Me.SetOrigin.Highlight = False
        Me.SetOrigin.HighlightColor = System.Drawing.Color.Green
        Me.SetOrigin.Location = New System.Drawing.Point(9, 195)
        Me.SetOrigin.Margin = New System.Windows.Forms.Padding(4)
        Me.SetOrigin.MaximumHoldTime = 3000
        Me.SetOrigin.MinimumHoldTime = 500
        Me.SetOrigin.Name = "SetOrigin"
        Me.SetOrigin.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SetOrigin.PLCAddressClick = "017189"
        Me.SetOrigin.SelectTextAlternate = False
        Me.SetOrigin.Size = New System.Drawing.Size(210, 75)
        Me.SetOrigin.TabIndex = 12
        Me.SetOrigin.Text = "Set Origin"
        Me.SetOrigin.TextAlternate = Nothing
        Me.SetOrigin.UseVisualStyleBackColor = False
        Me.SetOrigin.ValueToWrite = 0
        '
        'ModbusTCPCom1
        '
        Me.ModbusTCPCom1.DisableSubscriptions = False
        Me.ModbusTCPCom1.IniFileName = ""
        Me.ModbusTCPCom1.IniFileSection = Nothing
        Me.ModbusTCPCom1.IPAddress = "169.254.223.102"
        Me.ModbusTCPCom1.MaxReadGroupSize = 20
        Me.ModbusTCPCom1.PollRateOverride = 10
        Me.ModbusTCPCom1.SwapBytes = True
        Me.ModbusTCPCom1.SwapWords = True
        Me.ModbusTCPCom1.TcpipPort = CType(502US, UShort)
        Me.ModbusTCPCom1.TimeOut = 50
        Me.ModbusTCPCom1.UnitId = CType(1, Byte)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DRO_N)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(91, 109)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox4.Size = New System.Drawing.Size(128, 78)
        Me.GroupBox4.TabIndex = 36
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Force, N"
        '
        'DRO_N
        '
        Me.DRO_N.BackColor = System.Drawing.Color.Transparent
        Me.DRO_N.ComComponent = Me.ModbusTCPCom1
        Me.DRO_N.DecimalPosition = 0
        Me.DRO_N.Enabled = False
        Me.DRO_N.ForecolorHighLimitValue = 999999.0R
        Me.DRO_N.ForeColorInLimits = System.Drawing.Color.IndianRed
        Me.DRO_N.ForecolorLowLimitValue = -0.01R
        Me.DRO_N.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.DRO_N.ForeColorUnderLowLimit = System.Drawing.Color.Red
        Me.DRO_N.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DRO_N.KeypadMaxValue = 0R
        Me.DRO_N.KeypadMinValue = 0R
        Me.DRO_N.KeypadScaleFactor = 1.0R
        Me.DRO_N.KeypadText = Nothing
        Me.DRO_N.KeypadWidth = 300
        Me.DRO_N.Location = New System.Drawing.Point(16, 19)
        Me.DRO_N.Margin = New System.Windows.Forms.Padding(4)
        Me.DRO_N.Name = "DRO_N"
        Me.DRO_N.NumberOfDigits = 3
        Me.DRO_N.PLCAddressKeypad = ""
        Me.DRO_N.PLCAddressText = ""
        Me.DRO_N.PLCAddressValue = Nothing
        Me.DRO_N.PLCAddressVisible = ""
        Me.DRO_N.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DRO_N.ShowOffSegments = True
        Me.DRO_N.Size = New System.Drawing.Size(98, 42)
        Me.DRO_N.TabIndex = 11
        Me.DRO_N.Text = "SevenSegment21"
        Me.DRO_N.Value = 999999.0R
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DRO_mm)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(91, 27)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(128, 78)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Position, mm"
        '
        'DRO_mm
        '
        Me.DRO_mm.BackColor = System.Drawing.Color.Transparent
        Me.DRO_mm.ComComponent = Me.ModbusTCPCom1
        Me.DRO_mm.DecimalPosition = 1
        Me.DRO_mm.ForecolorHighLimitValue = 999999.0R
        Me.DRO_mm.ForeColorInLimits = System.Drawing.Color.White
        Me.DRO_mm.ForecolorLowLimitValue = -999999.0R
        Me.DRO_mm.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.DRO_mm.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.DRO_mm.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DRO_mm.KeypadMaxValue = 0R
        Me.DRO_mm.KeypadMinValue = 0R
        Me.DRO_mm.KeypadScaleFactor = 1.0R
        Me.DRO_mm.KeypadText = Nothing
        Me.DRO_mm.KeypadWidth = 300
        Me.DRO_mm.Location = New System.Drawing.Point(16, 22)
        Me.DRO_mm.Margin = New System.Windows.Forms.Padding(4)
        Me.DRO_mm.Name = "DRO_mm"
        Me.DRO_mm.NumberOfDigits = 3
        Me.DRO_mm.PLCAddressKeypad = ""
        Me.DRO_mm.PLCAddressText = ""
        Me.DRO_mm.PLCAddressValue = CType(resources.GetObject("DRO_mm.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.DRO_mm.PLCAddressVisible = ""
        Me.DRO_mm.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.DRO_mm.ShowOffSegments = True
        Me.DRO_mm.Size = New System.Drawing.Size(95, 41)
        Me.DRO_mm.TabIndex = 11
        Me.DRO_mm.Text = "SevenSegment21"
        Me.DRO_mm.Value = 0R
        '
        'JogMinus
        '
        Me.JogMinus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.JogMinus.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.JogMinus.ComComponent = Me.ModbusTCPCom1
        Me.JogMinus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.JogMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.JogMinus.Font = New System.Drawing.Font("OCR A Extended", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JogMinus.ForeColor = System.Drawing.SystemColors.Window
        Me.JogMinus.ForeColorAltername = System.Drawing.Color.Black
        Me.JogMinus.Highlight = False
        Me.JogMinus.HighlightColor = System.Drawing.Color.Green
        Me.JogMinus.Location = New System.Drawing.Point(9, 29)
        Me.JogMinus.Margin = New System.Windows.Forms.Padding(4)
        Me.JogMinus.MaximumHoldTime = 90000
        Me.JogMinus.MinimumHoldTime = 2
        Me.JogMinus.Name = "JogMinus"
        Me.JogMinus.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.JogMinus.PLCAddressClick = "017188"
        Me.JogMinus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.JogMinus.SelectTextAlternate = False
        Me.JogMinus.Size = New System.Drawing.Size(75, 75)
        Me.JogMinus.TabIndex = 8
        Me.JogMinus.Text = "-"
        Me.JogMinus.TextAlternate = Nothing
        Me.JogMinus.UseVisualStyleBackColor = False
        Me.JogMinus.ValueToWrite = 1
        '
        'JogPlus
        '
        Me.JogPlus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.JogPlus.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.JogPlus.ComComponent = Me.ModbusTCPCom1
        Me.JogPlus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.JogPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.JogPlus.Font = New System.Drawing.Font("OCR A Extended", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JogPlus.ForeColor = System.Drawing.SystemColors.Window
        Me.JogPlus.ForeColorAltername = System.Drawing.Color.Black
        Me.JogPlus.Highlight = False
        Me.JogPlus.HighlightColor = System.Drawing.Color.Green
        Me.JogPlus.Location = New System.Drawing.Point(9, 112)
        Me.JogPlus.Margin = New System.Windows.Forms.Padding(4)
        Me.JogPlus.MaximumHoldTime = 90000
        Me.JogPlus.MinimumHoldTime = 2
        Me.JogPlus.Name = "JogPlus"
        Me.JogPlus.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.JogPlus.PLCAddressClick = "017187"
        Me.JogPlus.SelectTextAlternate = False
        Me.JogPlus.Size = New System.Drawing.Size(75, 75)
        Me.JogPlus.TabIndex = 9
        Me.JogPlus.Text = "+"
        Me.JogPlus.TextAlternate = Nothing
        Me.JogPlus.UseVisualStyleBackColor = False
        Me.JogPlus.ValueToWrite = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.HW_Zero)
        Me.GroupBox1.Controls.Add(Me.DisplacementZero)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(11, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(228, 199)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Auto Home"
        '
        'HW_Zero
        '
        Me.HW_Zero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.HW_Zero.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.HW_Zero.ComComponent = Me.ModbusTCPCom1
        Me.HW_Zero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.HW_Zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HW_Zero.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HW_Zero.ForeColor = System.Drawing.SystemColors.Window
        Me.HW_Zero.ForeColorAltername = System.Drawing.Color.Black
        Me.HW_Zero.Highlight = False
        Me.HW_Zero.HighlightColor = System.Drawing.Color.Green
        Me.HW_Zero.Location = New System.Drawing.Point(9, 113)
        Me.HW_Zero.Margin = New System.Windows.Forms.Padding(4)
        Me.HW_Zero.MaximumHoldTime = 3000
        Me.HW_Zero.MinimumHoldTime = 500
        Me.HW_Zero.Name = "HW_Zero"
        Me.HW_Zero.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.HW_Zero.PLCAddressClick = "017190"
        Me.HW_Zero.SelectTextAlternate = False
        Me.HW_Zero.Size = New System.Drawing.Size(210, 75)
        Me.HW_Zero.TabIndex = 15
        Me.HW_Zero.Text = "Hardware"
        Me.HW_Zero.TextAlternate = Nothing
        Me.HW_Zero.UseVisualStyleBackColor = False
        Me.HW_Zero.ValueToWrite = 0
        '
        'DisplacementZero
        '
        Me.DisplacementZero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DisplacementZero.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DisplacementZero.ComComponent = Me.ModbusTCPCom1
        Me.DisplacementZero.Enabled = False
        Me.DisplacementZero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DisplacementZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisplacementZero.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplacementZero.ForeColor = System.Drawing.SystemColors.Window
        Me.DisplacementZero.ForeColorAltername = System.Drawing.Color.Black
        Me.DisplacementZero.Highlight = False
        Me.DisplacementZero.HighlightColor = System.Drawing.Color.Green
        Me.DisplacementZero.Location = New System.Drawing.Point(10, 30)
        Me.DisplacementZero.Margin = New System.Windows.Forms.Padding(4)
        Me.DisplacementZero.MaximumHoldTime = 3000
        Me.DisplacementZero.MinimumHoldTime = 500
        Me.DisplacementZero.Name = "DisplacementZero"
        Me.DisplacementZero.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.DisplacementZero.PLCAddressClick = ""
        Me.DisplacementZero.SelectTextAlternate = False
        Me.DisplacementZero.Size = New System.Drawing.Size(210, 75)
        Me.DisplacementZero.TabIndex = 12
        Me.DisplacementZero.Text = "Displacement"
        Me.DisplacementZero.TextAlternate = Nothing
        Me.DisplacementZero.UseVisualStyleBackColor = False
        Me.DisplacementZero.ValueToWrite = 0
        '
        'GraphPanel
        '
        Me.GraphPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GraphPanel.Controls.Add(Me.LiveGraph)
        Me.GraphPanel.Location = New System.Drawing.Point(248, 68)
        Me.GraphPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.GraphPanel.Name = "GraphPanel"
        Me.GraphPanel.Size = New System.Drawing.Size(892, 672)
        Me.GraphPanel.TabIndex = 27
        '
        'LiveGraph
        '
        Me.LiveGraph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LiveGraph.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        ChartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea2.AxisX.IsLabelAutoFit = False
        ChartArea2.AxisX.IsMarginVisible = False
        ChartArea2.AxisX.IsStartedFromZero = False
        ChartArea2.AxisX.LabelAutoFitMaxFontSize = 12
        ChartArea2.AxisX.LabelAutoFitMinFontSize = 12
        ChartArea2.AxisX.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels
        ChartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Bisque
        ChartArea2.AxisX.LabelStyle.Format = "0"
        ChartArea2.AxisX.LabelStyle.Interval = 1.0R
        ChartArea2.AxisX.LabelStyle.IntervalOffset = 0R
        ChartArea2.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea2.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea2.AxisX.LabelStyle.TruncatedLabels = True
        ChartArea2.AxisX.LineColor = System.Drawing.Color.Bisque
        ChartArea2.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea2.AxisX.MajorGrid.Enabled = False
        ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea2.AxisX.MajorTickMark.Interval = 1.0R
        ChartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Bisque
        ChartArea2.AxisX.MajorTickMark.Size = 2.0!
        ChartArea2.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea
        ChartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea2.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea2.AxisY.IsMarginVisible = False
        ChartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Bisque
        ChartArea2.AxisY.LabelStyle.Interval = 10.0R
        ChartArea2.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea2.AxisY.LineColor = System.Drawing.Color.Bisque
        ChartArea2.AxisY.MajorGrid.Interval = 10.0R
        ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray
        ChartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea2.AxisY.MajorTickMark.Interval = 10.0R
        ChartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Bisque
        ChartArea2.AxisY.MajorTickMark.LineWidth = 5
        ChartArea2.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis
        ChartArea2.AxisY.Maximum = 50.0R
        ChartArea2.AxisY.Minimum = 0R
        ChartArea2.AxisY.TitleForeColor = System.Drawing.Color.White
        ChartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea2.AxisY2.Interval = 10.0R
        ChartArea2.AxisY2.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea2.AxisY2.IsMarginVisible = False
        ChartArea2.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.Bisque
        ChartArea2.AxisY2.LabelStyle.Interval = 10.0R
        ChartArea2.AxisY2.LabelStyle.IsEndLabelVisible = False
        ChartArea2.AxisY2.LineColor = System.Drawing.Color.Bisque
        ChartArea2.AxisY2.LineWidth = 2
        ChartArea2.AxisY2.MajorGrid.Interval = 10.0R
        ChartArea2.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Bisque
        ChartArea2.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea2.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.Bisque
        ChartArea2.AxisY2.MajorTickMark.LineWidth = 10
        ChartArea2.AxisY2.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis
        ChartArea2.AxisY2.Maximum = 50.0R
        ChartArea2.AxisY2.Minimum = 0R
        ChartArea2.AxisY2.MinorGrid.Interval = 1.0R
        ChartArea2.AxisY2.MinorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisY2.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea2.AxisY2.TitleForeColor = System.Drawing.Color.Bisque
        ChartArea2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer))
        ChartArea2.BorderColor = System.Drawing.Color.Bisque
        ChartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea2.Name = "ChartAreaDisp"
        Me.LiveGraph.ChartAreas.Add(ChartArea2)
        Me.LiveGraph.Location = New System.Drawing.Point(-29, -16)
        Me.LiveGraph.Margin = New System.Windows.Forms.Padding(2)
        Me.LiveGraph.Name = "LiveGraph"
        Me.LiveGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light
        Series2.BorderColor = System.Drawing.Color.White
        Series2.BorderWidth = 2
        Series2.ChartArea = "ChartAreaDisp"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Color = System.Drawing.Color.White
        Series2.MarkerBorderColor = System.Drawing.Color.White
        Series2.MarkerBorderWidth = 2
        Series2.MarkerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Series2.MarkerSize = 4
        Series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star4
        Series2.Name = "DisplacementSeries"
        Me.LiveGraph.Series.Add(Series2)
        Me.LiveGraph.Size = New System.Drawing.Size(971, 709)
        Me.LiveGraph.TabIndex = 39
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.DefaultExt = "csv"
        Me.SaveFileDialog.FileName = "flexure_recording.csv"
        Me.SaveFileDialog.Filter = """.csv files|*.csv"""
        Me.SaveFileDialog.Title = "Save Recording Data"
        '
        'SetupButton
        '
        Me.SetupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.SetupButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.SetupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetupButton.ForeColor = System.Drawing.Color.White
        Me.SetupButton.Location = New System.Drawing.Point(12, 500)
        Me.SetupButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SetupButton.Name = "SetupButton"
        Me.SetupButton.Size = New System.Drawing.Size(228, 75)
        Me.SetupButton.TabIndex = 41
        Me.SetupButton.Text = "⬑ Experimental Setup"
        Me.SetupButton.UseVisualStyleBackColor = False
        '
        'StartButton
        '
        Me.StartButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.StartButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.Font = New System.Drawing.Font("OCR A Extended", 27.75!)
        Me.StartButton.ForeColor = System.Drawing.Color.White
        Me.StartButton.Location = New System.Drawing.Point(164, 665)
        Me.StartButton.Margin = New System.Windows.Forms.Padding(4)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 75)
        Me.StartButton.TabIndex = 43
        Me.StartButton.Text = "▶"
        Me.StartButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'ConnectionCheckThread
        '
        '
        'ControlBlinker
        '
        '
        'ConnectionCheckTimer
        '
        Me.ConnectionCheckTimer.Enabled = True
        Me.ConnectionCheckTimer.Interval = 1001
        '
        'ConnectionIndicator
        '
        Me.ConnectionIndicator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConnectionIndicator.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.ConnectionIndicator.ForeColor = System.Drawing.Color.White
        Me.ConnectionIndicator.Location = New System.Drawing.Point(15, 22)
        Me.ConnectionIndicator.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ConnectionIndicator.Name = "ConnectionIndicator"
        Me.ConnectionIndicator.Size = New System.Drawing.Size(195, 22)
        Me.ConnectionIndicator.TabIndex = 38
        Me.ConnectionIndicator.Text = "Connection Status: "
        '
        'GraphUpdateTimer
        '
        Me.GraphUpdateTimer.Interval = 49
        '
        'GraphControlBox
        '
        Me.GraphControlBox.Controls.Add(Me.DecorativeDivider)
        Me.GraphControlBox.Controls.Add(Me.YMaxLabel)
        Me.GraphControlBox.Controls.Add(Me.UserSecondsButton)
        Me.GraphControlBox.Controls.Add(Me.GraphYInputBox)
        Me.GraphControlBox.Controls.Add(Me.UserSecondsInput)
        Me.GraphControlBox.Controls.Add(Me.TwoCycleButton)
        Me.GraphControlBox.Controls.Add(Me.HalfCycleButton)
        Me.GraphControlBox.Controls.Add(Me.OneCycleButton)
        Me.GraphControlBox.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.GraphControlBox.ForeColor = System.Drawing.Color.White
        Me.GraphControlBox.Location = New System.Drawing.Point(248, 4)
        Me.GraphControlBox.Margin = New System.Windows.Forms.Padding(2)
        Me.GraphControlBox.Name = "GraphControlBox"
        Me.GraphControlBox.Padding = New System.Windows.Forms.Padding(2)
        Me.GraphControlBox.Size = New System.Drawing.Size(659, 59)
        Me.GraphControlBox.TabIndex = 40
        Me.GraphControlBox.TabStop = False
        Me.GraphControlBox.Text = "Graph"
        '
        'DecorativeDivider
        '
        Me.DecorativeDivider.Location = New System.Drawing.Point(470, 0)
        Me.DecorativeDivider.Name = "DecorativeDivider"
        Me.DecorativeDivider.Size = New System.Drawing.Size(1, 59)
        Me.DecorativeDivider.TabIndex = 3
        Me.DecorativeDivider.TabStop = False
        '
        'YMaxLabel
        '
        Me.YMaxLabel.AutoSize = True
        Me.YMaxLabel.Location = New System.Drawing.Point(490, 24)
        Me.YMaxLabel.Name = "YMaxLabel"
        Me.YMaxLabel.Size = New System.Drawing.Size(76, 22)
        Me.YMaxLabel.TabIndex = 2
        Me.YMaxLabel.Text = "Y (mm):"
        '
        'UserSecondsButton
        '
        Me.UserSecondsButton.AutoSize = True
        Me.UserSecondsButton.Location = New System.Drawing.Point(299, 22)
        Me.UserSecondsButton.Margin = New System.Windows.Forms.Padding(2)
        Me.UserSecondsButton.Name = "UserSecondsButton"
        Me.UserSecondsButton.Size = New System.Drawing.Size(70, 26)
        Me.UserSecondsButton.TabIndex = 0
        Me.UserSecondsButton.TabStop = True
        Me.UserSecondsButton.Text = "Sec."
        Me.UserSecondsButton.UseVisualStyleBackColor = True
        '
        'GraphYInputBox
        '
        Me.GraphYInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GraphYInputBox.Location = New System.Drawing.Point(567, 23)
        Me.GraphYInputBox.Margin = New System.Windows.Forms.Padding(2)
        Me.GraphYInputBox.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.GraphYInputBox.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.GraphYInputBox.Name = "GraphYInputBox"
        Me.GraphYInputBox.Size = New System.Drawing.Size(75, 25)
        Me.GraphYInputBox.TabIndex = 1
        Me.GraphYInputBox.Value = New Decimal(New Integer() {40, 0, 0, 0})
        '
        'UserSecondsInput
        '
        Me.UserSecondsInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserSecondsInput.Location = New System.Drawing.Point(372, 23)
        Me.UserSecondsInput.Margin = New System.Windows.Forms.Padding(2)
        Me.UserSecondsInput.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.UserSecondsInput.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UserSecondsInput.Name = "UserSecondsInput"
        Me.UserSecondsInput.Size = New System.Drawing.Size(75, 25)
        Me.UserSecondsInput.TabIndex = 1
        Me.UserSecondsInput.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TwoCycleButton
        '
        Me.TwoCycleButton.AutoSize = True
        Me.TwoCycleButton.Checked = True
        Me.TwoCycleButton.Location = New System.Drawing.Point(208, 22)
        Me.TwoCycleButton.Margin = New System.Windows.Forms.Padding(2)
        Me.TwoCycleButton.Name = "TwoCycleButton"
        Me.TwoCycleButton.Size = New System.Drawing.Size(85, 26)
        Me.TwoCycleButton.TabIndex = 0
        Me.TwoCycleButton.TabStop = True
        Me.TwoCycleButton.Text = "2 Cyc."
        Me.TwoCycleButton.UseVisualStyleBackColor = True
        '
        'HalfCycleButton
        '
        Me.HalfCycleButton.AutoSize = True
        Me.HalfCycleButton.Location = New System.Drawing.Point(11, 22)
        Me.HalfCycleButton.Margin = New System.Windows.Forms.Padding(2)
        Me.HalfCycleButton.Name = "HalfCycleButton"
        Me.HalfCycleButton.Size = New System.Drawing.Size(101, 26)
        Me.HalfCycleButton.TabIndex = 0
        Me.HalfCycleButton.Text = "1/2 Cyc."
        Me.HalfCycleButton.UseVisualStyleBackColor = True
        '
        'OneCycleButton
        '
        Me.OneCycleButton.AutoSize = True
        Me.OneCycleButton.Location = New System.Drawing.Point(118, 22)
        Me.OneCycleButton.Margin = New System.Windows.Forms.Padding(2)
        Me.OneCycleButton.Name = "OneCycleButton"
        Me.OneCycleButton.Size = New System.Drawing.Size(85, 26)
        Me.OneCycleButton.TabIndex = 0
        Me.OneCycleButton.Text = "1 Cyc."
        Me.OneCycleButton.UseVisualStyleBackColor = True
        '
        'ConnectionStatusBox
        '
        Me.ConnectionStatusBox.Controls.Add(Me.ConnectionIndicator)
        Me.ConnectionStatusBox.Location = New System.Drawing.Point(918, 4)
        Me.ConnectionStatusBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ConnectionStatusBox.Name = "ConnectionStatusBox"
        Me.ConnectionStatusBox.Padding = New System.Windows.Forms.Padding(2)
        Me.ConnectionStatusBox.Size = New System.Drawing.Size(221, 59)
        Me.ConnectionStatusBox.TabIndex = 40
        Me.ConnectionStatusBox.TabStop = False
        '
        'StopButton
        '
        Me.StopButton.BackColor = System.Drawing.Color.Red
        Me.StopButton.ComComponent = Me.ModbusTCPCom1
        Me.StopButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopButton.Font = New System.Drawing.Font("OCR A Extended", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopButton.ForeColor = System.Drawing.SystemColors.Window
        Me.StopButton.ForeColorAltername = System.Drawing.Color.Black
        Me.StopButton.Highlight = False
        Me.StopButton.HighlightColor = System.Drawing.Color.Red
        Me.StopButton.Location = New System.Drawing.Point(11, 665)
        Me.StopButton.Margin = New System.Windows.Forms.Padding(4)
        Me.StopButton.MaximumHoldTime = 3000
        Me.StopButton.MinimumHoldTime = 500
        Me.StopButton.Name = "StopButton"
        Me.StopButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.StopButton.PLCAddressClick = "017186"
        Me.StopButton.SelectTextAlternate = False
        Me.StopButton.Size = New System.Drawing.Size(145, 75)
        Me.StopButton.TabIndex = 13
        Me.StopButton.Text = "■"
        Me.StopButton.TextAlternate = Nothing
        Me.StopButton.UseVisualStyleBackColor = False
        Me.StopButton.ValueToWrite = 1
        '
        'ExperimentRecordingThread
        '
        '
        'GeneralCommsUpdateTimer
        '
        Me.GeneralCommsUpdateTimer.Interval = 99
        '
        'ProgressTable
        '
        Me.ProgressTable.ColumnCount = 2
        Me.ProgressTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.52174!))
        Me.ProgressTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.47826!))
        Me.ProgressTable.Controls.Add(Me.TimeRemaingLabelTitle, 0, 1)
        Me.ProgressTable.Controls.Add(Me.TimeRemainingLabel, 1, 1)
        Me.ProgressTable.Controls.Add(Me.CurrentCycleLabel, 1, 0)
        Me.ProgressTable.Controls.Add(Me.CurrentCycleLabelTitle, 0, 0)
        Me.ProgressTable.Location = New System.Drawing.Point(11, 588)
        Me.ProgressTable.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressTable.Name = "ProgressTable"
        Me.ProgressTable.RowCount = 2
        Me.ProgressTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ProgressTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ProgressTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ProgressTable.Size = New System.Drawing.Size(230, 63)
        Me.ProgressTable.TabIndex = 44
        '
        'TimeRemaingLabelTitle
        '
        Me.TimeRemaingLabelTitle.AutoSize = True
        Me.TimeRemaingLabelTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TimeRemaingLabelTitle.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.TimeRemaingLabelTitle.ForeColor = System.Drawing.Color.White
        Me.TimeRemaingLabelTitle.Location = New System.Drawing.Point(2, 31)
        Me.TimeRemaingLabelTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TimeRemaingLabelTitle.Name = "TimeRemaingLabelTitle"
        Me.TimeRemaingLabelTitle.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.TimeRemaingLabelTitle.Size = New System.Drawing.Size(126, 32)
        Me.TimeRemaingLabelTitle.TabIndex = 5
        Me.TimeRemaingLabelTitle.Text = "Est. Remain:"
        '
        'TimeRemainingLabel
        '
        Me.TimeRemainingLabel.AutoSize = True
        Me.TimeRemainingLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TimeRemainingLabel.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.TimeRemainingLabel.ForeColor = System.Drawing.Color.White
        Me.TimeRemainingLabel.Location = New System.Drawing.Point(132, 31)
        Me.TimeRemainingLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TimeRemainingLabel.Name = "TimeRemainingLabel"
        Me.TimeRemainingLabel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.TimeRemainingLabel.Size = New System.Drawing.Size(96, 32)
        Me.TimeRemainingLabel.TabIndex = 4
        Me.TimeRemainingLabel.Text = "hh:mm:ss"
        '
        'CurrentCycleLabel
        '
        Me.CurrentCycleLabel.AutoSize = True
        Me.CurrentCycleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CurrentCycleLabel.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.CurrentCycleLabel.ForeColor = System.Drawing.Color.White
        Me.CurrentCycleLabel.Location = New System.Drawing.Point(133, 0)
        Me.CurrentCycleLabel.Name = "CurrentCycleLabel"
        Me.CurrentCycleLabel.Size = New System.Drawing.Size(94, 31)
        Me.CurrentCycleLabel.TabIndex = 6
        Me.CurrentCycleLabel.Text = "0/1"
        '
        'CurrentCycleLabelTitle
        '
        Me.CurrentCycleLabelTitle.AutoSize = True
        Me.CurrentCycleLabelTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CurrentCycleLabelTitle.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.CurrentCycleLabelTitle.ForeColor = System.Drawing.Color.White
        Me.CurrentCycleLabelTitle.Location = New System.Drawing.Point(3, 0)
        Me.CurrentCycleLabelTitle.Name = "CurrentCycleLabelTitle"
        Me.CurrentCycleLabelTitle.Size = New System.Drawing.Size(124, 31)
        Me.CurrentCycleLabelTitle.TabIndex = 7
        Me.CurrentCycleLabelTitle.Text = "Cycle:"
        '
        'EstTimeRemiainingCounter
        '
        Me.EstTimeRemiainingCounter.Interval = 1000
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1151, 751)
        Me.Controls.Add(Me.ProgressTable)
        Me.Controls.Add(Me.ConnectionStatusBox)
        Me.Controls.Add(Me.GraphControlBox)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.SetupButton)
        Me.Controls.Add(Me.GraphPanel)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flex Rig Control"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ModbusTCPCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GraphPanel.ResumeLayout(False)
        CType(Me.LiveGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GraphControlBox.ResumeLayout(False)
        Me.GraphControlBox.PerformLayout()
        CType(Me.GraphYInputBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserSecondsInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConnectionStatusBox.ResumeLayout(False)
        Me.ProgressTable.ResumeLayout(False)
        Me.ProgressTable.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DF1ComWF1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents ForceItemsIntoToolBox1 As MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SetOrigin As AdvancedHMIControls.BasicButton
    Friend WithEvents JogMinus As AdvancedHMIControls.BasicButton
    Friend WithEvents JogPlus As AdvancedHMIControls.BasicButton
    Friend WithEvents StopButton As AdvancedHMIControls.BasicButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DisplacementZero As AdvancedHMIControls.BasicButton
    Friend WithEvents HW_Zero As AdvancedHMIControls.BasicButton
    Friend WithEvents ModbusTCPCom1 As AdvancedHMIDrivers.ModbusTCPCom
    Friend WithEvents GraphPanel As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DRO_mm As AdvancedHMIControls.SevenSegment2
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DRO_N As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ExperimentRecordingTimer As Timer
    Friend WithEvents SetupButton As Button
    Friend WithEvents StartButton As CheckBox
    Friend WithEvents ConnectionCheckThread As System.ComponentModel.BackgroundWorker
    Friend WithEvents ControlBlinker As Timer
    Friend WithEvents ConnectionCheckTimer As Timer
    Friend WithEvents LiveGraph As DataVisualization.Charting.Chart
    Friend WithEvents ConnectionIndicator As Label
    Friend WithEvents GraphUpdateTimer As Timer
    Friend WithEvents GraphControlBox As GroupBox
    Friend WithEvents TwoCycleButton As RadioButton
    Friend WithEvents HalfCycleButton As RadioButton
    Friend WithEvents OneCycleButton As RadioButton
    Friend WithEvents ConnectionStatusBox As GroupBox
    Friend WithEvents UserSecondsButton As RadioButton
    Friend WithEvents UserSecondsInput As NumericUpDown
    Friend WithEvents ExperimentRecordingThread As System.ComponentModel.BackgroundWorker
    Friend WithEvents GeneralCommsUpdateTimer As Timer
    Friend WithEvents GraphYInputBox As NumericUpDown
    Friend WithEvents DecorativeDivider As GroupBox
    Friend WithEvents YMaxLabel As Label
    Friend WithEvents ProgressTable As TableLayoutPanel
    Friend WithEvents TimeRemaingLabelTitle As Label
    Friend WithEvents TimeRemainingLabel As Label
    Friend WithEvents CurrentCycleLabel As Label
    Friend WithEvents CurrentCycleLabelTitle As Label
    Friend WithEvents EstTimeRemiainingCounter As Timer
End Class
