<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class switchOptions
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
        Me.AddAPIBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddAPIBtn
        '
        Me.AddAPIBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddAPIBtn.Location = New System.Drawing.Point(12, 12)
        Me.AddAPIBtn.Name = "AddAPIBtn"
        Me.AddAPIBtn.Size = New System.Drawing.Size(260, 23)
        Me.AddAPIBtn.TabIndex = 0
        Me.AddAPIBtn.Text = "Add Data To A Masterfile (Department Profile)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.AddAPIBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(12, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add To And Delete From A Data Storage"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'switchOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 93)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AddAPIBtn)
        Me.MinimumSize = New System.Drawing.Size(300, 132)
        Me.Name = "switchOptions"
        Me.Text = "Select Sample API "
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AddAPIBtn As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
