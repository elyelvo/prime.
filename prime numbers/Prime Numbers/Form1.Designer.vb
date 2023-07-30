<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class txtresult
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        NUMBER1 = New Label()
        NUMBER2 = New Label()
        txtnum1 = New TextBox()
        txtnum2 = New TextBox()
        TextBox3 = New TextBox()
        btnprime = New Button()
        txtresults = New TextBox()
        SuspendLayout()
        ' 
        ' NUMBER1
        ' 
        NUMBER1.AutoSize = True
        NUMBER1.Location = New Point(261, 98)
        NUMBER1.Name = "NUMBER1"
        NUMBER1.Size = New Size(41, 15)
        NUMBER1.TabIndex = 0
        NUMBER1.Text = "Label1"
        ' 
        ' NUMBER2
        ' 
        NUMBER2.AutoSize = True
        NUMBER2.Location = New Point(261, 150)
        NUMBER2.Name = "NUMBER2"
        NUMBER2.Size = New Size(41, 15)
        NUMBER2.TabIndex = 1
        NUMBER2.Text = "Label2"
        ' 
        ' txtnum1
        ' 
        txtnum1.Location = New Point(365, 90)
        txtnum1.Name = "txtnum1"
        txtnum1.Size = New Size(100, 23)
        txtnum1.TabIndex = 2
        ' 
        ' txtnum2
        ' 
        txtnum2.Location = New Point(365, 150)
        txtnum2.Name = "txtnum2"
        txtnum2.Size = New Size(100, 23)
        txtnum2.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.Location = New Point(274, 12)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(191, 32)
        TextBox3.TabIndex = 4
        TextBox3.Text = "PRIME NUMBERS"
        ' 
        ' btnprime
        ' 
        btnprime.Location = New Point(236, 233)
        btnprime.Name = "btnprime"
        btnprime.Size = New Size(75, 23)
        btnprime.TabIndex = 5
        btnprime.Text = "prime "
        btnprime.UseVisualStyleBackColor = True
        ' 
        ' txtresults
        ' 
        txtresults.Location = New Point(386, 233)
        txtresults.Name = "txtresults"
        txtresults.Size = New Size(252, 23)
        txtresults.TabIndex = 6
        ' 
        ' txtresult
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtresults)
        Controls.Add(btnprime)
        Controls.Add(TextBox3)
        Controls.Add(txtnum2)
        Controls.Add(txtnum1)
        Controls.Add(NUMBER2)
        Controls.Add(NUMBER1)
        Name = "txtresult"
        Text = "PRIME "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NUMBER1 As Label
    Friend WithEvents NUMBER2 As Label
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btnprime As Button
    Friend WithEvents txtresults As TextBox
End Class
