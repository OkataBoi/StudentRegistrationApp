<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecordCheck
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
        prgCheck = New ProgressBar()
        lstResults = New ListBox()
        btnStart = New Button()
        btnCancelCheck = New Button()
        btnClose = New Button()
        lblProgress = New Label()
        SuspendLayout()
        ' 
        ' prgCheck
        ' 
        prgCheck.Location = New Point(24, 65)
        prgCheck.Name = "prgCheck"
        prgCheck.Size = New Size(660, 24)
        prgCheck.Style = ProgressBarStyle.Continuous
        prgCheck.TabIndex = 1
        ' 
        ' lstResults
        ' 
        lstResults.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lstResults.FormattingEnabled = True
        lstResults.HorizontalScrollbar = True
        lstResults.Location = New Point(24, 110)
        lstResults.Name = "lstResults"
        lstResults.Size = New Size(660, 229)
        lstResults.TabIndex = 2
        ' 
        ' btnStart
        ' 
        btnStart.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnStart.Location = New Point(100, 352)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(110, 36)
        btnStart.TabIndex = 3
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' btnCancelCheck
        ' 
        btnCancelCheck.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCancelCheck.Enabled = False
        btnCancelCheck.Location = New Point(269, 352)
        btnCancelCheck.Name = "btnCancelCheck"
        btnCancelCheck.Size = New Size(110, 36)
        btnCancelCheck.TabIndex = 4
        btnCancelCheck.Text = "Cancel"
        btnCancelCheck.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClose.Location = New Point(459, 352)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(110, 36)
        btnClose.TabIndex = 5
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' lblProgress
        ' 
        lblProgress.AutoSize = True
        lblProgress.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProgress.Location = New Point(24, 24)
        lblProgress.Name = "lblProgress"
        lblProgress.Size = New Size(88, 32)
        lblProgress.TabIndex = 0
        lblProgress.Text = "Label1"
        ' 
        ' frmRecordCheck
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(698, 404)
        Controls.Add(lblProgress)
        Controls.Add(btnClose)
        Controls.Add(btnCancelCheck)
        Controls.Add(btnStart)
        Controls.Add(lstResults)
        Controls.Add(prgCheck)
        Name = "frmRecordCheck"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Check Student Records"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents prgCheck As ProgressBar
    Friend WithEvents lstResults As ListBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnCancelCheck As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblProgress As Label
End Class
