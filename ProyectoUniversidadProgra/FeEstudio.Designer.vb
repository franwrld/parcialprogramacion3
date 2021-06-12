<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeEstudio
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
        Me.TxtCodFecha = New System.Windows.Forms.TextBox()
        Me.TxtFechaI = New System.Windows.Forms.TextBox()
        Me.TxtFechaF = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registrar Fechas de Estudio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha de inicio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha de Finalizacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CodigoFecha:"
        '
        'TxtCodFecha
        '
        Me.TxtCodFecha.Location = New System.Drawing.Point(268, 96)
        Me.TxtCodFecha.Name = "TxtCodFecha"
        Me.TxtCodFecha.Size = New System.Drawing.Size(264, 20)
        Me.TxtCodFecha.TabIndex = 4
        '
        'TxtFechaI
        '
        Me.TxtFechaI.Location = New System.Drawing.Point(268, 177)
        Me.TxtFechaI.Name = "TxtFechaI"
        Me.TxtFechaI.Size = New System.Drawing.Size(264, 20)
        Me.TxtFechaI.TabIndex = 5
        '
        'TxtFechaF
        '
        Me.TxtFechaF.Location = New System.Drawing.Point(268, 254)
        Me.TxtFechaF.Name = "TxtFechaF"
        Me.TxtFechaF.Size = New System.Drawing.Size(264, 20)
        Me.TxtFechaF.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(619, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 51)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FeEstudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtFechaF)
        Me.Controls.Add(Me.TxtFechaI)
        Me.Controls.Add(Me.TxtCodFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FeEstudio"
        Me.Text = "FeEstudio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCodFecha As TextBox
    Friend WithEvents TxtFechaI As TextBox
    Friend WithEvents TxtFechaF As TextBox
    Friend WithEvents Button1 As Button
End Class
