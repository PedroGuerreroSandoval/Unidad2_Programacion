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
        Label5 = New Label()
        ListBox1 = New ListBox()
        ListBox2 = New ListBox()
        ListBox3 = New ListBox()
        ListBox4 = New ListBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(213, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 32)
        Label1.TabIndex = 0
        Label1.Text = "Z=x²+ x³"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(75, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(27, 32)
        Label2.TabIndex = 1
        Label2.Text = "x"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.Location = New Point(244, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 32)
        Label3.TabIndex = 2
        Label3.Text = "x²"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.Location = New Point(419, 134)
        Label4.Name = "Label4"
        Label4.Size = New Size(37, 32)
        Label4.TabIndex = 3
        Label4.Text = "x³"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.Location = New Point(615, 134)
        Label5.Name = "Label5"
        Label5.Size = New Size(29, 32)
        Label5.TabIndex = 4
        Label5.Text = "Z"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Location = New Point(23, 169)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(139, 204)
        ListBox1.TabIndex = 5
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 25
        ListBox2.Location = New Point(190, 169)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(151, 204)
        ListBox2.TabIndex = 6
        ' 
        ' ListBox3
        ' 
        ListBox3.FormattingEnabled = True
        ListBox3.ItemHeight = 25
        ListBox3.Location = New Point(366, 169)
        ListBox3.Name = "ListBox3"
        ListBox3.Size = New Size(152, 204)
        ListBox3.TabIndex = 7
        ' 
        ' ListBox4
        ' 
        ListBox4.FormattingEnabled = True
        ListBox4.ItemHeight = 25
        ListBox4.Location = New Point(559, 169)
        ListBox4.Name = "ListBox4"
        ListBox4.Size = New Size(147, 204)
        ListBox4.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveBorder
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.Location = New Point(279, 401)
        Button1.Name = "Button1"
        Button1.Size = New Size(204, 47)
        Button1.TabIndex = 9
        Button1.Text = "Calcular valores"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 463)
        Controls.Add(Button1)
        Controls.Add(ListBox4)
        Controls.Add(ListBox3)
        Controls.Add(ListBox2)
        Controls.Add(ListBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents Button1 As Button

End Class
