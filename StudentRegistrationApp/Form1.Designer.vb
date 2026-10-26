<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        pnlHeader = New Panel()
        lblTitle = New Label()
        layoutForm = New TableLayoutPanel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtFullName = New TextBox()
        cboProgramme = New ComboBox()
        txtEmail = New TextBox()
        dtpBirthDate = New DateTimePicker()
        txtAddress = New TextBox()
        Label5 = New Label()
        pnlActions = New Panel()
        lblStatus = New StatusStrip()
        lblStatusLabel = New ToolStripStatusLabel()
        flowActions = New FlowLayoutPanel()
        btnCancel = New Button()
        btnSave = New Button()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ClearToolStripMenuItem1 = New ToolStripMenuItem()
        ExitToolStripMenuItem1 = New ToolStripMenuItem()
        Errors = New ErrorProvider(components)
        pnlHeader.SuspendLayout()
        layoutForm.SuspendLayout()
        pnlActions.SuspendLayout()
        lblStatus.SuspendLayout()
        flowActions.SuspendLayout()
        MenuStrip1.SuspendLayout()
        CType(Errors, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.RoyalBlue
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 33)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(906, 70)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(3, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(446, 48)
        lblTitle.TabIndex = 0
        lblTitle.Text = "STUDENT REGISTRATION"
        ' 
        ' layoutForm
        ' 
        layoutForm.AutoSize = True
        layoutForm.ColumnCount = 2
        layoutForm.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35F))
        layoutForm.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65F))
        layoutForm.Controls.Add(Label1, 0, 0)
        layoutForm.Controls.Add(Label2, 0, 1)
        layoutForm.Controls.Add(Label3, 0, 2)
        layoutForm.Controls.Add(Label4, 0, 3)
        layoutForm.Controls.Add(txtFullName, 1, 0)
        layoutForm.Controls.Add(cboProgramme, 1, 1)
        layoutForm.Controls.Add(txtEmail, 1, 2)
        layoutForm.Controls.Add(dtpBirthDate, 1, 3)
        layoutForm.Controls.Add(txtAddress, 1, 4)
        layoutForm.Controls.Add(Label5, 0, 4)
        layoutForm.Location = New Point(0, 103)
        layoutForm.Name = "layoutForm"
        layoutForm.Padding = New Padding(24)
        layoutForm.RowCount = 5
        layoutForm.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        layoutForm.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        layoutForm.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        layoutForm.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        layoutForm.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        layoutForm.Size = New Size(903, 391)
        layoutForm.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Location = New Point(27, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 25)
        Label1.TabIndex = 0
        Label1.Text = "Full name"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Location = New Point(27, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 25)
        Label2.TabIndex = 1
        Label2.Text = "Programme"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Location = New Point(27, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 25)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Location = New Point(27, 186)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 25)
        Label4.TabIndex = 3
        Label4.Text = "Date of Birth"
        ' 
        ' txtFullName
        ' 
        txtFullName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtFullName.Location = New Point(326, 30)
        txtFullName.Margin = New Padding(3, 6, 12, 6)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(541, 31)
        txtFullName.TabIndex = 5
        ' 
        ' cboProgramme
        ' 
        cboProgramme.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cboProgramme.FormattingEnabled = True
        cboProgramme.Items.AddRange(New Object() {"BSc Information Technology", "BSc Computer Science", "BSc Software Engineering", "Cybersecurity"})
        cboProgramme.Location = New Point(326, 80)
        cboProgramme.Margin = New Padding(3, 6, 12, 6)
        cboProgramme.Name = "cboProgramme"
        cboProgramme.Size = New Size(541, 33)
        cboProgramme.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtEmail.Location = New Point(326, 130)
        txtEmail.Margin = New Padding(3, 6, 12, 6)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(541, 31)
        txtEmail.TabIndex = 7
        ' 
        ' dtpBirthDate
        ' 
        dtpBirthDate.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dtpBirthDate.Location = New Point(326, 180)
        dtpBirthDate.Margin = New Padding(3, 6, 12, 6)
        dtpBirthDate.Name = "dtpBirthDate"
        dtpBirthDate.Size = New Size(541, 31)
        dtpBirthDate.TabIndex = 8
        ' 
        ' txtAddress
        ' 
        txtAddress.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtAddress.Location = New Point(326, 230)
        txtAddress.Margin = New Padding(3, 6, 12, 6)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(541, 46)
        txtAddress.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(27, 224)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 25)
        Label5.TabIndex = 10
        Label5.Text = "Address"
        ' 
        ' pnlActions
        ' 
        pnlActions.BackColor = Color.WhiteSmoke
        pnlActions.Controls.Add(lblStatus)
        pnlActions.Controls.Add(flowActions)
        pnlActions.Dock = DockStyle.Bottom
        pnlActions.Location = New Point(0, 497)
        pnlActions.Name = "pnlActions"
        pnlActions.Size = New Size(906, 75)
        pnlActions.TabIndex = 1
        ' 
        ' lblStatus
        ' 
        lblStatus.ImageScalingSize = New Size(24, 24)
        lblStatus.Items.AddRange(New ToolStripItem() {lblStatusLabel})
        lblStatus.Location = New Point(0, 43)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(673, 32)
        lblStatus.TabIndex = 1
        lblStatus.Text = "Ready"
        ' 
        ' lblStatusLabel
        ' 
        lblStatusLabel.Name = "lblStatusLabel"
        lblStatusLabel.Size = New Size(60, 25)
        lblStatusLabel.Text = "Ready"
        ' 
        ' flowActions
        ' 
        flowActions.Controls.Add(btnCancel)
        flowActions.Controls.Add(btnSave)
        flowActions.Dock = DockStyle.Right
        flowActions.FlowDirection = FlowDirection.TopDown
        flowActions.Location = New Point(673, 0)
        flowActions.Name = "flowActions"
        flowActions.Size = New Size(233, 75)
        flowActions.TabIndex = 0
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(3, 3)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 40)
        btnCancel.TabIndex = 1
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(121, 3)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(109, 40)
        btnSave.TabIndex = 0
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, ClearToolStripMenuItem1, ExitToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(906, 33)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(54, 29)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' ClearToolStripMenuItem1
        ' 
        ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        ClearToolStripMenuItem1.Size = New Size(67, 29)
        ClearToolStripMenuItem1.Text = "Clear"
        ' 
        ' ExitToolStripMenuItem1
        ' 
        ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        ExitToolStripMenuItem1.Size = New Size(55, 29)
        ExitToolStripMenuItem1.Text = "Exit"
        ' 
        ' Errors
        ' 
        Errors.BlinkStyle = ErrorBlinkStyle.NeverBlink
        Errors.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(906, 572)
        Controls.Add(pnlActions)
        Controls.Add(layoutForm)
        Controls.Add(pnlHeader)
        Controls.Add(MenuStrip1)
        MinimumSize = New Size(720, 520)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Registration"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        layoutForm.ResumeLayout(False)
        layoutForm.PerformLayout()
        pnlActions.ResumeLayout(False)
        pnlActions.PerformLayout()
        lblStatus.ResumeLayout(False)
        lblStatus.PerformLayout()
        flowActions.ResumeLayout(False)
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(Errors, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label


    Friend WithEvents layoutForm As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

    Friend WithEvents txtFullName As TextBox
    Friend WithEvents cboProgramme As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents txtAddress As TextBox



    Friend WithEvents pnlActions As Panel
    Friend WithEvents flowActions As FlowLayoutPanel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblStatus As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents Errors As ErrorProvider
    Friend WithEvents lblStatusLabel As ToolStripStatusLabel



End Class
