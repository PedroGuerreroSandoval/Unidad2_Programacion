<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 10F, FontStyle.Bold)
        Label1.Location = New Point(35, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 28)
        Label1.TabIndex = 0
        Label1.Text = "Datos"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 10F, FontStyle.Bold)
        Label2.Location = New Point(80, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(166, 28)
        Label2.TabIndex = 1
        Label2.Text = "Ingresa el valor"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 10F, FontStyle.Bold)
        Label3.Location = New Point(48, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(249, 28)
        Label3.TabIndex = 2
        Label3.Text = "Opciones de conversion"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveBorder
        Button1.Location = New Point(65, 177)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 3
        Button1.Text = "Fahrenheit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveBorder
        Button2.Location = New Point(285, 177)
        Button2.Name = "Button2"
        Button2.Size = New Size(129, 34)
        Button2.TabIndex = 4
        Button2.Text = "centigrados"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ActiveBorder
        Button3.Location = New Point(172, 234)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 34)
        Button3.TabIndex = 5
        Button3.Text = "Borrar"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 10F, FontStyle.Bold)
        Label4.Location = New Point(35, 271)
        Label4.Name = "Label4"
        Label4.Size = New Size(216, 28)
        Label4.TabIndex = 6
        Label4.Text = "Resultado en grados"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Black", 10F, FontStyle.Bold)
        Label5.Location = New Point(46, 331)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 28)
        Label5.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Black", 10F, FontStyle.Bold)
        Label6.Location = New Point(65, 299)
        Label6.Name = "Label6"
        Label6.Size = New Size(232, 28)
        Label6.TabIndex = 8
        Label6.Text = "Equivalente en grados"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(282, 63)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(203, 31)
        TextBox1.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(150, 347)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(203, 31)
        TextBox2.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(513, 450)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox

End Class
