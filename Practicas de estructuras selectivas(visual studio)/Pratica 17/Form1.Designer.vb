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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(61, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(336, 25)
        Label1.TabIndex = 0
        Label1.Text = "Ordenar 3 numeros de mayor a menor"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(60, 94)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(137, 31)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(260, 94)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(137, 31)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(447, 94)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(137, 31)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(61, 250)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(137, 31)
        TextBox4.TabIndex = 4
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(260, 250)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(137, 31)
        TextBox5.TabIndex = 5
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(447, 250)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(137, 31)
        TextBox6.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold)
        Label2.Location = New Point(111, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 32)
        Label2.TabIndex = 7
        Label2.Text = "A"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold)
        Label3.Location = New Point(305, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 32)
        Label3.TabIndex = 8
        Label3.Text = "B"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold)
        Label4.Location = New Point(499, 150)
        Label4.Name = "Label4"
        Label4.Size = New Size(29, 32)
        Label4.TabIndex = 9
        Label4.Text = "C"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkGray
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(75, 193)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 34)
        Button1.TabIndex = 10
        Button1.Text = "Ordenar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkGray
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(279, 193)
        Button2.Name = "Button2"
        Button2.Size = New Size(96, 34)
        Button2.TabIndex = 11
        Button2.Text = "Borrar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DarkGray
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(469, 193)
        Button3.Name = "Button3"
        Button3.Size = New Size(96, 34)
        Button3.TabIndex = 12
        Button3.Text = "Salir"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Orange
        ClientSize = New Size(681, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Ordenar de mayor a menor"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button

End Class
