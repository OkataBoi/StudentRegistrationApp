<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentDetails
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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlDetailsCard = New Panel()
        btnClose = New Button()
        lblAddress = New Label()
        lblAddressCaption = New Label()
        lblBirthDate = New Label()
        lblBirthDateCaption = New Label()
        lblEmail = New Label()
        lblEmailCaption = New Label()
        lblProgramme = New Label()
        lblFullName = New Label()
        picAvatar = New PictureBox()
        pnlDetailsCard.SuspendLayout()
        CType(picAvatar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlDetailsCard
        ' 
        pnlDetailsCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDetailsCard.BackColor = Color.White
        pnlDetailsCard.Controls.Add(btnClose)
        pnlDetailsCard.Controls.Add(lblAddress)
        pnlDetailsCard.Controls.Add(lblAddressCaption)
        pnlDetailsCard.Controls.Add(lblBirthDate)
        pnlDetailsCard.Controls.Add(lblBirthDateCaption)
        pnlDetailsCard.Controls.Add(lblEmail)
        pnlDetailsCard.Controls.Add(lblEmailCaption)
        pnlDetailsCard.Controls.Add(lblProgramme)
        pnlDetailsCard.Controls.Add(lblFullName)
        pnlDetailsCard.Controls.Add(picAvatar)
        pnlDetailsCard.Location = New Point(115, 35)
        pnlDetailsCard.Name = "pnlDetailsCard"
        pnlDetailsCard.Padding = New Padding(20)
        pnlDetailsCard.Size = New Size(670, 650)
        pnlDetailsCard.TabIndex = 0
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Bottom
        btnClose.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        btnClose.Location = New Point(265, 559)
        btnClose.Name = "btnClose"
        btnClose.Padding = New Padding(10, 5, 10, 5)
        btnClose.Size = New Size(151, 48)
        btnClose.TabIndex = 9
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoEllipsis = True
        lblAddress.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAddress.ForeColor = Color.FromArgb(CByte(17), CByte(24), CByte(39))
        lblAddress.Location = New Point(40, 357)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(590, 50)
        lblAddress.TabIndex = 8
        lblAddress.Text = "Address"
        lblAddress.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblAddressCaption
        ' 
        lblAddressCaption.AutoSize = True
        lblAddressCaption.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAddressCaption.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblAddressCaption.Location = New Point(40, 330)
        lblAddressCaption.Name = "lblAddressCaption"
        lblAddressCaption.Size = New Size(77, 25)
        lblAddressCaption.TabIndex = 7
        lblAddressCaption.Text = "Address"
        ' 
        ' lblBirthDate
        ' 
        lblBirthDate.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBirthDate.ForeColor = Color.FromArgb(CByte(17), CByte(24), CByte(39))
        lblBirthDate.Location = New Point(355, 262)
        lblBirthDate.Name = "lblBirthDate"
        lblBirthDate.Size = New Size(260, 36)
        lblBirthDate.TabIndex = 6
        lblBirthDate.Text = "Date of Birth"
        lblBirthDate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblBirthDateCaption
        ' 
        lblBirthDateCaption.AutoSize = True
        lblBirthDateCaption.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBirthDateCaption.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblBirthDateCaption.Location = New Point(355, 235)
        lblBirthDateCaption.Name = "lblBirthDateCaption"
        lblBirthDateCaption.Size = New Size(112, 25)
        lblBirthDateCaption.TabIndex = 5
        lblBirthDateCaption.Text = "Date of Birth"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoEllipsis = True
        lblEmail.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmail.ForeColor = Color.FromArgb(CByte(17), CByte(24), CByte(39))
        lblEmail.Location = New Point(40, 262)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(270, 36)
        lblEmail.TabIndex = 4
        lblEmail.Text = "Email"
        lblEmail.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblEmailCaption
        ' 
        lblEmailCaption.AutoSize = True
        lblEmailCaption.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmailCaption.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblEmailCaption.Location = New Point(40, 235)
        lblEmailCaption.Name = "lblEmailCaption"
        lblEmailCaption.Size = New Size(124, 25)
        lblEmailCaption.TabIndex = 3
        lblEmailCaption.Text = "Email Address"
        ' 
        ' lblProgramme
        ' 
        lblProgramme.AutoEllipsis = True
        lblProgramme.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblProgramme.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblProgramme.Location = New Point(40, 168)
        lblProgramme.Name = "lblProgramme"
        lblProgramme.Size = New Size(590, 32)
        lblProgramme.TabIndex = 2
        lblProgramme.Text = "Programme"
        lblProgramme.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoEllipsis = True
        lblFullName.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFullName.ForeColor = Color.FromArgb(CByte(17), CByte(24), CByte(39))
        lblFullName.Location = New Point(40, 120)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(590, 45)
        lblFullName.TabIndex = 1
        lblFullName.Text = "Full name"
        lblFullName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picAvatar
        ' 
        picAvatar.BackColor = Color.FromArgb(CByte(229), CByte(231), CByte(235))
        picAvatar.Location = New Point(295, 30)
        picAvatar.Name = "picAvatar"
        picAvatar.Size = New Size(80, 80)
        picAvatar.SizeMode = PictureBoxSizeMode.Zoom
        picAvatar.TabIndex = 0
        picAvatar.TabStop = False
        ' 
        ' frmStudentDetails
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        ClientSize = New Size(900, 720)
        Controls.Add(pnlDetailsCard)
        MinimumSize = New Size(820, 650)
        Name = "frmStudentDetails"
        StartPosition = FormStartPosition.CenterParent
        Text = "Student Details"
        pnlDetailsCard.ResumeLayout(False)
        pnlDetailsCard.PerformLayout()
        CType(picAvatar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlDetailsCard As Panel
    Friend WithEvents picAvatar As PictureBox
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblProgramme As Label
    Friend WithEvents lblEmailCaption As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblBirthDateCaption As Label
    Friend WithEvents lblBirthDate As Label
    Friend WithEvents lblAddressCaption As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents btnClose As Button
End Class
