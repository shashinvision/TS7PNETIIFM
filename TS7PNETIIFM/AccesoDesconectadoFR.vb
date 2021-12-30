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

    Dim dataSetNames As New DataSet()
    Dim adapterNames As New MySqlDataAdapter()
    Dim tablaNames As DataTable = New DataTable()

    Dim dataSetOTDEtalles As New DataSet()
    Dim adapterOTDEtalles As New MySqlDataAdapter()
    Dim tablaOTDEtalles As DataTable = New DataTable()


    Dim query As String

    Dim idOrdenDeTrabajoGLobal As String

    Private Sub AccesoDesconectadoFR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        orderenesDeTrabajoGet()
        orderenesDeTrabajoDetalleGet()
        countrysGet()
        countryCB()
        namesGet()
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
                    o.ShipName,
                    o.ShipVia,
                    o.ShipCity
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

    Public Sub orderenesDeTrabajoDetalleGet()

        query = "SELECT 
                    s.OrderID,
                    p.ProductID,
                    p.ProductName,
                    s.UnitPrice,
                    s.Quantity,
                    s.Discount 
                    FROM northwind.orderdetails s
                    inner join products p 
                    on p.ProductID = s.ProductID ;"



        Try


            comando = New MySqlCommand(query, conn)
            comando.commandType = CommandType.Text
            adapterOTDEtalles.SelectCommand = comando
            conn.Open()
            adapterOTDEtalles.Fill(dataSetOTDEtalles, "OrdenesDeTrabajoDetalle")
            adapterOTDEtalles.MissingSchemaAction = MissingSchemaAction.AddWithKey
            tablaOTDEtalles = dataSetOTDEtalles.Tables("OrdenesDeTrabajoDetalle")


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

    Public Sub namesGet()
        query = "select
                    o.OrderID, 
                    o.ShipName
                    FROM northwind.orders o
                    group by o.ShipName;"
        Try

            comando = New MySqlCommand(query, conn)
            comando.commandType = CommandType.Text
            adapterNames.SelectCommand = comando
            conn.Open()
            adapterNames.Fill(dataSetNames, "names")
            adapterNames.MissingSchemaAction = MissingSchemaAction.AddWithKey
            tablaNames = dataSetNames.Tables("names")


        Catch ex As Exception
            MessageBox.Show("Error getSuppliers: " + ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub nameCB()

        Try
            Dim row As DataRow

            Dim shipNameCBDictionary As New Dictionary(Of String, String)()

            For Each row In tablaNames.Rows

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

    Public Sub ordenesTrabajoGrid()
        Try
            ordenesDeTrabajoDG.DataSource = tablaOrdenesDeTrabajo
            ordenesDeTrabajoDG.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error carga data OT: " + ex.Message)

        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Usando un metodo de filtro
        If shipCountryRB.Checked Then

            Dim valorCountryCB As String = shipCountryCB.Text
            Dim expresion As String
            Dim dtResultado As DataTable

            expresion = "ShipCountry = '" + valorCountryCB + "'"
            dtResultado = tablaOrdenesDeTrabajo.Clone()

            For Each rowResult As DataRow In tablaOrdenesDeTrabajo.Select(expresion)
                dtResultado.ImportRow(rowResult)
            Next

            ordenesDeTrabajoDG.DataSource = dtResultado


        End If

        If shipNameRB.Checked Then
            ' Usando otro metodo de filtro
            Dim valorNameCB = shipNameCB.Text
            Dim filtro As String
            Dim vistaTemp As DataView

            filtro = "ShipName = '" + valorNameCB + "'"
            vistaTemp = New DataView(tablaOrdenesDeTrabajo, filtro, "ShipName Asc", DataViewRowState.CurrentRows)
            ordenesDeTrabajoDG.DataSource = vistaTemp

        End If
    End Sub

    Private Sub ShipViaAsc_CheckedChanged(sender As Object, e As EventArgs) Handles ShipViaAsc.CheckedChanged


        If shipCountryRB.Checked Then
            ' Usando otro metodo de filtro
            Dim valorCountryCB As String = shipCountryCB.Text
            Dim filtro As String
            Dim vistaTemp As DataView

            filtro = "ShipCountry = '" + valorCountryCB + "'"
            vistaTemp = New DataView(tablaOrdenesDeTrabajo, filtro, "ShipVia ASC", DataViewRowState.CurrentRows)
            ordenesDeTrabajoDG.DataSource = vistaTemp


        ElseIf shipNameRB.Checked Then
            ' Usando otro metodo de filtro
            Dim valorNameCB = shipNameCB.Text
            Dim filtro As String
            Dim vistaTemp As DataView

            filtro = "ShipName = '" + valorNameCB + "'"
            vistaTemp = New DataView(tablaOrdenesDeTrabajo, filtro, "ShipVia ASC", DataViewRowState.CurrentRows)
            ordenesDeTrabajoDG.DataSource = vistaTemp

        Else
            Dim vtOrder = New DataView(tablaOrdenesDeTrabajo)
            Dim orden As String


            orden = "ShipVia ASC"
            vtOrder.Sort = orden
            ordenesDeTrabajoDG.DataSource = vtOrder
        End If

    End Sub

    Private Sub ShipViaDesc_CheckedChanged(sender As Object, e As EventArgs) Handles ShipViaDesc.CheckedChanged
        If shipCountryRB.Checked Then
            ' Usando otro metodo de filtro
            Dim valorCountryCB As String = shipCountryCB.Text
            Dim filtro As String
            Dim vistaTemp As DataView

            filtro = "ShipCountry = '" + valorCountryCB + "'"
            vistaTemp = New DataView(tablaOrdenesDeTrabajo, filtro, "ShipVia DESC", DataViewRowState.CurrentRows)
            ordenesDeTrabajoDG.DataSource = vistaTemp


        ElseIf shipNameRB.Checked Then
            ' Usando otro metodo de filtro
            Dim valorNameCB = shipNameCB.Text
            Dim filtro As String
            Dim vistaTemp As DataView

            filtro = "ShipName = '" + valorNameCB + "'"
            vistaTemp = New DataView(tablaOrdenesDeTrabajo, filtro, "ShipVia DESC", DataViewRowState.CurrentRows)
            ordenesDeTrabajoDG.DataSource = vistaTemp

        Else
            Dim vtOrder = New DataView(tablaOrdenesDeTrabajo)
            Dim orden As String


            orden = "ShipVia DESC"
            vtOrder.Sort = orden
            ordenesDeTrabajoDG.DataSource = vtOrder
        End If
    End Sub

    Private Sub ShipCityAsc_CheckedChanged(sender As Object, e As EventArgs) Handles ShipCityAsc.CheckedChanged
        If shipCountryRB.Checked Then
            ' Usando otro metodo de filtro
            Dim valorCountryCB As String = shipCountryCB.Text
            Dim filtro As String
            Dim vistaTemp As DataView

            filtro = "ShipCountry = '" + valorCountryCB + "'"
            vistaTemp = New DataView(tablaOrdenesDeTrabajo, filtro, "ShipCity ASC", DataViewRowState.CurrentRows)
            ordenesDeTrabajoDG.DataSource = vistaTemp


        ElseIf shipNameRB.Checked Then
            ' Usando otro metodo de filtro
            Dim valorNameCB = shipNameCB.Text
            Dim filtro As String
            Dim vistaTemp As DataView

            filtro = "ShipName = '" + valorNameCB + "'"
            vistaTemp = New DataView(tablaOrdenesDeTrabajo, filtro, "ShipCity ASC", DataViewRowState.CurrentRows)
            ordenesDeTrabajoDG.DataSource = vistaTemp

        Else
            Dim vtOrder = New DataView(tablaOrdenesDeTrabajo)
            Dim orden As String


            orden = "ShipCity ASC"
            vtOrder.Sort = orden
            ordenesDeTrabajoDG.DataSource = vtOrder
        End If
    End Sub

    Private Sub ShipCityDesc_CheckedChanged(sender As Object, e As EventArgs) Handles ShipCityDesc.CheckedChanged
        If shipCountryRB.Checked Then
            ' Usando otro metodo de filtro
            Dim valorCountryCB As String = shipCountryCB.Text
            Dim filtro As String
            Dim vistaTemp As DataView

            filtro = "ShipCountry = '" + valorCountryCB + "'"
            vistaTemp = New DataView(tablaOrdenesDeTrabajo, filtro, "ShipCity DESC", DataViewRowState.CurrentRows)
            ordenesDeTrabajoDG.DataSource = vistaTemp


        ElseIf shipNameRB.Checked Then
            ' Usando otro metodo de filtro
            Dim valorNameCB = shipNameCB.Text
            Dim filtro As String
            Dim vistaTemp As DataView

            filtro = "ShipName = '" + valorNameCB + "'"
            vistaTemp = New DataView(tablaOrdenesDeTrabajo, filtro, "ShipCity DESC", DataViewRowState.CurrentRows)
            ordenesDeTrabajoDG.DataSource = vistaTemp

        Else
            Dim vtOrder = New DataView(tablaOrdenesDeTrabajo)
            Dim orden As String


            orden = "ShipCity DESC"
            vtOrder.Sort = orden
            ordenesDeTrabajoDG.DataSource = vtOrder
        End If
    End Sub

    Private Sub ordenesDeTrabajoDG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ordenesDeTrabajoDG.CellClick

        idOrdenDeTrabajoGLobal = ordenesDeTrabajoDG.Rows(e.RowIndex).Cells(0).Value
        Dim filtro As String
        Dim vistaTemp As DataView

        filtro = "OrderID = '" + idOrdenDeTrabajoGLobal + "'"
        vistaTemp = New DataView(tablaOTDEtalles, filtro, "OrderID ASC", DataViewRowState.CurrentRows)
        detalleOrdenesDeTrabajoDG.DataSource = vistaTemp
        detalleOrdenesDeTrabajoDG.Refresh()

    End Sub


End Class