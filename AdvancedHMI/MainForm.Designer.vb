﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
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
        Me.ForceZero = New AdvancedHMIControls.BasicButton()
        Me.DisplacementZero = New AdvancedHMIControls.BasicButton()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        'Me.DispGraph = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DisplacementChart = New AdvancedHMIControls.BasicTrendChart()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ConnectionIndicator = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ForceChart = New AdvancedHMIControls.BasicTrendChart()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ExperimentRecordingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SetupButton = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.CheckBox()
        Me.ConnectionCheckTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MotionControlThread = New System.ComponentModel.BackgroundWorker()
        Me.StopButton = New AdvancedHMIControls.BasicButton()
        Me.StartButtonSubscriber = New AdvancedHMIControls.DataSubscriber(Me.components)
        Me.ConnectionCheckThread = New System.ComponentModel.BackgroundWorker()
        Me.ControlBlinker = New System.Windows.Forms.Timer(Me.components)
        Me.CheckIfHoming = New AdvancedHMIControls.DataSubscriber(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.ModbusTCPCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        'CType(Me.DispGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.StartButtonSubscriber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckIfHoming, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 915)
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
        Me.GroupBox2.Location = New System.Drawing.Point(11, 294)
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
        Me.SetOrigin.Location = New System.Drawing.Point(9, 198)
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
        Me.ModbusTCPCom1.TimeOut = 3000
        Me.ModbusTCPCom1.UnitId = CType(1, Byte)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DRO_N)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(91, 112)
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
        Me.DRO_N.ForecolorHighLimitValue = 999999.0R
        Me.DRO_N.ForeColorInLimits = System.Drawing.Color.IndianRed
        Me.DRO_N.ForecolorLowLimitValue = -999999.0R
        Me.DRO_N.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.DRO_N.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.DRO_N.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DRO_N.KeypadMaxValue = 0R
        Me.DRO_N.KeypadMinValue = 0R
        Me.DRO_N.KeypadScaleFactor = 1.0R
        Me.DRO_N.KeypadText = Nothing
        Me.DRO_N.KeypadWidth = 300
        Me.DRO_N.Location = New System.Drawing.Point(16, 22)
        Me.DRO_N.Margin = New System.Windows.Forms.Padding(4)
        Me.DRO_N.Name = "DRO_N"
        Me.DRO_N.NumberOfDigits = 3
        Me.DRO_N.PLCAddressKeypad = ""
        Me.DRO_N.PLCAddressText = ""
        Me.DRO_N.PLCAddressValue = Nothing
        Me.DRO_N.PLCAddressVisible = ""
        Me.DRO_N.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DRO_N.ShowOffSegments = True
        Me.DRO_N.Size = New System.Drawing.Size(99, 43)
        Me.DRO_N.TabIndex = 11
        Me.DRO_N.Text = "SevenSegment21"
        Me.DRO_N.Value = 0R
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DRO_mm)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(91, 30)
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
        Me.DRO_mm.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DRO_mm.ShowOffSegments = True
        Me.DRO_mm.Size = New System.Drawing.Size(99, 43)
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
        Me.JogMinus.Location = New System.Drawing.Point(9, 32)
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
        Me.JogPlus.Location = New System.Drawing.Point(9, 115)
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
        Me.GroupBox1.Controls.Add(Me.ForceZero)
        Me.GroupBox1.Controls.Add(Me.DisplacementZero)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(11, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(228, 282)
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
        Me.HW_Zero.Location = New System.Drawing.Point(9, 198)
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
        Me.ForceZero.Location = New System.Drawing.Point(9, 115)
        Me.ForceZero.Margin = New System.Windows.Forms.Padding(4)
        Me.ForceZero.MaximumHoldTime = 3000
        Me.ForceZero.MinimumHoldTime = 500
        Me.ForceZero.Name = "ForceZero"
        Me.ForceZero.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.ForceZero.PLCAddressClick = ""
        Me.ForceZero.SelectTextAlternate = False
        Me.ForceZero.Size = New System.Drawing.Size(210, 75)
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
        Me.DisplacementZero.Location = New System.Drawing.Point(9, 32)
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
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(11, 748)
        Me.ProgressBar.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(228, 28)
        Me.ProgressBar.Step = 1
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar.TabIndex = 29
        Me.ProgressBar.Value = 1
        '
        'Panel2
        '
        'Me.Panel2.Controls.Add(Me.DispGraph)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.DisplacementChart)
        Me.Panel2.Location = New System.Drawing.Point(246, 4)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(502, 771)
        Me.Panel2.TabIndex = 27
        '
        'DispGraph
        '
        'Me.DispGraph.BackColor = System.Drawing.Color.WhiteSmoke
        'ChartArea2.Name = "ChartArea1"
        'Me.DispGraph.ChartAreas.Add(ChartArea2)
        'Legend2.Name = "Legend1"
        'Me.DispGraph.Legends.Add(Legend2)
        'Me.DispGraph.Location = New System.Drawing.Point(40, 198)
        'Me.DispGraph.Margin = New System.Windows.Forms.Padding(4)
        'Me.DispGraph.Name = "DispGraph"
        'Me.DispGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        'Series2.ChartArea = "ChartArea1"
        'Series2.Legend = "Legend1"
        'Series2.Name = "Series1"
        'Me.DispGraph.Series.Add(Series2)
        'Me.DispGraph.Size = New System.Drawing.Size(375, 375)
        'Me.DispGraph.TabIndex = 27
        'Me.DispGraph.Text = "Chart1"
        'Me.DispGraph.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(-2, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 18)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Displacement:"
        '
        'DisplacementChart
        '
        Me.DisplacementChart.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.DisplacementChart.ComComponent = Me.ModbusTCPCom1
        Me.DisplacementChart.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.DisplacementChart.ForeColor = System.Drawing.Color.White
        Me.DisplacementChart.Location = New System.Drawing.Point(0, 44)
        Me.DisplacementChart.Margin = New System.Windows.Forms.Padding(10)
        Me.DisplacementChart.MaxPoints = 1000
        Me.DisplacementChart.Name = "DisplacementChart"
        Me.DisplacementChart.PLCAddressValue = "400008"
        Me.DisplacementChart.PLCAddressVisible = ""
        Me.DisplacementChart.Size = New System.Drawing.Size(492, 728)
        Me.DisplacementChart.TabIndex = 16
        Me.DisplacementChart.Text = "BasicTrendChart1"
        Me.DisplacementChart.Value = ""
        Me.DisplacementChart.YMaximum = 50000
        Me.DisplacementChart.YMinimum = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ConnectionIndicator)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ForceChart)
        Me.Panel1.Location = New System.Drawing.Point(750, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(499, 771)
        Me.Panel1.TabIndex = 27
        '
        'ConnectionIndicator
        '
        Me.ConnectionIndicator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConnectionIndicator.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.ConnectionIndicator.ForeColor = System.Drawing.Color.White
        Me.ConnectionIndicator.Location = New System.Drawing.Point(312, 11)
        Me.ConnectionIndicator.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ConnectionIndicator.Name = "ConnectionIndicator"
        Me.ConnectionIndicator.Size = New System.Drawing.Size(176, 22)
        Me.ConnectionIndicator.TabIndex = 38
        Me.ConnectionIndicator.Text = "Connection Status: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Force:"
        '
        'ForceChart
        '
        Me.ForceChart.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.ForceChart.ComComponent = Me.ModbusTCPCom1
        Me.ForceChart.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForceChart.ForeColor = System.Drawing.Color.White
        Me.ForceChart.Location = New System.Drawing.Point(0, 44)
        Me.ForceChart.Margin = New System.Windows.Forms.Padding(10)
        Me.ForceChart.MaxPoints = 100
        Me.ForceChart.Name = "ForceChart"
        Me.ForceChart.PLCAddressValue = ""
        Me.ForceChart.PLCAddressVisible = ""
        Me.ForceChart.Size = New System.Drawing.Size(489, 728)
        Me.ForceChart.TabIndex = 16
        Me.ForceChart.Text = "BasicTrendChart1"
        Me.ForceChart.Value = ""
        Me.ForceChart.YMaximum = 5000
        Me.ForceChart.YMinimum = 0
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
        Me.SetupButton.Location = New System.Drawing.Point(11, 582)
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
        'ConnectionCheckTimer
        '
        Me.ConnectionCheckTimer.Interval = 2000
        '
        'MotionControlThread
        '
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
        'StartButtonSubscriber
        '
        Me.StartButtonSubscriber.ComComponent = Me.ModbusTCPCom1
        Me.StartButtonSubscriber.PLCAddressValue = CType(resources.GetObject("StartButtonSubscriber.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.StartButtonSubscriber.Value = Nothing
        '
        'ConnectionCheckThread
        '
        '
        'ControlBlinker
        '
        '
        'CheckIfHoming
        '
        Me.CheckIfHoming.ComComponent = Me.ModbusTCPCom1
        Me.CheckIfHoming.PLCAddressValue = CType(resources.GetObject("CheckIfHoming.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.CheckIfHoming.Value = Nothing
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1254, 789)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.SetupButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flexure Control"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ModbusTCPCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        'CType(Me.DispGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.StartButtonSubscriber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckIfHoming, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents DisplacementChart As AdvancedHMIControls.BasicTrendChart
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ForceChart As AdvancedHMIControls.BasicTrendChart
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DRO_mm As AdvancedHMIControls.SevenSegment2
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DRO_N As AdvancedHMIControls.SevenSegment2
    Friend WithEvents ExperimentRecordingTimer As Timer
    Friend WithEvents SetupButton As Button
    Friend WithEvents StartButton As CheckBox
    Friend WithEvents ConnectionIndicator As Label
    Friend WithEvents ConnectionCheckTimer As Timer
    Friend WithEvents MotionControlThread As System.ComponentModel.BackgroundWorker
    Friend WithEvents StartButtonSubscriber As AdvancedHMIControls.DataSubscriber
    Friend WithEvents ConnectionCheckThread As System.ComponentModel.BackgroundWorker
    Friend WithEvents ControlBlinker As Timer
    Friend WithEvents CheckIfHoming As AdvancedHMIControls.DataSubscriber
End Class
