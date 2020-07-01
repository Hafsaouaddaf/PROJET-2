Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Module ModuleChien
    Public conC As New SqlConnection
    Public comC As New SqlCommand
    Public odaC As New SqlDataAdapter
    Public OdsC As New DataSet
    Public strC As String
    Public OdtC As DataTable
    Public objetDatarC As DataRow
    Public RowNumC As Integer
    Public strconC As String
    Public builderC As SqlCommandBuilder
End Module
Module ModuleChienHandicapé
    Public conC2 As New SqlConnection
    Public comC2 As New SqlCommand
    Public odaC2 As New SqlDataAdapter
    Public OdsC2 As New DataSet
    Public strC2 As String
    Public OdtC2 As DataTable
    Public objetDatarC2 As DataRow
    Public RowNumC2 As Integer
    Public strconC2 As String
    Public builderC2 As SqlCommandBuilder
End Module
