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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.LabelTerminal = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ButtonCodeTag = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ButtonR4 = New System.Windows.Forms.Button()
        Me.LabelAESrfiID = New System.Windows.Forms.Label()
        Me.LabelTagID = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePickerEndofLife = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerAlarm = New System.Windows.Forms.DateTimePicker()
        Me.LabelEndofLife = New System.Windows.Forms.Label()
        Me.LabelAlarmDate = New System.Windows.Forms.Label()
        Me.LabelEndoflifeDateFrame = New System.Windows.Forms.Label()
        Me.LabelAESEndoflifeDate = New System.Windows.Forms.Label()
        Me.LabelAESAlarmDate = New System.Windows.Forms.Label()
        Me.LabelAlarmDateFrame = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelReg4 = New System.Windows.Forms.Label()
        Me.LabelReg8 = New System.Windows.Forms.Label()
        Me.LabelReg12 = New System.Windows.Forms.Label()
        Me.ButtonClearAll = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabelReg20 = New System.Windows.Forms.Label()
        Me.LabelReg16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelEndoflifeDateDecrypted = New System.Windows.Forms.Label()
        Me.LabelAlamDateDecrypted = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ReadInputRegistersRTC = New System.Windows.Forms.Button()
        Me.LabelRTC = New System.Windows.Forms.Label()
        Me.LabelAlarmmodb = New System.Windows.Forms.Label()
        Me.ReadInputRegistersAlarm = New System.Windows.Forms.Button()
        Me.LabelEndoflifemodb = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonTimeSynchrone = New System.Windows.Forms.Button()
        Me.ButtonWritealarm = New System.Windows.Forms.Button()
        Me.CheckBoxRfID = New System.Windows.Forms.CheckBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(82, 17)
        Me.ListBox1.TabIndex = 3
        '
        'LabelTerminal
        '
        Me.LabelTerminal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTerminal.Location = New System.Drawing.Point(3, 538)
        Me.LabelTerminal.Name = "LabelTerminal"
        Me.LabelTerminal.Size = New System.Drawing.Size(943, 25)
        Me.LabelTerminal.TabIndex = 6
        Me.LabelTerminal.Text = "Label1"
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM9"
        '
        'ButtonCodeTag
        '
        Me.ButtonCodeTag.Location = New System.Drawing.Point(12, 254)
        Me.ButtonCodeTag.Name = "ButtonCodeTag"
        Me.ButtonCodeTag.Size = New System.Drawing.Size(380, 45)
        Me.ButtonCodeTag.TabIndex = 12
        Me.ButtonCodeTag.Text = "Coding and write Tag"
        Me.ButtonCodeTag.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 566)
        Me.ProgressBar1.MarqueeAnimationSpeed = 1
        Me.ProgressBar1.Maximum = 60
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(946, 18)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 34
        Me.ProgressBar1.Visible = False
        '
        'ButtonR4
        '
        Me.ButtonR4.Location = New System.Drawing.Point(12, 202)
        Me.ButtonR4.Name = "ButtonR4"
        Me.ButtonR4.Size = New System.Drawing.Size(163, 41)
        Me.ButtonR4.TabIndex = 35
        Me.ButtonR4.Text = "Read Tag"
        Me.ButtonR4.UseVisualStyleBackColor = True
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
        'LabelTagID
        '
        Me.LabelTagID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTagID.Location = New System.Drawing.Point(15, 26)
        Me.LabelTagID.Name = "LabelTagID"
        Me.LabelTagID.Size = New System.Drawing.Size(97, 22)
        Me.LabelTagID.TabIndex = 37
        Me.LabelTagID.Text = " "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.DateTimePickerEndofLife)
        Me.GroupBox2.Controls.Add(Me.DateTimePickerAlarm)
        Me.GroupBox2.Controls.Add(Me.LabelEndofLife)
        Me.GroupBox2.Controls.Add(Me.LabelAlarmDate)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(220, 171)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TAG Life Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "End of Life"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Alarm Date"
        '
        'DateTimePickerEndofLife
        '
        Me.DateTimePickerEndofLife.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerEndofLife.Location = New System.Drawing.Point(114, 61)
        Me.DateTimePickerEndofLife.Name = "DateTimePickerEndofLife"
        Me.DateTimePickerEndofLife.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePickerEndofLife.TabIndex = 41
        '
        'DateTimePickerAlarm
        '
        Me.DateTimePickerAlarm.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerAlarm.Location = New System.Drawing.Point(114, 29)
        Me.DateTimePickerAlarm.Name = "DateTimePickerAlarm"
        Me.DateTimePickerAlarm.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePickerAlarm.TabIndex = 40
        '
        'LabelEndofLife
        '
        Me.LabelEndofLife.AutoSize = True
        Me.LabelEndofLife.Location = New System.Drawing.Point(20, 133)
        Me.LabelEndofLife.Name = "LabelEndofLife"
        Me.LabelEndofLife.Size = New System.Drawing.Size(58, 13)
        Me.LabelEndofLife.TabIndex = 30
        Me.LabelEndofLife.Text = "End of Life"
        '
        'LabelAlarmDate
        '
        Me.LabelAlarmDate.AutoSize = True
        Me.LabelAlarmDate.Location = New System.Drawing.Point(20, 100)
        Me.LabelAlarmDate.Name = "LabelAlarmDate"
        Me.LabelAlarmDate.Size = New System.Drawing.Size(59, 13)
        Me.LabelAlarmDate.TabIndex = 29
        Me.LabelAlarmDate.Text = "Alarm Date"
        '
        'LabelEndoflifeDateFrame
        '
        Me.LabelEndoflifeDateFrame.AutoSize = True
        Me.LabelEndoflifeDateFrame.Location = New System.Drawing.Point(142, 35)
        Me.LabelEndoflifeDateFrame.Name = "LabelEndoflifeDateFrame"
        Me.LabelEndoflifeDateFrame.Size = New System.Drawing.Size(39, 13)
        Me.LabelEndoflifeDateFrame.TabIndex = 47
        Me.LabelEndoflifeDateFrame.Text = "Label3"
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
        'LabelAESAlarmDate
        '
        Me.LabelAESAlarmDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelAESAlarmDate.Location = New System.Drawing.Point(14, 97)
        Me.LabelAESAlarmDate.Name = "LabelAESAlarmDate"
        Me.LabelAESAlarmDate.Size = New System.Drawing.Size(228, 23)
        Me.LabelAESAlarmDate.TabIndex = 43
        Me.LabelAESAlarmDate.Text = " "
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
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(35, 399)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(319, 109)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
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
        'LabelReg8
        '
        Me.LabelReg8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelReg8.Location = New System.Drawing.Point(15, 97)
        Me.LabelReg8.Name = "LabelReg8"
        Me.LabelReg8.Size = New System.Drawing.Size(222, 22)
        Me.LabelReg8.TabIndex = 42
        Me.LabelReg8.Text = " "
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
        'ButtonClearAll
        '
        Me.ButtonClearAll.Location = New System.Drawing.Point(229, 202)
        Me.ButtonClearAll.Name = "ButtonClearAll"
        Me.ButtonClearAll.Size = New System.Drawing.Size(163, 41)
        Me.ButtonClearAll.TabIndex = 44
        Me.ButtonClearAll.Text = "Clear Tag"
        Me.ButtonClearAll.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
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
        Me.GroupBox3.Location = New System.Drawing.Point(516, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(439, 309)
        Me.GroupBox3.TabIndex = 46
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tag Registers"
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
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.LabelEndoflifeDateDecrypted)
        Me.GroupBox1.Controls.Add(Me.LabelAlamDateDecrypted)
        Me.GroupBox1.Location = New System.Drawing.Point(289, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 109)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AES decrypted"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "End of Life"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Alarm Date"
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LabelEndoflifeDateFrame)
        Me.GroupBox4.Controls.Add(Me.LabelAESEndoflifeDate)
        Me.GroupBox4.Controls.Add(Me.LabelAlarmDateFrame)
        Me.GroupBox4.Controls.Add(Me.LabelAESrfiID)
        Me.GroupBox4.Controls.Add(Me.LabelAESAlarmDate)
        Me.GroupBox4.Location = New System.Drawing.Point(252, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(258, 171)
        Me.GroupBox4.TabIndex = 47
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "AES encryption"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ListBox1)
        Me.GroupBox5.Location = New System.Drawing.Point(407, 194)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(103, 48)
        Me.GroupBox5.TabIndex = 48
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Serial Port"
        '
        'ReadInputRegistersRTC
        '
        Me.ReadInputRegistersRTC.Location = New System.Drawing.Point(370, 399)
        Me.ReadInputRegistersRTC.Name = "ReadInputRegistersRTC"
        Me.ReadInputRegistersRTC.Size = New System.Drawing.Size(179, 23)
        Me.ReadInputRegistersRTC.TabIndex = 52
        Me.ReadInputRegistersRTC.Text = "Read Input Registers RTC"
        Me.ReadInputRegistersRTC.UseVisualStyleBackColor = True
        '
        'LabelRTC
        '
        Me.LabelRTC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelRTC.Location = New System.Drawing.Point(557, 400)
        Me.LabelRTC.Name = "LabelRTC"
        Me.LabelRTC.Size = New System.Drawing.Size(222, 22)
        Me.LabelRTC.TabIndex = 55
        Me.LabelRTC.Text = " "
        '
        'LabelAlarmmodb
        '
        Me.LabelAlarmmodb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelAlarmmodb.Location = New System.Drawing.Point(557, 428)
        Me.LabelAlarmmodb.Name = "LabelAlarmmodb"
        Me.LabelAlarmmodb.Size = New System.Drawing.Size(222, 22)
        Me.LabelAlarmmodb.TabIndex = 57
        Me.LabelAlarmmodb.Text = " "
        '
        'ReadInputRegistersAlarm
        '
        Me.ReadInputRegistersAlarm.Location = New System.Drawing.Point(370, 428)
        Me.ReadInputRegistersAlarm.Name = "ReadInputRegistersAlarm"
        Me.ReadInputRegistersAlarm.Size = New System.Drawing.Size(179, 23)
        Me.ReadInputRegistersAlarm.TabIndex = 56
        Me.ReadInputRegistersAlarm.Text = "Read Input Registers Alarm"
        Me.ReadInputRegistersAlarm.UseVisualStyleBackColor = True
        '
        'LabelEndoflifemodb
        '
        Me.LabelEndoflifemodb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelEndoflifemodb.Location = New System.Drawing.Point(557, 461)
        Me.LabelEndoflifemodb.Name = "LabelEndoflifemodb"
        Me.LabelEndoflifemodb.Size = New System.Drawing.Size(222, 22)
        Me.LabelEndoflifemodb.TabIndex = 59
        Me.LabelEndoflifemodb.Text = " "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(370, 457)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 23)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "Read Input Registers End of live"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonTimeSynchrone
        '
        Me.ButtonTimeSynchrone.Location = New System.Drawing.Point(370, 370)
        Me.ButtonTimeSynchrone.Name = "ButtonTimeSynchrone"
        Me.ButtonTimeSynchrone.Size = New System.Drawing.Size(175, 23)
        Me.ButtonTimeSynchrone.TabIndex = 60
        Me.ButtonTimeSynchrone.Text = "time synchronization"
        Me.ButtonTimeSynchrone.UseVisualStyleBackColor = True
        '
        'ButtonWritealarm
        '
        Me.ButtonWritealarm.Location = New System.Drawing.Point(370, 486)
        Me.ButtonWritealarm.Name = "ButtonWritealarm"
        Me.ButtonWritealarm.Size = New System.Drawing.Size(409, 29)
        Me.ButtonWritealarm.TabIndex = 61
        Me.ButtonWritealarm.Text = "Write Modbus Registers"
        Me.ButtonWritealarm.UseVisualStyleBackColor = True
        '
        'CheckBoxRfID
        '
        Me.CheckBoxRfID.AutoSize = True
        Me.CheckBoxRfID.Location = New System.Drawing.Point(812, 404)
        Me.CheckBoxRfID.Name = "CheckBoxRfID"
        Me.CheckBoxRfID.Size = New System.Drawing.Size(79, 17)
        Me.CheckBoxRfID.TabIndex = 62
        Me.CheckBoxRfID.Text = "rfID Enable"
        Me.CheckBoxRfID.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 596)
        Me.Controls.Add(Me.CheckBoxRfID)
        Me.Controls.Add(Me.ButtonWritealarm)
        Me.Controls.Add(Me.ButtonTimeSynchrone)
        Me.Controls.Add(Me.LabelEndoflifemodb)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelAlarmmodb)
        Me.Controls.Add(Me.ReadInputRegistersAlarm)
        Me.Controls.Add(Me.LabelRTC)
        Me.Controls.Add(Me.ReadInputRegistersRTC)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.ButtonCodeTag)
        Me.Controls.Add(Me.ButtonR4)
        Me.Controls.Add(Me.ButtonClearAll)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LabelTerminal)
        Me.Name = "Form1"
        Me.Text = "rf ID "
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents LabelTerminal As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents ButtonCodeTag As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ButtonR4 As System.Windows.Forms.Button
    Friend WithEvents LabelAESrfiID As System.Windows.Forms.Label
    Friend WithEvents LabelTagID As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelEndofLife As System.Windows.Forms.Label
    Friend WithEvents LabelAlarmDate As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerAlarm As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerEndofLife As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelAlarmDateFrame As System.Windows.Forms.Label
    Friend WithEvents LabelAESAlarmDate As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelAESEndoflifeDate As System.Windows.Forms.Label
    Friend WithEvents LabelEndoflifeDateFrame As System.Windows.Forms.Label
    Friend WithEvents LabelReg4 As System.Windows.Forms.Label
    Friend WithEvents LabelReg8 As System.Windows.Forms.Label
    Friend WithEvents LabelReg12 As System.Windows.Forms.Label
    Friend WithEvents ButtonClearAll As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelEndoflifeDateDecrypted As System.Windows.Forms.Label
    Friend WithEvents LabelAlamDateDecrypted As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LabelReg20 As System.Windows.Forms.Label
    Friend WithEvents LabelReg16 As System.Windows.Forms.Label
    Private WithEvents ReadInputRegistersRTC As System.Windows.Forms.Button
    Friend WithEvents LabelRTC As System.Windows.Forms.Label
    Friend WithEvents LabelAlarmmodb As System.Windows.Forms.Label
    Private WithEvents ReadInputRegistersAlarm As System.Windows.Forms.Button
    Friend WithEvents LabelEndoflifemodb As System.Windows.Forms.Label
    Private WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButtonTimeSynchrone As System.Windows.Forms.Button
    Friend WithEvents ButtonWritealarm As System.Windows.Forms.Button
    Friend WithEvents CheckBoxRfID As System.Windows.Forms.CheckBox

End Class
