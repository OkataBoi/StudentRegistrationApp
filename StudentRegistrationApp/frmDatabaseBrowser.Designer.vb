<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabaseBrowser
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
        btnReload = New Button()
        dgvStudents = New DataGridView()
        lblDbStatus = New Label()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnReload
        ' 
        btnReload.Location = New Point(20, 12)
        btnReload.Name = "btnReload"
        btnReload.Size = New Size(112, 34)
        btnReload.TabIndex = 0
        btnReload.Text = "Reload"
        btnReload.UseVisualStyleBackColor = True
        ' 
        ' dgvStudents
        ' 
        dgvStudents.AllowUserToAddRows = False
        dgvStudents.AllowUserToDeleteRows = False
        dgvStudents.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudents.Location = New Point(16, 52)
        dgvStudents.MultiSelect = False
        dgvStudents.Name = "dgvStudents"
        dgvStudents.ReadOnly = True
        dgvStudents.RowHeadersWidth = 62
        dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStudents.Size = New Size(950, 430)
        dgvStudents.TabIndex = 1
        ' 
        ' lblDbStatus
        ' 
        lblDbStatus.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblDbStatus.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblDbStatus.Location = New Point(38, 497)
        lblDbStatus.Name = "lblDbStatus"
        lblDbStatus.Size = New Size(94, 38)
        lblDbStatus.TabIndex = 2
        lblDbStatus.Text = "Label1"
        ' 
        ' frmDatabaseBrowser
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(978, 544)
        Controls.Add(lblDbStatus)
        Controls.Add(dgvStudents)
        Controls.Add(btnReload)
        Name = "frmDatabaseBrowser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Database Students"
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnReload As Button
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents lblDbStatus As Label
End Class
