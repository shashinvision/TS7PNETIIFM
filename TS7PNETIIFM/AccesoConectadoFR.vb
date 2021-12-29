Imports MySql.Data.MySqlClient
Public Class AccesoConectadoFR

    Private connString As String = "Server=127.0.0.1;User=root;Password=Qwerty123.,;Port=3306;database=Northwind"
    Dim conn As New MySqlConnection(connString)
    Dim query As String
    Public comando As MySqlCommand = New MySqlCommand()
    Dim reader As MySqlDataReader


    Private Sub AccesoConectadoFR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getEmpleados()
    End Sub

    Public Sub getEmpleados()

        query = "SELECT EmployeeID as idEmpleado, concat(FirstName, ' ', LastName) as nombreEmpleado, BirthDate as fechaNacEmpleado, HireDate as fechaContratoEmpleado,                        city as ciudadEmpleado
                    FROM northwind.employees;"

        Try
            comando.CommandType = CommandType.Text
            comando.Connection = conn
            comando.CommandText = query
            conn.Open()

            reader = comando.ExecuteReader()

            While reader.Read()
                Dim idProveedor As Integer = reader(0).ToString
                Dim nombreEmpleado As String = reader(1).ToString
                Dim fechaNacEmpleado As String = reader(2).ToString.Substring(0, reader(2).ToString.LastIndexOf(" "))
                Dim fechaContratoEmpleado As String = reader(3).ToString.Substring(0, reader(3).ToString.LastIndexOf(" "))
                Dim ciudadEmpleado As String = reader(4).ToString

                empleadosDG.Rows.Add(idProveedor, nombreEmpleado, fechaNacEmpleado, fechaContratoEmpleado, ciudadEmpleado)
                empleadosDG.Refresh()

            End While



        Catch ex As Exception

            MessageBox.Show("Error Empleados: " + ex.Message)

        Finally

            conn.Close()

        End Try

    End Sub

    Private Sub empleadosDG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles empleadosDG.CellClick
        Dim idEmpleado = empleadosDG.Rows(e.RowIndex).Cells(0).Value
        ordenesDeTrabajoGet(idEmpleado)
    End Sub

    Public Sub ordenesDeTrabajoGet(ByVal idEmpleado As Integer)

        ordenTrabajoDG.Rows.Clear() ' limpio la tabla para la siguiente busqueda, si no se añadiran registros cada vez que haga una petición

        query = "select o.OrderID as id, c.CompanyName as nombreCliente, concat(e.FirstName, ' ', e.LastName) as nombreEmpleado , o.OrderDate as fechaOT, o.RequiredDate as fechaRequerida, s.CompanyName as enviadoPor, concat(o.ShipAddress, ', ', o.ShipCity, ', ', o.ShipCountry) as direccionEntrega, o.ShipPostalCode as codigoPostal
                    from orders o 
                    inner join customers c 
                    on o.CustomerID = c.CustomerID 
                    inner join shippers s 
                    on s.ShipperID = o.ShipVia 
                    inner join employees e 
                    on e.EmployeeID = o.EmployeeID 
                    where o.EmployeeID = @idEmpleado"

        Try
            comando.CommandType = CommandType.Text
            comando.Connection = conn
            comando.CommandText = query
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado)
            conn.Open()
            reader = comando.ExecuteReader()

            While reader.Read()
                Dim idOT As Integer = reader(0).ToString
                Dim nombreCliente As String = reader(1).ToString
                Dim nombreEmpleado As String = reader(2).ToString
                Dim fechaOT As String = reader(3).ToString.Substring(0, reader(3).ToString.LastIndexOf(" "))
                Dim fechaRequerida As String = reader(4).ToString.Substring(0, reader(4).ToString.LastIndexOf(" "))
                Dim delivery As String = reader(5).ToString
                Dim direccionEntrega As String = reader(6).ToString
                Dim codigoPostal As String = reader(7).ToString

                ordenTrabajoDG.Rows.Add(idOT, nombreCliente, nombreEmpleado, fechaOT, fechaRequerida, delivery, direccionEntrega, codigoPostal)
                ordenTrabajoDG.Refresh()

            End While



        Catch ex As Exception

            MessageBox.Show("Error Orden de trabajo: " + ex.Message)

        Finally

            conn.Close()

        End Try



    End Sub

End Class