<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarNotasAlumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListarNotasAlumnos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.botonconsultar = New System.Windows.Forms.Button()
        Me.ListarnotasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaRegistroNotasDataSet8 = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet8()
        Me.ListarnotasTableAdapter = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet8TableAdapters.listarnotasTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtidestudiante = New System.Windows.Forms.TextBox()
        Me.txtidasignatura = New System.Windows.Forms.TextBox()
        Me.txtidperiodo = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtnombreasigna = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtapellidos = New System.Windows.Forms.TextBox()
        Me.txtnota = New System.Windows.Forms.TextBox()
        Me.txtpuntos = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtidboleta = New System.Windows.Forms.TextBox()
        Me.ListnotasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaRegistroNotasDataSet15 = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet15()
        Me.ListnotasTableAdapter = New ProyectoUniversidadProgra.SistemaRegistroNotasDataSet15TableAdapters.listnotasTableAdapter()
        CType(Me.ListarnotasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaRegistroNotasDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListnotasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaRegistroNotasDataSet15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Keep Calm Med", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(119, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(550, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LISTAR NOTAS DE ALUMNOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(15, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(554, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Descripcion Nota"
        '
        'botonconsultar
        '
        Me.botonconsultar.Location = New System.Drawing.Point(591, 108)
        Me.botonconsultar.Name = "botonconsultar"
        Me.botonconsultar.Size = New System.Drawing.Size(139, 51)
        Me.botonconsultar.TabIndex = 21
        Me.botonconsultar.Text = "Buscar"
        Me.botonconsultar.UseVisualStyleBackColor = True
        '
        'ListarnotasBindingSource
        '
        Me.ListarnotasBindingSource.DataMember = "listarnotas"
        Me.ListarnotasBindingSource.DataSource = Me.SistemaRegistroNotasDataSet8
        '
        'SistemaRegistroNotasDataSet8
        '
        Me.SistemaRegistroNotasDataSet8.DataSetName = "SistemaRegistroNotasDataSet8"
        Me.SistemaRegistroNotasDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListarnotasTableAdapter
        '
        Me.ListarnotasTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(12, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 25)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "ID Estudiante"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(319, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 25)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "ID Periodo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(158, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 25)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "ID Asignatura"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Location = New System.Drawing.Point(15, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 25)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Apellidos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Location = New System.Drawing.Point(272, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(196, 25)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Nombre Asignatura"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Location = New System.Drawing.Point(272, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 25)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Nota"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Location = New System.Drawing.Point(554, 264)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 25)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Puntos"
        '
        'txtidestudiante
        '
        Me.txtidestudiante.Location = New System.Drawing.Point(17, 127)
        Me.txtidestudiante.Name = "txtidestudiante"
        Me.txtidestudiante.Size = New System.Drawing.Size(95, 20)
        Me.txtidestudiante.TabIndex = 35
        '
        'txtidasignatura
        '
        Me.txtidasignatura.Location = New System.Drawing.Point(163, 127)
        Me.txtidasignatura.Name = "txtidasignatura"
        Me.txtidasignatura.Size = New System.Drawing.Size(98, 20)
        Me.txtidasignatura.TabIndex = 36
        '
        'txtidperiodo
        '
        Me.txtidperiodo.Location = New System.Drawing.Point(324, 124)
        Me.txtidperiodo.Name = "txtidperiodo"
        Me.txtidperiodo.Size = New System.Drawing.Size(98, 20)
        Me.txtidperiodo.TabIndex = 37
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(20, 211)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(215, 20)
        Me.txtnombre.TabIndex = 38
        '
        'txtnombreasigna
        '
        Me.txtnombreasigna.Location = New System.Drawing.Point(277, 228)
        Me.txtnombreasigna.Name = "txtnombreasigna"
        Me.txtnombreasigna.Size = New System.Drawing.Size(234, 20)
        Me.txtnombreasigna.TabIndex = 39
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(559, 228)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(218, 20)
        Me.txtdescripcion.TabIndex = 40
        '
        'txtapellidos
        '
        Me.txtapellidos.Location = New System.Drawing.Point(20, 303)
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(218, 20)
        Me.txtapellidos.TabIndex = 41
        '
        'txtnota
        '
        Me.txtnota.Location = New System.Drawing.Point(277, 303)
        Me.txtnota.Name = "txtnota"
        Me.txtnota.Size = New System.Drawing.Size(110, 20)
        Me.txtnota.TabIndex = 42
        '
        'txtpuntos
        '
        Me.txtpuntos.Location = New System.Drawing.Point(559, 303)
        Me.txtpuntos.Name = "txtpuntos"
        Me.txtpuntos.Size = New System.Drawing.Size(110, 20)
        Me.txtpuntos.TabIndex = 43
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Yellow
        Me.Label11.Location = New System.Drawing.Point(455, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 25)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "IdBoleta"
        '
        'txtidboleta
        '
        Me.txtidboleta.Location = New System.Drawing.Point(460, 124)
        Me.txtidboleta.Name = "txtidboleta"
        Me.txtidboleta.Size = New System.Drawing.Size(110, 20)
        Me.txtidboleta.TabIndex = 45
        '
        'ListnotasBindingSource
        '
        Me.ListnotasBindingSource.DataMember = "listnotas"
        Me.ListnotasBindingSource.DataSource = Me.SistemaRegistroNotasDataSet15
        '
        'SistemaRegistroNotasDataSet15
        '
        Me.SistemaRegistroNotasDataSet15.DataSetName = "SistemaRegistroNotasDataSet15"
        Me.SistemaRegistroNotasDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListnotasTableAdapter
        '
        Me.ListnotasTableAdapter.ClearBeforeFill = True
        '
        'ListarNotasAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(913, 472)
        Me.Controls.Add(Me.txtidboleta)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtpuntos)
        Me.Controls.Add(Me.txtnota)
        Me.Controls.Add(Me.txtapellidos)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.txtnombreasigna)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtidperiodo)
        Me.Controls.Add(Me.txtidasignatura)
        Me.Controls.Add(Me.txtidestudiante)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.botonconsultar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ListarNotasAlumnos"
        Me.Text = "ListarNotasAlumnos"
        CType(Me.ListarnotasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaRegistroNotasDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListnotasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaRegistroNotasDataSet15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents botonconsultar As Button
    Friend WithEvents ListarnotasBindingSource As BindingSource
    Friend WithEvents SistemaRegistroNotasDataSet8 As SistemaRegistroNotasDataSet8
    Friend WithEvents ListarnotasTableAdapter As SistemaRegistroNotasDataSet8TableAdapters.listarnotasTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtidestudiante As TextBox
    Friend WithEvents txtidasignatura As TextBox
    Friend WithEvents txtidperiodo As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtnombreasigna As TextBox
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents txtapellidos As TextBox
    Friend WithEvents txtnota As TextBox
    Friend WithEvents txtpuntos As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtidboleta As TextBox
    Friend WithEvents ListnotasBindingSource As BindingSource
    Friend WithEvents SistemaRegistroNotasDataSet15 As SistemaRegistroNotasDataSet15
    Friend WithEvents ListnotasTableAdapter As SistemaRegistroNotasDataSet15TableAdapters.listnotasTableAdapter
End Class
