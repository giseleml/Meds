Imports System.Data.OleDb
Imports System.IO
Module Module1

    'OleDb = conexão de banco de dados
    Public ConnectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {Directory.GetCurrentDirectory}\RemediosTela3.accdb;Persist Security Info=False;"
    Public sql As String
    Public mySql As String
    Public myDr As OleDbDataReader
    Public myDr1 As OleDbDataReader
    Public myDrPedido As OleDbDataReader
    Public cmd As OleDbCommand
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public conexao As New OleDbConnection
    Public conexaoPedidos As New OleDbConnection
    Public conexaoEmpresa As New OleDbConnection
    Public MenorPedido As Integer
    Public ArquivoIni As String
    Public Linhas As Integer
End Module
