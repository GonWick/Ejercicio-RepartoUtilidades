<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Utilidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Utilidades))
        Me.GroupBoxDatos = New System.Windows.Forms.GroupBox()
        Me.GroupBoxUtilidad = New System.Windows.Forms.GroupBox()
        Me.LabelUtilidad = New System.Windows.Forms.Label()
        Me.LabelSalario = New System.Windows.Forms.Label()
        Me.LabelAntiguedad = New System.Windows.Forms.Label()
        Me.TextBoxSalario = New System.Windows.Forms.TextBox()
        Me.TextBoxAntiguedad = New System.Windows.Forms.TextBox()
        Me.TextBoxUtilidad = New System.Windows.Forms.TextBox()
        Me.ButtonNuevo = New System.Windows.Forms.Button()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelAños = New System.Windows.Forms.Label()
        Me.LabelEuroSalario = New System.Windows.Forms.Label()
        Me.LabelEuroUtilidad = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.GroupBoxDatos.SuspendLayout()
        Me.GroupBoxUtilidad.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxDatos
        '
        Me.GroupBoxDatos.Controls.Add(Me.LabelEuroSalario)
        Me.GroupBoxDatos.Controls.Add(Me.LabelAños)
        Me.GroupBoxDatos.Controls.Add(Me.TextBoxAntiguedad)
        Me.GroupBoxDatos.Controls.Add(Me.TextBoxSalario)
        Me.GroupBoxDatos.Controls.Add(Me.LabelAntiguedad)
        Me.GroupBoxDatos.Controls.Add(Me.LabelSalario)
        Me.GroupBoxDatos.Location = New System.Drawing.Point(12, 41)
        Me.GroupBoxDatos.Name = "GroupBoxDatos"
        Me.GroupBoxDatos.Size = New System.Drawing.Size(258, 141)
        Me.GroupBoxDatos.TabIndex = 0
        Me.GroupBoxDatos.TabStop = False
        Me.GroupBoxDatos.Text = "DATOS INGRESADOS"
        '
        'GroupBoxUtilidad
        '
        Me.GroupBoxUtilidad.Controls.Add(Me.LabelEuroUtilidad)
        Me.GroupBoxUtilidad.Controls.Add(Me.TextBoxUtilidad)
        Me.GroupBoxUtilidad.Controls.Add(Me.LabelUtilidad)
        Me.GroupBoxUtilidad.Location = New System.Drawing.Point(276, 41)
        Me.GroupBoxUtilidad.Name = "GroupBoxUtilidad"
        Me.GroupBoxUtilidad.Size = New System.Drawing.Size(258, 110)
        Me.GroupBoxUtilidad.TabIndex = 1
        Me.GroupBoxUtilidad.TabStop = False
        Me.GroupBoxUtilidad.Text = "RESULTADO"
        '
        'LabelUtilidad
        '
        Me.LabelUtilidad.AutoSize = True
        Me.LabelUtilidad.Location = New System.Drawing.Point(22, 58)
        Me.LabelUtilidad.Name = "LabelUtilidad"
        Me.LabelUtilidad.Size = New System.Drawing.Size(57, 13)
        Me.LabelUtilidad.TabIndex = 0
        Me.LabelUtilidad.Text = "UTILIDAD"
        '
        'LabelSalario
        '
        Me.LabelSalario.AutoSize = True
        Me.LabelSalario.Location = New System.Drawing.Point(23, 58)
        Me.LabelSalario.Name = "LabelSalario"
        Me.LabelSalario.Size = New System.Drawing.Size(53, 13)
        Me.LabelSalario.TabIndex = 0
        Me.LabelSalario.Text = "SALARIO"
        '
        'LabelAntiguedad
        '
        Me.LabelAntiguedad.AutoSize = True
        Me.LabelAntiguedad.Location = New System.Drawing.Point(23, 97)
        Me.LabelAntiguedad.Name = "LabelAntiguedad"
        Me.LabelAntiguedad.Size = New System.Drawing.Size(78, 13)
        Me.LabelAntiguedad.TabIndex = 1
        Me.LabelAntiguedad.Text = "ANTIGUEDAD"
        '
        'TextBoxSalario
        '
        Me.TextBoxSalario.Location = New System.Drawing.Point(107, 55)
        Me.TextBoxSalario.Name = "TextBoxSalario"
        Me.TextBoxSalario.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSalario.TabIndex = 2
        '
        'TextBoxAntiguedad
        '
        Me.TextBoxAntiguedad.Location = New System.Drawing.Point(107, 94)
        Me.TextBoxAntiguedad.Name = "TextBoxAntiguedad"
        Me.TextBoxAntiguedad.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAntiguedad.TabIndex = 3
        '
        'TextBoxUtilidad
        '
        Me.TextBoxUtilidad.Location = New System.Drawing.Point(105, 55)
        Me.TextBoxUtilidad.Name = "TextBoxUtilidad"
        Me.TextBoxUtilidad.Size = New System.Drawing.Size(92, 20)
        Me.TextBoxUtilidad.TabIndex = 1
        '
        'ButtonNuevo
        '
        Me.ButtonNuevo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonNuevo.Image = CType(resources.GetObject("ButtonNuevo.Image"), System.Drawing.Image)
        Me.ButtonNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNuevo.Location = New System.Drawing.Point(12, 12)
        Me.ButtonNuevo.Name = "ButtonNuevo"
        Me.ButtonNuevo.Size = New System.Drawing.Size(258, 23)
        Me.ButtonNuevo.TabIndex = 2
        Me.ButtonNuevo.Text = "Nuevo"
        Me.ButtonNuevo.UseVisualStyleBackColor = False
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCalcular.Image = CType(resources.GetObject("ButtonCalcular.Image"), System.Drawing.Image)
        Me.ButtonCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCalcular.Location = New System.Drawing.Point(276, 159)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(258, 23)
        Me.ButtonCalcular.TabIndex = 3
        Me.ButtonCalcular.Text = "Calcular"
        Me.ButtonCalcular.UseVisualStyleBackColor = False
        '
        'ButtonSalir
        '
        Me.ButtonSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonSalir.Image = CType(resources.GetObject("ButtonSalir.Image"), System.Drawing.Image)
        Me.ButtonSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSalir.Location = New System.Drawing.Point(12, 310)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(522, 23)
        Me.ButtonSalir.TabIndex = 4
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 188)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(522, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'LabelAños
        '
        Me.LabelAños.AutoSize = True
        Me.LabelAños.Location = New System.Drawing.Point(213, 97)
        Me.LabelAños.Name = "LabelAños"
        Me.LabelAños.Size = New System.Drawing.Size(31, 13)
        Me.LabelAños.TabIndex = 4
        Me.LabelAños.Text = "Años"
        '
        'LabelEuroSalario
        '
        Me.LabelEuroSalario.AutoSize = True
        Me.LabelEuroSalario.Location = New System.Drawing.Point(213, 58)
        Me.LabelEuroSalario.Name = "LabelEuroSalario"
        Me.LabelEuroSalario.Size = New System.Drawing.Size(13, 13)
        Me.LabelEuroSalario.TabIndex = 5
        Me.LabelEuroSalario.Text = "€"
        '
        'LabelEuroUtilidad
        '
        Me.LabelEuroUtilidad.AutoSize = True
        Me.LabelEuroUtilidad.Location = New System.Drawing.Point(203, 58)
        Me.LabelEuroUtilidad.Name = "LabelEuroUtilidad"
        Me.LabelEuroUtilidad.Size = New System.Drawing.Size(13, 13)
        Me.LabelEuroUtilidad.TabIndex = 2
        Me.LabelEuroUtilidad.Text = "€"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(288, 17)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(0, 13)
        Me.LabelTotal.TabIndex = 6
        Me.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Utilidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 345)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonCalcular)
        Me.Controls.Add(Me.ButtonNuevo)
        Me.Controls.Add(Me.GroupBoxUtilidad)
        Me.Controls.Add(Me.GroupBoxDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Utilidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPARTO DE UTILIDADES"
        Me.GroupBoxDatos.ResumeLayout(False)
        Me.GroupBoxDatos.PerformLayout()
        Me.GroupBoxUtilidad.ResumeLayout(False)
        Me.GroupBoxUtilidad.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxDatos As GroupBox
    Friend WithEvents TextBoxAntiguedad As TextBox
    Friend WithEvents TextBoxSalario As TextBox
    Friend WithEvents LabelAntiguedad As Label
    Friend WithEvents LabelSalario As Label
    Friend WithEvents GroupBoxUtilidad As GroupBox
    Friend WithEvents TextBoxUtilidad As TextBox
    Friend WithEvents LabelUtilidad As Label
    Friend WithEvents ButtonNuevo As Button
    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelEuroSalario As Label
    Friend WithEvents LabelAños As Label
    Friend WithEvents LabelEuroUtilidad As Label
    Friend WithEvents LabelTotal As Label
End Class
