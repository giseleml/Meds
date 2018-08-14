Imports System.Data.OleDb

Public Class Form3


    Private Sub btnInsert_Click(sender As Object, e As EventArgs)


        'If TxtRem.Text.Trim = "" Then
        '    MessageBox.Show("Nome inválido.")
        '    Exit Sub
        'End If

        'TextBox1.Text = TextBox1.Text & " " & TxtRem.Text.Trim

        ''Dim fluxoTexto As IO.StreamWriter

        ''instrução pra pegar registros da tabela
        ''so numero = não põe aspas simples
        ''quando for alfa numérico = '" "' 
        'Try
        '    sql = "Update Meds set observação ='" & TextBox1.Text & "'"
        '    'cria conexão com meu banco de dados
        '    conexao = New OleDbConnection(ConnectionString)
        '    'abre conexão do banco de dados
        '    If conexao.State = ConnectionState.Closed Then conexao.Open()
        '    'cria o comando de executar
        '    cmd = New OleDbCommand(sql, conexao)
        '    'executa
        '    cmd.ExecuteNonQuery()
        'Catch ex As Exception
        '    MsgBox(Err.Description)
        'End Try


        'Dim linhaTexto As String



        'If IO.File.Exists("C:\Users\Servidor\Desktop\Salvo\Diario1.txt") Then


        '    fluxoTexto = New IO.StreamWriter("C:\Users\Servidor\Desktop\Salvo\Diario1.txt", True)

        '    'i = inicial até a quantidade de linhas que tem no listbox - count

        '    fluxoTexto.WriteLine(TxtRem.Text)



        '    fluxoTexto.Close()

        'Else

        '    MessageBox.Show("Arquivo não existe")

        'End If
    End Sub

    Private Sub ListBox1_KeyDown(sender As Object, e As KeyEventArgs)

        'If (ListBox1.SelectedIndex >= 1) Then
        '    ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        '    'to delete each item from the listbox using the delete button on keyboard
        'End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

        'Dim fluxoTexto As IO.StreamWriter

        'Dim linhaTexto As String

        'If IO.File.Exists("C:\Users\Servidor\Desktop\Salvo\Diario1.txt") Then

        '    fluxoTexto = New IO.StreamWriter("C:\Users\Servidor\Desktop\Salvo\Diario1.txt", True)

        '    'i = inicial até a quantidade de linhas que tem no listbox - count
        '    For i = 0 To ListBox1.Items.Count - 1
        '        fluxoTexto.WriteLine(ListBox1.Items(i).ToString)
        '    Next

        '    fluxoTexto.Close()

        'Else

        '    MessageBox.Show("Arquivo não existe")

        'End If

    End Sub

    'BOTÃO ADICIONAR
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click


        sql = " INSERT INTO Remédio (Remédio,Data,Disposição,BomHumor,MelhoranaAtençãoFoco,SonoTranquilo,DiminuiçãodaAnsiedade,DiminuiçãodaDepressão,PensamentosPositivos,DordeCabeça,Fraqueza,Tontura,Enjôo,Vertigem,SonoPerturbado,Insônia,MalHumor,Ansiedade,Depressão,PensamentosNegativos) Values ('" & TxtRem.Text & "', #" & FormatDateTime(DataForm2.Value, DateFormat.ShortDate) & "#,'" & IIf(Disposição.Checked = True, 1, 0) & "','" & IIf(BomHumor.Checked = True, 1, 0) & "','" & IIf(Foco.Checked = True, 1, 0) & "','" & IIf(SonoBom.Checked = True, 1, 0) & "','" & IIf(MenosAnsie.Checked = True, 1, 0) & "','" & IIf(MenosDepre.Checked = True, 1, 0) & "','" & IIf(PensaPositv.Checked = True, 1, 0) & "',
        '" & IIf(Dor.Checked = True, 1, 0) & "','" & IIf(Fraqueza.Checked = True, 1, 0) & "','" & IIf(Tontura.Checked = True, 1, 0) & "','" & IIf(Enjoo.Checked = True, 1, 0) & "','" & IIf(Vertigem.Checked = True, 1, 0) & "','" & IIf(SonoRuim.Checked = True, 1, 0) & "','" & IIf(Insonia.Checked = True, 1, 0) & "','" & IIf(MalHumor.Checked = True, 1, 0) & "','" & IIf(Ansiedade.Checked = True, 1, 0) & "',
        '" & IIf(Depre.Checked = True, 1, 0) & "','" & IIf(PensaNeg.Checked = True, 1, 0) & "') "

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

    'BOTÃO SALVAR
    Private Sub BtnAtualizar_Click(sender As Object, e As EventArgs) Handles BtnAtualizar.Click



        sql = " Update  Remédio set Disposição='" & IIf(Disposição.Checked = True, 1, 0) & "', BomHumor='" & IIf(BomHumor.Checked = True, 1, 0) & "',"
        sql = sql & "MelhoranaAtençãoFoco ='" & IIf(Foco.Checked = True, 1, 0) & "',SonoTranquilo='" & IIf(SonoBom.Checked = True, 1, 0) & "',"
        sql = sql & "DiminuiçãodaAnsiedade ='" & IIf(MenosAnsie.Checked = True, 1, 0) & "',DiminuiçãodaDepressão='" & IIf(MenosDepre.Checked = True, 1, 0) & "',"
        sql = sql & "PensamentosPositivos ='" & IIf(PensaPositv.Checked = True, 1, 0) & "',DordeCabeça='" & IIf(Dor.Checked = True, 1, 0) & "',"
        sql = sql & "Fraqueza ='" & IIf(Fraqueza.Checked = True, 1, 0) & "',Tontura='" & IIf(Tontura.Checked = True, 1, 0) & "',Enjôo='" & IIf(Enjoo.Checked = True, 1, 0) & "',"
        sql = sql & "Vertigem ='" & IIf(Vertigem.Checked = True, 1, 0) & "',SonoPerturbado='" & IIf(SonoRuim.Checked = True, 1, 0) & "',Insônia='" & IIf(Insonia.Checked = True, 1, 0) & "',"
        sql = sql & "MalHumor ='" & IIf(MalHumor.Checked = True, 1, 0) & "',Ansiedade='" & IIf(Ansiedade.Checked = True, 1, 0) & "',Depressão='" & IIf(Depre.Checked = True, 1, 0) & "',"
        sql = sql & "PensamentosNegativos ='" & IIf(PensaNeg.Checked = True, 1, 0) & "' Where Remédio = '" & TxtRem.Text & "' And Data = #" & FormatDateTime(DataForm2.Value, DateFormat.ShortDate) & "#"

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

    'BOTÃO EXCLUIR
    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click


        sql = " Delete * From Remédio Where Remédio = '" & TxtRem.Text & "' And Data = #" & FormatDateTime(DataForm2.Value, DateFormat.ShortDate) & "#"
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

    'BOTÃO PESQUISAR
    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles BtnPesquisar.Click


        sql = "SELECT * From Remédio Where Remédio = '" & TxtRem.Text & "' And Data = #" & FormatDateTime(DataForm2.Value, DateFormat.ShortDate) & "#"
        conexao = New OleDbConnection(ConnectionString)
        If conexao.State = ConnectionState.Closed Then conexao.Open()
        cmd = New OleDbCommand(sql, conexao)
        myDr = cmd.ExecuteReader
        If myDr.Read Then

            Disposição.Checked = myDr("disposição")
            BomHumor.Checked = myDr("BomHumor")
            Foco.Checked = myDr("MelhoranaAtençãoFoco")
            SonoBom.Checked = myDr("SonoTranquilo")
            MenosAnsie.Checked = myDr("DiminuiçãodaAnsiedade")
            MenosDepre.Checked = myDr("DiminuiçãodaDepressão")
            PensaPositv.Checked = myDr("PensamentosPositivos")
            Dor.Checked = myDr("DordeCabeça")
            Fraqueza.Checked = myDr("Fraqueza")
            Tontura.Checked = myDr("Tontura")
            Enjoo.Checked = myDr("Enjôo")
            Vertigem.Checked = myDr("Vertigem")
            SonoRuim.Checked = myDr("SonoPerturbado")
            Insonia.Checked = myDr("Insônia")
            MalHumor.Checked = myDr("MalHumor")
            Ansiedade.Checked = myDr("Ansiedade")
            Depre.Checked = myDr("Depressão")
            PensaNeg.Checked = myDr("PensamentosNegativos")

        Else
            MsgBox("Registro Não Encontrado!")
        End If



    End Sub

    Private Sub TxtRem_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sql = "SELECT distinct (Remédio) from Remédio"
        conexao = New OleDbConnection(ConnectionString)
        If conexao.State = ConnectionState.Closed Then conexao.Open()
        cmd = New OleDbCommand(sql, conexao)
        myDr = cmd.ExecuteReader
        If myDr.HasRows Then
            Do While myDr.Read
                txtRem.Items.Add(myDr(“Remédio"))
            Loop
        End If

        conexao = New OleDbConnection(ConnectionString)
        If conexao.State = ConnectionState.Closed Then conexao.Open()
        'MySql = "select estoque_codigo as [Código], estoque_Referência as [Referência],estoque_descrição as [Descrição],format(estoque_tabela,'##0.00') as [Preço] ,format(estoque_anterior+entradas-saídas,'##0.00') as [Estoque],localização.descrição as  [Localização],estoque_memo as[Obs] from produtos,localização where localização.código=estoque_local  " & ws_opção
        'localização em branco na traz produtos
        'MySql = "select estoque_codigo as [Código], estoque_Referência as [Referência],estoque_descrição as [Descrição],format(estoque_tabela,'##0.00') as [Preço] ,format(estoque_anterior+entradas-saídas,'##0') as [Estoque],localização.descrição as  [Localização],estoque_memo as[Obs] from produtos,localização " & ws_opção
        mySql = "select Remédio, Data from remédio "
        da = New OleDbDataAdapter(mySql, conexao)
        ds = New DataSet
        da.Fill(ds, "Remédio")
        Me.DataGridView1.DataSource = ds.Tables("Remédio")
        Dim row As DataGridViewRow = DataGridView1.RowTemplate
        row.Height = 30
        row.MinimumHeight = 30

        DataGridView1.GridColor = Color.Red
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridView1.BackgroundColor = Color.LightGray

        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Green
        DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow

        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]

        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.AllowUserToResizeColumns = False




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        sql = "SELECT * From Remédio Where Remédio = '" & DataGridView1.SelectedRows(0).Cells(0).Value & "' And Data = #" & Mid(DataGridView1.SelectedRows(0).Cells(1).Value, 7, 4) & "/" & Mid(DataGridView1.SelectedRows(0).Cells(1).Value, 4, 2) & "/" & Mid(DataGridView1.SelectedRows(0).Cells(1).Value, 1, 2) & "#"
        conexao = New OleDbConnection(ConnectionString)
        If conexao.State = ConnectionState.Closed Then conexao.Open()
        cmd = New OleDbCommand(sql, conexao)
        myDr = cmd.ExecuteReader
        If myDr.Read Then

            Disposição.Checked = myDr("disposição")
            BomHumor.Checked = myDr("BomHumor")
            Foco.Checked = myDr("MelhoranaAtençãoFoco")
            SonoBom.Checked = myDr("SonoTranquilo")
            MenosAnsie.Checked = myDr("DiminuiçãodaAnsiedade")
            MenosDepre.Checked = myDr("DiminuiçãodaDepressão")
            PensaPositv.Checked = myDr("PensamentosPositivos")
            Dor.Checked = myDr("DordeCabeça")
            Fraqueza.Checked = myDr("Fraqueza")
            Tontura.Checked = myDr("Tontura")
            Enjoo.Checked = myDr("Enjôo")
            Vertigem.Checked = myDr("Vertigem")
            SonoRuim.Checked = myDr("SonoPerturbado")
            Insonia.Checked = myDr("Insônia")
            MalHumor.Checked = myDr("MalHumor")
            Ansiedade.Checked = myDr("Ansiedade")
            Depre.Checked = myDr("Depressão")
            PensaNeg.Checked = myDr("PensamentosNegativos")

        Else
            MsgBox("Registro Não Encontrado!")
        End If
    End Sub
End Class

