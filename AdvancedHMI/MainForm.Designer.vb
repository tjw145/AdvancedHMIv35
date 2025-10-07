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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
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
        Me.ForceZero = New AdvancedHMIControls.BasicButton()
        Me.DisplacementZero = New AdvancedHMIControls.BasicButton()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.GraphPanel = New System.Windows.Forms.Panel()
        Me.LiveGraph = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ExperimentRecordingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SetupButton = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.CheckBox()
        Me.ConnectionCheckThread = New System.ComponentModel.BackgroundWorker()
        Me.ControlBlinker = New System.Windows.Forms.Timer(Me.components)
        Me.ConnectionCheckTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StopButton = New AdvancedHMIControls.BasicButton()
        Me.StopButtonSubscriber = New AdvancedHMIControls.DataSubscriber(Me.components)
        Me.CheckIfHoming = New AdvancedHMIControls.DataSubscriber(Me.components)
        Me.ConnectionIndicator = New System.Windows.Forms.Label()
        Me.GraphUpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GraphControlBox = New System.Windows.Forms.GroupBox()
        Me.DataMarkersCheckbox = New System.Windows.Forms.CheckBox()
        Me.TwoCycleButton = New System.Windows.Forms.RadioButton()
        Me.HalfCycleButton = New System.Windows.Forms.RadioButton()
        Me.OneCycleButton = New System.Windows.Forms.RadioButton()
        Me.ConnectionStatusBox = New System.Windows.Forms.GroupBox()
        Me.UserSecondsInput = New System.Windows.Forms.NumericUpDown()
        Me.UserSecondsButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ModbusTCPCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GraphPanel.SuspendLayout()
        CType(Me.LiveGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StopButtonSubscriber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckIfHoming, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GraphControlBox.SuspendLayout()
        Me.ConnectionStatusBox.SuspendLayout()
        CType(Me.UserSecondsInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 1464)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 64)
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
        Me.GroupBox2.Location = New System.Drawing.Point(18, 470)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(365, 450)
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
        Me.SetOrigin.Location = New System.Drawing.Point(14, 317)
        Me.SetOrigin.Margin = New System.Windows.Forms.Padding(6)
        Me.SetOrigin.MaximumHoldTime = 3000
        Me.SetOrigin.MinimumHoldTime = 500
        Me.SetOrigin.Name = "SetOrigin"
        Me.SetOrigin.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SetOrigin.PLCAddressClick = "017189"
        Me.SetOrigin.SelectTextAlternate = False
        Me.SetOrigin.Size = New System.Drawing.Size(336, 120)
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
        Me.ModbusTCPCom1.TimeOut = 3000
        Me.ModbusTCPCom1.UnitId = CType(1, Byte)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DRO_N)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(146, 179)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox4.Size = New System.Drawing.Size(205, 125)
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
        Me.DRO_N.Location = New System.Drawing.Point(26, 35)
        Me.DRO_N.Margin = New System.Windows.Forms.Padding(6)
        Me.DRO_N.Name = "DRO_N"
        Me.DRO_N.NumberOfDigits = 3
        Me.DRO_N.PLCAddressKeypad = ""
        Me.DRO_N.PLCAddressText = ""
        Me.DRO_N.PLCAddressValue = Nothing
        Me.DRO_N.PLCAddressVisible = ""
        Me.DRO_N.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DRO_N.ShowOffSegments = True
        Me.DRO_N.Size = New System.Drawing.Size(159, 69)
        Me.DRO_N.TabIndex = 11
        Me.DRO_N.Text = "SevenSegment21"
        Me.DRO_N.Value = 999999.0R
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DRO_mm)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(146, 48)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(205, 125)
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
        Me.DRO_mm.Location = New System.Drawing.Point(26, 35)
        Me.DRO_mm.Margin = New System.Windows.Forms.Padding(6)
        Me.DRO_mm.Name = "DRO_mm"
        Me.DRO_mm.NumberOfDigits = 3
        Me.DRO_mm.PLCAddressKeypad = ""
        Me.DRO_mm.PLCAddressText = ""
        Me.DRO_mm.PLCAddressValue = Nothing
        Me.DRO_mm.PLCAddressVisible = ""
        Me.DRO_mm.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DRO_mm.ShowOffSegments = True
        Me.DRO_mm.Size = New System.Drawing.Size(159, 69)
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
        Me.JogMinus.Location = New System.Drawing.Point(14, 51)
        Me.JogMinus.Margin = New System.Windows.Forms.Padding(6)
        Me.JogMinus.MaximumHoldTime = 90000
        Me.JogMinus.MinimumHoldTime = 2
        Me.JogMinus.Name = "JogMinus"
        Me.JogMinus.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.JogMinus.PLCAddressClick = "017188"
        Me.JogMinus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.JogMinus.SelectTextAlternate = False
        Me.JogMinus.Size = New System.Drawing.Size(120, 120)
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
        Me.JogPlus.Location = New System.Drawing.Point(14, 184)
        Me.JogPlus.Margin = New System.Windows.Forms.Padding(6)
        Me.JogPlus.MaximumHoldTime = 90000
        Me.JogPlus.MinimumHoldTime = 2
        Me.JogPlus.Name = "JogPlus"
        Me.JogPlus.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.JogPlus.PLCAddressClick = "017187"
        Me.JogPlus.SelectTextAlternate = False
        Me.JogPlus.Size = New System.Drawing.Size(120, 120)
        Me.JogPlus.TabIndex = 9
        Me.JogPlus.Text = "+"
        Me.JogPlus.TextAlternate = Nothing
        Me.JogPlus.UseVisualStyleBackColor = False
        Me.JogPlus.ValueToWrite = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.HW_Zero)
        Me.GroupBox1.Controls.Add(Me.ForceZero)
        Me.GroupBox1.Controls.Add(Me.DisplacementZero)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(18, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(365, 451)
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
        Me.HW_Zero.Location = New System.Drawing.Point(14, 317)
        Me.HW_Zero.Margin = New System.Windows.Forms.Padding(6)
        Me.HW_Zero.MaximumHoldTime = 3000
        Me.HW_Zero.MinimumHoldTime = 500
        Me.HW_Zero.Name = "HW_Zero"
        Me.HW_Zero.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.HW_Zero.PLCAddressClick = "017190"
        Me.HW_Zero.SelectTextAlternate = False
        Me.HW_Zero.Size = New System.Drawing.Size(336, 120)
        Me.HW_Zero.TabIndex = 15
        Me.HW_Zero.Text = "Hardware"
        Me.HW_Zero.TextAlternate = Nothing
        Me.HW_Zero.UseVisualStyleBackColor = False
        Me.HW_Zero.ValueToWrite = 0
        '
        'ForceZero
        '
        Me.ForceZero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ForceZero.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ForceZero.ComComponent = Me.ModbusTCPCom1
        Me.ForceZero.Enabled = False
        Me.ForceZero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ForceZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ForceZero.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForceZero.ForeColor = System.Drawing.SystemColors.Window
        Me.ForceZero.ForeColorAltername = System.Drawing.Color.Black
        Me.ForceZero.Highlight = False
        Me.ForceZero.HighlightColor = System.Drawing.Color.Green
        Me.ForceZero.Location = New System.Drawing.Point(14, 184)
        Me.ForceZero.Margin = New System.Windows.Forms.Padding(6)
        Me.ForceZero.MaximumHoldTime = 3000
        Me.ForceZero.MinimumHoldTime = 500
        Me.ForceZero.Name = "ForceZero"
        Me.ForceZero.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.ForceZero.PLCAddressClick = ""
        Me.ForceZero.SelectTextAlternate = False
        Me.ForceZero.Size = New System.Drawing.Size(336, 120)
        Me.ForceZero.TabIndex = 13
        Me.ForceZero.Text = "Force"
        Me.ForceZero.TextAlternate = Nothing
        Me.ForceZero.UseVisualStyleBackColor = False
        Me.ForceZero.ValueToWrite = 0
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
        Me.DisplacementZero.Location = New System.Drawing.Point(14, 51)
        Me.DisplacementZero.Margin = New System.Windows.Forms.Padding(6)
        Me.DisplacementZero.MaximumHoldTime = 3000
        Me.DisplacementZero.MinimumHoldTime = 500
        Me.DisplacementZero.Name = "DisplacementZero"
        Me.DisplacementZero.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.DisplacementZero.PLCAddressClick = ""
        Me.DisplacementZero.SelectTextAlternate = False
        Me.DisplacementZero.Size = New System.Drawing.Size(336, 120)
        Me.DisplacementZero.TabIndex = 12
        Me.DisplacementZero.Text = "Displacement"
        Me.DisplacementZero.TextAlternate = Nothing
        Me.DisplacementZero.UseVisualStyleBackColor = False
        Me.DisplacementZero.ValueToWrite = 0
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(15, 1195)
        Me.ProgressBar.Margin = New System.Windows.Forms.Padding(6)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(368, 45)
        Me.ProgressBar.Step = 1
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar.TabIndex = 29
        Me.ProgressBar.Value = 1
        '
        'GraphPanel
        '
        Me.GraphPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GraphPanel.Controls.Add(Me.LiveGraph)
        Me.GraphPanel.Location = New System.Drawing.Point(395, 109)
        Me.GraphPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.GraphPanel.Name = "GraphPanel"
        Me.GraphPanel.Size = New System.Drawing.Size(1428, 1131)
        Me.GraphPanel.TabIndex = 27
        '
        'LiveGraph
        '
        Me.LiveGraph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LiveGraph.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.IsMarginVisible = False
        ChartArea1.AxisX.IsStartedFromZero = False
        ChartArea1.AxisX.LabelAutoFitMaxFontSize = 12
        ChartArea1.AxisX.LabelAutoFitMinFontSize = 12
        ChartArea1.AxisX.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Bisque
        ChartArea1.AxisX.LabelStyle.Format = "0"
        ChartArea1.AxisX.LabelStyle.Interval = 1.0R
        ChartArea1.AxisX.LabelStyle.IntervalOffset = 0R
        ChartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.AxisX.LabelStyle.TruncatedLabels = True
        ChartArea1.AxisX.LineColor = System.Drawing.Color.Bisque
        ChartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea1.AxisX.MajorTickMark.Interval = 1.0R
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Bisque
        ChartArea1.AxisX.MajorTickMark.Size = 2.0!
        ChartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea
        ChartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.AxisY.IsMarginVisible = False
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Bisque
        ChartArea1.AxisY.LabelStyle.Interval = 10.0R
        ChartArea1.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.AxisY.LineColor = System.Drawing.Color.Bisque
        ChartArea1.AxisY.MajorGrid.Interval = 10.0R
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray
        ChartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea1.AxisY.MajorTickMark.Interval = 10.0R
        ChartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Bisque
        ChartArea1.AxisY.MajorTickMark.LineWidth = 5
        ChartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis
        ChartArea1.AxisY.Maximum = 50.0R
        ChartArea1.AxisY.Minimum = 0R
        ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.White
        ChartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea1.AxisY2.Interval = 10.0R
        ChartArea1.AxisY2.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.AxisY2.IsMarginVisible = False
        ChartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.Bisque
        ChartArea1.AxisY2.LabelStyle.Interval = 10.0R
        ChartArea1.AxisY2.LineColor = System.Drawing.Color.Bisque
        ChartArea1.AxisY2.LineWidth = 2
        ChartArea1.AxisY2.MajorGrid.Interval = 10.0R
        ChartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Bisque
        ChartArea1.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea1.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.Bisque
        ChartArea1.AxisY2.MajorTickMark.LineWidth = 10
        ChartArea1.AxisY2.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis
        ChartArea1.AxisY2.Maximum = 50.0R
        ChartArea1.AxisY2.Minimum = 0R
        ChartArea1.AxisY2.TitleForeColor = System.Drawing.Color.Bisque
        ChartArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer))
        ChartArea1.BorderColor = System.Drawing.Color.Bisque
        ChartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea1.Name = "ChartAreaDisp"
        Me.LiveGraph.ChartAreas.Add(ChartArea1)
        Me.LiveGraph.Location = New System.Drawing.Point(-37, -38)
        Me.LiveGraph.Name = "LiveGraph"
        Me.LiveGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light
        Series1.BorderColor = System.Drawing.Color.White
        Series1.BorderWidth = 2
        Series1.ChartArea = "ChartAreaDisp"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.Color.White
        Series1.MarkerBorderColor = System.Drawing.Color.White
        Series1.MarkerBorderWidth = 2
        Series1.MarkerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Series1.MarkerSize = 4
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star4
        Series1.Name = "DisplacementSeries"
        Me.LiveGraph.Series.Add(Series1)
        Me.LiveGraph.Size = New System.Drawing.Size(1525, 1233)
        Me.LiveGraph.TabIndex = 39
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.DefaultExt = "csv"
        Me.SaveFileDialog.FileName = "flexure_recording.csv"
        Me.SaveFileDialog.Filter = """.csv files|*.csv"""
        Me.SaveFileDialog.Title = "Save Recording Data"
        '
        'ExperimentRecordingTimer
        '
        '
        'SetupButton
        '
        Me.SetupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.SetupButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.SetupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetupButton.ForeColor = System.Drawing.Color.White
        Me.SetupButton.Location = New System.Drawing.Point(18, 931)
        Me.SetupButton.Margin = New System.Windows.Forms.Padding(6)
        Me.SetupButton.Name = "SetupButton"
        Me.SetupButton.Size = New System.Drawing.Size(365, 120)
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
        Me.StartButton.Location = New System.Drawing.Point(262, 1064)
        Me.StartButton.Margin = New System.Windows.Forms.Padding(6)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(120, 120)
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
        Me.ConnectionCheckTimer.Interval = 1000
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
        Me.StopButton.Location = New System.Drawing.Point(18, 1064)
        Me.StopButton.Margin = New System.Windows.Forms.Padding(6)
        Me.StopButton.MaximumHoldTime = 3000
        Me.StopButton.MinimumHoldTime = 500
        Me.StopButton.Name = "StopButton"
        Me.StopButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetTrue
        Me.StopButton.PLCAddressClick = "017186"
        Me.StopButton.SelectTextAlternate = False
        Me.StopButton.Size = New System.Drawing.Size(232, 120)
        Me.StopButton.TabIndex = 13
        Me.StopButton.Text = "■"
        Me.StopButton.TextAlternate = Nothing
        Me.StopButton.UseVisualStyleBackColor = False
        Me.StopButton.ValueToWrite = 1
        '
        'StopButtonSubscriber
        '
        Me.StopButtonSubscriber.ComComponent = Me.ModbusTCPCom1
        Me.StopButtonSubscriber.PLCAddressValue = Nothing
        Me.StopButtonSubscriber.Value = Nothing
        '
        'CheckIfHoming
        '
        Me.CheckIfHoming.ComComponent = Me.ModbusTCPCom1
        Me.CheckIfHoming.PLCAddressValue = Nothing
        Me.CheckIfHoming.Value = Nothing
        '
        'ConnectionIndicator
        '
        Me.ConnectionIndicator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConnectionIndicator.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.ConnectionIndicator.ForeColor = System.Drawing.Color.White
        Me.ConnectionIndicator.Location = New System.Drawing.Point(16, 37)
        Me.ConnectionIndicator.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.ConnectionIndicator.Name = "ConnectionIndicator"
        Me.ConnectionIndicator.Size = New System.Drawing.Size(282, 35)
        Me.ConnectionIndicator.TabIndex = 38
        Me.ConnectionIndicator.Text = "Connection Status: "
        '
        'GraphUpdateTimer
        '
        Me.GraphUpdateTimer.Interval = 50
        '
        'GraphControlBox
        '
        Me.GraphControlBox.Controls.Add(Me.UserSecondsButton)
        Me.GraphControlBox.Controls.Add(Me.DataMarkersCheckbox)
        Me.GraphControlBox.Controls.Add(Me.UserSecondsInput)
        Me.GraphControlBox.Controls.Add(Me.TwoCycleButton)
        Me.GraphControlBox.Controls.Add(Me.HalfCycleButton)
        Me.GraphControlBox.Controls.Add(Me.OneCycleButton)
        Me.GraphControlBox.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.GraphControlBox.ForeColor = System.Drawing.Color.White
        Me.GraphControlBox.Location = New System.Drawing.Point(397, 6)
        Me.GraphControlBox.Name = "GraphControlBox"
        Me.GraphControlBox.Size = New System.Drawing.Size(1055, 94)
        Me.GraphControlBox.TabIndex = 40
        Me.GraphControlBox.TabStop = False
        Me.GraphControlBox.Text = "Graph"
        '
        'DataMarkersCheckbox
        '
        Me.DataMarkersCheckbox.AutoSize = True
        Me.DataMarkersCheckbox.Checked = True
        Me.DataMarkersCheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DataMarkersCheckbox.Location = New System.Drawing.Point(731, 39)
        Me.DataMarkersCheckbox.Name = "DataMarkersCheckbox"
        Me.DataMarkersCheckbox.Size = New System.Drawing.Size(300, 39)
        Me.DataMarkersCheckbox.TabIndex = 3
        Me.DataMarkersCheckbox.Text = "Data Point Markers"
        Me.DataMarkersCheckbox.UseVisualStyleBackColor = True
        '
        'TwoCycleButton
        '
        Me.TwoCycleButton.AutoSize = True
        Me.TwoCycleButton.Checked = True
        Me.TwoCycleButton.Location = New System.Drawing.Point(333, 39)
        Me.TwoCycleButton.Name = "TwoCycleButton"
        Me.TwoCycleButton.Size = New System.Drawing.Size(131, 39)
        Me.TwoCycleButton.TabIndex = 0
        Me.TwoCycleButton.TabStop = True
        Me.TwoCycleButton.Text = "2 Cyc."
        Me.TwoCycleButton.UseVisualStyleBackColor = True
        '
        'HalfCycleButton
        '
        Me.HalfCycleButton.AutoSize = True
        Me.HalfCycleButton.Location = New System.Drawing.Point(18, 39)
        Me.HalfCycleButton.Name = "HalfCycleButton"
        Me.HalfCycleButton.Size = New System.Drawing.Size(156, 39)
        Me.HalfCycleButton.TabIndex = 0
        Me.HalfCycleButton.Text = "1/2 Cyc."
        Me.HalfCycleButton.UseVisualStyleBackColor = True
        '
        'OneCycleButton
        '
        Me.OneCycleButton.AutoSize = True
        Me.OneCycleButton.Location = New System.Drawing.Point(188, 39)
        Me.OneCycleButton.Name = "OneCycleButton"
        Me.OneCycleButton.Size = New System.Drawing.Size(131, 39)
        Me.OneCycleButton.TabIndex = 0
        Me.OneCycleButton.Text = "1 Cyc."
        Me.OneCycleButton.UseVisualStyleBackColor = True
        '
        'ConnectionStatusBox
        '
        Me.ConnectionStatusBox.Controls.Add(Me.ConnectionIndicator)
        Me.ConnectionStatusBox.Location = New System.Drawing.Point(1469, 6)
        Me.ConnectionStatusBox.Name = "ConnectionStatusBox"
        Me.ConnectionStatusBox.Size = New System.Drawing.Size(354, 94)
        Me.ConnectionStatusBox.TabIndex = 40
        Me.ConnectionStatusBox.TabStop = False
        '
        'UserSecondsInput
        '
        Me.UserSecondsInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserSecondsInput.Location = New System.Drawing.Point(597, 39)
        Me.UserSecondsInput.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.UserSecondsInput.Name = "UserSecondsInput"
        Me.UserSecondsInput.Size = New System.Drawing.Size(120, 38)
        Me.UserSecondsInput.TabIndex = 1
        '
        'UserSecondsButton
        '
        Me.UserSecondsButton.AutoSize = True
        Me.UserSecondsButton.Location = New System.Drawing.Point(478, 39)
        Me.UserSecondsButton.Name = "UserSecondsButton"
        Me.UserSecondsButton.Size = New System.Drawing.Size(105, 39)
        Me.UserSecondsButton.TabIndex = 0
        Me.UserSecondsButton.TabStop = True
        Me.UserSecondsButton.Text = "Sec."
        Me.UserSecondsButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1841, 1262)
        Me.Controls.Add(Me.ConnectionStatusBox)
        Me.Controls.Add(Me.GraphControlBox)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.SetupButton)
        Me.Controls.Add(Me.GraphPanel)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(6)
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
        CType(Me.StopButtonSubscriber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckIfHoming, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GraphControlBox.ResumeLayout(False)
        Me.GraphControlBox.PerformLayout()
        Me.ConnectionStatusBox.ResumeLayout(False)
        CType(Me.UserSecondsInput, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ForceZero As AdvancedHMIControls.BasicButton
    Friend WithEvents DisplacementZero As AdvancedHMIControls.BasicButton
    Friend WithEvents HW_Zero As AdvancedHMIControls.BasicButton
    Friend WithEvents ModbusTCPCom1 As AdvancedHMIDrivers.ModbusTCPCom
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents GraphPanel As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DRO_mm As AdvancedHMIControls.SevenSegment2
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DRO_N As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ExperimentRecordingTimer As Timer
    Friend WithEvents SetupButton As Button
    Friend WithEvents StartButton As CheckBox
    Friend WithEvents StopButtonSubscriber As AdvancedHMIControls.DataSubscriber
    Friend WithEvents ConnectionCheckThread As System.ComponentModel.BackgroundWorker
    Friend WithEvents ControlBlinker As Timer
    Friend WithEvents CheckIfHoming As AdvancedHMIControls.DataSubscriber
    Friend WithEvents ConnectionCheckTimer As Timer
    Friend WithEvents LiveGraph As DataVisualization.Charting.Chart
    Friend WithEvents ConnectionIndicator As Label
    Friend WithEvents GraphUpdateTimer As Timer
    Friend WithEvents GraphControlBox As GroupBox
    Friend WithEvents TwoCycleButton As RadioButton
    Friend WithEvents HalfCycleButton As RadioButton
    Friend WithEvents OneCycleButton As RadioButton
    Friend WithEvents DataMarkersCheckbox As CheckBox
    Friend WithEvents ConnectionStatusBox As GroupBox
    Friend WithEvents UserSecondsButton As RadioButton
    Friend WithEvents UserSecondsInput As NumericUpDown
End Class
