<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtSnmpPassword = New System.Windows.Forms.TextBox()
        Me.txtSnmpTimeout = New System.Windows.Forms.TextBox()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.txtIPAddress = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblMagentaTonerPercent = New System.Windows.Forms.Label()
        Me.lblYellowTonerPercent = New System.Windows.Forms.Label()
        Me.lblCyanTonerPercent = New System.Windows.Forms.Label()
        Me.lblBlackTonerPercent = New System.Windows.Forms.Label()
        Me.chkIsColor = New System.Windows.Forms.CheckBox()
        Me.pbMagentaToner = New System.Windows.Forms.ProgressBar()
        Me.pbYellowToner = New System.Windows.Forms.ProgressBar()
        Me.pbCyanToner = New System.Windows.Forms.ProgressBar()
        Me.pbBlackToner = New System.Windows.Forms.ProgressBar()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtMagentaTonerPart = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtYellowTonerPart = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCyanTonerPart = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBlackTonerPart = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtColorCount = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMonoCount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalPageCount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSerialNumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtManufacture = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSnmpPassword
        '
        Me.txtSnmpPassword.Location = New System.Drawing.Point(162, 47)
        Me.txtSnmpPassword.Name = "txtSnmpPassword"
        Me.txtSnmpPassword.Size = New System.Drawing.Size(109, 21)
        Me.txtSnmpPassword.TabIndex = 1
        Me.txtSnmpPassword.Text = "public"
        '
        'txtSnmpTimeout
        '
        Me.txtSnmpTimeout.Location = New System.Drawing.Point(204, 74)
        Me.txtSnmpTimeout.Name = "txtSnmpTimeout"
        Me.txtSnmpTimeout.Size = New System.Drawing.Size(67, 21)
        Me.txtSnmpTimeout.TabIndex = 2
        Me.txtSnmpTimeout.Text = "2000"
        '
        'btnScan
        '
        Me.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScan.Image = Global.Verifier.My.Resources.Resources.search_printer
        Me.btnScan.Location = New System.Drawing.Point(12, 139)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(274, 86)
        Me.btnScan.TabIndex = 4
        Me.btnScan.Text = "Scan"
        Me.btnScan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnScan.UseVisualStyleBackColor = True
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Location = New System.Drawing.Point(162, 20)
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.Size = New System.Drawing.Size(109, 21)
        Me.txtIPAddress.TabIndex = 5
        Me.txtIPAddress.Text = "192.168.1.1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(298, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIPAddress)
        Me.GroupBox1.Controls.Add(Me.txtSnmpPassword)
        Me.GroupBox1.Controls.Add(Me.txtSnmpTimeout)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 106)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Device Information"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Timeout (ms)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Community Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Device IP Address"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblMagentaTonerPercent)
        Me.GroupBox2.Controls.Add(Me.lblYellowTonerPercent)
        Me.GroupBox2.Controls.Add(Me.lblCyanTonerPercent)
        Me.GroupBox2.Controls.Add(Me.lblBlackTonerPercent)
        Me.GroupBox2.Controls.Add(Me.chkIsColor)
        Me.GroupBox2.Controls.Add(Me.pbMagentaToner)
        Me.GroupBox2.Controls.Add(Me.pbYellowToner)
        Me.GroupBox2.Controls.Add(Me.pbCyanToner)
        Me.GroupBox2.Controls.Add(Me.pbBlackToner)
        Me.GroupBox2.Controls.Add(Me.txtDisplay)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtMagentaTonerPart)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtYellowTonerPart)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtCyanTonerPart)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtBlackTonerPart)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtColorCount)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtMonoCount)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtTotalPageCount)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtSerialNumber)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtModel)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtManufacture)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 231)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(276, 457)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Scanned Information"
        '
        'lblMagentaTonerPercent
        '
        Me.lblMagentaTonerPercent.AutoSize = True
        Me.lblMagentaTonerPercent.Location = New System.Drawing.Point(129, 374)
        Me.lblMagentaTonerPercent.Name = "lblMagentaTonerPercent"
        Me.lblMagentaTonerPercent.Size = New System.Drawing.Size(39, 15)
        Me.lblMagentaTonerPercent.TabIndex = 47
        Me.lblMagentaTonerPercent.Text = "100%"
        Me.lblMagentaTonerPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYellowTonerPercent
        '
        Me.lblYellowTonerPercent.AutoSize = True
        Me.lblYellowTonerPercent.Location = New System.Drawing.Point(129, 320)
        Me.lblYellowTonerPercent.Name = "lblYellowTonerPercent"
        Me.lblYellowTonerPercent.Size = New System.Drawing.Size(39, 15)
        Me.lblYellowTonerPercent.TabIndex = 46
        Me.lblYellowTonerPercent.Text = "100%"
        Me.lblYellowTonerPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCyanTonerPercent
        '
        Me.lblCyanTonerPercent.AutoSize = True
        Me.lblCyanTonerPercent.Location = New System.Drawing.Point(129, 266)
        Me.lblCyanTonerPercent.Name = "lblCyanTonerPercent"
        Me.lblCyanTonerPercent.Size = New System.Drawing.Size(39, 15)
        Me.lblCyanTonerPercent.TabIndex = 45
        Me.lblCyanTonerPercent.Text = "100%"
        Me.lblCyanTonerPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBlackTonerPercent
        '
        Me.lblBlackTonerPercent.AutoSize = True
        Me.lblBlackTonerPercent.Location = New System.Drawing.Point(129, 212)
        Me.lblBlackTonerPercent.Name = "lblBlackTonerPercent"
        Me.lblBlackTonerPercent.Size = New System.Drawing.Size(39, 15)
        Me.lblBlackTonerPercent.TabIndex = 44
        Me.lblBlackTonerPercent.Text = "100%"
        Me.lblBlackTonerPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkIsColor
        '
        Me.chkIsColor.AutoSize = True
        Me.chkIsColor.Enabled = False
        Me.chkIsColor.Location = New System.Drawing.Point(132, 105)
        Me.chkIsColor.Name = "chkIsColor"
        Me.chkIsColor.Size = New System.Drawing.Size(15, 14)
        Me.chkIsColor.TabIndex = 43
        Me.chkIsColor.UseVisualStyleBackColor = True
        '
        'pbMagentaToner
        '
        Me.pbMagentaToner.BackColor = System.Drawing.SystemColors.Control
        Me.pbMagentaToner.ForeColor = System.Drawing.Color.Magenta
        Me.pbMagentaToner.Location = New System.Drawing.Point(174, 369)
        Me.pbMagentaToner.MarqueeAnimationSpeed = 0
        Me.pbMagentaToner.Name = "pbMagentaToner"
        Me.pbMagentaToner.Size = New System.Drawing.Size(96, 23)
        Me.pbMagentaToner.Step = 1
        Me.pbMagentaToner.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbMagentaToner.TabIndex = 42
        '
        'pbYellowToner
        '
        Me.pbYellowToner.BackColor = System.Drawing.SystemColors.Control
        Me.pbYellowToner.ForeColor = System.Drawing.Color.Yellow
        Me.pbYellowToner.Location = New System.Drawing.Point(174, 315)
        Me.pbYellowToner.MarqueeAnimationSpeed = 0
        Me.pbYellowToner.Name = "pbYellowToner"
        Me.pbYellowToner.Size = New System.Drawing.Size(96, 23)
        Me.pbYellowToner.Step = 1
        Me.pbYellowToner.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbYellowToner.TabIndex = 41
        '
        'pbCyanToner
        '
        Me.pbCyanToner.BackColor = System.Drawing.SystemColors.Control
        Me.pbCyanToner.ForeColor = System.Drawing.Color.Cyan
        Me.pbCyanToner.Location = New System.Drawing.Point(174, 263)
        Me.pbCyanToner.MarqueeAnimationSpeed = 0
        Me.pbCyanToner.Name = "pbCyanToner"
        Me.pbCyanToner.Size = New System.Drawing.Size(96, 23)
        Me.pbCyanToner.Step = 1
        Me.pbCyanToner.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbCyanToner.TabIndex = 40
        '
        'pbBlackToner
        '
        Me.pbBlackToner.BackColor = System.Drawing.SystemColors.Control
        Me.pbBlackToner.ForeColor = System.Drawing.Color.Black
        Me.pbBlackToner.Location = New System.Drawing.Point(174, 207)
        Me.pbBlackToner.MarqueeAnimationSpeed = 0
        Me.pbBlackToner.Name = "pbBlackToner"
        Me.pbBlackToner.Size = New System.Drawing.Size(96, 23)
        Me.pbBlackToner.Step = 1
        Me.pbBlackToner.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbBlackToner.TabIndex = 39
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(132, 425)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(138, 21)
        Me.txtDisplay.TabIndex = 38
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(5, 428)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 15)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "Display"
        '
        'txtMagentaTonerPart
        '
        Me.txtMagentaTonerPart.Location = New System.Drawing.Point(132, 398)
        Me.txtMagentaTonerPart.Name = "txtMagentaTonerPart"
        Me.txtMagentaTonerPart.Size = New System.Drawing.Size(138, 21)
        Me.txtMagentaTonerPart.TabIndex = 36
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(5, 401)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(116, 15)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Magenta Toner Part"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(5, 374)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(105, 15)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "Magenta Toner %"
        '
        'txtYellowTonerPart
        '
        Me.txtYellowTonerPart.Location = New System.Drawing.Point(132, 344)
        Me.txtYellowTonerPart.Name = "txtYellowTonerPart"
        Me.txtYellowTonerPart.Size = New System.Drawing.Size(138, 21)
        Me.txtYellowTonerPart.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(5, 347)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 15)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Yellow Toner Part"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(5, 320)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 15)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Yellow Toner %"
        '
        'txtCyanTonerPart
        '
        Me.txtCyanTonerPart.Location = New System.Drawing.Point(132, 290)
        Me.txtCyanTonerPart.Name = "txtCyanTonerPart"
        Me.txtCyanTonerPart.Size = New System.Drawing.Size(138, 21)
        Me.txtCyanTonerPart.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 293)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 15)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Cyan Toner Part"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 266)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 15)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Cyan Toner %"
        '
        'txtBlackTonerPart
        '
        Me.txtBlackTonerPart.Location = New System.Drawing.Point(132, 236)
        Me.txtBlackTonerPart.Name = "txtBlackTonerPart"
        Me.txtBlackTonerPart.Size = New System.Drawing.Size(138, 21)
        Me.txtBlackTonerPart.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 239)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 15)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Black Toner Part"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 15)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Black Toner %"
        '
        'txtColorCount
        '
        Me.txtColorCount.Location = New System.Drawing.Point(132, 182)
        Me.txtColorCount.Name = "txtColorCount"
        Me.txtColorCount.Size = New System.Drawing.Size(138, 21)
        Me.txtColorCount.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 185)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 15)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Color Page Count"
        '
        'txtMonoCount
        '
        Me.txtMonoCount.Location = New System.Drawing.Point(132, 155)
        Me.txtMonoCount.Name = "txtMonoCount"
        Me.txtMonoCount.Size = New System.Drawing.Size(138, 21)
        Me.txtMonoCount.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Mono Page Count"
        '
        'txtTotalPageCount
        '
        Me.txtTotalPageCount.Location = New System.Drawing.Point(132, 128)
        Me.txtTotalPageCount.Name = "txtTotalPageCount"
        Me.txtTotalPageCount.Size = New System.Drawing.Size(138, 21)
        Me.txtTotalPageCount.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Total Page Count"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Is Color Device"
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.Location = New System.Drawing.Point(132, 74)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.Size = New System.Drawing.Size(138, 21)
        Me.txtSerialNumber.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Serial Number"
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(132, 47)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(138, 21)
        Me.txtModel.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Model"
        '
        'txtManufacture
        '
        Me.txtManufacture.Location = New System.Drawing.Point(132, 20)
        Me.txtManufacture.Name = "txtManufacture"
        Me.txtManufacture.Size = New System.Drawing.Size(138, 21)
        Me.txtManufacture.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Manufacture"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 695)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(298, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsLabel
        '
        Me.tsLabel.Name = "tsLabel"
        Me.tsLabel.Size = New System.Drawing.Size(252, 17)
        Me.tsLabel.Spring = True
        Me.tsLabel.Text = "Application Ready"
        Me.tsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnScan
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 717)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Device Verifier"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSnmpPassword As TextBox
    Friend WithEvents txtSnmpTimeout As TextBox
    Friend WithEvents btnScan As Button
    Friend WithEvents txtIPAddress As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtManufacture As TextBox
    Friend WithEvents txtSerialNumber As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCyanTonerPart As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtBlackTonerPart As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtColorCount As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMonoCount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTotalPageCount As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMagentaTonerPart As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtYellowTonerPart As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents chkIsColor As CheckBox
    Friend WithEvents pbMagentaToner As ProgressBar
    Friend WithEvents pbYellowToner As ProgressBar
    Friend WithEvents pbCyanToner As ProgressBar
    Friend WithEvents pbBlackToner As ProgressBar
    Friend WithEvents lblMagentaTonerPercent As Label
    Friend WithEvents lblYellowTonerPercent As Label
    Friend WithEvents lblCyanTonerPercent As Label
    Friend WithEvents lblBlackTonerPercent As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsLabel As ToolStripStatusLabel
End Class
