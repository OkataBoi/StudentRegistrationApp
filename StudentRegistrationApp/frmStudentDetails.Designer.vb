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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        pnlHeader = New Panel()
        lblTitle = New Label()
        btnClose = New Button()
        lblAddress = New Label()
        lblBirthDate = New Label()
        lblEmail = New Label()
        lblProgramme = New Label()
        lblFullName = New Label()
        Panel1 = New Panel()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.RoyalBlue
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(906, 85)
        pnlHeader.TabIndex = 2
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(12, 22)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(330, 48)
        lblTitle.TabIndex = 0
        lblTitle.Text = "STUDENT DETAILS"
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.RoyalBlue
        btnClose.Location = New Point(707, 500)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(112, 47)
        btnClose.TabIndex = 3
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI", 15F)
        lblAddress.Location = New Point(287, 458)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(125, 41)
        lblAddress.TabIndex = 10
        lblAddress.Text = "Address"
        ' 
        ' lblBirthDate
        ' 
        lblBirthDate.Anchor = AnchorStyles.Left
        lblBirthDate.AutoSize = True
        lblBirthDate.Font = New Font("Segoe UI", 15F)
        lblBirthDate.Location = New Point(256, 372)
        lblBirthDate.Name = "lblBirthDate"
        lblBirthDate.Size = New Size(184, 41)
        lblBirthDate.TabIndex = 3
        lblBirthDate.Text = "Date of Birth"
        ' 
        ' lblEmail
        ' 
        lblEmail.Anchor = AnchorStyles.Left
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 15F)
        lblEmail.Location = New Point(287, 290)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(88, 41)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"
        ' 
        ' lblProgramme
        ' 
        lblProgramme.Anchor = AnchorStyles.Left
        lblProgramme.AutoSize = True
        lblProgramme.Font = New Font("Segoe UI", 15F)
        lblProgramme.Location = New Point(247, 220)
        lblProgramme.Name = "lblProgramme"
        lblProgramme.Size = New Size(174, 41)
        lblProgramme.TabIndex = 1
        lblProgramme.Text = "Programme"
        ' 
        ' lblFullName
        ' 
        lblFullName.Anchor = AnchorStyles.Left
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 15F)
        lblFullName.Location = New Point(256, 145)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(146, 41)
        lblFullName.TabIndex = 0
        lblFullName.Text = "Full name"
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(563, 145)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 268)
        Panel1.TabIndex = 11
        ' 
        ' frmStudentDetails
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(906, 572)
        Controls.Add(Panel1)
        Controls.Add(lblProgramme)
        Controls.Add(lblFullName)
        Controls.Add(lblAddress)
        Controls.Add(lblEmail)
        Controls.Add(btnClose)
        Controls.Add(lblBirthDate)
        Controls.Add(pnlHeader)
        MinimumSize = New Size(720, 520)
        Name = "frmStudentDetails"
        Text = "frmStudentDetails"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblBirthDate As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblProgramme As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents Panel1 As Panel
End Class
