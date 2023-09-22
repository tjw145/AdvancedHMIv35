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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DispControlPanel = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MotionStepsInput = New System.Windows.Forms.DataGridView()
        Me.target = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dwell = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GenerateStepsButton = New System.Windows.Forms.Button()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.DispControlPanel.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.MotionStepsInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DispControlPanel.Size = New System.Drawing.Size(466, 438)
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
        Me.TabPage2.Size = New System.Drawing.Size(458, 412)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Displacement Control"
        '
        'MotionStepsInput
        '
        Me.MotionStepsInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MotionStepsInput.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.MotionStepsInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MotionStepsInput.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MotionStepsInput.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MotionStepsInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MotionStepsInput.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.target, Me.time, Me.dwell, Me.delete})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 8.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MotionStepsInput.DefaultCellStyle = DataGridViewCellStyle6
        Me.MotionStepsInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MotionStepsInput.EnableHeadersVisualStyles = False
        Me.MotionStepsInput.GridColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.MotionStepsInput.Location = New System.Drawing.Point(3, 3)
        Me.MotionStepsInput.Name = "MotionStepsInput"
        Me.MotionStepsInput.Size = New System.Drawing.Size(452, 406)
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.delete.DefaultCellStyle = DataGridViewCellStyle5
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
        Me.TabPage3.Size = New System.Drawing.Size(458, 412)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Force Control"
        '
        'GenerateStepsButton
        '
        Me.GenerateStepsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.GenerateStepsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.GenerateStepsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GenerateStepsButton.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.GenerateStepsButton.ForeColor = System.Drawing.Color.White
        Me.GenerateStepsButton.Location = New System.Drawing.Point(190, 456)
        Me.GenerateStepsButton.Name = "GenerateStepsButton"
        Me.GenerateStepsButton.Size = New System.Drawing.Size(90, 28)
        Me.GenerateStepsButton.TabIndex = 87
        Me.GenerateStepsButton.Text = "Generate"
        Me.GenerateStepsButton.UseVisualStyleBackColor = False
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
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(828, 502)
        Me.Controls.Add(Me.GenerateStepsButton)
        Me.Controls.Add(Me.DispControlPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.DispControlPanel.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.MotionStepsInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DispControlPanel As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MotionStepsInput As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GenerateStepsButton As Button
    Friend WithEvents target As DataGridViewTextBoxColumn
    Friend WithEvents time As DataGridViewTextBoxColumn
    Friend WithEvents dwell As DataGridViewTextBoxColumn
    Friend WithEvents delete As DataGridViewButtonColumn
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
End Class
