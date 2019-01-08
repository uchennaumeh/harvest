Imports Microsoft.VisualBasic
Imports System.Web.Mail
Imports System.Web
Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Web.UI.UserControl
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.Common
Imports System.Web.SessionState.HttpSessionState
Imports System.Net
Imports System.Threading
Imports System.Runtime.Remoting
Imports System
Imports System.IO

Public Class Appraise_BLL
    Dim DAL As New ReturnFields
#Region "ERROR LOG"
    Public Shared Sub WriteLog(ByVal msg As String)
        If msg.ToString.Contains("Thread was being aborted") Then
            ''do nothing
        Else
            Dim context As HttpContext = HttpContext.Current
            Dim _path As String
            _path = "~/App_Logs\ErrorLog.txt"
            Dim path As String = context.Server.MapPath(_path)
            Dim writer As New System.IO.StreamWriter(path, True)
            writer.WriteLine(msg + " " + New Appraise_BLL().Get_Date() & " " & New Appraise_BLL().Get_Time())
            writer.Close()
        End If
    End Sub
#End Region
#Region "DATE GETTER"
    Public Function Get_Date() As String
        Return Format(DateTime.Now, "dd/MM/yyyy")
    End Function
#End Region

#Region "TIME GETTER"
    Public Function Get_Time() As String
        Return Format(DateAndTime.Now, "hh:mm:ss tt").ToUpper
    End Function
#End Region

#Region "PRINT Drill Down Report"
    Public Shared Function CheckPrintURL(ByVal ReportName As String, ByVal TheID As String) As String
        If TheID <> "" Then
            Select Case ReportName.ToUpper
                Case "PLANBENEFITS"
                    Return "var ScreenWidth=window.screen.width;" & "var ScreenHeight=window.screen.height;" & "var movefromedge=0;" & "placementx=(ScreenWidth/2)-((518)/2);" & "placementy=(ScreenHeight/2)-((550+50)/2);" & "window.open('../../Reports/Product Report/DrilldownBenefits.aspx?PlanCode=" & TheID & "','_blank','toolbar=no,resizable=0,width=470,height=335,scrollbars=no');"
                Case "SCHEME"
                    Return "var ScreenWidth=window.screen.width;" & "var ScreenHeight=window.screen.height;" & "var movefromedge=0;" & "placementx=(ScreenWidth/2)-((618)/2);" & "placementy=(ScreenHeight/2)-((650+50)/2);" & "window.open('../../Reports/Product Report/DrilldownBenefits.aspx?SchemeID=" & TheID & "','_blank','toolbar=no,resizable=0,width=570,height=635,scrollbars=no');"
                Case "ENROLLEE"
                    Return "var ScreenWidth=window.screen.width;" & "var ScreenHeight=window.screen.height;" & "var movefromedge=0;" & "placementx=(ScreenWidth/2)-((900)/2);" & "placementy=(ScreenHeight/2)-((650+50)/2);" & "window.open('../../Enrollee/Views/EnrolleeDrillDown.aspx?Enrollee_Number=" & TheID & "','_blank','toolbar=no,resizable=0,width=900,height=650,scrollbars=yes');"
                Case "ACCESSRIGHT"
                    Return "var ScreenWidth=window.screen.width;" & "var ScreenHeight=window.screen.height;" & "var movefromedge=0;" & "placementx=(ScreenWidth/2)-((1018)/2);" & "placementy=(ScreenHeight/2)-((750+50)/2);" & "window.open('../../AddsOn/AccessRights.aspx?RoleID=" & TheID & "','_blank','toolbar=no,resizable=0,width=1018,height=750,scrollbars=yes');"
                Case "CARDPRINT"
                    Return "var ScreenWidth=window.screen.width;" & "var ScreenHeight=window.screen.height;" & "var movefromedge=0;" & "placementx=(ScreenWidth/2)-((518)/2);" & "placementy=(ScreenHeight/2)-((550+50)/2);" & "window.open('../../Enrollee/Pages/PrintCard.aspx?Enrollee_Number=" & TheID & "','_blank','toolbar=no,resizable=0,width=470,height=335,scrollbars=yes');"

            End Select
        End If
    End Function
#End Region

End Class
