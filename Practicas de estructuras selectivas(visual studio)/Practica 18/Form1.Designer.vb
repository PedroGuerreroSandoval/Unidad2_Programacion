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
        Label4 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(801, 25)
        Label1.TabIndex = 0
        Label1.Text = "Diagrama que pida los 3 lados de un triangulo y que diga si es equilatero, isoceles o escaleno" & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(37, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(198, 32)
        Label2.TabIndex = 1
        Label2.Text = "Longitud lado A"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(37, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(196, 32)
        Label3.TabIndex = 2
        Label3.Text = "Longitud lado B"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(37, 204)
        Label4.Name = "Label4"
        Label4.Size = New Size(196, 32)
        Label4.TabIndex = 3
        Label4.Text = "Longitud lado C"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveBorder
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(27, 276)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 39)
        Button1.TabIndex = 4
        Button1.Text = "Desicion"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveBorder
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(214, 276)
        Button2.Name = "Button2"
        Button2.Size = New Size(151, 39)
        Button2.TabIndex = 5
        Button2.Text = "Borrar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ActiveBorder
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(411, 276)
        Button3.Name = "Button3"
        Button3.Size = New Size(151, 39)
        Button3.TabIndex = 6
        Button3.Text = "Salir"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(39, 362)
        Label5.Name = "Label5"
        Label5.Size = New Size(178, 32)
        Label5.TabIndex = 7
        Label5.Text = "Tipo triangulo"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(250, 93)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(175, 31)
        TextBox1.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(250, 153)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(175, 31)
        TextBox2.TabIndex = 9
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(250, 205)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(175, 31)
        TextBox3.TabIndex = 10
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(250, 362)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(175, 31)
        TextBox4.TabIndex = 11
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.TRabajo_17
        PictureBox1.Location = New Point(496, 70)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(263, 185)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(831, 450)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents PictureBox1 As PictureBox

End Class
