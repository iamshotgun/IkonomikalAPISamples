<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class saveNewData
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
        Me.depCodeFld = New System.Windows.Forms.TextBox()
        Me.depCodeLbl = New System.Windows.Forms.Label()
        Me.depDescLbl = New System.Windows.Forms.Label()
        Me.depDescFld = New System.Windows.Forms.TextBox()
        Me.othDescLbl = New System.Windows.Forms.Label()
        Me.othDescFld = New System.Windows.Forms.TextBox()
        Me.expTypFld = New System.Windows.Forms.ComboBox()
        Me.expTypLbl = New System.Windows.Forms.Label()
        Me.Step3Btn = New System.Windows.Forms.Button()
        Me.Step2Btn = New System.Windows.Forms.Button()
        Me.Step2RspFld = New System.Windows.Forms.TextBox()
        Me.Step3RspFld = New System.Windows.Forms.TextBox()
        Me.Step2ReqFld = New System.Windows.Forms.TextBox()
        Me.Step3ReqFld = New System.Windows.Forms.TextBox()
        Me.Step2ReqLbl = New System.Windows.Forms.Label()
        Me.Step2RspLbl = New System.Windows.Forms.Label()
        Me.Step3RspLbl = New System.Windows.Forms.Label()
        Me.Step3ReqLbl = New System.Windows.Forms.Label()
        Me.emailPasswordLbl = New System.Windows.Forms.Label()
        Me.emailPasswordFld = New System.Windows.Forms.TextBox()
        Me.emailIDLbl = New System.Windows.Forms.Label()
        Me.emailIDFld = New System.Windows.Forms.TextBox()
        Me.Step1RspLbl = New System.Windows.Forms.Label()
        Me.Step1ReqLbl = New System.Windows.Forms.Label()
        Me.Step1ReqFld = New System.Windows.Forms.TextBox()
        Me.Step1RspFld = New System.Windows.Forms.TextBox()
        Me.Step1Btn = New System.Windows.Forms.Button()
        Me.sessIDLbl = New System.Windows.Forms.Label()
        Me.sessIDFld = New System.Windows.Forms.TextBox()
        Me.profileTitleLbl = New System.Windows.Forms.Label()
        Me.intGIDLbl = New System.Windows.Forms.Label()
        Me.intGIDFld = New System.Windows.Forms.TextBox()
        Me.subsIDLbl = New System.Windows.Forms.Label()
        Me.subsIDFld = New System.Windows.Forms.TextBox()
        Me.ikonomikalAddLbl = New System.Windows.Forms.Label()
        Me.ikonomikalAddFld = New System.Windows.Forms.TextBox()
        Me.makeSureAPIIsEnabledLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'depCodeFld
        '
        Me.depCodeFld.Location = New System.Drawing.Point(118, 298)
        Me.depCodeFld.Name = "depCodeFld"
        Me.depCodeFld.Size = New System.Drawing.Size(411, 20)
        Me.depCodeFld.TabIndex = 10
        '
        'depCodeLbl
        '
        Me.depCodeLbl.Location = New System.Drawing.Point(18, 298)
        Me.depCodeLbl.Name = "depCodeLbl"
        Me.depCodeLbl.Size = New System.Drawing.Size(94, 20)
        Me.depCodeLbl.TabIndex = 0
        Me.depCodeLbl.Text = "Code"
        '
        'depDescLbl
        '
        Me.depDescLbl.Location = New System.Drawing.Point(18, 324)
        Me.depDescLbl.Name = "depDescLbl"
        Me.depDescLbl.Size = New System.Drawing.Size(94, 20)
        Me.depDescLbl.TabIndex = 0
        Me.depDescLbl.Text = "Description"
        '
        'depDescFld
        '
        Me.depDescFld.Location = New System.Drawing.Point(118, 324)
        Me.depDescFld.Name = "depDescFld"
        Me.depDescFld.Size = New System.Drawing.Size(411, 20)
        Me.depDescFld.TabIndex = 11
        '
        'othDescLbl
        '
        Me.othDescLbl.Location = New System.Drawing.Point(18, 350)
        Me.othDescLbl.Name = "othDescLbl"
        Me.othDescLbl.Size = New System.Drawing.Size(94, 20)
        Me.othDescLbl.TabIndex = 0
        Me.othDescLbl.Text = "Other Description"
        '
        'othDescFld
        '
        Me.othDescFld.Location = New System.Drawing.Point(118, 350)
        Me.othDescFld.Name = "othDescFld"
        Me.othDescFld.Size = New System.Drawing.Size(411, 20)
        Me.othDescFld.TabIndex = 12
        '
        'expTypFld
        '
        Me.expTypFld.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.expTypFld.FormattingEnabled = True
        Me.expTypFld.Items.AddRange(New Object() {"Operating Expenses", "Non-Operating Expenses"})
        Me.expTypFld.Location = New System.Drawing.Point(118, 376)
        Me.expTypFld.Name = "expTypFld"
        Me.expTypFld.Size = New System.Drawing.Size(411, 21)
        Me.expTypFld.TabIndex = 13
        '
        'expTypLbl
        '
        Me.expTypLbl.Location = New System.Drawing.Point(18, 377)
        Me.expTypLbl.Name = "expTypLbl"
        Me.expTypLbl.Size = New System.Drawing.Size(94, 20)
        Me.expTypLbl.TabIndex = 0
        Me.expTypLbl.Text = "Expense Type"
        '
        'Step3Btn
        '
        Me.Step3Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Step3Btn.Location = New System.Drawing.Point(21, 522)
        Me.Step3Btn.Name = "Step3Btn"
        Me.Step3Btn.Size = New System.Drawing.Size(508, 23)
        Me.Step3Btn.TabIndex = 16
        Me.Step3Btn.Text = "Step 3: Execute ADD"
        Me.Step3Btn.UseVisualStyleBackColor = True
        '
        'Step2Btn
        '
        Me.Step2Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Step2Btn.Location = New System.Drawing.Point(21, 403)
        Me.Step2Btn.Name = "Step2Btn"
        Me.Step2Btn.Size = New System.Drawing.Size(508, 23)
        Me.Step2Btn.TabIndex = 14
        Me.Step2Btn.Text = "Step 2: Get ADD Token"
        Me.Step2Btn.UseVisualStyleBackColor = True
        '
        'Step2RspFld
        '
        Me.Step2RspFld.Location = New System.Drawing.Point(278, 446)
        Me.Step2RspFld.Multiline = True
        Me.Step2RspFld.Name = "Step2RspFld"
        Me.Step2RspFld.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Step2RspFld.Size = New System.Drawing.Size(251, 70)
        Me.Step2RspFld.TabIndex = 16
        '
        'Step3RspFld
        '
        Me.Step3RspFld.Location = New System.Drawing.Point(278, 565)
        Me.Step3RspFld.Multiline = True
        Me.Step3RspFld.Name = "Step3RspFld"
        Me.Step3RspFld.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Step3RspFld.Size = New System.Drawing.Size(251, 70)
        Me.Step3RspFld.TabIndex = 18
        '
        'Step2ReqFld
        '
        Me.Step2ReqFld.Location = New System.Drawing.Point(21, 446)
        Me.Step2ReqFld.Multiline = True
        Me.Step2ReqFld.Name = "Step2ReqFld"
        Me.Step2ReqFld.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Step2ReqFld.Size = New System.Drawing.Size(251, 70)
        Me.Step2ReqFld.TabIndex = 15
        '
        'Step3ReqFld
        '
        Me.Step3ReqFld.Location = New System.Drawing.Point(21, 565)
        Me.Step3ReqFld.Multiline = True
        Me.Step3ReqFld.Name = "Step3ReqFld"
        Me.Step3ReqFld.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Step3ReqFld.Size = New System.Drawing.Size(251, 70)
        Me.Step3ReqFld.TabIndex = 17
        '
        'Step2ReqLbl
        '
        Me.Step2ReqLbl.Location = New System.Drawing.Point(21, 429)
        Me.Step2ReqLbl.Name = "Step2ReqLbl"
        Me.Step2ReqLbl.Size = New System.Drawing.Size(251, 14)
        Me.Step2ReqLbl.TabIndex = 0
        Me.Step2ReqLbl.Text = "Request Data"
        '
        'Step2RspLbl
        '
        Me.Step2RspLbl.Location = New System.Drawing.Point(278, 429)
        Me.Step2RspLbl.Name = "Step2RspLbl"
        Me.Step2RspLbl.Size = New System.Drawing.Size(251, 14)
        Me.Step2RspLbl.TabIndex = 0
        Me.Step2RspLbl.Text = "Response Data"
        '
        'Step3RspLbl
        '
        Me.Step3RspLbl.Location = New System.Drawing.Point(278, 548)
        Me.Step3RspLbl.Name = "Step3RspLbl"
        Me.Step3RspLbl.Size = New System.Drawing.Size(251, 14)
        Me.Step3RspLbl.TabIndex = 0
        Me.Step3RspLbl.Text = "Response Data"
        '
        'Step3ReqLbl
        '
        Me.Step3ReqLbl.Location = New System.Drawing.Point(21, 548)
        Me.Step3ReqLbl.Name = "Step3ReqLbl"
        Me.Step3ReqLbl.Size = New System.Drawing.Size(251, 14)
        Me.Step3ReqLbl.TabIndex = 0
        Me.Step3ReqLbl.Text = "Request Data"
        '
        'emailPasswordLbl
        '
        Me.emailPasswordLbl.Location = New System.Drawing.Point(18, 82)
        Me.emailPasswordLbl.Name = "emailPasswordLbl"
        Me.emailPasswordLbl.Size = New System.Drawing.Size(94, 20)
        Me.emailPasswordLbl.TabIndex = 0
        Me.emailPasswordLbl.Text = "Password"
        '
        'emailPasswordFld
        '
        Me.emailPasswordFld.Location = New System.Drawing.Point(118, 82)
        Me.emailPasswordFld.Name = "emailPasswordFld"
        Me.emailPasswordFld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.emailPasswordFld.Size = New System.Drawing.Size(411, 20)
        Me.emailPasswordFld.TabIndex = 3
        '
        'emailIDLbl
        '
        Me.emailIDLbl.Location = New System.Drawing.Point(18, 56)
        Me.emailIDLbl.Name = "emailIDLbl"
        Me.emailIDLbl.Size = New System.Drawing.Size(94, 20)
        Me.emailIDLbl.TabIndex = 0
        Me.emailIDLbl.Text = "Email ID"
        '
        'emailIDFld
        '
        Me.emailIDFld.Location = New System.Drawing.Point(118, 56)
        Me.emailIDFld.Name = "emailIDFld"
        Me.emailIDFld.Size = New System.Drawing.Size(411, 20)
        Me.emailIDFld.TabIndex = 2
        '
        'Step1RspLbl
        '
        Me.Step1RspLbl.Location = New System.Drawing.Point(278, 134)
        Me.Step1RspLbl.Name = "Step1RspLbl"
        Me.Step1RspLbl.Size = New System.Drawing.Size(251, 14)
        Me.Step1RspLbl.TabIndex = 0
        Me.Step1RspLbl.Text = "Response Data"
        '
        'Step1ReqLbl
        '
        Me.Step1ReqLbl.Location = New System.Drawing.Point(21, 134)
        Me.Step1ReqLbl.Name = "Step1ReqLbl"
        Me.Step1ReqLbl.Size = New System.Drawing.Size(251, 14)
        Me.Step1ReqLbl.TabIndex = 0
        Me.Step1ReqLbl.Text = "Request Data"
        '
        'Step1ReqFld
        '
        Me.Step1ReqFld.Location = New System.Drawing.Point(21, 151)
        Me.Step1ReqFld.Multiline = True
        Me.Step1ReqFld.Name = "Step1ReqFld"
        Me.Step1ReqFld.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Step1ReqFld.Size = New System.Drawing.Size(251, 70)
        Me.Step1ReqFld.TabIndex = 5
        '
        'Step1RspFld
        '
        Me.Step1RspFld.Location = New System.Drawing.Point(278, 151)
        Me.Step1RspFld.Multiline = True
        Me.Step1RspFld.Name = "Step1RspFld"
        Me.Step1RspFld.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Step1RspFld.Size = New System.Drawing.Size(251, 70)
        Me.Step1RspFld.TabIndex = 6
        '
        'Step1Btn
        '
        Me.Step1Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Step1Btn.Location = New System.Drawing.Point(21, 108)
        Me.Step1Btn.Name = "Step1Btn"
        Me.Step1Btn.Size = New System.Drawing.Size(508, 23)
        Me.Step1Btn.TabIndex = 4
        Me.Step1Btn.Text = "Step 1: Login"
        Me.Step1Btn.UseVisualStyleBackColor = True
        '
        'sessIDLbl
        '
        Me.sessIDLbl.Location = New System.Drawing.Point(278, 225)
        Me.sessIDLbl.Name = "sessIDLbl"
        Me.sessIDLbl.Size = New System.Drawing.Size(94, 20)
        Me.sessIDLbl.TabIndex = 0
        Me.sessIDLbl.Text = "Session ID"
        '
        'sessIDFld
        '
        Me.sessIDFld.Location = New System.Drawing.Point(375, 225)
        Me.sessIDFld.Name = "sessIDFld"
        Me.sessIDFld.Size = New System.Drawing.Size(154, 20)
        Me.sessIDFld.TabIndex = 8
        '
        'profileTitleLbl
        '
        Me.profileTitleLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profileTitleLbl.Location = New System.Drawing.Point(18, 248)
        Me.profileTitleLbl.Name = "profileTitleLbl"
        Me.profileTitleLbl.Size = New System.Drawing.Size(511, 20)
        Me.profileTitleLbl.TabIndex = 0
        Me.profileTitleLbl.Text = "Department Profile"
        Me.profileTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'intGIDLbl
        '
        Me.intGIDLbl.Location = New System.Drawing.Point(21, 225)
        Me.intGIDLbl.Name = "intGIDLbl"
        Me.intGIDLbl.Size = New System.Drawing.Size(94, 20)
        Me.intGIDLbl.TabIndex = 0
        Me.intGIDLbl.Text = "Ikonomikal ID"
        '
        'intGIDFld
        '
        Me.intGIDFld.Location = New System.Drawing.Point(118, 225)
        Me.intGIDFld.Name = "intGIDFld"
        Me.intGIDFld.Size = New System.Drawing.Size(154, 20)
        Me.intGIDFld.TabIndex = 7
        '
        'subsIDLbl
        '
        Me.subsIDLbl.Location = New System.Drawing.Point(18, 272)
        Me.subsIDLbl.Name = "subsIDLbl"
        Me.subsIDLbl.Size = New System.Drawing.Size(94, 20)
        Me.subsIDLbl.TabIndex = 0
        Me.subsIDLbl.Text = "Company ID"
        '
        'subsIDFld
        '
        Me.subsIDFld.Location = New System.Drawing.Point(118, 272)
        Me.subsIDFld.Name = "subsIDFld"
        Me.subsIDFld.Size = New System.Drawing.Size(411, 20)
        Me.subsIDFld.TabIndex = 9
        Me.subsIDFld.Text = "2000001"
        '
        'ikonomikalAddLbl
        '
        Me.ikonomikalAddLbl.Location = New System.Drawing.Point(18, 9)
        Me.ikonomikalAddLbl.Name = "ikonomikalAddLbl"
        Me.ikonomikalAddLbl.Size = New System.Drawing.Size(94, 20)
        Me.ikonomikalAddLbl.TabIndex = 0
        Me.ikonomikalAddLbl.Text = "API Address"
        '
        'ikonomikalAddFld
        '
        Me.ikonomikalAddFld.Location = New System.Drawing.Point(118, 9)
        Me.ikonomikalAddFld.Name = "ikonomikalAddFld"
        Me.ikonomikalAddFld.Size = New System.Drawing.Size(411, 20)
        Me.ikonomikalAddFld.TabIndex = 1
        Me.ikonomikalAddFld.Text = "https://www.ikonomikal.com"
        '
        'makeSureAPIIsEnabledLbl
        '
        Me.makeSureAPIIsEnabledLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.makeSureAPIIsEnabledLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.makeSureAPIIsEnabledLbl.Location = New System.Drawing.Point(21, 32)
        Me.makeSureAPIIsEnabledLbl.Name = "makeSureAPIIsEnabledLbl"
        Me.makeSureAPIIsEnabledLbl.Size = New System.Drawing.Size(508, 20)
        Me.makeSureAPIIsEnabledLbl.TabIndex = 36
        Me.makeSureAPIIsEnabledLbl.Text = "API must be enabled from the User Home Page"
        Me.makeSureAPIIsEnabledLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'saveNewData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(550, 647)
        Me.Controls.Add(Me.makeSureAPIIsEnabledLbl)
        Me.Controls.Add(Me.ikonomikalAddLbl)
        Me.Controls.Add(Me.ikonomikalAddFld)
        Me.Controls.Add(Me.subsIDLbl)
        Me.Controls.Add(Me.subsIDFld)
        Me.Controls.Add(Me.intGIDLbl)
        Me.Controls.Add(Me.intGIDFld)
        Me.Controls.Add(Me.profileTitleLbl)
        Me.Controls.Add(Me.sessIDLbl)
        Me.Controls.Add(Me.sessIDFld)
        Me.Controls.Add(Me.Step1RspLbl)
        Me.Controls.Add(Me.Step1ReqLbl)
        Me.Controls.Add(Me.Step1ReqFld)
        Me.Controls.Add(Me.Step1RspFld)
        Me.Controls.Add(Me.Step1Btn)
        Me.Controls.Add(Me.emailPasswordLbl)
        Me.Controls.Add(Me.emailPasswordFld)
        Me.Controls.Add(Me.emailIDLbl)
        Me.Controls.Add(Me.emailIDFld)
        Me.Controls.Add(Me.Step3RspLbl)
        Me.Controls.Add(Me.Step3ReqLbl)
        Me.Controls.Add(Me.Step2RspLbl)
        Me.Controls.Add(Me.Step2ReqLbl)
        Me.Controls.Add(Me.Step3ReqFld)
        Me.Controls.Add(Me.Step2ReqFld)
        Me.Controls.Add(Me.Step3RspFld)
        Me.Controls.Add(Me.Step2RspFld)
        Me.Controls.Add(Me.Step2Btn)
        Me.Controls.Add(Me.Step3Btn)
        Me.Controls.Add(Me.expTypLbl)
        Me.Controls.Add(Me.expTypFld)
        Me.Controls.Add(Me.othDescLbl)
        Me.Controls.Add(Me.othDescFld)
        Me.Controls.Add(Me.depDescLbl)
        Me.Controls.Add(Me.depDescFld)
        Me.Controls.Add(Me.depCodeLbl)
        Me.Controls.Add(Me.depCodeFld)
        Me.Name = "saveNewData"
        Me.Text = "Adding Department Profile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents depCodeFld As System.Windows.Forms.TextBox
    Friend WithEvents depCodeLbl As System.Windows.Forms.Label
    Friend WithEvents depDescLbl As System.Windows.Forms.Label
    Friend WithEvents depDescFld As System.Windows.Forms.TextBox
    Friend WithEvents othDescLbl As System.Windows.Forms.Label
    Friend WithEvents othDescFld As System.Windows.Forms.TextBox
    Friend WithEvents expTypFld As System.Windows.Forms.ComboBox
    Friend WithEvents expTypLbl As System.Windows.Forms.Label
    Friend WithEvents Step3Btn As System.Windows.Forms.Button
    Friend WithEvents Step2Btn As System.Windows.Forms.Button
    Friend WithEvents Step2RspFld As System.Windows.Forms.TextBox
    Friend WithEvents Step3RspFld As System.Windows.Forms.TextBox
    Friend WithEvents Step2ReqFld As System.Windows.Forms.TextBox
    Friend WithEvents Step3ReqFld As System.Windows.Forms.TextBox
    Friend WithEvents Step2ReqLbl As System.Windows.Forms.Label
    Friend WithEvents Step2RspLbl As System.Windows.Forms.Label
    Friend WithEvents Step3RspLbl As System.Windows.Forms.Label
    Friend WithEvents Step3ReqLbl As System.Windows.Forms.Label
    Friend WithEvents emailPasswordLbl As System.Windows.Forms.Label
    Friend WithEvents emailPasswordFld As System.Windows.Forms.TextBox
    Friend WithEvents emailIDLbl As System.Windows.Forms.Label
    Friend WithEvents emailIDFld As System.Windows.Forms.TextBox
    Friend WithEvents Step1RspLbl As System.Windows.Forms.Label
    Friend WithEvents Step1ReqLbl As System.Windows.Forms.Label
    Friend WithEvents Step1ReqFld As System.Windows.Forms.TextBox
    Friend WithEvents Step1RspFld As System.Windows.Forms.TextBox
    Friend WithEvents Step1Btn As System.Windows.Forms.Button
    Friend WithEvents sessIDLbl As System.Windows.Forms.Label
    Friend WithEvents sessIDFld As System.Windows.Forms.TextBox
    Friend WithEvents profileTitleLbl As System.Windows.Forms.Label
    Friend WithEvents intGIDLbl As System.Windows.Forms.Label
    Friend WithEvents intGIDFld As System.Windows.Forms.TextBox
    Friend WithEvents subsIDLbl As System.Windows.Forms.Label
    Friend WithEvents subsIDFld As System.Windows.Forms.TextBox
    Friend WithEvents ikonomikalAddLbl As System.Windows.Forms.Label
    Friend WithEvents ikonomikalAddFld As System.Windows.Forms.TextBox
    Friend WithEvents makeSureAPIIsEnabledLbl As System.Windows.Forms.Label

End Class
