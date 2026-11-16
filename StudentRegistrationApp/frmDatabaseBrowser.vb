Imports Microsoft.Data.SqlClient
Imports System.Threading.Tasks

Public Class frmDatabaseBrowser

    Private ReadOnly _repo As New StudentRepository()

    Private Async Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        btnReload.Enabled = False
        Try
            Dim records = Await _repo.GetAllAsync()
            dgvStudents.DataSource = records
            lblDbStatus.Text = $"{records.Count} database students."
        Catch ex As SqlException
            MessageBox.Show(Me, ex.Message, "Database error")
        Finally
            btnReload.Enabled = True
        End Try
    End Sub

    Private Sub frmDatabaseBrowser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not btnReload.Enabled Then e.Cancel = True
    End Sub

End Class