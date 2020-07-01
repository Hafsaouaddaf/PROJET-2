Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Module ModuleP2
    Public conP2 As New SqlConnection
    Public comP2 As New SqlCommand
    Public odaP2 As New SqlDataAdapter
    Public OdsP2 As New DataSet
    Public strP2 As String
    Public OdtP2 As DataTable
    Public objetDatarP2 As DataRow
    Public RowNumP2 As Integer
    Public strconP2 As String
    Public builderP2 As SqlCommandBuilder
End Module
