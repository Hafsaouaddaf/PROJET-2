Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Module ModuleNourriture
    Public conN As New SqlConnection
    Public comN As New SqlCommand
    Public odaN As New SqlDataAdapter
    Public OdsN As New DataSet
    Public strN As String
    Public OdtN As DataTable
    Public objetDatarN As DataRow
    Public RowNumN As Integer
    Public strconN As String
    Public builderN As SqlCommandBuilder
End Module
