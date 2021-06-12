<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Asignatura
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
        Me.TxtAsignatura = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtIdDocente = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdAsignaturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreAsignaturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDocenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsignaturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaRegistroNotasDataSet2 = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet2()
        Me.AsignaturaTableAdapter = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet2TableAdapters.AsignaturaTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsignaturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaRegistroNotasDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(341, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registrar Asignatura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID Asignatura:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Id Docente:"
        '
        'TxtAsignatura
        '
        Me.TxtAsignatura.Location = New System.Drawing.Point(174, 93)
        Me.TxtAsignatura.Name = "TxtAsignatura"
        Me.TxtAsignatura.Size = New System.Drawing.Size(68, 20)
        Me.TxtAsignatura.TabIndex = 4
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(159, 133)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(233, 20)
        Me.TxtNombre.TabIndex = 5
        '
        'TxtIdDocente
        '
        Me.TxtIdDocente.Location = New System.Drawing.Point(159, 184)
        Me.TxtIdDocente.Name = "TxtIdDocente"
        Me.TxtIdDocente.Size = New System.Drawing.Size(68, 20)
        Me.TxtIdDocente.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(312, 51)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(199, 349)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 51)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(432, 87)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 51)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Cargar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAsignaturaDataGridViewTextBoxColumn, Me.NombreAsignaturaDataGridViewTextBoxColumn, Me.IdDocenteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AsignaturaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(432, 144)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(342, 171)
        Me.DataGridView1.TabIndex = 21
        '
        'IdAsignaturaDataGridViewTextBoxColumn
        '
        Me.IdAsignaturaDataGridViewTextBoxColumn.DataPropertyName = "IdAsignatura"
        Me.IdAsignaturaDataGridViewTextBoxColumn.HeaderText = "IdAsignatura"
        Me.IdAsignaturaDataGridViewTextBoxColumn.Name = "IdAsignaturaDataGridViewTextBoxColumn"
        '
        'NombreAsignaturaDataGridViewTextBoxColumn
        '
        Me.NombreAsignaturaDataGridViewTextBoxColumn.DataPropertyName = "NombreAsignatura"
        Me.NombreAsignaturaDataGridViewTextBoxColumn.HeaderText = "NombreAsignatura"
        Me.NombreAsignaturaDataGridViewTextBoxColumn.Name = "NombreAsignaturaDataGridViewTextBoxColumn"
        '
        'IdDocenteDataGridViewTextBoxColumn
        '
        Me.IdDocenteDataGridViewTextBoxColumn.DataPropertyName = "IdDocente"
        Me.IdDocenteDataGridViewTextBoxColumn.HeaderText = "IdDocente"
        Me.IdDocenteDataGridViewTextBoxColumn.Name = "IdDocenteDataGridViewTextBoxColumn"
        '
        'AsignaturaBindingSource
        '
        Me.AsignaturaBindingSource.DataMember = "Asignatura"
        Me.AsignaturaBindingSource.DataSource = Me.SistemaRegistroNotasDataSet2
        '
        'SistemaRegistroNotasDataSet2
        '
        Me.SistemaRegistroNotasDataSet2.DataSetName = "SistemaRegistroNotasDataSet2"
        Me.SistemaRegistroNotasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AsignaturaTableAdapter
        '
        Me.AsignaturaTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(26, 349)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 51)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Editar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(635, 349)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(139, 51)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Actualizar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Asignatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.ProyectoUniversidadProgra.My.Resources.Resources.WhatsApp_Image_2021_06_06_at_08_31_14
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(888, 450)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtIdDocente)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtAsignatura)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Asignatura"
        Me.Text = "Asignatura"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsignaturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaRegistroNotasDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtAsignatura As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtIdDocente As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SistemaRegistroNotasDataSet2 As SistemaRegistroNotasDataSet2
    Friend WithEvents AsignaturaBindingSource As BindingSource
    Friend WithEvents AsignaturaTableAdapter As SistemaRegistroNotasDataSet2TableAdapters.AsignaturaTableAdapter
    Friend WithEvents IdAsignaturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreAsignaturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDocenteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
