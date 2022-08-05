<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnNegro = New System.Windows.Forms.Button()
        Me.btnRojo = New System.Windows.Forms.Button()
        Me.btnAzul = New System.Windows.Forms.Button()
        Me.BtnAmarillo = New System.Windows.Forms.Button()
        Me.txtcolores = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnNegro
        '
        Me.btnNegro.Location = New System.Drawing.Point(71, 201)
        Me.btnNegro.Name = "btnNegro"
        Me.btnNegro.Size = New System.Drawing.Size(75, 23)
        Me.btnNegro.TabIndex = 0
        Me.btnNegro.Text = "NEGRO"
        Me.btnNegro.UseVisualStyleBackColor = True
        '
        'btnRojo
        '
        Me.btnRojo.Location = New System.Drawing.Point(71, 76)
        Me.btnRojo.Name = "btnRojo"
        Me.btnRojo.Size = New System.Drawing.Size(75, 23)
        Me.btnRojo.TabIndex = 1
        Me.btnRojo.Text = "ROJO"
        Me.btnRojo.UseVisualStyleBackColor = True
        '
        'btnAzul
        '
        Me.btnAzul.Location = New System.Drawing.Point(71, 266)
        Me.btnAzul.Name = "btnAzul"
        Me.btnAzul.Size = New System.Drawing.Size(75, 23)
        Me.btnAzul.TabIndex = 2
        Me.btnAzul.Text = "AZUL"
        Me.btnAzul.UseVisualStyleBackColor = True
        '
        'BtnAmarillo
        '
        Me.BtnAmarillo.Location = New System.Drawing.Point(71, 138)
        Me.BtnAmarillo.Name = "BtnAmarillo"
        Me.BtnAmarillo.Size = New System.Drawing.Size(75, 23)
        Me.BtnAmarillo.TabIndex = 3
        Me.BtnAmarillo.Text = "AMARILLO"
        Me.BtnAmarillo.UseVisualStyleBackColor = True
        '
        'txtcolores
        '
        Me.txtcolores.Location = New System.Drawing.Point(223, 76)
        Me.txtcolores.Multiline = True
        Me.txtcolores.Name = "txtcolores"
        Me.txtcolores.Size = New System.Drawing.Size(306, 213)
        Me.txtcolores.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 333)
        Me.Controls.Add(Me.txtcolores)
        Me.Controls.Add(Me.BtnAmarillo)
        Me.Controls.Add(Me.btnAzul)
        Me.Controls.Add(Me.btnRojo)
        Me.Controls.Add(Me.btnNegro)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNegro As Button
    Friend WithEvents btnRojo As Button
    Friend WithEvents btnAzul As Button
    Friend WithEvents BtnAmarillo As Button
    Friend WithEvents txtcolores As TextBox
End Class
