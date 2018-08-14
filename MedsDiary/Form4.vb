Imports System.Data.OleDb

Public Class Form4

    Private Sub TxtCod_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCod.KeyDown

        If e.KeyCode = Keys.Enter Then

            Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source= C:\Users\Servidor\Documents\banco de dados\Database51.accdb;User Id=admin;Password=;"

        sql = "SELECT * From Cliente Where Código = " & TxtCod.Text
        conexao = New OleDbConnection(ConnectionString)
        If conexao.State = ConnectionState.Closed Then conexao.Open()
        cmd = New OleDbCommand(sql, conexao)
        myDr = cmd.ExecuteReader
            If myDr.Read Then
                TxtNome.Text = myDr("Nome")
                TxtRG.Text = myDr("RG")
                TxtCPF.Text = myDr("CPF")
                TxtEnd.Text = myDr("Endereço")
                TxtCEP.Text = myDr("CEP")
                TxtEst.Text = myDr("Estado")
                TxtCid.Text = myDr("Cidade")
            End If
        End If
    End Sub



    Private Sub TxtCod_TextChanged(sender As Object, e As EventArgs) Handles TxtCod.TextChanged


    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub BtnAt_Click(sender As Object, e As EventArgs) Handles BtnAt.Click
        Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source= C:\Users\Servidor\Documents\banco de dados\Database51.accdb;User Id=admin;Password=;"

        sql = " update Cliente set Nome = '" & TxtNome.Text & "', RG = '" & TxtRG.Text & "', CPF ='" & TxtCPF.Text & "', Endereço = '" & TxtEnd.Text & "', CEP = '" & TxtCEP.Text & "', Estado = '" & TxtEst.Text & "', Cidade = '" & TxtCid.Text & "' Where Código = " & TxtCod.Text

        Try
            conexao = New OleDbConnection(ConnectionString)
            If conexao.State = ConnectionState.Closed Then conexao.Open()
            cmd = New OleDbCommand(sql, conexao)
            cmd.ExecuteNonQuery()
            MsgBox("Registro Atualizado!")
        Catch ex As Exception
            MsgBox("Erro Durante abertura de caixa: " & ex.Message.ToString(), MsgBoxStyle.Critical, "Walleg")

        End Try
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source= C:\Users\Servidor\Documents\banco de dados\Database51.accdb;User Id=admin;Password=;"

        sql = " INSERT INTO Cliente (Nome, RG, CPF, Endereço, CEP, Estado, Cidade) values ('" & TxtNome.Text & "','" & TxtRG.Text & "','" & TxtCPF.Text & "','" & TxtEnd.Text & "','" & TxtCEP.Text & "','" & TxtEst.Text & "','" & TxtCid.Text & "')"

        Try
            conexao = New OleDbConnection(ConnectionString)
            If conexao.State = ConnectionState.Closed Then conexao.Open()
            cmd = New OleDbCommand(sql, conexao)
            cmd.ExecuteNonQuery()
            MsgBox("Registro Incluido!")
        Catch ex As Exception
            MsgBox("Erro Durante abertura de caixa: " & ex.Message.ToString(), MsgBoxStyle.Critical, "Walleg")

        End Try
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source= C:\Users\Servidor\Documents\banco de dados\Database51.accdb;User Id=admin;Password=;"

        sql = " Delete * From Cliente Where Código = " & TxtCod.Text

        Try
            conexao = New OleDbConnection(ConnectionString)
            If conexao.State = ConnectionState.Closed Then conexao.Open()
            cmd = New OleDbCommand(sql, conexao)
            cmd.ExecuteNonQuery()
            MsgBox("Registro Excluido!")
        Catch ex As Exception
            MsgBox("Erro Durante abertura de caixa: " & ex.Message.ToString(), MsgBoxStyle.Critical, "Walleg")

        End Try
    End Sub
End Class