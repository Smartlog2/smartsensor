<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LabelTerminal = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Rf = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ButtonCodeTag = New System.Windows.Forms.Button()
        Me.ButtonClearAll = New System.Windows.Forms.Button()
        Me.ButtonR4 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabelReg24 = New System.Windows.Forms.Label()
        Me.ButClipboard = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabelReg20 = New System.Windows.Forms.Label()
        Me.LabelReg16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelEndoflifeinweeks = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelEndoflifeDateDecrypted = New System.Windows.Forms.Label()
        Me.LabelAlamDateDecrypted = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelReg12 = New System.Windows.Forms.Label()
        Me.LabelReg8 = New System.Windows.Forms.Label()
        Me.LabelTagID = New System.Windows.Forms.Label()
        Me.LabelReg4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LabelAESWeeks = New System.Windows.Forms.Label()
        Me.LabelEndoflifeDateFrame = New System.Windows.Forms.Label()
        Me.LabelAESEndoflifeDate = New System.Windows.Forms.Label()
        Me.LabelAlarmDateFrame = New System.Windows.Forms.Label()
        Me.LabelAESrfiID = New System.Windows.Forms.Label()
        Me.LabelAESAlarmDate = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDownWeeksB = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.NumericUpDownWeeks = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListBoxClients = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePickerEndofLife = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerAlarm = New System.Windows.Forms.DateTimePicker()
        Me.LabelEndofLife = New System.Windows.Forms.Label()
        Me.LabelAlarmDate = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CheckBoxRfID = New System.Windows.Forms.CheckBox()
        Me.ButtonWritealarm = New System.Windows.Forms.Button()
        Me.ButtonTimeSynchrone = New System.Windows.Forms.Button()
        Me.LabelEndoflifemodb = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelAlarmmodb = New System.Windows.Forms.Label()
        Me.ReadInputRegistersAlarm = New System.Windows.Forms.Button()
        Me.LabelRTC = New System.Windows.Forms.Label()
        Me.ReadInputRegistersRTC = New System.Windows.Forms.Button()
        Me.CheckBox_Dynamisch = New System.Windows.Forms.CheckBox()
        Me.NumericUpDownWeeksC = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LabelWeeksA = New System.Windows.Forms.Label()
        Me.LabelWeeksB = New System.Windows.Forms.Label()
        Me.LabelWeeksC = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.Rf.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericUpDownWeeksB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownWeeks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.NumericUpDownWeeksC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTerminal
        '
        Me.LabelTerminal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTerminal.Location = New System.Drawing.Point(3, 489)
        Me.LabelTerminal.Name = "LabelTerminal"
        Me.LabelTerminal.Size = New System.Drawing.Size(943, 25)
        Me.LabelTerminal.TabIndex = 6
        Me.LabelTerminal.Text = "Label1"
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM10"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 517)
        Me.ProgressBar1.MarqueeAnimationSpeed = 1
        Me.ProgressBar1.Maximum = 60
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(946, 18)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 34
        Me.ProgressBar1.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Rf)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1149, 474)
        Me.TabControl1.TabIndex = 63
        '
        'Rf
        '
        Me.Rf.Controls.Add(Me.GroupBox5)
        Me.Rf.Controls.Add(Me.ButtonCodeTag)
        Me.Rf.Controls.Add(Me.ButtonClearAll)
        Me.Rf.Controls.Add(Me.ButtonR4)
        Me.Rf.Controls.Add(Me.GroupBox3)
        Me.Rf.Controls.Add(Me.GroupBox4)
        Me.Rf.Controls.Add(Me.GroupBox2)
        Me.Rf.Location = New System.Drawing.Point(4, 22)
        Me.Rf.Name = "Rf"
        Me.Rf.Padding = New System.Windows.Forms.Padding(3)
        Me.Rf.Size = New System.Drawing.Size(1141, 448)
        Me.Rf.TabIndex = 0
        Me.Rf.Text = "rf ID TAGS"
        Me.Rf.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Controls.Add(Me.ListBox1)
        Me.GroupBox5.Location = New System.Drawing.Point(430, 345)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(103, 83)
        Me.GroupBox5.TabIndex = 53
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Serial Port"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(76, 20)
        Me.TextBox1.TabIndex = 54
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(82, 30)
        Me.ListBox1.TabIndex = 3
        '
        'ButtonCodeTag
        '
        Me.ButtonCodeTag.Location = New System.Drawing.Point(18, 383)
        Me.ButtonCodeTag.Name = "ButtonCodeTag"
        Me.ButtonCodeTag.Size = New System.Drawing.Size(380, 45)
        Me.ButtonCodeTag.TabIndex = 52
        Me.ButtonCodeTag.Text = "Coding and write Tag"
        Me.ButtonCodeTag.UseVisualStyleBackColor = True
        '
        'ButtonClearAll
        '
        Me.ButtonClearAll.Location = New System.Drawing.Point(235, 333)
        Me.ButtonClearAll.Name = "ButtonClearAll"
        Me.ButtonClearAll.Size = New System.Drawing.Size(163, 41)
        Me.ButtonClearAll.TabIndex = 51
        Me.ButtonClearAll.Text = "Clear Tag"
        Me.ButtonClearAll.UseVisualStyleBackColor = True
        '
        'ButtonR4
        '
        Me.ButtonR4.Location = New System.Drawing.Point(18, 333)
        Me.ButtonR4.Name = "ButtonR4"
        Me.ButtonR4.Size = New System.Drawing.Size(163, 41)
        Me.ButtonR4.TabIndex = 50
        Me.ButtonR4.Text = "Read Tag"
        Me.ButtonR4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.LabelReg24)
        Me.GroupBox3.Controls.Add(Me.ButClipboard)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.LabelReg20)
        Me.GroupBox3.Controls.Add(Me.LabelReg16)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.LabelReg12)
        Me.GroupBox3.Controls.Add(Me.LabelReg8)
        Me.GroupBox3.Controls.Add(Me.LabelTagID)
        Me.GroupBox3.Controls.Add(Me.LabelReg4)
        Me.GroupBox3.Location = New System.Drawing.Point(680, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(439, 311)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tag Registers"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(243, 237)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "R15"
        '
        'LabelReg24
        '
        Me.LabelReg24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelReg24.Location = New System.Drawing.Point(15, 237)
        Me.LabelReg24.Name = "LabelReg24"
        Me.LabelReg24.Size = New System.Drawing.Size(222, 22)
        Me.LabelReg24.TabIndex = 58
        Me.LabelReg24.Text = " "
        '
        'ButClipboard
        '
        Me.ButClipboard.Location = New System.Drawing.Point(171, 26)
        Me.ButClipboard.Name = "ButClipboard"
        Me.ButClipboard.Size = New System.Drawing.Size(99, 25)
        Me.ButClipboard.TabIndex = 57
        Me.ButClipboard.Text = "Copy to Clipboard"
        Me.ButClipboard.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(243, 205)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 13)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "R14"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(243, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "R10"
        '
        'LabelReg20
        '
        Me.LabelReg20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelReg20.Location = New System.Drawing.Point(15, 203)
        Me.LabelReg20.Name = "LabelReg20"
        Me.LabelReg20.Size = New System.Drawing.Size(222, 22)
        Me.LabelReg20.TabIndex = 54
        Me.LabelReg20.Text = " "
        '
        'LabelReg16
        '
        Me.LabelReg16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelReg16.Location = New System.Drawing.Point(15, 165)
        Me.LabelReg16.Name = "LabelReg16"
        Me.LabelReg16.Size = New System.Drawing.Size(222, 22)
        Me.LabelReg16.TabIndex = 53
        Me.LabelReg16.Text = " "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelWeeksC)
        Me.GroupBox1.Controls.Add(Me.LabelWeeksB)
        Me.GroupBox1.Controls.Add(Me.LabelWeeksA)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.LabelEndoflifeinweeks)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.LabelEndoflifeDateDecrypted)
        Me.GroupBox1.Controls.Add(Me.LabelAlamDateDecrypted)
        Me.GroupBox1.Location = New System.Drawing.Point(289, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 240)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AES decrypted"
        '
        'LabelEndoflifeinweeks
        '
        Me.LabelEndoflifeinweeks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelEndoflifeinweeks.Location = New System.Drawing.Point(7, 122)
        Me.LabelEndoflifeinweeks.Name = "LabelEndoflifeinweeks"
        Me.LabelEndoflifeinweeks.Size = New System.Drawing.Size(125, 22)
        Me.LabelEndoflifeinweeks.TabIndex = 52
        Me.LabelEndoflifeinweeks.Text = " "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "High Alarm Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Low Alarm Date"
        '
        'LabelEndoflifeDateDecrypted
        '
        Me.LabelEndoflifeDateDecrypted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelEndoflifeDateDecrypted.Location = New System.Drawing.Point(7, 72)
        Me.LabelEndoflifeDateDecrypted.Name = "LabelEndoflifeDateDecrypted"
        Me.LabelEndoflifeDateDecrypted.Size = New System.Drawing.Size(125, 22)
        Me.LabelEndoflifeDateDecrypted.TabIndex = 49
        Me.LabelEndoflifeDateDecrypted.Text = " "
        '
        'LabelAlamDateDecrypted
        '
        Me.LabelAlamDateDecrypted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelAlamDateDecrypted.Location = New System.Drawing.Point(6, 36)
        Me.LabelAlamDateDecrypted.Name = "LabelAlamDateDecrypted"
        Me.LabelAlamDateDecrypted.Size = New System.Drawing.Size(125, 22)
        Me.LabelAlamDateDecrypted.TabIndex = 48
        Me.LabelAlamDateDecrypted.Text = " "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(243, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "R0C"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(243, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "R08"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(243, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "R04"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Tag ID"
        '
        'LabelReg12
        '
        Me.LabelReg12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelReg12.Location = New System.Drawing.Point(15, 132)
        Me.LabelReg12.Name = "LabelReg12"
        Me.LabelReg12.Size = New System.Drawing.Size(222, 22)
        Me.LabelReg12.TabIndex = 43
        Me.LabelReg12.Text = " "
        '
        'LabelReg8
        '
        Me.LabelReg8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelReg8.Location = New System.Drawing.Point(15, 97)
        Me.LabelReg8.Name = "LabelReg8"
        Me.LabelReg8.Size = New System.Drawing.Size(222, 22)
        Me.LabelReg8.TabIndex = 42
        Me.LabelReg8.Text = " "
        '
        'LabelTagID
        '
        Me.LabelTagID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTagID.Location = New System.Drawing.Point(15, 26)
        Me.LabelTagID.Name = "LabelTagID"
        Me.LabelTagID.Size = New System.Drawing.Size(97, 22)
        Me.LabelTagID.TabIndex = 37
        Me.LabelTagID.Text = " "
        '
        'LabelReg4
        '
        Me.LabelReg4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelReg4.Location = New System.Drawing.Point(15, 59)
        Me.LabelReg4.Name = "LabelReg4"
        Me.LabelReg4.Size = New System.Drawing.Size(222, 22)
        Me.LabelReg4.TabIndex = 41
        Me.LabelReg4.Text = " "
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LabelAESWeeks)
        Me.GroupBox4.Controls.Add(Me.LabelEndoflifeDateFrame)
        Me.GroupBox4.Controls.Add(Me.LabelAESEndoflifeDate)
        Me.GroupBox4.Controls.Add(Me.LabelAlarmDateFrame)
        Me.GroupBox4.Controls.Add(Me.LabelAESrfiID)
        Me.GroupBox4.Controls.Add(Me.LabelAESAlarmDate)
        Me.GroupBox4.Location = New System.Drawing.Point(416, 18)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(258, 209)
        Me.GroupBox4.TabIndex = 48
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "AES encryption"
        '
        'LabelAESWeeks
        '
        Me.LabelAESWeeks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelAESWeeks.Location = New System.Drawing.Point(14, 166)
        Me.LabelAESWeeks.Name = "LabelAESWeeks"
        Me.LabelAESWeeks.Size = New System.Drawing.Size(228, 23)
        Me.LabelAESWeeks.TabIndex = 48
        Me.LabelAESWeeks.Text = " "
        '
        'LabelEndoflifeDateFrame
        '
        Me.LabelEndoflifeDateFrame.AutoSize = True
        Me.LabelEndoflifeDateFrame.Location = New System.Drawing.Point(142, 35)
        Me.LabelEndoflifeDateFrame.Name = "LabelEndoflifeDateFrame"
        Me.LabelEndoflifeDateFrame.Size = New System.Drawing.Size(91, 13)
        Me.LabelEndoflifeDateFrame.TabIndex = 47
        Me.LabelEndoflifeDateFrame.Text = "20101030000000"
        '
        'LabelAESEndoflifeDate
        '
        Me.LabelAESEndoflifeDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelAESEndoflifeDate.Location = New System.Drawing.Point(14, 131)
        Me.LabelAESEndoflifeDate.Name = "LabelAESEndoflifeDate"
        Me.LabelAESEndoflifeDate.Size = New System.Drawing.Size(228, 23)
        Me.LabelAESEndoflifeDate.TabIndex = 45
        Me.LabelAESEndoflifeDate.Text = " "
        '
        'LabelAlarmDateFrame
        '
        Me.LabelAlarmDateFrame.AutoSize = True
        Me.LabelAlarmDateFrame.Location = New System.Drawing.Point(11, 35)
        Me.LabelAlarmDateFrame.Name = "LabelAlarmDateFrame"
        Me.LabelAlarmDateFrame.Size = New System.Drawing.Size(39, 13)
        Me.LabelAlarmDateFrame.TabIndex = 42
        Me.LabelAlarmDateFrame.Text = "Label3"
        '
        'LabelAESrfiID
        '
        Me.LabelAESrfiID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelAESrfiID.Location = New System.Drawing.Point(14, 58)
        Me.LabelAESrfiID.Name = "LabelAESrfiID"
        Me.LabelAESrfiID.Size = New System.Drawing.Size(228, 23)
        Me.LabelAESrfiID.TabIndex = 36
        Me.LabelAESrfiID.Text = " "
        '
        'LabelAESAlarmDate
        '
        Me.LabelAESAlarmDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelAESAlarmDate.Location = New System.Drawing.Point(14, 97)
        Me.LabelAESAlarmDate.Name = "LabelAESAlarmDate"
        Me.LabelAESAlarmDate.Size = New System.Drawing.Size(228, 23)
        Me.LabelAESAlarmDate.TabIndex = 43
        Me.LabelAESAlarmDate.Text = " "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NumericUpDownWeeksC)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.CheckBox_Dynamisch)
        Me.GroupBox2.Controls.Add(Me.NumericUpDownWeeksB)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.NumericUpDownWeeks)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.ListBoxClients)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.DateTimePickerEndofLife)
        Me.GroupBox2.Controls.Add(Me.DateTimePickerAlarm)
        Me.GroupBox2.Controls.Add(Me.LabelEndofLife)
        Me.GroupBox2.Controls.Add(Me.LabelAlarmDate)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 294)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TAG Life Time"
        '
        'NumericUpDownWeeksB
        '
        Me.NumericUpDownWeeksB.Enabled = False
        Me.NumericUpDownWeeksB.Location = New System.Drawing.Point(234, 208)
        Me.NumericUpDownWeeksB.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.NumericUpDownWeeksB.Name = "NumericUpDownWeeksB"
        Me.NumericUpDownWeeksB.Size = New System.Drawing.Size(132, 20)
        Me.NumericUpDownWeeksB.TabIndex = 48
        Me.NumericUpDownWeeksB.Value = New Decimal(New Integer() {52, 0, 0, 0})
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 212)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 13)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "Life period in weeks B"
        '
        'NumericUpDownWeeks
        '
        Me.NumericUpDownWeeks.Enabled = False
        Me.NumericUpDownWeeks.Location = New System.Drawing.Point(234, 180)
        Me.NumericUpDownWeeks.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.NumericUpDownWeeks.Name = "NumericUpDownWeeks"
        Me.NumericUpDownWeeks.Size = New System.Drawing.Size(132, 20)
        Me.NumericUpDownWeeks.TabIndex = 46
        Me.NumericUpDownWeeks.Value = New Decimal(New Integer() {104, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Life period in weeks A"
        '
        'ListBoxClients
        '
        Me.ListBoxClients.Enabled = False
        Me.ListBoxClients.FormattingEnabled = True
        Me.ListBoxClients.Location = New System.Drawing.Point(234, 31)
        Me.ListBoxClients.Name = "ListBoxClients"
        Me.ListBoxClients.Size = New System.Drawing.Size(133, 82)
        Me.ListBoxClients.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "High Alarm Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Low Alarm Date"
        '
        'DateTimePickerEndofLife
        '
        Me.DateTimePickerEndofLife.Enabled = False
        Me.DateTimePickerEndofLife.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerEndofLife.Location = New System.Drawing.Point(141, 57)
        Me.DateTimePickerEndofLife.Name = "DateTimePickerEndofLife"
        Me.DateTimePickerEndofLife.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePickerEndofLife.TabIndex = 41
        '
        'DateTimePickerAlarm
        '
        Me.DateTimePickerAlarm.Enabled = False
        Me.DateTimePickerAlarm.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerAlarm.Location = New System.Drawing.Point(141, 31)
        Me.DateTimePickerAlarm.Name = "DateTimePickerAlarm"
        Me.DateTimePickerAlarm.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePickerAlarm.TabIndex = 40
        '
        'LabelEndofLife
        '
        Me.LabelEndofLife.AutoSize = True
        Me.LabelEndofLife.Location = New System.Drawing.Point(20, 133)
        Me.LabelEndofLife.Name = "LabelEndofLife"
        Me.LabelEndofLife.Size = New System.Drawing.Size(84, 13)
        Me.LabelEndofLife.TabIndex = 30
        Me.LabelEndofLife.Text = "High Alarm Date"
        '
        'LabelAlarmDate
        '
        Me.LabelAlarmDate.AutoSize = True
        Me.LabelAlarmDate.Location = New System.Drawing.Point(22, 97)
        Me.LabelAlarmDate.Name = "LabelAlarmDate"
        Me.LabelAlarmDate.Size = New System.Drawing.Size(82, 13)
        Me.LabelAlarmDate.TabIndex = 29
        Me.LabelAlarmDate.Text = "Low Alarm Date"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CheckBoxRfID)
        Me.TabPage2.Controls.Add(Me.ButtonWritealarm)
        Me.TabPage2.Controls.Add(Me.ButtonTimeSynchrone)
        Me.TabPage2.Controls.Add(Me.LabelEndoflifemodb)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.LabelAlarmmodb)
        Me.TabPage2.Controls.Add(Me.ReadInputRegistersAlarm)
        Me.TabPage2.Controls.Add(Me.LabelRTC)
        Me.TabPage2.Controls.Add(Me.ReadInputRegistersRTC)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1141, 448)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "rf ID CONTROLER"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CheckBoxRfID
        '
        Me.CheckBoxRfID.AutoSize = True
        Me.CheckBoxRfID.Location = New System.Drawing.Point(689, 66)
        Me.CheckBoxRfID.Name = "CheckBoxRfID"
        Me.CheckBoxRfID.Size = New System.Drawing.Size(79, 17)
        Me.CheckBoxRfID.TabIndex = 71
        Me.CheckBoxRfID.Text = "rfID Enable"
        Me.CheckBoxRfID.UseVisualStyleBackColor = True
        '
        'ButtonWritealarm
        '
        Me.ButtonWritealarm.Location = New System.Drawing.Point(247, 148)
        Me.ButtonWritealarm.Name = "ButtonWritealarm"
        Me.ButtonWritealarm.Size = New System.Drawing.Size(409, 29)
        Me.ButtonWritealarm.TabIndex = 70
        Me.ButtonWritealarm.Text = "Write Modbus Registers"
        Me.ButtonWritealarm.UseVisualStyleBackColor = True
        '
        'ButtonTimeSynchrone
        '
        Me.ButtonTimeSynchrone.Location = New System.Drawing.Point(247, 32)
        Me.ButtonTimeSynchrone.Name = "ButtonTimeSynchrone"
        Me.ButtonTimeSynchrone.Size = New System.Drawing.Size(175, 23)
        Me.ButtonTimeSynchrone.TabIndex = 69
        Me.ButtonTimeSynchrone.Text = "time synchronization"
        Me.ButtonTimeSynchrone.UseVisualStyleBackColor = True
        '
        'LabelEndoflifemodb
        '
        Me.LabelEndoflifemodb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelEndoflifemodb.Location = New System.Drawing.Point(434, 123)
        Me.LabelEndoflifemodb.Name = "LabelEndoflifemodb"
        Me.LabelEndoflifemodb.Size = New System.Drawing.Size(222, 22)
        Me.LabelEndoflifemodb.TabIndex = 68
        Me.LabelEndoflifemodb.Text = " "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(247, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 23)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "Read Input Registers End of live"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelAlarmmodb
        '
        Me.LabelAlarmmodb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelAlarmmodb.Location = New System.Drawing.Point(434, 90)
        Me.LabelAlarmmodb.Name = "LabelAlarmmodb"
        Me.LabelAlarmmodb.Size = New System.Drawing.Size(222, 22)
        Me.LabelAlarmmodb.TabIndex = 66
        Me.LabelAlarmmodb.Text = " "
        '
        'ReadInputRegistersAlarm
        '
        Me.ReadInputRegistersAlarm.Location = New System.Drawing.Point(247, 90)
        Me.ReadInputRegistersAlarm.Name = "ReadInputRegistersAlarm"
        Me.ReadInputRegistersAlarm.Size = New System.Drawing.Size(179, 23)
        Me.ReadInputRegistersAlarm.TabIndex = 65
        Me.ReadInputRegistersAlarm.Text = "Read Input Registers Alarm"
        Me.ReadInputRegistersAlarm.UseVisualStyleBackColor = True
        '
        'LabelRTC
        '
        Me.LabelRTC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelRTC.Location = New System.Drawing.Point(434, 62)
        Me.LabelRTC.Name = "LabelRTC"
        Me.LabelRTC.Size = New System.Drawing.Size(222, 22)
        Me.LabelRTC.TabIndex = 64
        Me.LabelRTC.Text = " "
        '
        'ReadInputRegistersRTC
        '
        Me.ReadInputRegistersRTC.Location = New System.Drawing.Point(247, 61)
        Me.ReadInputRegistersRTC.Name = "ReadInputRegistersRTC"
        Me.ReadInputRegistersRTC.Size = New System.Drawing.Size(179, 23)
        Me.ReadInputRegistersRTC.TabIndex = 63
        Me.ReadInputRegistersRTC.Text = "Read Input Registers RTC"
        Me.ReadInputRegistersRTC.UseVisualStyleBackColor = True
        '
        'CheckBox_Dynamisch
        '
        Me.CheckBox_Dynamisch.AutoSize = True
        Me.CheckBox_Dynamisch.Checked = True
        Me.CheckBox_Dynamisch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Dynamisch.Location = New System.Drawing.Point(25, 162)
        Me.CheckBox_Dynamisch.Name = "CheckBox_Dynamisch"
        Me.CheckBox_Dynamisch.Size = New System.Drawing.Size(69, 17)
        Me.CheckBox_Dynamisch.TabIndex = 49
        Me.CheckBox_Dynamisch.Text = "In weeks"
        Me.CheckBox_Dynamisch.UseVisualStyleBackColor = True
        '
        'NumericUpDownWeeksC
        '
        Me.NumericUpDownWeeksC.Location = New System.Drawing.Point(234, 234)
        Me.NumericUpDownWeeksC.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.NumericUpDownWeeksC.Name = "NumericUpDownWeeksC"
        Me.NumericUpDownWeeksC.Size = New System.Drawing.Size(132, 20)
        Me.NumericUpDownWeeksC.TabIndex = 51
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 238)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 13)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Life period in weeks C"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 106)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 13)
        Me.Label16.TabIndex = 54
        Me.Label16.Text = "End of life in weeks "
        '
        'LabelWeeksA
        '
        Me.LabelWeeksA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelWeeksA.Location = New System.Drawing.Point(68, 148)
        Me.LabelWeeksA.Name = "LabelWeeksA"
        Me.LabelWeeksA.Size = New System.Drawing.Size(63, 22)
        Me.LabelWeeksA.TabIndex = 55
        Me.LabelWeeksA.Text = " "
        '
        'LabelWeeksB
        '
        Me.LabelWeeksB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelWeeksB.Location = New System.Drawing.Point(68, 177)
        Me.LabelWeeksB.Name = "LabelWeeksB"
        Me.LabelWeeksB.Size = New System.Drawing.Size(63, 22)
        Me.LabelWeeksB.TabIndex = 56
        Me.LabelWeeksB.Text = " "
        '
        'LabelWeeksC
        '
        Me.LabelWeeksC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelWeeksC.Location = New System.Drawing.Point(68, 203)
        Me.LabelWeeksC.Name = "LabelWeeksC"
        Me.LabelWeeksC.Size = New System.Drawing.Size(63, 22)
        Me.LabelWeeksC.TabIndex = 57
        Me.LabelWeeksC.Text = " "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 538)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LabelTerminal)
        Me.Name = "Form1"
        Me.Text = "rf ID "
        Me.TabControl1.ResumeLayout(False)
        Me.Rf.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumericUpDownWeeksB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownWeeks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.NumericUpDownWeeksC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelTerminal As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Rf As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents CheckBoxRfID As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonWritealarm As System.Windows.Forms.Button
    Friend WithEvents ButtonTimeSynchrone As System.Windows.Forms.Button
    Friend WithEvents LabelEndoflifemodb As System.Windows.Forms.Label
    Private WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LabelAlarmmodb As System.Windows.Forms.Label
    Private WithEvents ReadInputRegistersAlarm As System.Windows.Forms.Button
    Friend WithEvents LabelRTC As System.Windows.Forms.Label
    Private WithEvents ReadInputRegistersRTC As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ButtonCodeTag As System.Windows.Forms.Button
    Friend WithEvents ButtonClearAll As System.Windows.Forms.Button
    Friend WithEvents ButtonR4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LabelReg20 As System.Windows.Forms.Label
    Friend WithEvents LabelReg16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LabelEndoflifeDateDecrypted As System.Windows.Forms.Label
    Friend WithEvents LabelAlamDateDecrypted As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelReg12 As System.Windows.Forms.Label
    Friend WithEvents LabelReg8 As System.Windows.Forms.Label
    Friend WithEvents LabelTagID As System.Windows.Forms.Label
    Friend WithEvents LabelReg4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelEndoflifeDateFrame As System.Windows.Forms.Label
    Friend WithEvents LabelAESEndoflifeDate As System.Windows.Forms.Label
    Friend WithEvents LabelAlarmDateFrame As System.Windows.Forms.Label
    Friend WithEvents LabelAESrfiID As System.Windows.Forms.Label
    Friend WithEvents LabelAESAlarmDate As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerEndofLife As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerAlarm As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelEndofLife As System.Windows.Forms.Label
    Friend WithEvents LabelAlarmDate As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ButClipboard As System.Windows.Forms.Button
    Friend WithEvents ListBoxClients As System.Windows.Forms.ListBox
    Friend WithEvents LabelAESWeeks As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownWeeks As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LabelReg24 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LabelEndoflifeinweeks As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownWeeksB As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CheckBox_Dynamisch As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDownWeeksC As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LabelWeeksC As System.Windows.Forms.Label
    Friend WithEvents LabelWeeksB As System.Windows.Forms.Label
    Friend WithEvents LabelWeeksA As System.Windows.Forms.Label

End Class
