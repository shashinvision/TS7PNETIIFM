Imports MySql.Data.MySqlClient
Public Class AccesoConectadoFR

    Private connString As String = "Server=127.0.0.1;User=root;Password=Qwerty123.,;Port=3306;database=Northwind;Convert Zero Datetime=True"
    Dim conn As New MySqlConnection(connString)
    Dim query As String
    Public comando As MySqlCommand = New MySqlCommand()
    Dim reader As MySqlDataReader
    Dim idEmpleadoGlobal As Integer


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
        idEmpleadoGlobal = empleadosDG.Rows(e.RowIndex).Cells(0).Value
        ordenesDeTrabajoGet(idEmpleadoGlobal, "", "", "", "", "")
    End Sub

    Public Sub ordenesDeTrabajoGet(ByVal Optional idEmpleado As Integer = 0, ByVal Optional fechaEnvioInput As String = "", ByVal Optional pesoCargaDesde As String = "", ByVal Optional pesoCargaHasta As String = "", ByVal Optional rangoFechaOrdenDesde As String = "", ByVal Optional rangoFechaOrdenHasta As String = "")

        ordenTrabajoDG.Rows.Clear() ' limpio la tabla para la siguiente busqueda, si no se añadiran registros cada vez que haga una petición

        Try

            If idEmpleado > 0 Then
                query = "select
                            o.OrderID as id, 
                            c.CompanyName as nombreCliente,
                            concat(e.FirstName, ' ', e.LastName) as nombreEmpleado , 
                            o.Freight as carga,
                            o.OrderDate as fechaOT, 
                            o.RequiredDate as fechaRequerida, 
                            o.ShippedDate as fechaEnvio,
                            s.CompanyName as enviadoPor, 
                            concat(o.ShipAddress, ', ',
                            o.ShipCity, ', ', 
                            o.ShipCountry) as direccionEntrega,
                            o.ShipPostalCode as codigoPostal
                            from orders o 
                            inner join customers c 
                            on o.CustomerID = c.CustomerID 
                            inner join shippers s 
                            on s.ShipperID = o.ShipVia 
                            inner join employees e 
                            on e.EmployeeID = o.EmployeeID 
                            where o.EmployeeID = @idEmpleado;"

                comando.CommandType = CommandType.Text
                comando.Connection = conn
                comando.CommandText = query
                comando.Parameters.Clear()
                comando.Parameters.AddWithValue("@idEmpleado", idEmpleado)

            ElseIf fechaEnvioinput IsNot "" Then

                query = "select
                            o.OrderID as id, 
                            c.CompanyName as nombreCliente,
                            concat(e.FirstName, ' ', e.LastName) as nombreEmpleado , 
                            o.Freight as carga,
                            o.OrderDate as fechaOT, 
                            o.RequiredDate as fechaRequerida, 
                            o.ShippedDate as fechaEnvio,
                            s.CompanyName as enviadoPor, 
                            concat(o.ShipAddress, ', ',
                            o.ShipCity, ', ', 
                            o.ShipCountry) as direccionEntrega,
                            o.ShipPostalCode as codigoPostal
                            from orders o 
                            inner join customers c 
                            on o.CustomerID = c.CustomerID 
                            inner join shippers s 
                            on s.ShipperID = o.ShipVia 
                            inner join employees e 
                            on e.EmployeeID = o.EmployeeID 
                            where o.EmployeeID = @idEmpleado
                            and substring(date_format(o.ShippedDate, '%d-%m-%Y'), 1, 10) = @fechaEnvio;"

                comando.CommandType = CommandType.Text
                comando.Connection = conn
                comando.CommandText = query
                comando.Parameters.Clear()
                comando.Parameters.AddWithValue("@idEmpleado", idEmpleadoGlobal)
                comando.Parameters.AddWithValue("@fechaEnvio", fechaEnvioInput)

            ElseIf pesoCargaDesde IsNot "" And pesoCargaHasta IsNot "" Then

                query = "select
                            o.OrderID as id, 
                            c.CompanyName as nombreCliente,
                            concat(e.FirstName, ' ', e.LastName) as nombreEmpleado , 
                            o.Freight as carga,
                            o.OrderDate as fechaOT, 
                            o.RequiredDate as fechaRequerida, 
                            o.ShippedDate as fechaEnvio,
                            s.CompanyName as enviadoPor, 
                            concat(o.ShipAddress, ', ',
                            o.ShipCity, ', ', 
                            o.ShipCountry) as direccionEntrega,
                            o.ShipPostalCode as codigoPostal
                            from orders o 
                            inner join customers c 
                            on o.CustomerID = c.CustomerID 
                            inner join shippers s 
                            on s.ShipperID = o.ShipVia 
                            inner join employees e 
                            on e.EmployeeID = o.EmployeeID 
                            where o.EmployeeID = @idEmpleado
                            and o.Freight >= @desde and o.Freight <= @hasta;"

                comando.CommandType = CommandType.Text
                comando.Connection = conn
                comando.CommandText = query
                comando.Parameters.Clear()
                comando.Parameters.AddWithValue("@idEmpleado", idEmpleadoGlobal)
                comando.Parameters.AddWithValue("@desde", pesoCargaDesde)
                comando.Parameters.AddWithValue("@hasta", pesoCargaHasta)



            End If

            conn.Open()
            reader = comando.ExecuteReader()

            While reader.Read()

                Dim idOT As Integer = reader(0).ToString
                Dim nombreCliente As String = reader(1).ToString
                Dim nombreEmpleado As String = reader(2).ToString
                Dim pesoCarga As String = reader(3).ToString
                Dim fechaOT As String = reader(4).ToString.Substring(0, reader(4).ToString.LastIndexOf(" "))
                Dim fechaRequerida As String = reader(5).ToString.Substring(0, reader(5).ToString.LastIndexOf(" "))
                Dim fechaEnvio As String = reader(6).ToString.Substring(0, reader(6).ToString.LastIndexOf(" "))
                Dim delivery As String = reader(7).ToString
                Dim direccionEntrega As String = reader(8).ToString
                Dim codigoPostal As String = reader(9).ToString

                ordenTrabajoDG.Rows.Add(idOT, nombreCliente, nombreEmpleado, pesoCarga, fechaOT, fechaRequerida, fechaEnvio, delivery, direccionEntrega, codigoPostal)
                ordenTrabajoDG.Refresh()

            End While

        Catch ex As MySqlException
            MessageBox.Show("Error Mysql: " & vbCrLf & ex.Message)

        Catch ex As Exception

            MessageBox.Show("Error Orden de trabajo: " + ex.Message)

        Finally

            conn.Close()

        End Try



    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles fechaEnvioRadio.CheckedChanged
        fechaEnvioDate.Enabled = True
        rangoCargaDesdeInput.Enabled = False
        rangoCargaHastaInput.Enabled = False
        fechaDesde.Enabled = False
        fechaHasta.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles randoCargaRadio.CheckedChanged
        fechaEnvioDate.Enabled = False
        rangoCargaDesdeInput.Enabled = True
        rangoCargaHastaInput.Enabled = True
        fechaDesde.Enabled = False
        fechaHasta.Enabled = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles rangoFechasRadio.CheckedChanged
        fechaEnvioDate.Enabled = False
        rangoCargaDesdeInput.Enabled = True
        rangoCargaHastaInput.Enabled = True
        fechaDesde.Enabled = True
        fechaHasta.Enabled = True
    End Sub


    Private Sub busqueda_Click(sender As Object, e As EventArgs) Handles busqueda.Click

        If fechaEnvioRadio.Checked Then
            Dim fechaEnvio As String = fechaEnvioDate.Value.ToString.Substring(0, fechaEnvioDate.Value.ToString.LastIndexOf(" "))
            ordenesDeTrabajoGet(0, fechaEnvio, "", "", "", "")
        End If

        If randoCargaRadio.Checked Then
            Dim cargaDesde As String = rangoCargaDesdeInput.Text
            Dim cargaHasta As String = rangoCargaHastaInput.Text

            ordenesDeTrabajoGet(0, "", cargaDesde, cargaHasta, "", "")
        End If

        If rangoFechasRadio.Checked Then

        End If

    End Sub
End Class