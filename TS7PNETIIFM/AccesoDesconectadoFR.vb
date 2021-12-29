Imports MySql.Data.MySqlClient

Public Class AccesoDesconectadoFR

    Private connString As String = "Server=127.0.0.1;User=root;Password=Qwerty123.,;Port=3306;database=Northwind;Convert Zero Datetime=True"

    Dim conn As MySqlConnection = New MySqlConnection(connString)
    Dim dataSet As New DataSet()
    Dim adapter As New MySqlDataAdapter()
    Dim comando = New MySqlCommand()
    Dim tablaOrdenesDeTrabajo As DataTable = New DataTable()


    Dim query As String

    Private Sub AccesoDesconectadoFR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        orderenesDeTrabajoGet()
        countryCB()
        nameCB()

    End Sub

    Public Sub orderenesDeTrabajoGet()
        query = "SELECT * FROM northwind.orders"

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

    Public Sub countryCB()

        Try
            Dim row As DataRow

            Dim shipCountryCBDictionary As New Dictionary(Of String, String)()

            For Each row In tablaOrdenesDeTrabajo.Rows

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
End Class