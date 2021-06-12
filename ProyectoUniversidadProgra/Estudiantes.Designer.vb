<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Estudiantes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtEstudiante = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtResidencia = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.EstudiantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaRegistroNotasDataSet = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet()
        Me.EstudiantesTableAdapter = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSetTableAdapters.EstudiantesTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.EstudiantesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaRegistroNotasDataSet7 = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet7()
        Me.EstudiantesTableAdapter1 = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet7TableAdapters.EstudiantesTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdEstudianteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResidenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstudiantesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaRegistroNotasDataSet12 = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet12()
        Me.EstudiantesTableAdapter2 = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet12TableAdapters.EstudiantesTableAdapter()
        Me.cbsexo = New System.Windows.Forms.ComboBox()
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaRegistroNotasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiantesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaRegistroNotasDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiantesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaRegistroNotasDataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Black Ground", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(238, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registrar Estudiante"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(7, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IdEstudiante:"
        '
        'TxtEstudiante
        '
        Me.TxtEstudiante.Location = New System.Drawing.Point(150, 104)
        Me.TxtEstudiante.Name = "TxtEstudiante"
        Me.TxtEstudiante.Size = New System.Drawing.Size(69, 20)
        Me.TxtEstudiante.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(13, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Apellido:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(7, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nombre:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(150, 136)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(288, 20)
        Me.TxtNombre.TabIndex = 6
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(150, 175)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(288, 20)
        Me.TxtApellido.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(13, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Residencia:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(13, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 25)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Sexo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(13, 299)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 25)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Telefono:"
        '
        'TxtResidencia
        '
        Me.TxtResidencia.Location = New System.Drawing.Point(150, 265)
        Me.TxtResidencia.Name = "TxtResidencia"
        Me.TxtResidencia.Size = New System.Drawing.Size(288, 20)
        Me.TxtResidencia.TabIndex = 13
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(150, 305)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(157, 20)
        Me.TxtTelefono.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(522, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(288, 51)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(705, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 51)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(522, 259)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 51)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Cargar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'EstudiantesBindingSource
        '
        Me.EstudiantesBindingSource.DataMember = "Estudiantes"
        Me.EstudiantesBindingSource.DataSource = Me.SistemaRegistroNotasDataSet
        '
        'SistemaRegistroNotasDataSet
        '
        Me.SistemaRegistroNotasDataSet.DataSetName = "SistemaRegistroNotasDataSet"
        Me.SistemaRegistroNotasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstudiantesTableAdapter
        '
        Me.EstudiantesTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(522, 175)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 51)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Editar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(741, 401)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(139, 51)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Actualizar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'EstudiantesBindingSource1
        '
        Me.EstudiantesBindingSource1.DataMember = "Estudiantes"
        Me.EstudiantesBindingSource1.DataSource = Me.SistemaRegistroNotasDataSet7
        '
        'SistemaRegistroNotasDataSet7
        '
        Me.SistemaRegistroNotasDataSet7.DataSetName = "SistemaRegistroNotasDataSet7"
        Me.SistemaRegistroNotasDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstudiantesTableAdapter1
        '
        Me.EstudiantesTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEstudianteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.SexoDataGridViewTextBoxColumn, Me.ResidenciaDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EstudiantesBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(57, 351)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(645, 150)
        Me.DataGridView1.TabIndex = 22
        '
        'IdEstudianteDataGridViewTextBoxColumn
        '
        Me.IdEstudianteDataGridViewTextBoxColumn.DataPropertyName = "IdEstudiante"
        Me.IdEstudianteDataGridViewTextBoxColumn.HeaderText = "IdEstudiante"
        Me.IdEstudianteDataGridViewTextBoxColumn.Name = "IdEstudianteDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        '
        'SexoDataGridViewTextBoxColumn
        '
        Me.SexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.HeaderText = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.Name = "SexoDataGridViewTextBoxColumn"
        '
        'ResidenciaDataGridViewTextBoxColumn
        '
        Me.ResidenciaDataGridViewTextBoxColumn.DataPropertyName = "Residencia"
        Me.ResidenciaDataGridViewTextBoxColumn.HeaderText = "Residencia"
        Me.ResidenciaDataGridViewTextBoxColumn.Name = "ResidenciaDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'EstudiantesBindingSource2
        '
        Me.EstudiantesBindingSource2.DataMember = "Estudiantes"
        Me.EstudiantesBindingSource2.DataSource = Me.SistemaRegistroNotasDataSet12
        '
        'SistemaRegistroNotasDataSet12
        '
        Me.SistemaRegistroNotasDataSet12.DataSetName = "SistemaRegistroNotasDataSet12"
        Me.SistemaRegistroNotasDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstudiantesTableAdapter2
        '
        Me.EstudiantesTableAdapter2.ClearBeforeFill = True
        '
        'cbsexo
        '
        Me.cbsexo.FormattingEnabled = True
        Me.cbsexo.Items.AddRange(New Object() {"M", "F"})
        Me.cbsexo.Location = New System.Drawing.Point(150, 221)
        Me.cbsexo.Name = "cbsexo"
        Me.cbsexo.Size = New System.Drawing.Size(93, 21)
        Me.cbsexo.TabIndex = 23
        '
        'Estudiantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.ProyectoUniversidadProgra.My.Resources.Resources.WhatsApp_Image_2021_06_06_at_08_31_14
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(908, 513)
        Me.Controls.Add(Me.cbsexo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtResidencia)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtEstudiante)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Estudiantes"
        Me.Text = "Estudiantes"
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaRegistroNotasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudiantesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaRegistroNotasDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudiantesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaRegistroNotasDataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtEstudiante As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtResidencia As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents SistemaRegistroNotasDataSet As SistemaRegistroNotasDataSet
    Friend WithEvents EstudiantesBindingSource As BindingSource
    Friend WithEvents EstudiantesTableAdapter As SistemaRegistroNotasDataSetTableAdapters.EstudiantesTableAdapter
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents SistemaRegistroNotasDataSet7 As SistemaRegistroNotasDataSet7
    Friend WithEvents EstudiantesBindingSource1 As BindingSource
    Friend WithEvents EstudiantesTableAdapter1 As SistemaRegistroNotasDataSet7TableAdapters.EstudiantesTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SistemaRegistroNotasDataSet12 As SistemaRegistroNotasDataSet12
    Friend WithEvents EstudiantesBindingSource2 As BindingSource
    Friend WithEvents EstudiantesTableAdapter2 As SistemaRegistroNotasDataSet12TableAdapters.EstudiantesTableAdapter
    Friend WithEvents IdEstudianteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResidenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cbsexo As ComboBox
End Class
