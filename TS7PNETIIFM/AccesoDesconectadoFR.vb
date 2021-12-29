Imports MySql.Data.MySqlClient

Public Class AccesoDesconectadoFR

    Private connString As String = "Server=127.0.0.1;User=root;Password=Qwerty123.,;Port=3306;database=Northwind;Convert Zero Datetime=True"

    Dim conn As MySqlConnection = New MySqlConnection(connString)
    Dim dataSet As New DataSet()
    Dim adapter As New MySqlDataAdapter()
    Dim comando = New MySqlCommand()
    Dim tablaOrdenesDeTrabajo As DataTable = New DataTable()

    Dim dataSetCountrys As New DataSet()
    Dim adapterCountrys As New MySqlDataAdapter()
    Dim tablaCountrys As DataTable = New DataTable()

    Dim query As String

    Private Sub AccesoDesconectadoFR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        orderenesDeTrabajoGet()
        countrysGet()
        countryCB()
        nameCB()
        ordenesTrabajoGrid()

    End Sub



    Public Sub orderenesDeTrabajoGet()
        query = "select
                    o.OrderID, 
                    c.CompanyName as nombreCliente,
                    o.Freight as carga,
                    o.OrderDate as fechaOT, 
                    o.RequiredDate as fechaRequerida, 
                    o.ShippedDate as fechaEnvio,
                    concat(o.ShipAddress, ', ',
                    o.ShipCity, ', ', 
                    o.ShipCountry) as direccionEntrega,
                    o.ShipPostalCode as codigoPostal,
                    o.ShipCountry,
                    o.ShipName
                    FROM northwind.orders o
                    inner join customers c 
                    on c.CustomerID = o.CustomerID;"
        Try

            comando = New MySqlCommand(query, conn)
            comando.commandType = CommandType.Text
            adapter.SelectCommand = comando
            conn.Open()
            adapter.Fill(dataSet, "OrdenesDeTrabajo")
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
            tablaOrdenesDeTrabajo = dataSet.Tables("OrdenesDeTrabajo")


        Catch ex As Exception
            MessageBox.Show("Error getSuppliers: " + ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub countrysGet()
        query = "select
                    o.OrderID, 
                    o.ShipCountry
                    FROM northwind.orders o
                    group by o.ShipCountry;"
        Try

            comando = New MySqlCommand(query, conn)
            comando.commandType = CommandType.Text
            adapterCountrys.SelectCommand = comando
            conn.Open()
            adapterCountrys.Fill(dataSetCountrys, "country")
            adapterCountrys.MissingSchemaAction = MissingSchemaAction.AddWithKey
            tablaCountrys = dataSetCountrys.Tables("country")


        Catch ex As Exception
            MessageBox.Show("Error getSuppliers: " + ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub countryCB()

        Try
            Dim row As DataRow

            Dim shipCountryCBDictionary As New Dictionary(Of String, String)()

            For Each row In tablaCountrys.Rows

                shipCountryCBDictionary.Add(row.Item("OrderID"), row.Item("ShipCountry"))

            Next
            shipCountryCB.DataSource = New BindingSource(shipCountryCBDictionary, Nothing)
            shipCountryCB.DisplayMember = "Value"
            shipCountryCB.ValueMember = "Key"

        Catch ex As Exception
            MessageBox.Show("Error cargaComboBox: " + ex.Message)

        Finally

            conn.Close()

        End Try

    End Sub

    Public Sub nameCB()

        Try
            Dim row As DataRow

            Dim shipNameCBDictionary As New Dictionary(Of String, String)()

            For Each row In tablaOrdenesDeTrabajo.Rows

                shipNameCBDictionary.Add(row.Item("OrderID"), row.Item("ShipName"))

            Next
            shipNameCB.DataSource = New BindingSource(shipNameCBDictionary, Nothing)
            shipNameCB.DisplayMember = "Value"
            shipNameCB.ValueMember = "Key"

        Catch ex As Exception
            MessageBox.Show("Error cargaComboBox: " + ex.Message)

        Finally

            conn.Close()

        End Try

    End Sub

    Private Sub shipCountryRB_CheckedChanged(sender As Object, e As EventArgs) Handles shipCountryRB.CheckedChanged
        shipCountryCB.Enabled = True
        shipNameCB.Enabled = False
    End Sub

    Private Sub shipNameRB_CheckedChanged(sender As Object, e As EventArgs) Handles shipNameRB.CheckedChanged
        shipNameCB.Enabled = True
        shipCountryCB.Enabled = False
    End Sub

    Private Sub shipCountryCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles shipCountryCB.SelectedIndexChanged


    End Sub

    Public Sub ordenesTrabajoGrid()
        Try
            ordenesDeTrabajoDG.DataSource = tablaOrdenesDeTrabajo
        Catch ex As Exception
            MessageBox.Show("Error carga data OT: " + ex.Message)

        Finally
            conn.Close()
        End Try
    End Sub


End Class