Imports System.Security.Cryptography

Public Class Form1
    Public Class AESCrypter

        Public Shared pass As Byte() = {&H0, &H1, &H2, &H3, &H4, &H5, &H6, &H7, &H8, &H9, &HA, &HB, &HC, &HD, &HE, &HF}

        Public Shared Function AES_Encrypt(ByVal Buffer As Byte()) As Byte()
            Dim AES As New System.Security.Cryptography.RijndaelManaged
            Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
            Dim encrypted As String = ""
            Try
                Dim hash(31) As Byte
                Dim uit() As Byte

                AES.Key = pass ' hash
                AES.Mode = CipherMode.ECB
                Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor

                uit = DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length)

                Return uit
            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Shared Function AES_Decrypt(ByVal Buffer As Byte()) As Byte()
            Dim AES As New System.Security.Cryptography.RijndaelManaged
            Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
            Dim decrypted As String = ""
            Dim uit() As Byte
            Try
                Dim hash(31) As Byte


                AES.Padding = Security.Cryptography.PaddingMode.None

                AES.Key = pass
                AES.Mode = CipherMode.ECB
                Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
                uit = DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length)
               
                Return uit
            Catch ex As Exception
                Return Nothing
            End Try

        End Function

    End Class

   
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ListBox1.Items.Add(sp)
        Next
        

        DateTimePickerAlarm.Format = DateTimePickerFormat.Time
        LabelAlarmDate.Text = "Alarm date = " + DateTimePickerAlarm.Value.ToLocalTime.ToString
        LabelEndofLife.Text = "End of life = " + DateTimePickerEndofLife.Value.ToLocalTime.ToString
        With DateTimePickerAlarm.Value
            LabelAlarmDateFrame.Text = .Year.ToString + .Month.ToString("00") + .Day.ToString("00") + .Hour.ToString("00") + .Minute.ToString("00") + .Second.ToString("00")
        End With
        With DateTimePickerEndofLife.Value
            LabelEndoflifeDateFrame.Text = .Year.ToString + .Month.ToString("00") + .Day.ToString("00") + .Hour.ToString("00") + .Minute.ToString("00") + .Second.ToString("00")
        End With

    End Sub



    Private Sub ButtonID_Click(sender As Object, e As EventArgs)





    End Sub
    Function RFID(ByVal Data As String) As String

        Dim returnStr As String = ""
        Dim Err As Boolean
        Try
            SerialPort1.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        

        SerialPort1.WriteLine(Data)

        Try

            SerialPort1.ReadTimeout = 10000

            returnStr = SerialPort1.ReadLine()
            SerialPort1.DiscardInBuffer()

        Catch ex As TimeoutException
            returnStr = "Error: Serial Port read timed out."
        Finally
            If SerialPort1 IsNot Nothing Then SerialPort1.Close()
        End Try



        Return returnStr

    End Function

    Private Sub ButtonREADR04_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button2WriteR04_Click(sender As Object, e As EventArgs) Handles ButtonCodeTag.Click
        Dim LabelRegister As Label() = New Label() {LabelReg4, LabelReg8, LabelReg12}
        Dim i As Integer
       
        Dim mydata As String

        Dim EncryptionID, EncryptionAlarmdate, EncryptionEndoflife As String

        Dim R(24) As String
        LabelTerminal.BackColor = Color.Orange
        LabelTerminal.Text = "Writing tag ..."

        For i = 0 To 2
            LabelRegister(i).Text = ""
        Next
        LabelTagID.Text = ""
        LabelReg4.Text = ""
        LabelReg8.Text = ""
        LabelReg12.Text = ""
        LabelAESrfiID.Text = ""
        LabelAESAlarmDate.Text = ""
        LabelAESEndoflifeDate.Text = ""
        LabelAlamDateDecrypted.Text = ""
        LabelEndoflifeDateDecrypted.Text = ""

        Application.DoEvents()

        ProgressBar1.Visible = True
        ProgressBar1.Value = 0
        'Reading the Tag ID
        LabelTagID.Text = RFID("s")

        If LabelTagID.Text.Length > 10 Then

            'Tag ID encryption
            EncryptionID = DoEncryption(LabelTagID.Text)
            LabelAESrfiID.Text = EncryptionID
            ProgressBar1.Value += 1

            'Alarm date encryption
            EncryptionAlarmdate = DoEncryption(LabelAlarmDateFrame.Text)
            LabelAESAlarmDate.Text = EncryptionAlarmdate
            ProgressBar1.Value += 1

            'End of life date encryption
            EncryptionEndoflife = DoEncryption(LabelEndoflifeDateFrame.Text)
            LabelAESEndoflifeDate.Text = EncryptionEndoflife
            ProgressBar1.Value += 1

            Application.DoEvents()



            'Reading the registers from 4 to 15 
            For i = 4 To 15
                If i < 10 Then R(i) = RFID("r0" & i) Else R(i) = RFID("r0" & Chr(i + 55))
                If i = 4 Or i = 8 Or i = 12 Then
                    LabelRegister((i / 4) - 1).Text = R(i)
                End If
                ProgressBar1.Value += 1
            Next

            For i = 16 To 23
                If i < 10 Then R(i) = RFID("r0" & i) Else If i <= &HF Then R(i) = RFID("r0" & Chr(i + 55)) Else R(i) = RFID("r" & Hex(i))
            Next
            Application.DoEvents()

            Dim mycom As String
            Dim myError As Boolean
            i = 4


            'Writing the Tag ID encryption 

            Do

                mydata = Microsoft.VisualBasic.Mid(EncryptionID, 1 + ((i - 4) * 8), 8) + Microsoft.VisualBasic.Right(R(i), 25)
                If i < 10 Then mycom = "w0" & i Else mycom = "w0" & Chr(i + 55)
                If RFID(mycom + mydata) = mydata Then myError = False Else myError = True
                ProgressBar1.Value += 1
                i += 1
            Loop While i < 8 And Not myError

            Application.DoEvents()

            ' writing the alarm date

            i = 8
            Do

                mydata = Microsoft.VisualBasic.Mid(EncryptionAlarmdate, 1 + ((i - 8) * 8), 8) + Microsoft.VisualBasic.Right(R(i), 25)
                If i < 10 Then mycom = "w0" & i Else mycom = "w0" & Chr(i + 55)

                If RFID(mycom + mydata) = mydata Then myError = False Else myError = True
                ProgressBar1.Value += 1
                i += 1
            Loop While i < 12 And Not myError
            Application.DoEvents()

            ' writing the end of life
            i = 12
            Do

                mydata = Microsoft.VisualBasic.Mid(EncryptionEndoflife, 1 + ((i - 12) * 8), 8) + Microsoft.VisualBasic.Right(R(i), 25)
                If i < 10 Then mycom = "w0" & i Else mycom = "w0" & Chr(i + 55)
                If RFID(mycom + mydata) = mydata Then myError = False Else myError = True
                ProgressBar1.Value += 1
                i += 1
            Loop While i < 16 And Not myError

            'writing alarm date ascii
            i = 16
            Do

                mydata = Microsoft.VisualBasic.Mid(LabelAlarmDateFrame.Text & "00", 1 + ((i - 16) * 8), 8)
                mydata = mydata + Microsoft.VisualBasic.Right(R(i), 25)
                If i < 10 Then
                    mycom = "w0" & i
                Else
                    If i <= &HF Then
                        mycom = "w0" & Chr(i + 55)
                    Else
                        mycom = "w" & Hex(i)
                    End If
                End If

                If RFID(mycom + mydata) = mydata Then myError = False Else myError = True
                ProgressBar1.Value += 1
                i += 1
            Loop While i < 18 And Not myError

            'writing end of life date ascii
            i = 20
            Do

                mydata = Microsoft.VisualBasic.Mid(LabelEndoflifeDateFrame.Text & "00", 1 + ((i - 20) * 8), 8)
                mydata = mydata + Microsoft.VisualBasic.Right(R(i), 25)
                If i < 10 Then
                    mycom = "w0" & i
                Else
                    If i <= &HF Then
                        mycom = "w0" & Chr(i + 55)
                    Else
                        mycom = "w" & Hex(i)
                    End If
                End If

                If RFID(mycom + mydata) = mydata Then myError = False Else myError = True
                ProgressBar1.Value += 1
                i += 1
            Loop While i < 22 And Not myError




            Application.DoEvents()
            If myError Then
                LabelTerminal.Text = "Writing Tag NOK"
                LabelTerminal.BackColor = Color.Red

            Else
                LabelTerminal.BackColor = Color.Green
                LabelTerminal.Text = "Writing Tag done"
            End If
            Readregisters()
            ProgressBar1.Visible = False
        Else
            LabelTerminal.Text = "Writing Tag NOK, no Tag?"
            LabelTerminal.BackColor = Color.Red
        End If

    End Sub
    
    Private Function DoDecryption(ByVal mydata As String) As String
        Dim myDecryption As Byte()
        Dim myDecryptionString As String
        Dim i As Integer
        Dim Buffer(15) As Byte
        For i = 0 To 15
            Buffer(i) = CByte("&h" + Microsoft.VisualBasic.Mid(mydata, i * 2 + 1, 2))
        Next
        myDecryption = AESCrypter.AES_Decrypt(Buffer)
        For i = 0 To myDecryption.Length / 2 - 1
            myDecryptionString += myDecryption(i).ToString("X2")

        Next
        Return myDecryptionString


    End Function
   

    Private Function DoEncryption(ByVal mydata As String) As String


        Dim myEncryption As Byte()
        Dim myEncryptionString As String
        Dim i As Integer
        Dim Buffer(15) As Byte
        Buffer(7) = &H20
        Buffer(8) = &H53
        Buffer(9) = &H4D
        Buffer(10) = &H41
        Buffer(11) = &H52
        Buffer(12) = &H54
        Buffer(13) = &H4C
        Buffer(14) = &H4F
        Buffer(15) = &H47

        For i = 0 To 6
            Buffer(i) = CByte("&h" + Microsoft.VisualBasic.Mid(mydata, i * 2 + 1, 2))
        Next

        myEncryption = AESCrypter.AES_Encrypt(Buffer)
        For i = 0 To myEncryption.Length / 2 - 1
            myEncryptionString += myEncryption(i).ToString("X2")

        Next
        Return myEncryptionString


    End Function
    Private Sub ButtonREADR5_Click(sender As Object, e As EventArgs)



    End Sub












    Private Sub ButtonW7_Click(sender As Object, e As EventArgs)
        Dim mydata As String

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonR4_Click(sender As Object, e As EventArgs) Handles ButtonR4.Click
        LabelTerminal.Text = "Reading Tag..."
        If Readregisters() = False Then

           
            LabelTerminal.Text = "Reading done!"
        Else
            LabelTerminal.Text = "Reading not possible, no Tag?"
        End If


    End Sub

    Private Function Readregisters() As Boolean
        Dim myerror As Boolean
        LabelTagID.Text = ""
        LabelReg4.Text = ""
        LabelReg8.Text = ""
        LabelReg12.Text = ""
        LabelReg16.Text = ""
        LabelReg20.Text = ""

        LabelAlamDateDecrypted.Text = ""
        LabelEndoflifeDateDecrypted.Text = ""

        Application.DoEvents()

        myerror = False
        LabelTagID.Text = RFID("s")
        If LabelTagID.Text.Length < 10 Then myerror = True
        LabelReg4.Text = RFID("r04")
        If LabelReg4.Text.Length < 10 Then myerror = True
        LabelReg8.Text = RFID("r08")
        If LabelReg8.Text.Length < 10 Then myerror = True
        LabelReg12.Text = RFID("r0C")
        If LabelReg12.Text.Length < 10 Then myerror = True
        LabelReg16.Text = RFID("r10")
        If LabelReg16.Text.Length < 10 Then myerror = True
        LabelReg20.Text = RFID("r14")
        If LabelReg20.Text.Length < 10 Then myerror = True

        LabelAlamDateDecrypted.Text = timestamp(DoDecryption(LabelReg8.Text))
        LabelEndoflifeDateDecrypted.Text = timestamp(DoDecryption(LabelReg12.Text))

        Return myerror

    End Function


    Private Sub DateTimePickerAlarm_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerAlarm.ValueChanged
        LabelAlarmDate.Text = "Alarm date = " + DateTimePickerAlarm.Value.ToLocalTime.ToString
        With DateTimePickerAlarm.Value
            LabelAlarmDateFrame.Text = .Year.ToString + .Month.ToString("00") + .Day.ToString("00") + .Hour.ToString("00") + .Minute.ToString("00") + .Second.ToString("00")
        End With

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub DateTimePickerEndofLife_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerEndofLife.ValueChanged
        LabelEndofLife.Text = "End of life = " + DateTimePickerEndofLife.Value.ToLocalTime.ToString
        With DateTimePickerEndofLife.Value
            LabelEndoflifeDateFrame.Text = .Year.ToString + .Month.ToString("00") + .Day.ToString("00") + .Hour.ToString("00") + .Minute.ToString("00") + .Second.ToString("00")
        End With
    End Sub

    Private Sub ButtonClearAll_Click(sender As Object, e As EventArgs) Handles ButtonClearAll.Click
        Dim i As Integer
        Dim R(24) As String
        Dim mycom As String
        Dim err As Boolean
        LabelTerminal.Text = "Clearing all the registers..."
        LabelTerminal.BackColor = Color.Orange

        ProgressBar1.Visible = True
        ProgressBar1.Value = 1
        Application.DoEvents()
        'Reading the registers from 4 to 15 
        For i = 4 To 24
            If i < 10 Then R(i) = RFID("r0" & i) Else If i <= &HF Then R(i) = RFID("r0" & Chr(i + 55)) Else R(i) = RFID("r" & Hex(i))
            ProgressBar1.Value += 1
        Next
        For i = 4 To 24
            If i < 10 Then mycom = "w0" & i Else If i <= &HF Then mycom = "w0" & Chr(i + 55) Else mycom = "w" & Hex(i)
            If RFID(mycom & "00000000" & Microsoft.VisualBasic.Right(R(i), 25)) = "00000000" & Microsoft.VisualBasic.Right(R(i), 25) Then err = False Else err = True
            ProgressBar1.Value += 1
        Next
        If err Then
            LabelTerminal.Text = "Registers are not cleared"
            LabelTerminal.BackColor = Color.Red

        Else
            Readregisters()
            LabelTerminal.Text = "Clear Done"
            LabelTerminal.BackColor = SystemColors.Control

        End If

        ProgressBar1.Visible = False

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)


    End Sub
    Private Function timestamp(ByVal mydata As String)
        Dim mytimestamp As String
        mytimestamp = Microsoft.VisualBasic.Mid(mydata, 7, 2) + "/" + Microsoft.VisualBasic.Mid(mydata, 5, 2) + "/" + Microsoft.VisualBasic.Left(mydata, 4) _
        + " " + Microsoft.VisualBasic.Mid(mydata, 9, 2) + ":" + Microsoft.VisualBasic.Mid(mydata, 11, 2) + ":" + Microsoft.VisualBasic.Mid(mydata, 13, 2)
        Return mytimestamp
    End Function

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        MsgBox(ListBox1.SelectedItem)

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    
    Private Sub ButtonModbus_Click(sender As Object, e As EventArgs) Handles ButtonModbus.Click
        Dim Result As WSMBS.Result
        WsmbsControl1.Mode = WSMBS.Mode.RTU      'Use standard Modbus RTU
        WsmbsControl1.PortName = "COM8"
        WsmbsControl1.BaudRate = 9600
        WsmbsControl1.StopBits = 1
        WsmbsControl1.Parity = WSMBS.Parity.None
        WsmbsControl1.ResponseTimeout = 1000   '1000ms
        Result = WsmbsControl1.Open()
        If Result <> WSMBS.Result.SUCCESS Then
            MessageBox.Show(WsmbsControl1.GetLastErrorString())
        End If
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReadInputRegisters_Click(sender As Object, e As EventArgs) Handles ReadInputRegistersRTC.Click
        LabelRTC.Text = Dates(0)
    End Sub

    Private Function Dates(ByVal kind As Integer) As String

        Dim DataString As String = ""
        Dim str As String = ""
        Dim sec, hour, min, day, month, year As String
        Dim Registers(5) As Short
        Dim Result As WSMBS.Result
        Dim myResult As String

        Result = WsmbsControl1.ReadInputRegisters(1, kind, 6, Registers)
        If (Result = WSMBS.Result.SUCCESS) Then
            sec = Registers(0).ToString("00")
            min = Registers(1).ToString("00")
            hour = Registers(2).ToString("00")
            day = Registers(3).ToString("00")
            month = Registers(4).ToString("00")
            year = Registers(5).ToString("00")

            myResult = day & "/" & month & "/" & year & "  " & hour & ":" & min & ":" & sec

        Else
            MessageBox.Show(WsmbsControl1.GetLastErrorString())
        End If
        Return myResult
    End Function

    Private Sub ReadInputRegistersAlarm_Click(sender As Object, e As EventArgs) Handles ReadInputRegistersAlarm.Click

        LabelAlarm.Text = Dates(6)
    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles Button1.Click
        LabelEndoflive.Text = Dates(12)
    End Sub

    Private Sub ButtonTimeSynchrone_Click(sender As Object, e As EventArgs) Handles ButtonTimeSynchrone.Click
        Dim Registers(6) As Short
        Dim i As Integer
        Dim Result As WSMBS.Result
        Registers(0) = Now.Second
        Registers(1) = Now.Minute
        Registers(2) = Now.Hour
        Registers(3) = Now.DayOfWeek
        Registers(4) = Now.Day
        Registers(5) = Now.Month
        Registers(6) = Val(Now.Year.ToString().Substring(2, 2))



        Result = WsmbsControl1.WriteMultipleRegisters(1, 0, 7, Registers)
        If (Result <> WSMBS.Result.SUCCESS) Then
            MessageBox.Show(WsmbsControl1.GetLastErrorString())
        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub ButtonWritealarm_Click(sender As Object, e As EventArgs) Handles ButtonWritealarm.Click
        Dim EncryptionID, EncryptionAlarmdate, EncryptionEndoflife As String

        'Alarm date encryption
        EncryptionAlarmdate = DoEncryption(LabelAlarmDateFrame.Text)
        LabelAESAlarmDate.Text = EncryptionAlarmdate
        ProgressBar1.Value += 1

        'End of life date encryption
        EncryptionEndoflife = DoEncryption(LabelEndoflifeDateFrame.Text)
        LabelAESEndoflifeDate.Text = EncryptionEndoflife
        ProgressBar1.Value += 1


        Dim Result As WSMBS.Result
        Dim Registers(15) As Short
        Dim t As Integer
        
        Dim hexString As String = LabelAESAlarmDate.Text


       


        For t = 0 To 15
            Registers(t) = Convert.ToByte(hexString.Substring(t * 2, 2), 16)
        Next




        Result = WsmbsControl1.WriteMultipleRegisters(1, 7, 16, Registers)
        If (Result <> WSMBS.Result.SUCCESS) Then
            MessageBox.Show(WsmbsControl1.GetLastErrorString())
        End If
    End Sub
End Class


