Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class userHome
    Inherits System.Web.UI.Page
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        txtDepartment.Text = Session("Department")
        txtBranch.Text = Session("Branch")
        txtUsername.Text = Session("User")
        txtRole.Text = Session("Role")

        'If txtRole.Text = "1" Then
        '    Panel3.Visible = True
        'ElseIf txtRole.Text = "2" Then
        '    Panel1.Visible = True
        'ElseIf txtRole.Text = "3" Then
        '    Panel2.Visible = True
        'End If
    End Sub
End Class
