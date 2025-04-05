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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        ListBox1 = New ListBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(237, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(240, 32)
        Label1.TabIndex = 0
        Label1.Text = "Tabla de multiplicar"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 8F, FontStyle.Bold)
        Label2.Location = New Point(12, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(347, 21)
        Label2.TabIndex = 1
        Label2.Text = "Introduce el valor de la tabla de multiplicar"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 8F, FontStyle.Bold)
        Label3.Location = New Point(399, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(368, 21)
        Label3.TabIndex = 2
        Label3.Text = "Limite maximo para la tabla de multiplicacion"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(25, 124)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(121, 31)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(412, 124)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(121, 31)
        TextBox2.TabIndex = 4
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Location = New Point(211, 185)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(231, 229)
        ListBox1.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveBorder
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.Location = New Point(533, 303)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 41)
        Button1.TabIndex = 6
        Button1.Text = "Calcular"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(ListBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button

End Class
