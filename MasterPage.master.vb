Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Partial Class MasterPage
    Inherits System.Web.UI.MasterPage
    Private Connstring As String = ConfigurationManager.ConnectionStrings("connCane").ConnectionString
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            If Not Session("AdminOk") = True Then Response.Redirect("logout.aspx")
            Dim params() As SqlParameter = {New SqlParameter("@user", Session("user"))}
            Dim myReader As SqlDataReader = Nothing
            myReader = SqlHelper.ExecuteReader(Connstring, Data.CommandType.StoredProcedure, "CaneWeigh_Role_via_username_Fetch", params)
            If myReader.HasRows Then
                myReader.Read()
                'lblFullName.Text = myReader.GetString(2)
                'lblDept.Text = myReader.GetString(1)
                'ProfileImage.ImageUrl = myReader.GetString(0)
            Else
            End If
            If myReader IsNot Nothing Then
                myReader.Close()
            End If



            If Session("Role") = "1" Then
               transCh.Visible = False
                AllUsers.Visible = False
                resetP.Visible = False
                usermanagement.Visible = False
                AddUser.Visible = False
                usermanagement.Visible = False
                UserOffload.Visible = False
                weighOut.Visible = False
                enableUser.Visible = False
                disableUser.Visible = False
                TruckCreate.Visible = False
                ZoneCreate.Visible = False
                ShiftCreate.Visible = False
                EstateCreate.Visible = False
                FieldCreate.Visible = False


            ElseIf Session("Role") = "2" Then
               
                transCh.Visible = False
                AllUsers.Visible = False
                resetP.Visible = False
                usermanagement.Visible = False
                AddUser.Visible = False
                usermanagement.Visible = False
                UserTicket.Visible = False
                weighin.Visible = False
                enableUser.Visible = False
                disableUser.Visible = False
                TruckCreate.Visible = False
                ZoneCreate.Visible = False
                ShiftCreate.Visible = False
                EstateCreate.Visible = False
                FieldCreate.Visible = False


                'logout.Visible = True
            ElseIf Session("Role") = "3" Then
                'home.Visible = True


                'logout.Visible = True
            ElseIf Session("Role") = "4" Then
                AllUsers.Visible = False
                resetP.Visible = False
                usermanagement.Visible = False
                AddUser.Visible = False
                usermanagement.Visible = False
                enableUser.Visible = False
                disableUser.Visible = False
                TruckCreate.Visible = False
                ZoneCreate.Visible = False
                ShiftCreate.Visible = False
                EstateCreate.Visible = False
                FieldCreate.Visible = False

                'logout.Visible = True
            ElseIf Session("Role") = "5" Then
                AllUsers.Visible = False
                resetP.Visible = False
                usermanagement.Visible = False
                AddUser.Visible = False
                usermanagement.Visible = False
                enableUser.Visible = False
                disableUser.Visible = False
                TruckCreate.Visible = False
                ZoneCreate.Visible = False
                ShiftCreate.Visible = False
                EstateCreate.Visible = False
                FieldCreate.Visible = False


            ElseIf Session("Role") = "6" Then
                'home.Visible = True


            End If

        Catch ex As Exception
            caneLog.WriteLog(ex.Message, ex.Source)
        End Try
    End Sub
End Class

