<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contactform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label4 = New Label()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        RadioButton7 = New RadioButton()
        RadioButton6 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(30, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 25)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(134, 42)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(162, 29)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(30, 185)
        Label2.Name = "Label2"
        Label2.Size = New Size(209, 25)
        Label2.TabIndex = 2
        Label2.Text = "How would you rate us:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(30, 302)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 25)
        Label3.TabIndex = 3
        Label3.Text = "Query/Report"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(12, 347)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(610, 218)
        TextBox2.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(30, 99)
        Label4.Name = "Label4"
        Label4.Size = New Size(135, 25)
        Label4.TabIndex = 5
        Label4.Text = "Feedback Type"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton2.Location = New Point(282, 131)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(85, 29)
        RadioButton2.TabIndex = 8
        RadioButton2.TabStop = True
        RadioButton2.Text = "Report"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton1.Location = New Point(182, 123)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(81, 29)
        RadioButton1.TabIndex = 7
        RadioButton1.TabStop = True
        RadioButton1.Text = "Query"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton7
        ' 
        RadioButton7.AutoSize = True
        RadioButton7.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton7.Location = New Point(509, 244)
        RadioButton7.Name = "RadioButton7"
        RadioButton7.Size = New Size(69, 29)
        RadioButton7.TabIndex = 11
        RadioButton7.TabStop = True
        RadioButton7.Text = "Poor"
        RadioButton7.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton6.Location = New Point(390, 244)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(99, 29)
        RadioButton6.TabIndex = 10
        RadioButton6.TabStop = True
        RadioButton6.Text = "Average"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton5.Location = New Point(282, 244)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(76, 29)
        RadioButton5.TabIndex = 9
        RadioButton5.TabStop = True
        RadioButton5.Text = "Good"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton3.Location = New Point(153, 244)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(127, 29)
        RadioButton3.TabIndex = 8
        RadioButton3.TabStop = True
        RadioButton3.Text = "Satisfactory"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton4.Location = New Point(30, 244)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(105, 29)
        RadioButton4.TabIndex = 7
        RadioButton4.TabStop = True
        RadioButton4.Text = "Excellent"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(298, 583)
        Button1.Name = "Button1"
        Button1.Size = New Size(80, 34)
        Button1.TabIndex = 10
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(410, 583)
        Button2.Name = "Button2"
        Button2.Size = New Size(89, 34)
        Button2.TabIndex = 11
        Button2.Text = "Delete"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(518, 583)
        Button3.Name = "Button3"
        Button3.Size = New Size(95, 34)
        Button3.TabIndex = 12
        Button3.Text = "Exit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(509, 312)
        Button4.Name = "Button4"
        Button4.Size = New Size(104, 29)
        Button4.TabIndex = 13
        Button4.Text = "Clear Query"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(12, 583)
        Button5.Name = "Button5"
        Button5.Size = New Size(143, 34)
        Button5.TabIndex = 14
        Button5.Text = "generate report"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Contactform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(638, 629)
        Controls.Add(Button5)
        Controls.Add(RadioButton7)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton6)
        Controls.Add(Button4)
        Controls.Add(RadioButton5)
        Controls.Add(RadioButton1)
        Controls.Add(RadioButton3)
        Controls.Add(Button3)
        Controls.Add(RadioButton4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Contactform"
        Text = "Contactform"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
