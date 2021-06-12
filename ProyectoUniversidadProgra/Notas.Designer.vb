<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notas
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Txtdetallenota = New System.Windows.Forms.TextBox()
        Me.TxtIdboleta = New System.Windows.Forms.TextBox()
        Me.Txtnota = New System.Windows.Forms.TextBox()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.TxtPorcentaje = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DetalleNotaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaRegistroNotasDataSet4 = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet4()
        Me.DetalleNotaTableAdapter = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet4TableAdapters.DetalleNotaTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DetalleNotaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaRegistroNotasDataSet9 = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet9()
        Me.DetalleNotaTableAdapter1 = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet9TableAdapters.DetalleNotaTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbidperiodo = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SistemaRegistroNotasDataSet14 = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet14()
        Me.DetalleNotaBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetalleNotaTableAdapter2 = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet14TableAdapters.DetalleNotaTableAdapter()
        Me.IdDetalleNotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdBoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionNotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcentajeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPeriodoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DetalleNotaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaRegistroNotasDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleNotaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaRegistroNotasDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaRegistroNotasDataSet14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleNotaBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(238, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IdBoleta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "IdDetalleNota:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Porcentaje:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Descripción:"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.Color.Transparent
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.White
        Me.Label.Location = New System.Drawing.Point(12, 135)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(63, 25)
        Me.Label.TabIndex = 5
        Me.Label.Text = "Nota:"
        '
        'Txtdetallenota
        '
        Me.Txtdetallenota.Location = New System.Drawing.Point(191, 77)
        Me.Txtdetallenota.Name = "Txtdetallenota"
        Me.Txtdetallenota.Size = New System.Drawing.Size(88, 20)
        Me.Txtdetallenota.TabIndex = 9
        '
        'TxtIdboleta
        '
        Me.TxtIdboleta.Location = New System.Drawing.Point(191, 108)
        Me.TxtIdboleta.Name = "TxtIdboleta"
        Me.TxtIdboleta.Size = New System.Drawing.Size(225, 20)
        Me.TxtIdboleta.TabIndex = 19
        '
        'Txtnota
        '
        Me.Txtnota.Location = New System.Drawing.Point(191, 135)
        Me.Txtnota.Name = "Txtnota"
        Me.Txtnota.Size = New System.Drawing.Size(88, 20)
        Me.Txtnota.TabIndex = 20
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.Location = New System.Drawing.Point(191, 174)
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.Size = New System.Drawing.Size(88, 20)
        Me.Txtdescripcion.TabIndex = 21
        '
        'TxtPorcentaje
        '
        Me.TxtPorcentaje.Location = New System.Drawing.Point(191, 225)
        Me.TxtPorcentaje.Name = "TxtPorcentaje"
        Me.TxtPorcentaje.Size = New System.Drawing.Size(88, 20)
        Me.TxtPorcentaje.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(455, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(399, 51)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(653, 174)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 51)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(455, 219)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 51)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Cargar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DetalleNotaBindingSource
        '
        Me.DetalleNotaBindingSource.DataMember = "DetalleNota"
        Me.DetalleNotaBindingSource.DataSource = Me.SistemaRegistroNotasDataSet4
        '
        'SistemaRegistroNotasDataSet4
        '
        Me.SistemaRegistroNotasDataSet4.DataSetName = "SistemaRegistroNotasDataSet4"
        Me.SistemaRegistroNotasDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetalleNotaTableAdapter
        '
        Me.DetalleNotaTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(455, 135)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 51)
        Me.Button4.TabIndex = 34
        Me.Button4.Text = "Editar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(674, 362)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(139, 51)
        Me.Button5.TabIndex = 35
        Me.Button5.Text = "Actualizar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DetalleNotaBindingSource1
        '
        Me.DetalleNotaBindingSource1.DataMember = "DetalleNota"
        Me.DetalleNotaBindingSource1.DataSource = Me.SistemaRegistroNotasDataSet9
        '
        'SistemaRegistroNotasDataSet9
        '
        Me.SistemaRegistroNotasDataSet9.DataSetName = "SistemaRegistroNotasDataSet9"
        Me.SistemaRegistroNotasDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetalleNotaTableAdapter1
        '
        Me.DetalleNotaTableAdapter1.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(238, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(259, 39)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Registrar Notas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 25)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "IDPeriodo:"
        '
        'cbidperiodo
        '
        Me.cbidperiodo.FormattingEnabled = True
        Me.cbidperiodo.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cbidperiodo.Location = New System.Drawing.Point(191, 268)
        Me.cbidperiodo.Name = "cbidperiodo"
        Me.cbidperiodo.Size = New System.Drawing.Size(121, 21)
        Me.cbidperiodo.TabIndex = 39
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDetalleNotaDataGridViewTextBoxColumn, Me.IdBoletaDataGridViewTextBoxColumn, Me.NotaDataGridViewTextBoxColumn, Me.DescripcionNotaDataGridViewTextBoxColumn, Me.PorcentajeDataGridViewTextBoxColumn, Me.IdPeriodoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DetalleNotaBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 316)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(623, 150)
        Me.DataGridView1.TabIndex = 40
        '
        'SistemaRegistroNotasDataSet14
        '
        Me.SistemaRegistroNotasDataSet14.DataSetName = "SistemaRegistroNotasDataSet14"
        Me.SistemaRegistroNotasDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetalleNotaBindingSource2
        '
        Me.DetalleNotaBindingSource2.DataMember = "DetalleNota"
        Me.DetalleNotaBindingSource2.DataSource = Me.SistemaRegistroNotasDataSet14
        '
        'DetalleNotaTableAdapter2
        '
        Me.DetalleNotaTableAdapter2.ClearBeforeFill = True
        '
        'IdDetalleNotaDataGridViewTextBoxColumn
        '
        Me.IdDetalleNotaDataGridViewTextBoxColumn.DataPropertyName = "IdDetalleNota"
        Me.IdDetalleNotaDataGridViewTextBoxColumn.HeaderText = "IdDetalleNota"
        Me.IdDetalleNotaDataGridViewTextBoxColumn.Name = "IdDetalleNotaDataGridViewTextBoxColumn"
        '
        'IdBoletaDataGridViewTextBoxColumn
        '
        Me.IdBoletaDataGridViewTextBoxColumn.DataPropertyName = "IdBoleta"
        Me.IdBoletaDataGridViewTextBoxColumn.HeaderText = "IdBoleta"
        Me.IdBoletaDataGridViewTextBoxColumn.Name = "IdBoletaDataGridViewTextBoxColumn"
        '
        'NotaDataGridViewTextBoxColumn
        '
        Me.NotaDataGridViewTextBoxColumn.DataPropertyName = "Nota"
        Me.NotaDataGridViewTextBoxColumn.HeaderText = "Nota"
        Me.NotaDataGridViewTextBoxColumn.Name = "NotaDataGridViewTextBoxColumn"
        '
        'DescripcionNotaDataGridViewTextBoxColumn
        '
        Me.DescripcionNotaDataGridViewTextBoxColumn.DataPropertyName = "DescripcionNota"
        Me.DescripcionNotaDataGridViewTextBoxColumn.HeaderText = "DescripcionNota"
        Me.DescripcionNotaDataGridViewTextBoxColumn.Name = "DescripcionNotaDataGridViewTextBoxColumn"
        '
        'PorcentajeDataGridViewTextBoxColumn
        '
        Me.PorcentajeDataGridViewTextBoxColumn.DataPropertyName = "Porcentaje"
        Me.PorcentajeDataGridViewTextBoxColumn.HeaderText = "Porcentaje"
        Me.PorcentajeDataGridViewTextBoxColumn.Name = "PorcentajeDataGridViewTextBoxColumn"
        '
        'IdPeriodoDataGridViewTextBoxColumn
        '
        Me.IdPeriodoDataGridViewTextBoxColumn.DataPropertyName = "IdPeriodo"
        Me.IdPeriodoDataGridViewTextBoxColumn.HeaderText = "IdPeriodo"
        Me.IdPeriodoDataGridViewTextBoxColumn.Name = "IdPeriodoDataGridViewTextBoxColumn"
        '
        'Notas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.ProyectoUniversidadProgra.My.Resources.Resources.WhatsApp_Image_2021_06_06_at_08_31_14
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(892, 493)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cbidperiodo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtPorcentaje)
        Me.Controls.Add(Me.Txtdescripcion)
        Me.Controls.Add(Me.Txtnota)
        Me.Controls.Add(Me.TxtIdboleta)
        Me.Controls.Add(Me.Txtdetallenota)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Notas"
        Me.Text = " "
        CType(Me.DetalleNotaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaRegistroNotasDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleNotaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaRegistroNotasDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaRegistroNotasDataSet14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleNotaBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label As Label
    Friend WithEvents Txtdetallenota As TextBox
    Friend WithEvents TxtIdboleta As TextBox
    Friend WithEvents Txtnota As TextBox
    Friend WithEvents Txtdescripcion As TextBox
    Friend WithEvents TxtPorcentaje As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents SistemaRegistroNotasDataSet4 As SistemaRegistroNotasDataSet4
    Friend WithEvents DetalleNotaBindingSource As BindingSource
    Friend WithEvents DetalleNotaTableAdapter As SistemaRegistroNotasDataSet4TableAdapters.DetalleNotaTableAdapter
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents SistemaRegistroNotasDataSet9 As SistemaRegistroNotasDataSet9
    Friend WithEvents DetalleNotaBindingSource1 As BindingSource
    Friend WithEvents DetalleNotaTableAdapter1 As SistemaRegistroNotasDataSet9TableAdapters.DetalleNotaTableAdapter
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbidperiodo As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SistemaRegistroNotasDataSet14 As SistemaRegistroNotasDataSet14
    Friend WithEvents DetalleNotaBindingSource2 As BindingSource
    Friend WithEvents DetalleNotaTableAdapter2 As SistemaRegistroNotasDataSet14TableAdapters.DetalleNotaTableAdapter
    Friend WithEvents IdDetalleNotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdBoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionNotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PorcentajeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdPeriodoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
