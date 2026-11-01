<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        pnlSidebar = New Panel()
        btnNewRegistration = New Button()
        pnlMain = New Panel()
        pnlContentCard = New Panel()
        Button1 = New Button()
        btnViewStudent = New Button()
        lblStatusMessage = New Label()
        lblStudentCount = New Label()
        dgvStudents = New DataGridView()
        lblRegisteredStudent = New Label()
        pnlHeader = New Panel()
        lblNewRegistration = New Label()
        pnlSidebar.SuspendLayout()
        pnlMain.SuspendLayout()
        pnlContentCard.SuspendLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = SystemColors.MenuHighlight
        pnlSidebar.Controls.Add(btnNewRegistration)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(200, 672)
        pnlSidebar.TabIndex = 0
        ' 
        ' btnNewRegistration
        ' 
        btnNewRegistration.BackColor = SystemColors.InfoText
        btnNewRegistration.Dock = DockStyle.Top
        btnNewRegistration.FlatAppearance.BorderSize = 0
        btnNewRegistration.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnNewRegistration.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnNewRegistration.FlatStyle = FlatStyle.Flat
        btnNewRegistration.Font = New Font("Segoe UI", 10.0F)
        btnNewRegistration.ForeColor = Color.White
        btnNewRegistration.Location = New Point(0, 0)
        btnNewRegistration.Name = "btnNewRegistration"
        btnNewRegistration.Padding = New Padding(16, 0, 0, 0)
        btnNewRegistration.Size = New Size(200, 52)
        btnNewRegistration.TabIndex = 0
        btnNewRegistration.Text = "New Registration"
        btnNewRegistration.TextAlign = ContentAlignment.MiddleLeft
        btnNewRegistration.UseVisualStyleBackColor = False
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        pnlMain.Controls.Add(pnlContentCard)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(200, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(890, 672)
        pnlMain.TabIndex = 1
        ' 
        ' pnlContentCard
        ' 
        pnlContentCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlContentCard.BackColor = Color.White
        pnlContentCard.Controls.Add(Button1)
        pnlContentCard.Controls.Add(btnViewStudent)
        pnlContentCard.Controls.Add(lblStatusMessage)
        pnlContentCard.Controls.Add(lblStudentCount)
        pnlContentCard.Controls.Add(dgvStudents)
        pnlContentCard.Controls.Add(lblRegisteredStudent)
        pnlContentCard.Location = New Point(60, 90)
        pnlContentCard.Name = "pnlContentCard"
        pnlContentCard.Padding = New Padding(20)
        pnlContentCard.Size = New Size(770, 540)
        pnlContentCard.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button1.BackColor = Color.FromArgb(CByte(229), CByte(231), CByte(235))
        Button1.Enabled = False
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(20, 455)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(5, 0, 15, 0)
        Button1.Size = New Size(224, 46)
        Button1.TabIndex = 7
        Button1.Text = "Close the details form"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnViewStudent
        ' 
        btnViewStudent.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnViewStudent.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnViewStudent.Enabled = False
        btnViewStudent.FlatAppearance.BorderSize = 0
        btnViewStudent.FlatStyle = FlatStyle.Flat
        btnViewStudent.ForeColor = Color.White
        btnViewStudent.Location = New Point(526, 455)
        btnViewStudent.Name = "btnViewStudent"
        btnViewStudent.Padding = New Padding(5, 0, 15, 0)
        btnViewStudent.Size = New Size(224, 48)
        btnViewStudent.TabIndex = 3
        btnViewStudent.Text = "Open selected student"
        btnViewStudent.UseVisualStyleBackColor = False
        ' 
        ' lblStatusMessage
        ' 
        lblStatusMessage.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblStatusMessage.AutoSize = True
        lblStatusMessage.Font = New Font("Segoe UI", 10.0F)
        lblStatusMessage.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblStatusMessage.Location = New Point(20, 422)
        lblStatusMessage.Name = "lblStatusMessage"
        lblStatusMessage.Size = New Size(0, 28)
        lblStatusMessage.TabIndex = 4
        ' 
        ' lblStudentCount
        ' 
        lblStudentCount.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblStudentCount.AutoSize = True
        lblStudentCount.Font = New Font("Segoe UI", 10.0F)
        lblStudentCount.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblStudentCount.Location = New Point(20, 390)
        lblStudentCount.Name = "lblStudentCount"
        lblStudentCount.Size = New Size(201, 28)
        lblStudentCount.TabIndex = 2
        lblStudentCount.Text = "Students registered: 0"
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
        dgvStudents.Font = New Font("Segoe UI", 10.0F)
        dgvStudents.Location = New Point(20, 55)
        dgvStudents.MultiSelect = False
        dgvStudents.Name = "dgvStudents"
        dgvStudents.ReadOnly = True
        dgvStudents.RowHeadersVisible = False
        dgvStudents.RowHeadersWidth = 62
        dgvStudents.RowTemplate.Height = 32
        dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStudents.Size = New Size(730, 315)
        dgvStudents.TabIndex = 1
        ' 
        ' lblRegisteredStudent
        ' 
        lblRegisteredStudent.AutoSize = True
        lblRegisteredStudent.Font = New Font("Segoe UI", 10.0F)
        lblRegisteredStudent.Location = New Point(20, 20)
        lblRegisteredStudent.Name = "lblRegisteredStudent"
        lblRegisteredStudent.Size = New Size(246, 28)
        lblRegisteredStudent.TabIndex = 6
        lblRegisteredStudent.Text = "Display Registered Student"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.White
        pnlHeader.Controls.Add(lblNewRegistration)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Padding = New Padding(24, 0, 24, 0)
        pnlHeader.Size = New Size(890, 60)
        pnlHeader.TabIndex = 2
        ' 
        ' lblNewRegistration
        ' 
        lblNewRegistration.AutoSize = True
        lblNewRegistration.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNewRegistration.Location = New Point(24, 7)
        lblNewRegistration.Name = "lblNewRegistration"
        lblNewRegistration.Size = New Size(368, 48)
        lblNewRegistration.TabIndex = 0
        lblNewRegistration.Text = "NEW REGISTRATION"
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        ClientSize = New Size(1090, 672)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        MinimumSize = New Size(900, 600)
        Name = "frmDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Registration Dashboard"
        pnlSidebar.ResumeLayout(False)
        pnlMain.ResumeLayout(False)
        pnlContentCard.ResumeLayout(False)
        pnlContentCard.PerformLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlContentCard As Panel
    Friend WithEvents btnNewRegistration As Button
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents lblStudentCount As Label
    Friend WithEvents lblStatusMessage As Label
    Friend WithEvents btnViewStudent As Button
    Friend WithEvents lblNewRegistration As Label
    Friend WithEvents lblRegisteredStudent As Label
    Friend WithEvents Button1 As Button
End Class
