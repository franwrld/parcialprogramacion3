<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matricula
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtIdMatricula = New System.Windows.Forms.TextBox()
        Me.TxtFechMatricula = New System.Windows.Forms.TextBox()
        Me.TxtIdEstud = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MatriculaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaRegistroNotasDataSet3 = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet3()
        Me.MatriculaTableAdapter = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet3TableAdapters.MatriculaTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdMatriculaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaMatriculaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEstudianteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatriculaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaRegistroNotasDataSet11 = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet11()
        Me.MatriculaTableAdapter1 = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet11TableAdapters.MatriculaTableAdapter()
        CType(Me.MatriculaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaRegistroNotasDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatriculaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaRegistroNotasDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Keep Calm Med", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(219, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registar Matricula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(28, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IdMatricula:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FechaMatricula:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(28, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "IdEstudiante:"
        '
        'TxtIdMatricula
        '
        Me.TxtIdMatricula.Location = New System.Drawing.Point(205, 101)
        Me.TxtIdMatricula.Name = "TxtIdMatricula"
        Me.TxtIdMatricula.Size = New System.Drawing.Size(75, 20)
        Me.TxtIdMatricula.TabIndex = 7
        '
        'TxtFechMatricula
        '
        Me.TxtFechMatricula.Location = New System.Drawing.Point(205, 150)
        Me.TxtFechMatricula.Name = "TxtFechMatricula"
        Me.TxtFechMatricula.Size = New System.Drawing.Size(218, 20)
        Me.TxtFechMatricula.TabIndex = 8
        '
        'TxtIdEstud
        '
        Me.TxtIdEstud.Location = New System.Drawing.Point(205, 195)
        Me.TxtIdEstud.Name = "TxtIdEstud"
        Me.TxtIdEstud.Size = New System.Drawing.Size(92, 20)
        Me.TxtIdEstud.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(33, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(390, 51)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(284, 348)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 51)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(460, 86)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 51)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Cargar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MatriculaBindingSource
        '
        Me.MatriculaBindingSource.DataMember = "Matricula"
        Me.MatriculaBindingSource.DataSource = Me.SistemaRegistroNotasDataSet3
        '
        'SistemaRegistroNotasDataSet3
        '
        Me.SistemaRegistroNotasDataSet3.DataSetName = "SistemaRegistroNotasDataSet3"
        Me.SistemaRegistroNotasDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MatriculaTableAdapter
        '
        Me.MatriculaTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(33, 348)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 51)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Editar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(664, 348)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(139, 51)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Actualizar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMatriculaDataGridViewTextBoxColumn, Me.FechaMatriculaDataGridViewTextBoxColumn, Me.IdEstudianteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MatriculaBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(460, 150)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(343, 179)
        Me.DataGridView1.TabIndex = 24
        '
        'IdMatriculaDataGridViewTextBoxColumn
        '
        Me.IdMatriculaDataGridViewTextBoxColumn.DataPropertyName = "IdMatricula"
        Me.IdMatriculaDataGridViewTextBoxColumn.HeaderText = "IdMatricula"
        Me.IdMatriculaDataGridViewTextBoxColumn.Name = "IdMatriculaDataGridViewTextBoxColumn"
        '
        'FechaMatriculaDataGridViewTextBoxColumn
        '
        Me.FechaMatriculaDataGridViewTextBoxColumn.DataPropertyName = "FechaMatricula"
        Me.FechaMatriculaDataGridViewTextBoxColumn.HeaderText = "FechaMatricula"
        Me.FechaMatriculaDataGridViewTextBoxColumn.Name = "FechaMatriculaDataGridViewTextBoxColumn"
        '
        'IdEstudianteDataGridViewTextBoxColumn
        '
        Me.IdEstudianteDataGridViewTextBoxColumn.DataPropertyName = "IdEstudiante"
        Me.IdEstudianteDataGridViewTextBoxColumn.HeaderText = "IdEstudiante"
        Me.IdEstudianteDataGridViewTextBoxColumn.Name = "IdEstudianteDataGridViewTextBoxColumn"
        '
        'MatriculaBindingSource1
        '
        Me.MatriculaBindingSource1.DataMember = "Matricula"
        Me.MatriculaBindingSource1.DataSource = Me.SistemaRegistroNotasDataSet11
        '
        'SistemaRegistroNotasDataSet11
        '
        Me.SistemaRegistroNotasDataSet11.DataSetName = "SistemaRegistroNotasDataSet11"
        Me.SistemaRegistroNotasDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MatriculaTableAdapter1
        '
        Me.MatriculaTableAdapter1.ClearBeforeFill = True
        '
        'Matricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.ProyectoUniversidadProgra.My.Resources.Resources.WhatsApp_Image_2021_06_06_at_08_31_14
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(854, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtIdEstud)
        Me.Controls.Add(Me.TxtFechMatricula)
        Me.Controls.Add(Me.TxtIdMatricula)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Matricula"
        Me.Text = "   n "
        CType(Me.MatriculaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaRegistroNotasDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatriculaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaRegistroNotasDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtIdMatricula As TextBox
    Friend WithEvents TxtFechMatricula As TextBox
    Friend WithEvents TxtIdEstud As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents SistemaRegistroNotasDataSet3 As SistemaRegistroNotasDataSet3
    Friend WithEvents MatriculaBindingSource As BindingSource
    Friend WithEvents MatriculaTableAdapter As SistemaRegistroNotasDataSet3TableAdapters.MatriculaTableAdapter
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SistemaRegistroNotasDataSet11 As SistemaRegistroNotasDataSet11
    Friend WithEvents MatriculaBindingSource1 As BindingSource
    Friend WithEvents MatriculaTableAdapter1 As SistemaRegistroNotasDataSet11TableAdapters.MatriculaTableAdapter
    Friend WithEvents IdMatriculaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaMatriculaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdEstudianteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
