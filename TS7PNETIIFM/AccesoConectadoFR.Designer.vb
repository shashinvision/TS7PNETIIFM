<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccesoConectadoFR
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
        Me.empleadosDG = New System.Windows.Forms.DataGridView()
        Me.idEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaNacEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaContratoEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ciudad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ordenTrabajoDG = New System.Windows.Forms.DataGridView()
        Me.idOrden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pesoCarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaOt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaRequerida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaEnvio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enviadoPor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccionEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoPostal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ordenesDeTrabajoGB = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.fechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rangoCargaHastaInput = New System.Windows.Forms.TextBox()
        Me.rangoCargaDesdeInput = New System.Windows.Forms.TextBox()
        Me.fechaEnvioDate = New System.Windows.Forms.DateTimePicker()
        Me.rangoFechasRadio = New System.Windows.Forms.RadioButton()
        Me.randoCargaRadio = New System.Windows.Forms.RadioButton()
        Me.fechaEnvioRadio = New System.Windows.Forms.RadioButton()
        Me.busqueda = New System.Windows.Forms.Button()
        CType(Me.empleadosDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordenTrabajoDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ordenesDeTrabajoGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'empleadosDG
        '
        Me.empleadosDG.AllowUserToAddRows = False
        Me.empleadosDG.AllowUserToDeleteRows = False
        Me.empleadosDG.AllowUserToOrderColumns = True
        Me.empleadosDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.empleadosDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idEmpleado, Me.nombreEmpleado, Me.fechaNacEmpleado, Me.fechaContratoEmpleado, Me.ciudad})
        Me.empleadosDG.Location = New System.Drawing.Point(24, 48)
        Me.empleadosDG.Name = "empleadosDG"
        Me.empleadosDG.ReadOnly = True
        Me.empleadosDG.RowTemplate.Height = 25
        Me.empleadosDG.Size = New System.Drawing.Size(581, 168)
        Me.empleadosDG.TabIndex = 0
        '
        'idEmpleado
        '
        Me.idEmpleado.HeaderText = "ID"
        Me.idEmpleado.Name = "idEmpleado"
        Me.idEmpleado.ReadOnly = True
        '
        'nombreEmpleado
        '
        Me.nombreEmpleado.HeaderText = "Nombre"
        Me.nombreEmpleado.Name = "nombreEmpleado"
        Me.nombreEmpleado.ReadOnly = True
        '
        'fechaNacEmpleado
        '
        Me.fechaNacEmpleado.HeaderText = "Fecha Nac."
        Me.fechaNacEmpleado.Name = "fechaNacEmpleado"
        Me.fechaNacEmpleado.ReadOnly = True
        '
        'fechaContratoEmpleado
        '
        Me.fechaContratoEmpleado.HeaderText = "Fecha Contrato"
        Me.fechaContratoEmpleado.Name = "fechaContratoEmpleado"
        Me.fechaContratoEmpleado.ReadOnly = True
        '
        'ciudad
        '
        Me.ciudad.HeaderText = "Ciudad"
        Me.ciudad.Name = "ciudad"
        Me.ciudad.ReadOnly = True
        '
        'ordenTrabajoDG
        '
        Me.ordenTrabajoDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ordenTrabajoDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idOrden, Me.nombreCliente, Me.DataGridViewTextBoxColumn1, Me.pesoCarga, Me.fechaOt, Me.fechaRequerida, Me.fechaEnvio, Me.enviadoPor, Me.direccionEntrega, Me.codigoPostal})
        Me.ordenTrabajoDG.Location = New System.Drawing.Point(16, 179)
        Me.ordenTrabajoDG.Name = "ordenTrabajoDG"
        Me.ordenTrabajoDG.RowTemplate.Height = 25
        Me.ordenTrabajoDG.Size = New System.Drawing.Size(944, 168)
        Me.ordenTrabajoDG.TabIndex = 1
        '
        'idOrden
        '
        Me.idOrden.HeaderText = "ID"
        Me.idOrden.Name = "idOrden"
        Me.idOrden.ReadOnly = True
        '
        'nombreCliente
        '
        Me.nombreCliente.HeaderText = "Nombre Cliente"
        Me.nombreCliente.Name = "nombreCliente"
        Me.nombreCliente.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre Empleado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'pesoCarga
        '
        Me.pesoCarga.HeaderText = "Peso Carga"
        Me.pesoCarga.Name = "pesoCarga"
        '
        'fechaOt
        '
        Me.fechaOt.HeaderText = "Fecha OT"
        Me.fechaOt.Name = "fechaOt"
        Me.fechaOt.ReadOnly = True
        '
        'fechaRequerida
        '
        Me.fechaRequerida.HeaderText = "Fecha Requerida"
        Me.fechaRequerida.Name = "fechaRequerida"
        Me.fechaRequerida.ReadOnly = True
        '
        'fechaEnvio
        '
        Me.fechaEnvio.HeaderText = "Fecha Envio"
        Me.fechaEnvio.Name = "fechaEnvio"
        '
        'enviadoPor
        '
        Me.enviadoPor.HeaderText = "Emp. Delivery"
        Me.enviadoPor.Name = "enviadoPor"
        Me.enviadoPor.ReadOnly = True
        '
        'direccionEntrega
        '
        Me.direccionEntrega.HeaderText = "Dirección Entrega"
        Me.direccionEntrega.Name = "direccionEntrega"
        Me.direccionEntrega.ReadOnly = True
        '
        'codigoPostal
        '
        Me.codigoPostal.HeaderText = "Código Postal"
        Me.codigoPostal.Name = "codigoPostal"
        Me.codigoPostal.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(24, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Listado de empleados"
        '
        'ordenesDeTrabajoGB
        '
        Me.ordenesDeTrabajoGB.Controls.Add(Me.busqueda)
        Me.ordenesDeTrabajoGB.Controls.Add(Me.Label4)
        Me.ordenesDeTrabajoGB.Controls.Add(Me.Label3)
        Me.ordenesDeTrabajoGB.Controls.Add(Me.fechaHasta)
        Me.ordenesDeTrabajoGB.Controls.Add(Me.fechaDesde)
        Me.ordenesDeTrabajoGB.Controls.Add(Me.Label2)
        Me.ordenesDeTrabajoGB.Controls.Add(Me.rangoCargaHastaInput)
        Me.ordenesDeTrabajoGB.Controls.Add(Me.rangoCargaDesdeInput)
        Me.ordenesDeTrabajoGB.Controls.Add(Me.fechaEnvioDate)
        Me.ordenesDeTrabajoGB.Controls.Add(Me.rangoFechasRadio)
        Me.ordenesDeTrabajoGB.Controls.Add(Me.randoCargaRadio)
        Me.ordenesDeTrabajoGB.Controls.Add(Me.fechaEnvioRadio)
        Me.ordenesDeTrabajoGB.Controls.Add(Me.ordenTrabajoDG)
        Me.ordenesDeTrabajoGB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ordenesDeTrabajoGB.Location = New System.Drawing.Point(24, 245)
        Me.ordenesDeTrabajoGB.Name = "ordenesDeTrabajoGB"
        Me.ordenesDeTrabajoGB.Size = New System.Drawing.Size(980, 376)
        Me.ordenesDeTrabajoGB.TabIndex = 4
        Me.ordenesDeTrabajoGB.TabStop = False
        Me.ordenesDeTrabajoGB.Text = "Órdenes de trabajo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(555, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(410, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Desde"
        '
        'fechaHasta
        '
        Me.fechaHasta.Enabled = False
        Me.fechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaHasta.Location = New System.Drawing.Point(555, 100)
        Me.fechaHasta.Name = "fechaHasta"
        Me.fechaHasta.Size = New System.Drawing.Size(108, 23)
        Me.fechaHasta.TabIndex = 9
        '
        'fechaDesde
        '
        Me.fechaDesde.Enabled = False
        Me.fechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaDesde.Location = New System.Drawing.Point(410, 100)
        Me.fechaDesde.Name = "fechaDesde"
        Me.fechaDesde.Size = New System.Drawing.Size(108, 23)
        Me.fechaDesde.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(271, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "-"
        '
        'rangoCargaHastaInput
        '
        Me.rangoCargaHastaInput.Enabled = False
        Me.rangoCargaHastaInput.Location = New System.Drawing.Point(289, 97)
        Me.rangoCargaHastaInput.Name = "rangoCargaHastaInput"
        Me.rangoCargaHastaInput.Size = New System.Drawing.Size(49, 23)
        Me.rangoCargaHastaInput.TabIndex = 7
        '
        'rangoCargaDesdeInput
        '
        Me.rangoCargaDesdeInput.Enabled = False
        Me.rangoCargaDesdeInput.Location = New System.Drawing.Point(216, 97)
        Me.rangoCargaDesdeInput.Name = "rangoCargaDesdeInput"
        Me.rangoCargaDesdeInput.Size = New System.Drawing.Size(49, 23)
        Me.rangoCargaDesdeInput.TabIndex = 6
        '
        'fechaEnvioDate
        '
        Me.fechaEnvioDate.Enabled = False
        Me.fechaEnvioDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaEnvioDate.Location = New System.Drawing.Point(50, 93)
        Me.fechaEnvioDate.Name = "fechaEnvioDate"
        Me.fechaEnvioDate.Size = New System.Drawing.Size(108, 23)
        Me.fechaEnvioDate.TabIndex = 5
        '
        'rangoFechasRadio
        '
        Me.rangoFechasRadio.AutoSize = True
        Me.rangoFechasRadio.Location = New System.Drawing.Point(410, 44)
        Me.rangoFechasRadio.Name = "rangoFechasRadio"
        Me.rangoFechasRadio.Size = New System.Drawing.Size(171, 19)
        Me.rangoFechasRadio.TabIndex = 4
        Me.rangoFechasRadio.TabStop = True
        Me.rangoFechasRadio.Text = "Rango de fechas de Orden"
        Me.rangoFechasRadio.UseVisualStyleBackColor = True
        '
        'randoCargaRadio
        '
        Me.randoCargaRadio.AutoSize = True
        Me.randoCargaRadio.Location = New System.Drawing.Point(216, 44)
        Me.randoCargaRadio.Name = "randoCargaRadio"
        Me.randoCargaRadio.Size = New System.Drawing.Size(110, 19)
        Me.randoCargaRadio.TabIndex = 3
        Me.randoCargaRadio.TabStop = True
        Me.randoCargaRadio.Text = "Rango de carga"
        Me.randoCargaRadio.UseVisualStyleBackColor = True
        '
        'fechaEnvioRadio
        '
        Me.fechaEnvioRadio.AutoSize = True
        Me.fechaEnvioRadio.Location = New System.Drawing.Point(50, 44)
        Me.fechaEnvioRadio.Name = "fechaEnvioRadio"
        Me.fechaEnvioRadio.Size = New System.Drawing.Size(108, 19)
        Me.fechaEnvioRadio.TabIndex = 2
        Me.fechaEnvioRadio.TabStop = True
        Me.fechaEnvioRadio.Text = "Fecha de envío"
        Me.fechaEnvioRadio.UseVisualStyleBackColor = True
        '
        'busqueda
        '
        Me.busqueda.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.busqueda.Location = New System.Drawing.Point(735, 97)
        Me.busqueda.Name = "busqueda"
        Me.busqueda.Size = New System.Drawing.Size(75, 23)
        Me.busqueda.TabIndex = 12
        Me.busqueda.Text = "Busqueda"
        Me.busqueda.UseVisualStyleBackColor = False
        '
        'AccesoConectadoFR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 659)
        Me.Controls.Add(Me.ordenesDeTrabajoGB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.empleadosDG)
        Me.Name = "AccesoConectadoFR"
        Me.Text = "Acceso Conectado"
        CType(Me.empleadosDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordenTrabajoDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ordenesDeTrabajoGB.ResumeLayout(False)
        Me.ordenesDeTrabajoGB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents empleadosDG As DataGridView
    Friend WithEvents ordenTrabajoDG As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ordenesDeTrabajoGB As GroupBox
    Friend WithEvents rangoFechasRadio As RadioButton
    Friend WithEvents randoCargaRadio As RadioButton
    Friend WithEvents fechaEnvioRadio As RadioButton
    Friend WithEvents idEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents nombreEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents fechaNacEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents fechaContratoEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents ciudad As DataGridViewTextBoxColumn
    Friend WithEvents fechaEnvioDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents rangoCargaHastaInput As TextBox
    Friend WithEvents rangoCargaDesdeInput As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents fechaHasta As DateTimePicker
    Friend WithEvents fechaDesde As DateTimePicker
    Friend WithEvents idOrden As DataGridViewTextBoxColumn
    Friend WithEvents nombreCliente As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents pesoCarga As DataGridViewTextBoxColumn
    Friend WithEvents fechaOt As DataGridViewTextBoxColumn
    Friend WithEvents fechaRequerida As DataGridViewTextBoxColumn
    Friend WithEvents fechaEnvio As DataGridViewTextBoxColumn
    Friend WithEvents enviadoPor As DataGridViewTextBoxColumn
    Friend WithEvents direccionEntrega As DataGridViewTextBoxColumn
    Friend WithEvents codigoPostal As DataGridViewTextBoxColumn
    Friend WithEvents busqueda As Button
End Class
