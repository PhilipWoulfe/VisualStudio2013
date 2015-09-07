Imports System.Data.SqlClient


Public Class frmLogin

    Dim PACArrList As ArrayList
    Dim dTable As DataTable

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'seed rnd
        Randomize()
        PACArrList = New ArrayList()
        GenPACDigits()

        ' Set text of PAC labels
        lblDig1.Text = "Digit " & PACArrList.Item(0)
        lblDig2.Text = "Digit " & PACArrList.Item(1)
        lblDig3.Text = "Digit " & PACArrList.Item(2)

        Me.ActiveControl = mtbPassword
        Me.AcceptButton = btnNext
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If mtbPassword.Text.Length = 8 Then
            pnlVerify.Visible = True
            Me.ActiveControl = mtbDigit1
        Else
            lblError.Text = "Enter 8 digit account number"
        End If
        Me.AcceptButton = btnLogin
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtbPassword.MaskInputRejected

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ClearAll()
        pnlVerify.Visible = False
        Me.ActiveControl = mtbPassword
        Me.AcceptButton = btnNext
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If mtbDigit1.Text.Length = 0 Or mtbDigit2.Text.Length = 0 Or mtbDigit3.Text.Length = 0 Then
            lblError2.Text = "Enter requested PAC digits"
        Else

            ConnectToDatabase()
            'validate registration number an PAC
            If dTable.Rows.Count > 0 Then
                Dim PAC As String = dTable.Rows(0).Item("PAC").ToString()
                Dim PACArr = PAC.ToCharArray()

                'Get input digits
                Dim dig1Input As Integer = CInt(mtbDigit1.Text)
                Dim dig2Input As Integer = CInt(mtbDigit2.Text)
                Dim dig3Input As Integer = CInt(mtbDigit3.Text)

                'Get which index to compare it with
                Dim PAC1Index As Integer = PACArrList.Item(0) - 1
                Dim PAC2Index As Integer = PACArrList.Item(1) - 1
                Dim PAC3Index As Integer = PACArrList.Item(2) - 1

                'get actual digits from database
                Dim dig1Actual As Integer = CInt(PACArr(PAC1Index).ToString())
                Dim dig2Actual As Integer = CInt(PACArr(PAC2Index).ToString())
                Dim dig3Actual As Integer = CInt(PACArr(PAC3Index).ToString())


                ' if input matches expected
                If dig1Input = dig1Actual And dig2Input = dig2Actual And dig3Input = dig3Actual Then

                    Dim mainForm As frmMain = New frmMain(mtbPassword.Text)
                    Me.Hide()
                    mainForm.Show()
                Else
                    ClearAll()
                    lblError2.Text = "Invalid login information"
                End If
            Else
                ClearAll()
                lblError2.Text = "Invalid login information"
            End If
        End If


    End Sub

    Private Sub ClearAll()
        mtbDigit1.Clear()
        mtbDigit2.Clear()
        mtbDigit3.Clear()
        mtbPassword.Clear()
    End Sub


    Private Sub mtbDigit1_TextChanged(sender As Object, e As EventArgs) Handles mtbDigit1.TextChanged
        Me.ActiveControl = mtbDigit2
    End Sub

    Private Sub mtbDigit2_TextChanged(sender As Object, e As EventArgs) Handles mtbDigit2.TextChanged
        Me.ActiveControl = mtbDigit3
    End Sub
    Private Sub GenPACDigits()
        'Pick three random pac digits to compare
        Dim newInt As Integer
        Do
            newInt = RandomNumber()
            If Not (PACArrList.Contains(newInt)) Then
                PACArrList.Add(newInt)
            End If

        Loop While PACArrList.Count < 3
    End Sub

    Private Sub ConnectToDatabase()
        Dim conn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\dbsBank.mdf;Integrated Security=True")

        Dim queryString As String = "SELECT PAC FROM Customers WHERE Registration_No = @RegNo"

        Dim cmd As New SqlCommand(queryString, conn)
        Dim param As SqlParameter = New SqlParameter("@RegNo", SqlDbType.Int)
        param.Value = mtbPassword.Text
        cmd.Parameters.Add(param)
        

        Dim adap As New SqlDataAdapter(cmd)

        dTable = New DataTable

        Try
            adap.Fill(dTable)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function RandomNumber() As Integer
        Return CInt(Math.Floor((5 - 1 + 1) * Rnd())) + 1
    End Function
End Class
