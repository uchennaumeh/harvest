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

Public Class LoanError
    Dim DAL As New ReturnFields
#Region "ERROR LOG"
    Public Shared Sub WriteLog(ByVal msg As String, ByVal msg2 As String)
        If msg.ToString.Contains("Thread was being aborted") Then
            ''do nothing
        Else
            Dim context As HttpContext = HttpContext.Current
            Dim _path As String
            _path = "~/App_Logs\ErrorLog.txt"
            Dim path As String = context.Server.MapPath(_path)
            Dim writer As New System.IO.StreamWriter(path, True)
            'writer.WriteLine(msg + " " + New LoanError().Get_Date() & " " & New LoanError().Get_Time())
            writer.WriteLine(msg + " " + msg2 + " " + New LoanError().Get_Date() & " " & New LoanError().Get_Time())
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
End Class
