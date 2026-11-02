<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentSummaryControl
    Inherits System.Windows.Forms.UserControl

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblName = New Label()
        lblProgramme = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        SuspendLayout()
        '
        ' lblName
        '
        lblName.AutoEllipsis = True
        lblName.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.ForeColor = Color.FromArgb(17, 24, 39)
        lblName.Location = New Point(20, 18)
        lblName.Name = "lblName"
        lblName.Size = New Size(340, 40)
        lblName.TabIndex = 0
        lblName.Text = "No student selected"
        '
        ' lblProgramme
        '
        lblProgramme.AutoEllipsis = True
        lblProgramme.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblProgramme.ForeColor = Color.FromArgb(107, 114, 128)
        lblProgramme.Location = New Point(20, 70)
        lblProgramme.Name = "lblProgramme"
        lblProgramme.Size = New Size(340, 28)
        lblProgramme.TabIndex = 1
        lblProgramme.Text = "Programme"
        '
        ' lblEmail
        '
        lblEmail.AutoEllipsis = True
        lblEmail.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmail.ForeColor = Color.FromArgb(107, 114, 128)
        lblEmail.Location = New Point(20, 108)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(340, 28)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"
        '
        ' lblPhone
        '
        lblPhone.AutoEllipsis = True
        lblPhone.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPhone.ForeColor = Color.FromArgb(107, 114, 128)
        lblPhone.Location = New Point(20, 146)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(340, 28)
        lblPhone.TabIndex = 3
        lblPhone.Text = "Phone"
        '
        ' StudentSummaryControl
        '
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BorderStyle = BorderStyle.FixedSingle
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblProgramme)
        Controls.Add(lblName)
        Name = "StudentSummaryControl"
        Size = New Size(380, 200)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblProgramme As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
End Class
