<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        btnNewRegistration = New Button()
        lstStudents = New ListBox()
        label2 = New Label()
        btnViewStudent = New Button()
        label3 = New Label()
        pnlHeader = New Panel()
        lblNewRegistration = New Label()
        lblRegisteredStudent = New Label()
        Button1 = New Button()
        lblTotalStudents = New Label()
        lblStatus = New Label()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnNewRegistration
        ' 
        btnNewRegistration.BackColor = Color.RoyalBlue
        btnNewRegistration.Location = New Point(691, 89)
        btnNewRegistration.Name = "btnNewRegistration"
        btnNewRegistration.Size = New Size(194, 70)
        btnNewRegistration.TabIndex = 0
        btnNewRegistration.Text = "Open existing registration form"
        btnNewRegistration.UseVisualStyleBackColor = False
        ' 
        ' lstStudents
        ' 
        lstStudents.BorderStyle = BorderStyle.FixedSingle
        lstStudents.FormattingEnabled = True
        lstStudents.Location = New Point(285, 180)
        lstStudents.Name = "lstStudents"
        lstStudents.Size = New Size(576, 52)
        lstStudents.TabIndex = 1
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("Segoe UI", 10F)
        label2.Location = New Point(31, 281)
        label2.Name = "label2"
        label2.Size = New Size(182, 28)
        label2.TabIndex = 2
        label2.Text = "Show current count"
        ' 
        ' btnViewStudent
        ' 
        btnViewStudent.BackColor = Color.RoyalBlue
        btnViewStudent.Enabled = False
        btnViewStudent.Location = New Point(661, 350)
        btnViewStudent.Name = "btnViewStudent"
        btnViewStudent.Size = New Size(224, 48)
        btnViewStudent.TabIndex = 3
        btnViewStudent.Text = "Open selected student"
        btnViewStudent.UseVisualStyleBackColor = False
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Point(31, 422)
        label3.Name = "label3"
        label3.Size = New Size(152, 25)
        label3.TabIndex = 4
        label3.Text = "Explain last action"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.RoyalBlue
        pnlHeader.Controls.Add(lblNewRegistration)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(906, 70)
        pnlHeader.TabIndex = 5
        ' 
        ' lblNewRegistration
        ' 
        lblNewRegistration.AutoSize = True
        lblNewRegistration.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNewRegistration.ForeColor = Color.White
        lblNewRegistration.Location = New Point(3, 9)
        lblNewRegistration.Name = "lblNewRegistration"
        lblNewRegistration.Size = New Size(368, 48)
        lblNewRegistration.TabIndex = 0
        lblNewRegistration.Text = "NEW REGISTRATION"
        ' 
        ' lblRegisteredStudent
        ' 
        lblRegisteredStudent.AutoSize = True
        lblRegisteredStudent.Font = New Font("Segoe UI", 10F)
        lblRegisteredStudent.Location = New Point(12, 191)
        lblRegisteredStudent.Name = "lblRegisteredStudent"
        lblRegisteredStudent.Size = New Size(246, 28)
        lblRegisteredStudent.TabIndex = 6
        lblRegisteredStudent.Text = "Display Registered Student"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.RoyalBlue
        Button1.Enabled = False
        Button1.Location = New Point(661, 488)
        Button1.Name = "Button1"
        Button1.Size = New Size(224, 46)
        Button1.TabIndex = 7
        Button1.Text = "Close the details form"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lblTotalStudents
        ' 
        lblTotalStudents.BorderStyle = BorderStyle.FixedSingle
        lblTotalStudents.Location = New Point(285, 288)
        lblTotalStudents.Name = "lblTotalStudents"
        lblTotalStudents.Size = New Size(576, 38)
        lblTotalStudents.TabIndex = 8
        ' 
        ' lblStatus
        ' 
        lblStatus.BorderStyle = BorderStyle.FixedSingle
        lblStatus.Location = New Point(285, 409)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(576, 38)
        lblStatus.TabIndex = 9
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(906, 572)
        Controls.Add(lblStatus)
        Controls.Add(lblTotalStudents)
        Controls.Add(Button1)
        Controls.Add(lblRegisteredStudent)
        Controls.Add(pnlHeader)
        Controls.Add(label3)
        Controls.Add(btnViewStudent)
        Controls.Add(label2)
        Controls.Add(lstStudents)
        Controls.Add(btnNewRegistration)
        MinimumSize = New Size(720, 520)
        Name = "frmDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmDashboard"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnNewRegistration As Button
    Friend WithEvents lstStudents As ListBox
    Friend WithEvents label2 As Label
    Friend WithEvents btnViewStudent As Button
    Friend WithEvents label3 As Label
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblNewRegistration As Label
    Friend WithEvents lblRegisteredStudent As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblTotalStudents As Label
    Friend WithEvents lblStatus As Label
End Class
