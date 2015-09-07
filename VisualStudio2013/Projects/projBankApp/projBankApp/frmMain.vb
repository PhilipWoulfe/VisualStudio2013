Imports System.Data.SqlClient

Public Class frmMain

    Dim dt As DataTable
    Dim conn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\dbsBank.mdf;Integrated Security=True")
    Dim regNo As String

    Sub New(p1 As String)
        ' TODO: Complete member initialization 
        InitializeComponent()
        regNo = p1
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim queryString As String = "SELECT Account_Type, Balance FROM Accounts where Registration_No = @RegNo"
        Dim cmd As New SqlCommand(queryString, conn)
        Dim param As SqlParameter = New SqlParameter("@RegNo", SqlDbType.Int)
        param.Value = regNo
        cmd.Parameters.Add(param)
        ConnectToDatabase(cmd)

        cboAccountsAccount.DataSource = dt
        cboAccountsAccount.DisplayMember = "Account_Type"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub ConnectToDatabase(cmd As SqlCommand)

        Dim adap As New SqlDataAdapter(cmd)

        dt = New DataTable

        Try
            adap.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class