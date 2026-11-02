<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlSidebar = New Panel()
        btnNewRegistration = New Button()
        pnlMain = New Panel()
        pnlContent = New Panel()
        pnlPreview = New Panel()
        btnViewDetails = New Button()
        studentSummary = New StudentSummaryControl()
        lblPreviewTitle = New Label()
        pnlListSection = New Panel()
        dgvStudents = New DataGridView()
        lblListTitle = New Label()
        pnlFooter = New Panel()
        lblStatusMessage = New Label()
        lblStudentCount = New Label()
        pnlHeader = New Panel()
        lblDashboardTitle = New Label()
        pnlSidebar.SuspendLayout()
        pnlMain.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlPreview.SuspendLayout()
        pnlListSection.SuspendLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        pnlFooter.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        pnlSidebar.Controls.Add(btnNewRegistration)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(220, 700)
        pnlSidebar.TabIndex = 0
        ' 
        ' btnNewRegistration
        ' 
        btnNewRegistration.BackColor = Color.Transparent
        btnNewRegistration.Dock = DockStyle.Top
        btnNewRegistration.FlatAppearance.BorderSize = 0
        btnNewRegistration.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnNewRegistration.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnNewRegistration.FlatStyle = FlatStyle.Flat
        btnNewRegistration.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        btnNewRegistration.ForeColor = Color.White
        btnNewRegistration.Location = New Point(0, 0)
        btnNewRegistration.Name = "btnNewRegistration"
        btnNewRegistration.Padding = New Padding(16, 0, 0, 0)
        btnNewRegistration.Size = New Size(220, 80)
        btnNewRegistration.TabIndex = 0
        btnNewRegistration.Text = "New Registration"
        btnNewRegistration.TextAlign = ContentAlignment.MiddleLeft
        btnNewRegistration.UseVisualStyleBackColor = False
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        pnlMain.Controls.Add(pnlContent)
        pnlMain.Controls.Add(pnlFooter)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(220, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1040, 700)
        pnlMain.TabIndex = 1
        ' 
        ' pnlContent
        ' 
        pnlContent.Controls.Add(pnlPreview)
        pnlContent.Controls.Add(pnlListSection)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(0, 80)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(24)
        pnlContent.Size = New Size(1040, 540)
        pnlContent.TabIndex = 3
        ' 
        ' pnlPreview
        ' 
        pnlPreview.BackColor = Color.White
        pnlPreview.BorderStyle = BorderStyle.FixedSingle
        pnlPreview.Controls.Add(btnViewDetails)
        pnlPreview.Controls.Add(studentSummary)
        pnlPreview.Controls.Add(lblPreviewTitle)
        pnlPreview.Dock = DockStyle.Right
        pnlPreview.Location = New Point(556, 24)
        pnlPreview.Name = "pnlPreview"
        pnlPreview.Padding = New Padding(24)
        pnlPreview.Size = New Size(460, 492)
        pnlPreview.TabIndex = 1
        ' 
        ' btnViewDetails
        ' 
        btnViewDetails.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnViewDetails.Dock = DockStyle.Bottom
        btnViewDetails.FlatAppearance.BorderSize = 0
        btnViewDetails.FlatStyle = FlatStyle.Flat
        btnViewDetails.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewDetails.ForeColor = Color.White
        btnViewDetails.Location = New Point(24, 398)
        btnViewDetails.Name = "btnViewDetails"
        btnViewDetails.Padding = New Padding(0, 8, 0, 8)
        btnViewDetails.Size = New Size(410, 68)
        btnViewDetails.TabIndex = 2
        btnViewDetails.Text = "View Details"
        btnViewDetails.UseVisualStyleBackColor = False
        ' 
        ' studentSummary
        ' 
        studentSummary.BackColor = Color.White
        studentSummary.BorderStyle = BorderStyle.FixedSingle
        studentSummary.Dock = DockStyle.Top
        studentSummary.Location = New Point(24, 54)
        studentSummary.Name = "studentSummary"
        studentSummary.Size = New Size(410, 234)
        studentSummary.TabIndex = 1
        ' 
        ' lblPreviewTitle
        ' 
        lblPreviewTitle.AutoSize = True
        lblPreviewTitle.Dock = DockStyle.Top
        lblPreviewTitle.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPreviewTitle.ForeColor = Color.FromArgb(CByte(17), CByte(24), CByte(39))
        lblPreviewTitle.Location = New Point(24, 24)
        lblPreviewTitle.Name = "lblPreviewTitle"
        lblPreviewTitle.Size = New Size(183, 30)
        lblPreviewTitle.TabIndex = 0
        lblPreviewTitle.Text = "Student Preview"
        ' 
        ' pnlListSection
        ' 
        pnlListSection.BackColor = Color.White
        pnlListSection.BorderStyle = BorderStyle.FixedSingle
        pnlListSection.Controls.Add(dgvStudents)
        pnlListSection.Controls.Add(lblListTitle)
        pnlListSection.Dock = DockStyle.Fill
        pnlListSection.Location = New Point(24, 24)
        pnlListSection.Name = "pnlListSection"
        pnlListSection.Padding = New Padding(24)
        pnlListSection.Size = New Size(992, 492)
        pnlListSection.TabIndex = 0
        ' 
        ' dgvStudents
        ' 
        dgvStudents.AllowUserToAddRows = False
        dgvStudents.AllowUserToDeleteRows = False
        dgvStudents.AllowUserToResizeRows = False
        dgvStudents.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStudents.BackgroundColor = Color.White
        dgvStudents.BorderStyle = BorderStyle.None
        dgvStudents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudents.ColumnHeadersVisible = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(219), CByte(234), CByte(254))
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(17), CByte(24), CByte(39))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvStudents.DefaultCellStyle = DataGridViewCellStyle1
        dgvStudents.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dgvStudents.Location = New Point(24, 72)
        dgvStudents.MultiSelect = False
        dgvStudents.Name = "dgvStudents"
        dgvStudents.ReadOnly = True
        dgvStudents.RowHeadersVisible = False
        dgvStudents.RowHeadersWidth = 62
        dgvStudents.RowTemplate.Height = 32
        dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStudents.Size = New Size(487, 393)
        dgvStudents.TabIndex = 1
        ' 
        ' lblListTitle
        ' 
        lblListTitle.AutoSize = True
        lblListTitle.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblListTitle.ForeColor = Color.FromArgb(CByte(17), CByte(24), CByte(39))
        lblListTitle.Location = New Point(24, 24)
        lblListTitle.Name = "lblListTitle"
        lblListTitle.Size = New Size(221, 30)
        lblListTitle.TabIndex = 0
        lblListTitle.Text = "Registered Students"
        ' 
        ' pnlFooter
        ' 
        pnlFooter.BackColor = Color.White
        pnlFooter.BorderStyle = BorderStyle.FixedSingle
        pnlFooter.Controls.Add(lblStatusMessage)
        pnlFooter.Controls.Add(lblStudentCount)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 620)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Padding = New Padding(24, 12, 24, 12)
        pnlFooter.Size = New Size(1040, 80)
        pnlFooter.TabIndex = 4
        ' 
        ' lblStatusMessage
        ' 
        lblStatusMessage.AutoSize = True
        lblStatusMessage.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStatusMessage.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblStatusMessage.Location = New Point(24, 40)
        lblStatusMessage.Name = "lblStatusMessage"
        lblStatusMessage.Size = New Size(0, 28)
        lblStatusMessage.TabIndex = 1
        ' 
        ' lblStudentCount
        ' 
        lblStudentCount.AutoSize = True
        lblStudentCount.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStudentCount.ForeColor = Color.FromArgb(CByte(75), CByte(85), CByte(99))
        lblStudentCount.Location = New Point(24, 10)
        lblStudentCount.Name = "lblStudentCount"
        lblStudentCount.Size = New Size(201, 28)
        lblStudentCount.TabIndex = 0
        lblStudentCount.Text = "Students registered: 0"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.RoyalBlue
        pnlHeader.BorderStyle = BorderStyle.FixedSingle
        pnlHeader.Controls.Add(lblDashboardTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Padding = New Padding(24, 16, 24, 16)
        pnlHeader.Size = New Size(1040, 80)
        pnlHeader.TabIndex = 2
        ' 
        ' lblDashboardTitle
        ' 
        lblDashboardTitle.AutoSize = True
        lblDashboardTitle.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboardTitle.ForeColor = Color.FromArgb(CByte(17), CByte(24), CByte(39))
        lblDashboardTitle.Location = New Point(24, 16)
        lblDashboardTitle.Name = "lblDashboardTitle"
        lblDashboardTitle.Size = New Size(629, 54)
        lblDashboardTitle.TabIndex = 0
        lblDashboardTitle.Text = "Student Registration Dashboard"
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        ClientSize = New Size(1260, 700)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        MinimumSize = New Size(1200, 600)
        Name = "frmDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Registration Dashboard"
        pnlSidebar.ResumeLayout(False)
        pnlMain.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
        pnlPreview.ResumeLayout(False)
        pnlPreview.PerformLayout()
        pnlListSection.ResumeLayout(False)
        pnlListSection.PerformLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        pnlFooter.ResumeLayout(False)
        pnlFooter.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnNewRegistration As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlListSection As Panel
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents lblListTitle As Label
    Friend WithEvents pnlPreview As Panel
    Friend WithEvents studentSummary As StudentSummaryControl
    Friend WithEvents lblPreviewTitle As Label
    Friend WithEvents btnViewDetails As Button
    Friend WithEvents lblDashboardTitle As Label
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents lblStudentCount As Label
    Friend WithEvents lblStatusMessage As Label
End Class
