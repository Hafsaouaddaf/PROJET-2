Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Module ModulePanier
    Public conP As New SqlConnection
    Public comP As New SqlCommand
    Public odaP As New SqlDataAdapter
    Public OdsP As New DataSet
    Public strP As String
    Public OdtP As DataTable
    Public objetDatarP As DataRow
    Public RowNumP As Integer
    Public strconP As String
    Public builderP As SqlCommandBuilder

End Module
