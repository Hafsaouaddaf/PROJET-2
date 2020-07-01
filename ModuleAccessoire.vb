Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Module ModuleAccessoire
    'Accessoire
    Public conAcc As New SqlConnection
    Public comAcc As New SqlCommand
    Public odaAcc As New SqlDataAdapter
    Public OdsAcc As New DataSet
    Public strAcc As String
    Public OdtAcc As DataTable
    Public objetDatarAcc As DataRow
    Public RowNumAcc As Integer
    Public strconAcc As String
    Public builderAcc As SqlCommandBuilder
End Module
