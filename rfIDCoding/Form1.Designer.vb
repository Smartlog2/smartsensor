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
        Me.WsmbsControl1 = New WSMBS.WSMBSControl(Me.components)
        Me.LabelTerminal = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ButtonCodeTag = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ButtonR4 = New System.Windows.Forms.Button()
        Me.LabelAESrfiID = New System.Windows.Forms.Label()
        Me.LabelTagID = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelAlamDateDecrypted = New System.Windows.Forms.Label()
        Me.LabelEndoflifeDateDecrypted = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(412, 202)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(165, 30)
        Me.ListBox1.TabIndex = 3
        '
        'WsmbsControl1
        '
        Me.WsmbsControl1.BaudRate = 9600
        Me.WsmbsControl1.DTREnable = False
        Me.WsmbsControl1.Mode = WSMBS.Mode.RTU
        Me.WsmbsControl1.Parity = WSMBS.Parity.None
        Me.WsmbsControl1.PortName = "COM1"
        Me.WsmbsControl1.RemoveEcho = False
        Me.WsmbsControl1.ResponseTimeout = 1000
        Me.WsmbsControl1.RTSEnable = False
        Me.WsmbsControl1.StopBits = 1
        '
        'LabelTerminal
        '
        Me.LabelTerminal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTerminal.Location = New System.Drawing.Point(15, 319)
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
        Me.ProgressBar1.Location = New System.Drawing.Point(15, 347)
        Me.ProgressBar1.MarqueeAnimationSpeed = 1
        Me.ProgressBar1.Maximum = 27
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
        Me.PictureBox1.Location = New System.Drawing.Point(636, 190)
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
        Me.GroupBox3.Size = New System.Drawing.Size(439, 172)
        Me.GroupBox3.TabIndex = 46
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tag Registers"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(243, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "R0A"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Alarm Date"
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
        'LabelAlamDateDecrypted
        '
        Me.LabelAlamDateDecrypted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelAlamDateDecrypted.Location = New System.Drawing.Point(6, 36)
        Me.LabelAlamDateDecrypted.Name = "LabelAlamDateDecrypted"
        Me.LabelAlamDateDecrypted.Size = New System.Drawing.Size(125, 22)
        Me.LabelAlamDateDecrypted.TabIndex = 48
        Me.LabelAlamDateDecrypted.Text = " "
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Alarm Date"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 373)
        Me.Controls.Add(Me.ButtonCodeTag)
        Me.Controls.Add(Me.ButtonR4)
        Me.Controls.Add(Me.ButtonClearAll)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LabelTerminal)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "rf ID "
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents WsmbsControl1 As WSMBS.WSMBSControl
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

End Class
