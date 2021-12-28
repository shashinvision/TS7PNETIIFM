Imports MySql.Data.MySqlClient
Public Class AccesoConectadoFR




    Private connString As String = "Server=127.0.0.1;User=root;Password=Qwerty123.,;Port=3306;database=Northwind"
    Dim conn As New MySqlConnection(connString)
    Dim dataSet As New DataSet()
    Dim tablaEmpleadores As DataTable
    Dim query As String
    Dim numReg As Integer


    Private Sub AccesoConectadoFR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class