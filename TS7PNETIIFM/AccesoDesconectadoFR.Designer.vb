<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccesoDesconectadoFR
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.detalleOrdenesDeTrabajoDG = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShipViaAsc = New System.Windows.Forms.RadioButton()
        Me.ShipViaDesc = New System.Windows.Forms.RadioButton()
        Me.ShipCityAsc = New System.Windows.Forms.RadioButton()
        Me.ShipCityDesc = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.shipNameRB = New System.Windows.Forms.RadioButton()
        Me.shipCountryRB = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ordenesDeTrabajoDG = New System.Windows.Forms.DataGridView()
        Me.shipNameCB = New System.Windows.Forms.ComboBox()
        Me.shipCountryCB = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.detalleOrdenesDeTrabajoDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ordenesDeTrabajoDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'detalleOrdenesDeTrabajoDG
        '
        Me.detalleOrdenesDeTrabajoDG.AllowUserToAddRows = False
        Me.detalleOrdenesDeTrabajoDG.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.detalleOrdenesDeTrabajoDG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.detalleOrdenesDeTrabajoDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.detalleOrdenesDeTrabajoDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.detalleOrdenesDeTrabajoDG.Location = New System.Drawing.Point(38, 371)
        Me.detalleOrdenesDeTrabajoDG.Name = "detalleOrdenesDeTrabajoDG"
        Me.detalleOrdenesDeTrabajoDG.ReadOnly = True
        Me.detalleOrdenesDeTrabajoDG.RowTemplate.Height = 25
        Me.detalleOrdenesDeTrabajoDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.detalleOrdenesDeTrabajoDG.Size = New System.Drawing.Size(803, 150)
        Me.detalleOrdenesDeTrabajoDG.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.shipNameRB)
        Me.GroupBox1.Controls.Add(Me.shipCountryRB)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ordenesDeTrabajoDG)
        Me.GroupBox1.Controls.Add(Me.shipNameCB)
        Me.GroupBox1.Controls.Add(Me.shipCountryCB)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(822, 299)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ordenes de trabajo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.ShipViaAsc)
        Me.GroupBox2.Controls.Add(Me.ShipViaDesc)
        Me.GroupBox2.Controls.Add(Me.ShipCityAsc)
        Me.GroupBox2.Controls.Add(Me.ShipCityDesc)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(531, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(278, 100)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Orden"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(19, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Orden ShipVia"
        '
        'ShipViaAsc
        '
        Me.ShipViaAsc.AutoSize = True
        Me.ShipViaAsc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ShipViaAsc.Location = New System.Drawing.Point(19, 50)
        Me.ShipViaAsc.Name = "ShipViaAsc"
        Me.ShipViaAsc.Size = New System.Drawing.Size(44, 19)
        Me.ShipViaAsc.TabIndex = 4
        Me.ShipViaAsc.TabStop = True
        Me.ShipViaAsc.Text = "Asc"
        Me.ShipViaAsc.UseVisualStyleBackColor = True
        '
        'ShipViaDesc
        '
        Me.ShipViaDesc.AutoSize = True
        Me.ShipViaDesc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ShipViaDesc.Location = New System.Drawing.Point(19, 75)
        Me.ShipViaDesc.Name = "ShipViaDesc"
        Me.ShipViaDesc.Size = New System.Drawing.Size(50, 19)
        Me.ShipViaDesc.TabIndex = 5
        Me.ShipViaDesc.TabStop = True
        Me.ShipViaDesc.Text = "Desc"
        Me.ShipViaDesc.UseVisualStyleBackColor = True
        '
        'ShipCityAsc
        '
        Me.ShipCityAsc.AutoSize = True
        Me.ShipCityAsc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ShipCityAsc.Location = New System.Drawing.Point(144, 50)
        Me.ShipCityAsc.Name = "ShipCityAsc"
        Me.ShipCityAsc.Size = New System.Drawing.Size(44, 19)
        Me.ShipCityAsc.TabIndex = 6
        Me.ShipCityAsc.TabStop = True
        Me.ShipCityAsc.Text = "Asc"
        Me.ShipCityAsc.UseVisualStyleBackColor = True
        '
        'ShipCityDesc
        '
        Me.ShipCityDesc.AutoSize = True
        Me.ShipCityDesc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ShipCityDesc.Location = New System.Drawing.Point(144, 75)
        Me.ShipCityDesc.Name = "ShipCityDesc"
        Me.ShipCityDesc.Size = New System.Drawing.Size(50, 19)
        Me.ShipCityDesc.TabIndex = 7
        Me.ShipCityDesc.TabStop = True
        Me.ShipCityDesc.Text = "Desc"
        Me.ShipCityDesc.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(144, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Orden ShipCity"
        '
        'shipNameRB
        '
        Me.shipNameRB.AutoSize = True
        Me.shipNameRB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.shipNameRB.Location = New System.Drawing.Point(192, 31)
        Me.shipNameRB.Name = "shipNameRB"
        Me.shipNameRB.Size = New System.Drawing.Size(82, 19)
        Me.shipNameRB.TabIndex = 13
        Me.shipNameRB.TabStop = True
        Me.shipNameRB.Text = "ShipName"
        Me.shipNameRB.UseVisualStyleBackColor = True
        '
        'shipCountryRB
        '
        Me.shipCountryRB.AutoSize = True
        Me.shipCountryRB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.shipCountryRB.Location = New System.Drawing.Point(21, 31)
        Me.shipCountryRB.Name = "shipCountryRB"
        Me.shipCountryRB.Size = New System.Drawing.Size(93, 19)
        Me.shipCountryRB.TabIndex = 12
        Me.shipCountryRB.TabStop = True
        Me.shipCountryRB.Text = "ShipCountry"
        Me.shipCountryRB.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(347, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ordenesDeTrabajoDG
        '
        Me.ordenesDeTrabajoDG.AllowUserToAddRows = False
        Me.ordenesDeTrabajoDG.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ordenesDeTrabajoDG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ordenesDeTrabajoDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ordenesDeTrabajoDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ordenesDeTrabajoDG.Location = New System.Drawing.Point(6, 122)
        Me.ordenesDeTrabajoDG.Name = "ordenesDeTrabajoDG"
        Me.ordenesDeTrabajoDG.ReadOnly = True
        Me.ordenesDeTrabajoDG.RowTemplate.Height = 25
        Me.ordenesDeTrabajoDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ordenesDeTrabajoDG.Size = New System.Drawing.Size(803, 150)
        Me.ordenesDeTrabajoDG.TabIndex = 10
        '
        'shipNameCB
        '
        Me.shipNameCB.Enabled = False
        Me.shipNameCB.FormattingEnabled = True
        Me.shipNameCB.Location = New System.Drawing.Point(192, 74)
        Me.shipNameCB.Name = "shipNameCB"
        Me.shipNameCB.Size = New System.Drawing.Size(121, 23)
        Me.shipNameCB.TabIndex = 2
        '
        'shipCountryCB
        '
        Me.shipCountryCB.Enabled = False
        Me.shipCountryCB.FormattingEnabled = True
        Me.shipCountryCB.Location = New System.Drawing.Point(21, 75)
        Me.shipCountryCB.Name = "shipCountryCB"
        Me.shipCountryCB.Size = New System.Drawing.Size(121, 23)
        Me.shipCountryCB.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(51, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Detalle de Orden de Trabajo"
        '
        'AccesoDesconectadoFR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 580)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.detalleOrdenesDeTrabajoDG)
        Me.Name = "AccesoDesconectadoFR"
        Me.Text = "Acceso Desconectado"
        CType(Me.detalleOrdenesDeTrabajoDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ordenesDeTrabajoDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents detalleOrdenesDeTrabajoDG As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents shipNameCB As ComboBox
    Friend WithEvents shipCountryCB As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ShipCityDesc As RadioButton
    Friend WithEvents ShipCityAsc As RadioButton
    Friend WithEvents ShipViaDesc As RadioButton
    Friend WithEvents ShipViaAsc As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents ordenesDeTrabajoDG As DataGridView
    Friend WithEvents shipNameRB As RadioButton
    Friend WithEvents shipCountryRB As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
