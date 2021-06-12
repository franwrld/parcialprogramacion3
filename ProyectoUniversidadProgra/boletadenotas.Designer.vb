<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class boletadenotas
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtIdboleta = New System.Windows.Forms.TextBox()
        Me.TxtIdAsignatura = New System.Windows.Forms.TextBox()
        Me.TxtIdEstudiante = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BoletaDeNotasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaRegistroNotasDataSet5 = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet5()
        Me.BoletaDeNotasTableAdapter = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet5TableAdapters.BoletaDeNotasTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BoletaDeNotasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaRegistroNotasDataSet6 = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet6()
        Me.BoletaDeNotasTableAdapter1 = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet6TableAdapters.BoletaDeNotasTableAdapter()
        Me.cbciclo = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SistemaRegistroNotasDataSet13 = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet13()
        Me.BoletaDeNotasBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BoletaDeNotasTableAdapter2 = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet13TableAdapters.BoletaDeNotasTableAdapter()
        Me.IdBoletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdAsignaturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCicloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEstudianteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BoletaDeNotasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaRegistroNotasDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoletaDeNotasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaRegistroNotasDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaRegistroNotasDataSet13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoletaDeNotasBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registar Boleta de Notas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "IdBoleta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "IdAsignatura:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "IdEstudiante:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "IdCiclo:"
        '
        'TxtIdboleta
        '
        Me.TxtIdboleta.Location = New System.Drawing.Point(205, 96)
        Me.TxtIdboleta.Name = "TxtIdboleta"
        Me.TxtIdboleta.Size = New System.Drawing.Size(88, 20)
        Me.TxtIdboleta.TabIndex = 10
        '
        'TxtIdAsignatura
        '
        Me.TxtIdAsignatura.Location = New System.Drawing.Point(205, 157)
        Me.TxtIdAsignatura.Name = "TxtIdAsignatura"
        Me.TxtIdAsignatura.Size = New System.Drawing.Size(88, 20)
        Me.TxtIdAsignatura.TabIndex = 11
        '
        'TxtIdEstudiante
        '
        Me.TxtIdEstudiante.Location = New System.Drawing.Point(205, 274)
        Me.TxtIdEstudiante.Name = "TxtIdEstudiante"
        Me.TxtIdEstudiante.Size = New System.Drawing.Size(88, 20)
        Me.TxtIdEstudiante.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(399, 51)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(27, 450)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 51)
        Me.Button4.TabIndex = 35
        Me.Button4.Text = "Editar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(287, 450)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 51)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BoletaDeNotasBindingSource
        '
        Me.BoletaDeNotasBindingSource.DataMember = "BoletaDeNotas"
        Me.BoletaDeNotasBindingSource.DataSource = Me.SistemaRegistroNotasDataSet5
        '
        'SistemaRegistroNotasDataSet5
        '
        Me.SistemaRegistroNotasDataSet5.DataSetName = "SistemaRegistroNotasDataSet5"
        Me.SistemaRegistroNotasDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BoletaDeNotasTableAdapter
        '
        Me.BoletaDeNotasTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(495, 96)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 51)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Cargar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(690, 450)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(139, 51)
        Me.Button5.TabIndex = 39
        Me.Button5.Text = "Actualizar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'BoletaDeNotasBindingSource1
        '
        Me.BoletaDeNotasBindingSource1.DataMember = "BoletaDeNotas"
        Me.BoletaDeNotasBindingSource1.DataSource = Me.SistemaRegistroNotasDataSet6
        '
        'SistemaRegistroNotasDataSet6
        '
        Me.SistemaRegistroNotasDataSet6.DataSetName = "SistemaRegistroNotasDataSet6"
        Me.SistemaRegistroNotasDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BoletaDeNotasTableAdapter1
        '
        Me.BoletaDeNotasTableAdapter1.ClearBeforeFill = True
        '
        'cbciclo
        '
        Me.cbciclo.FormattingEnabled = True
        Me.cbciclo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbciclo.Location = New System.Drawing.Point(205, 213)
        Me.cbciclo.Name = "cbciclo"
        Me.cbciclo.Size = New System.Drawing.Size(121, 21)
        Me.cbciclo.TabIndex = 41
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdBoletaDataGridViewTextBoxColumn, Me.IdAsignaturaDataGridViewTextBoxColumn, Me.IdCicloDataGridViewTextBoxColumn, Me.IdEstudianteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BoletaDeNotasBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(373, 169)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(442, 173)
        Me.DataGridView1.TabIndex = 42
        '
        'SistemaRegistroNotasDataSet13
        '
        Me.SistemaRegistroNotasDataSet13.DataSetName = "SistemaRegistroNotasDataSet13"
        Me.SistemaRegistroNotasDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BoletaDeNotasBindingSource2
        '
        Me.BoletaDeNotasBindingSource2.DataMember = "BoletaDeNotas"
        Me.BoletaDeNotasBindingSource2.DataSource = Me.SistemaRegistroNotasDataSet13
        '
        'BoletaDeNotasTableAdapter2
        '
        Me.BoletaDeNotasTableAdapter2.ClearBeforeFill = True
        '
        'IdBoletaDataGridViewTextBoxColumn
        '
        Me.IdBoletaDataGridViewTextBoxColumn.DataPropertyName = "IdBoleta"
        Me.IdBoletaDataGridViewTextBoxColumn.HeaderText = "IdBoleta"
        Me.IdBoletaDataGridViewTextBoxColumn.Name = "IdBoletaDataGridViewTextBoxColumn"
        '
        'IdAsignaturaDataGridViewTextBoxColumn
        '
        Me.IdAsignaturaDataGridViewTextBoxColumn.DataPropertyName = "IdAsignatura"
        Me.IdAsignaturaDataGridViewTextBoxColumn.HeaderText = "IdAsignatura"
        Me.IdAsignaturaDataGridViewTextBoxColumn.Name = "IdAsignaturaDataGridViewTextBoxColumn"
        '
        'IdCicloDataGridViewTextBoxColumn
        '
        Me.IdCicloDataGridViewTextBoxColumn.DataPropertyName = "IdCiclo"
        Me.IdCicloDataGridViewTextBoxColumn.HeaderText = "IdCiclo"
        Me.IdCicloDataGridViewTextBoxColumn.Name = "IdCicloDataGridViewTextBoxColumn"
        '
        'IdEstudianteDataGridViewTextBoxColumn
        '
        Me.IdEstudianteDataGridViewTextBoxColumn.DataPropertyName = "IdEstudiante"
        Me.IdEstudianteDataGridViewTextBoxColumn.HeaderText = "IdEstudiante"
        Me.IdEstudianteDataGridViewTextBoxColumn.Name = "IdEstudianteDataGridViewTextBoxColumn"
        '
        'boletadenotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoUniversidadProgra.My.Resources.Resources.WhatsApp_Image_2021_06_06_at_08_31_14
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(905, 513)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cbciclo)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtIdEstudiante)
        Me.Controls.Add(Me.TxtIdAsignatura)
        Me.Controls.Add(Me.TxtIdboleta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "boletadenotas"
        Me.Text = "IdBoleta"
        CType(Me.BoletaDeNotasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaRegistroNotasDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoletaDeNotasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaRegistroNotasDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaRegistroNotasDataSet13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoletaDeNotasBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtIdboleta As TextBox
    Friend WithEvents TxtIdAsignatura As TextBox
    Friend WithEvents TxtIdEstudiante As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents SistemaRegistroNotasDataSet5 As SistemaRegistroNotasDataSet5
    Friend WithEvents BoletaDeNotasBindingSource As BindingSource
    Friend WithEvents BoletaDeNotasTableAdapter As SistemaRegistroNotasDataSet5TableAdapters.BoletaDeNotasTableAdapter
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents SistemaRegistroNotasDataSet6 As SistemaRegistroNotasDataSet6
    Friend WithEvents BoletaDeNotasBindingSource1 As BindingSource
    Friend WithEvents BoletaDeNotasTableAdapter1 As SistemaRegistroNotasDataSet6TableAdapters.BoletaDeNotasTableAdapter
    Friend WithEvents cbciclo As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SistemaRegistroNotasDataSet13 As SistemaRegistroNotasDataSet13
    Friend WithEvents BoletaDeNotasBindingSource2 As BindingSource
    Friend WithEvents BoletaDeNotasTableAdapter2 As SistemaRegistroNotasDataSet13TableAdapters.BoletaDeNotasTableAdapter
    Friend WithEvents IdBoletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdAsignaturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCicloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdEstudianteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
