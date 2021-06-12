<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seccion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSeccion = New System.Windows.Forms.TextBox()
        Me.TxtNomSeccion = New System.Windows.Forms.TextBox()
        Me.TxtAsignaturaSe = New System.Windows.Forms.TextBox()
        Me.TxtIdDocenteSe = New System.Windows.Forms.TextBox()
        Me.TxtIdCodFecha = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(287, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registar Seccion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre Seccion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "IdSeccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "IdAsignatura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "IdDocente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "CodigoFecha"
        '
        'TxtSeccion
        '
        Me.TxtSeccion.Location = New System.Drawing.Point(241, 90)
        Me.TxtSeccion.Name = "TxtSeccion"
        Me.TxtSeccion.Size = New System.Drawing.Size(268, 20)
        Me.TxtSeccion.TabIndex = 6
        '
        'TxtNomSeccion
        '
        Me.TxtNomSeccion.Location = New System.Drawing.Point(241, 149)
        Me.TxtNomSeccion.Name = "TxtNomSeccion"
        Me.TxtNomSeccion.Size = New System.Drawing.Size(268, 20)
        Me.TxtNomSeccion.TabIndex = 7
        '
        'TxtAsignaturaSe
        '
        Me.TxtAsignaturaSe.Location = New System.Drawing.Point(241, 210)
        Me.TxtAsignaturaSe.Name = "TxtAsignaturaSe"
        Me.TxtAsignaturaSe.Size = New System.Drawing.Size(268, 20)
        Me.TxtAsignaturaSe.TabIndex = 8
        '
        'TxtIdDocenteSe
        '
        Me.TxtIdDocenteSe.Location = New System.Drawing.Point(241, 266)
        Me.TxtIdDocenteSe.Name = "TxtIdDocenteSe"
        Me.TxtIdDocenteSe.Size = New System.Drawing.Size(268, 20)
        Me.TxtIdDocenteSe.TabIndex = 9
        '
        'TxtIdCodFecha
        '
        Me.TxtIdCodFecha.Location = New System.Drawing.Point(241, 323)
        Me.TxtIdCodFecha.Name = "TxtIdCodFecha"
        Me.TxtIdCodFecha.Size = New System.Drawing.Size(268, 20)
        Me.TxtIdCodFecha.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(620, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 51)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Seccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtIdCodFecha)
        Me.Controls.Add(Me.TxtIdDocenteSe)
        Me.Controls.Add(Me.TxtAsignaturaSe)
        Me.Controls.Add(Me.TxtNomSeccion)
        Me.Controls.Add(Me.TxtSeccion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Seccion"
        Me.Text = "Seccion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtSeccion As TextBox
    Friend WithEvents TxtNomSeccion As TextBox
    Friend WithEvents TxtAsignaturaSe As TextBox
    Friend WithEvents TxtIdDocenteSe As TextBox
    Friend WithEvents TxtIdCodFecha As TextBox
    Friend WithEvents Button1 As Button
End Class
