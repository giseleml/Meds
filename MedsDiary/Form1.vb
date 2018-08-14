Imports System.IO
Imports System.Data.OleDb

Public Class Form1
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click


        'acessar senha/usuario do banco de dados


        sql = " SELECT * From Usuarios Where Usuário = '" & txtUser1.Text & "' And Senha='" & txtPass.Text & "'"



        conexao = New OleDbConnection(ConnectionString)
        If conexao.State = ConnectionState.Closed Then conexao.Open()
        cmd = New OleDbCommand(sql, conexao)
        myDr = cmd.ExecuteReader

        If myDr.Read Then
            Form3.Show()

        Else
            MsgBox("Usuário ou Senha Inválido!")
        End If


        Me.Hide()




    End Sub

    Private Sub txtUser1_TextChanged(sender As Object, e As EventArgs) Handles txtUser1.TextChanged


    End Sub

    Private Sub lblUser_Click(sender As Object, e As EventArgs) Handles lblUser.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txtUser1.Select()



    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub
End Class
