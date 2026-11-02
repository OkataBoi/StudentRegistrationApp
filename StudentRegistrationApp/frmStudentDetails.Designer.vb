<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentDetails
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlMain = New Panel()
        pnlContent = New Panel()
        pnlCard = New Panel()
        tblLayout = New TableLayoutPanel()
        lblAddressValue = New Label()
        lblAddressLabel = New Label()
        lblBirthDateValue = New Label()
        lblBirthDateLabel = New Label()
        lblPhoneValue = New Label()
        lblPhoneLabel = New Label()
        lblEmailValue = New Label()
        lblEmailLabel = New Label()
        lblProgrammeValue = New Label()
        lblProgrammeLabel = New Label()
        lblNameValue = New Label()
        pnlFooter = New Panel()
        btnClose = New Button()
        pnlHeader = New Panel()
        lblTitle = New Label()
        pnlMain.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlCard.SuspendLayout()
        tblLayout.SuspendLayout()
        pnlFooter.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        pnlMain.Controls.Add(pnlContent)
        pnlMain.Controls.Add(pnlFooter)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(900, 700)
        pnlMain.TabIndex = 0
        ' 
        ' pnlContent
        ' 
        pnlContent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlContent.Controls.Add(pnlCard)
        pnlContent.Location = New Point(50, 100)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(800, 500)
        pnlContent.TabIndex = 1
        ' 
        ' pnlCard
        ' 
        pnlCard.BackColor = Color.White
        pnlCard.BorderStyle = BorderStyle.FixedSingle
        pnlCard.Controls.Add(tblLayout)
        pnlCard.Dock = DockStyle.Fill
        pnlCard.Location = New Point(0, 0)
        pnlCard.Name = "pnlCard"
        pnlCard.Padding = New Padding(40)
        pnlCard.Size = New Size(800, 500)
        pnlCard.TabIndex = 0
        ' 
        ' tblLayout
        ' 
        tblLayout.ColumnCount = 2
        tblLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F))
        tblLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70.0F))
        tblLayout.Controls.Add(lblAddressValue, 1, 5)
        tblLayout.Controls.Add(lblAddressLabel, 0, 5)
        tblLayout.Controls.Add(lblBirthDateValue, 1, 4)
        tblLayout.Controls.Add(lblBirthDateLabel, 0, 4)
        tblLayout.Controls.Add(lblPhoneValue, 1, 3)
        tblLayout.Controls.Add(lblPhoneLabel, 0, 3)
        tblLayout.Controls.Add(lblEmailValue, 1, 2)
        tblLayout.Controls.Add(lblEmailLabel, 0, 2)
        tblLayout.Controls.Add(lblProgrammeValue, 1, 1)
        tblLayout.Controls.Add(lblProgrammeLabel, 0, 1)
        tblLayout.Controls.Add(lblNameValue, 0, 0)
        tblLayout.Dock = DockStyle.Fill
        tblLayout.Location = New Point(40, 40)
        tblLayout.Name = "tblLayout"
        tblLayout.RowCount = 6
        tblLayout.RowStyles.Add(New RowStyle(SizeType.Absolute, 50.0F))
        tblLayout.RowStyles.Add(New RowStyle(SizeType.Absolute, 50.0F))
        tblLayout.RowStyles.Add(New RowStyle(SizeType.Absolute, 50.0F))
        tblLayout.RowStyles.Add(New RowStyle(SizeType.Absolute, 50.0F))
        tblLayout.RowStyles.Add(New RowStyle(SizeType.Absolute, 50.0F))
        tblLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tblLayout.Size = New Size(718, 418)
        tblLayout.TabIndex = 0
        ' 
        ' lblAddressValue
        ' 
        lblAddressValue.AutoSize = True
        lblAddressValue.Dock = DockStyle.Fill
        lblAddressValue.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAddressValue.ForeColor = Color.FromArgb(CByte(17), CByte(24), CByte(39))
        lblAddressValue.Location = New Point(218, 250)
        lblAddressValue.Name = "lblAddressValue"
        lblAddressValue.Size = New Size(497, 168)
        lblAddressValue.TabIndex = 11
        lblAddressValue.Text = "Address"
        ' 
        ' lblAddressLabel
        ' 
        lblAddressLabel.AutoSize = True
        lblAddressLabel.Dock = DockStyle.Fill
        lblAddressLabel.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddressLabel.ForeColor = Color.FromArgb(CByte(75), CByte(85), CByte(99))
        lblAddressLabel.Location = New Point(3, 250)
        lblAddressLabel.Name = "lblAddressLabel"
        lblAddressLabel.Size = New Size(209, 168)
        lblAddressLabel.TabIndex = 10
        lblAddressLabel.Text = "Address"
        ' 
        ' lblBirthDateValue
        ' 
        lblBirthDateValue.AutoSize = True
        lblBirthDateValue.Dock = DockStyle.Fill
        lblBirthDateValue.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBirthDateValue.ForeColor = Color.FromArgb(CByte(17), CByte(24), CByte(39))
        lblBirthDateValue.Location = New Point(218, 200)
        lblBirthDateValue.Name = "lblBirthDateValue"
        lblBirthDateValue.Size = New Size(497, 50)
        lblBirthDateValue.TabIndex = 9
        lblBirthDateValue.Text = "Date of Birth"
        lblBirthDateValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblBirthDateLabel
        ' 
        lblBirthDateLabel.AutoSize = True
        lblBirthDateLabel.Dock = DockStyle.Fill
        lblBirthDateLabel.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBirthDateLabel.ForeColor = Color.FromArgb(CByte(75), CByte(85), CByte(99))
        lblBirthDateLabel.Location = New Point(3, 200)
        lblBirthDateLabel.Name = "lblBirthDateLabel"
        lblBirthDateLabel.Size = New Size(209, 50)
        lblBirthDateLabel.TabIndex = 8
        lblBirthDateLabel.Text = "Date of Birth"
        lblBirthDateLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblPhoneValue
        ' 
        lblPhoneValue.AutoSize = True
        lblPhoneValue.Dock = DockStyle.Fill
        lblPhoneValue.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPhoneValue.ForeColor = Color.FromArgb(CByte(17), CByte(24), CByte(39))
        lblPhoneValue.Location = New Point(218, 150)
        lblPhoneValue.Name = "lblPhoneValue"
        lblPhoneValue.Size = New Size(497, 50)
        lblPhoneValue.TabIndex = 7
        lblPhoneValue.Text = "Phone"
        lblPhoneValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblPhoneLabel
        ' 
        lblPhoneLabel.AutoSize = True
        lblPhoneLabel.Dock = DockStyle.Fill
        lblPhoneLabel.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPhoneLabel.ForeColor = Color.FromArgb(CByte(75), CByte(85), CByte(99))
        lblPhoneLabel.Location = New Point(3, 150)
        lblPhoneLabel.Name = "lblPhoneLabel"
        lblPhoneLabel.Size = New Size(209, 50)
        lblPhoneLabel.TabIndex = 6
        lblPhoneLabel.Text = "Phone"
        lblPhoneLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblEmailValue
        ' 
        lblEmailValue.AutoSize = True
        lblEmailValue.Dock = DockStyle.Fill
        lblEmailValue.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmailValue.ForeColor = Color.FromArgb(CByte(17), CByte(24), CByte(39))
        lblEmailValue.Location = New Point(218, 100)
        lblEmailValue.Name = "lblEmailValue"
        lblEmailValue.Size = New Size(497, 50)
        lblEmailValue.TabIndex = 5
        lblEmailValue.Text = "Email"
        lblEmailValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblEmailLabel
        ' 
        lblEmailLabel.AutoSize = True
        lblEmailLabel.Dock = DockStyle.Fill
        lblEmailLabel.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmailLabel.ForeColor = Color.FromArgb(CByte(75), CByte(85), CByte(99))
        lblEmailLabel.Location = New Point(3, 100)
        lblEmailLabel.Name = "lblEmailLabel"
        lblEmailLabel.Size = New Size(209, 50)
        lblEmailLabel.TabIndex = 4
        lblEmailLabel.Text = "Email"
        lblEmailLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblProgrammeValue
        ' 
        lblProgrammeValue.AutoSize = True
        lblProgrammeValue.Dock = DockStyle.Fill
        lblProgrammeValue.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblProgrammeValue.ForeColor = Color.FromArgb(CByte(17), CByte(24), CByte(39))
        lblProgrammeValue.Location = New Point(218, 50)
        lblProgrammeValue.Name = "lblProgrammeValue"
        lblProgrammeValue.Size = New Size(497, 50)
        lblProgrammeValue.TabIndex = 3
        lblProgrammeValue.Text = "Programme"
        lblProgrammeValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblProgrammeLabel
        ' 
        lblProgrammeLabel.AutoSize = True
        lblProgrammeLabel.Dock = DockStyle.Fill
        lblProgrammeLabel.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProgrammeLabel.ForeColor = Color.FromArgb(CByte(75), CByte(85), CByte(99))
        lblProgrammeLabel.Location = New Point(3, 50)
        lblProgrammeLabel.Name = "lblProgrammeLabel"
        lblProgrammeLabel.Size = New Size(209, 50)
        lblProgrammeLabel.TabIndex = 2
        lblProgrammeLabel.Text = "Programme"
        lblProgrammeLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblNameValue
        ' 
        lblNameValue.AutoSize = True
        tblLayout.SetColumnSpan(lblNameValue, 2)
        lblNameValue.Dock = DockStyle.Fill
        lblNameValue.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNameValue.ForeColor = Color.FromArgb(CByte(17), CByte(24), CByte(39))
        lblNameValue.Location = New Point(3, 0)
        lblNameValue.Name = "lblNameValue"
        lblNameValue.Size = New Size(712, 50)
        lblNameValue.TabIndex = 1
        lblNameValue.Text = "Student Name"
        lblNameValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlFooter
        ' 
        pnlFooter.BackColor = Color.White
        pnlFooter.BorderStyle = BorderStyle.FixedSingle
        pnlFooter.Controls.Add(btnClose)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 620)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Padding = New Padding(24, 12, 24, 12)
        pnlFooter.Size = New Size(900, 80)
        pnlFooter.TabIndex = 2
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.None
        btnClose.BackColor = Color.RoyalBlue
        btnClose.FlatAppearance.BorderColor = Color.FromArgb(CByte(229), CByte(231), CByte(235))
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        btnClose.Location = New Point(380, 16)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(140, 48)
        btnClose.TabIndex = 0
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.RoyalBlue
        pnlHeader.BorderStyle = BorderStyle.FixedSingle
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Padding = New Padding(24, 16, 24, 16)
        pnlHeader.Size = New Size(900, 80)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(17), CByte(24), CByte(39))
        lblTitle.Location = New Point(24, 16)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(312, 54)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Student Details"
        ' 
        ' frmStudentDetails
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        ClientSize = New Size(900, 700)
        Controls.Add(pnlMain)
        MinimumSize = New Size(800, 600)
        Name = "frmStudentDetails"
        StartPosition = FormStartPosition.CenterParent
        Text = "Student Details"
        pnlMain.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
        pnlCard.ResumeLayout(False)
        tblLayout.ResumeLayout(False)
        tblLayout.PerformLayout()
        pnlFooter.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents pnlCard As Panel
    Friend WithEvents tblLayout As TableLayoutPanel
    Friend WithEvents lblNameValue As Label
    Friend WithEvents lblProgrammeLabel As Label
    Friend WithEvents lblProgrammeValue As Label
    Friend WithEvents lblEmailLabel As Label
    Friend WithEvents lblEmailValue As Label
    Friend WithEvents lblPhoneLabel As Label
    Friend WithEvents lblPhoneValue As Label
    Friend WithEvents lblBirthDateLabel As Label
    Friend WithEvents lblBirthDateValue As Label
    Friend WithEvents lblAddressLabel As Label
    Friend WithEvents lblAddressValue As Label

End Class
