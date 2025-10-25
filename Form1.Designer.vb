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
        res = New Label()
        Txt1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        Label1.Location = New Point(182, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(412, 42)
        Label1.TabIndex = 0
        Label1.Text = "Convertisseur en DINAR"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Small", 18F, FontStyle.Bold)
        Label2.Location = New Point(55, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(242, 35)
        Label2.TabIndex = 1
        Label2.Text = "Montant en EURO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Small", 18F, FontStyle.Bold)
        Label3.Location = New Point(42, 223)
        Label3.Name = "Label3"
        Label3.Size = New Size(255, 35)
        Label3.TabIndex = 2
        Label3.Text = "Montant en DINAR"
        ' 
        ' res
        ' 
        res.AutoSize = True
        res.Font = New Font("Sitka Small", 18F, FontStyle.Bold)
        res.Location = New Point(319, 223)
        res.Name = "res"
        res.Size = New Size(0, 35)
        res.TabIndex = 3
        ' 
        ' Txt1
        ' 
        Txt1.Font = New Font("Sitka Small", 18F, FontStyle.Bold)
        Txt1.Location = New Point(318, 131)
        Txt1.Name = "Txt1"
        Txt1.Size = New Size(114, 37)
        Txt1.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Sitka Small", 18F, FontStyle.Bold)
        Button1.Location = New Point(520, 131)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 56)
        Button1.TabIndex = 5
        Button1.Text = "Convertir"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Sitka Small", 18F, FontStyle.Bold)
        Button2.Location = New Point(520, 223)
        Button2.Name = "Button2"
        Button2.Size = New Size(153, 54)
        Button2.TabIndex = 6
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Txt1)
        Controls.Add(res)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        ForeColor = Color.Chocolate
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents res As Label
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
