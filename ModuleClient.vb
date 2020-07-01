Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Module ModuleClient
    Public conCl As New SqlConnection
    Public comCl As New SqlCommand
    Public odaCl As New SqlDataAdapter
    Public OdsCl As New DataSet
    Public strCl As String
    Public OdtCl As DataTable
    Public objetDatarCl As DataRow
    Public RowNumCl As Integer
    Public strconCl As String
    Public builderCl As SqlCommandBuilder
End Module
