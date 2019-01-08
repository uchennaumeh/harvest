Imports Microsoft.VisualBasic
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.Common
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.Threading
Imports System.Runtime.Remoting
Imports DataObjects
Imports System.Net.Mail


Public Class ReturnFields
    Dim cn As SqlConnection

    Public Sub New()
        cn = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("connCane").ConnectionString)
    End Sub
    Public Function AppSendMailStart(ByVal fullname As String, ByVal email As String, ByVal username As String)


        Dim HtmlContent As String
        HtmlContent = HtmlContent & "<HTML>"
        HtmlContent = HtmlContent & "<HEAD>"
        HtmlContent = HtmlContent & "<TITLE>STAFF APPRAISAL::Kick Off</TITLE>"
        HtmlContent = HtmlContent & "<style type=""text/css"">"
        HtmlContent = HtmlContent & "<!--"
        HtmlContent = HtmlContent & ".style12 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; }"
        HtmlContent = HtmlContent & ".style14 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; }"
        HtmlContent = HtmlContent & "-->"
        HtmlContent = HtmlContent & "</style>"
        HtmlContent = HtmlContent & "</HEAD>"
        HtmlContent = HtmlContent & "<BODY>"
        HtmlContent = HtmlContent & "<div align=""center"">"
        HtmlContent = HtmlContent & "<center>"
        HtmlContent = HtmlContent & "<table width=""704"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"">"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td width=""542"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td width=""162"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><img src=""http://www.royalexchangeplc.com/images/logo.jpg"" width=""162"" height=""28"" /></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style14"">Dear " & fullname & ",</span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Please be informed that staff appraisal for the quarter has commenced</span></td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">your userID is " & username & " while your password is 'royal'. Please make use of the UserID and password if you are logging in for the first time on the application. </Br>Any complaints should be directed to HR and/or ICT</span></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Click to Log into <a href=""http://192.168.30.32/appraiseme""/> APPRAISE ME</a></span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Regards,</span></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Royal Exchange APPRAISEME </span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "</table>"
        HtmlContent = HtmlContent & "</center></div>"
        HtmlContent = HtmlContent & "</body>"
        HtmlContent = HtmlContent & "</html>"

        Dim ToEmail = email
        Const ToFrom As String = "appraiseme@royalexchangeplc.com"

        Dim mm As New MailMessage(ToFrom, ToEmail)


        mm.Subject = "STAFF APPRAISAL::Kick Off MAIL"
        mm.Body = HtmlContent
        mm.IsBodyHtml = True
        mm.Priority = MailPriority.High


        Dim smtp As SmtpClient = New SmtpClient("172.16.1.2", 25)
        smtp.Send(mm)

    End Function
    Public Function AppSendMailStop(ByVal fullname As String, ByVal email As String)


        Dim HtmlContent As String
        HtmlContent = HtmlContent & "<HTML>"
        HtmlContent = HtmlContent & "<HEAD>"
        HtmlContent = HtmlContent & "<TITLE>STAFF APPRAISAL::Closure</TITLE>"
        HtmlContent = HtmlContent & "<style type=""text/css"">"
        HtmlContent = HtmlContent & "<!--"
        HtmlContent = HtmlContent & ".style12 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; }"
        HtmlContent = HtmlContent & ".style14 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; }"
        HtmlContent = HtmlContent & "-->"
        HtmlContent = HtmlContent & "</style>"
        HtmlContent = HtmlContent & "</HEAD>"
        HtmlContent = HtmlContent & "<BODY>"
        HtmlContent = HtmlContent & "<div align=""center"">"
        HtmlContent = HtmlContent & "<center>"
        HtmlContent = HtmlContent & "<table width=""704"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"">"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td width=""542"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td width=""162"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><img src=""http://www.royalexchangeplc.com/images/logo.jpg"" width=""162"" height=""28"" /></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style14"">Dear " & fullname & ",</span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Please be informed that staff appraisal for the quarter has CLOSED</span></td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">We hope your appraisal for the quarter has been successfully concluded. </Br>Any complaints should be directed to HR and/or ICT</span></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">.</span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Regards,</span></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Royal Exchange APPRAISEME </span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "</table>"
        HtmlContent = HtmlContent & "</center></div>"
        HtmlContent = HtmlContent & "</body>"
        HtmlContent = HtmlContent & "</html>"

        Dim ToEmail = email
        Const ToFrom As String = "appraiseme@royalexchangeplc.com"

        Dim mm As New MailMessage(ToFrom, ToEmail)


        mm.Subject = "STAFF APPRAISAL::Closure"
        mm.Body = HtmlContent
        mm.IsBodyHtml = True
        mm.Priority = MailPriority.High


        Dim smtp As SmtpClient = New SmtpClient("172.16.1.2", 25)
        smtp.Send(mm)

    End Function
    Public Function AppSendMailCust(ByVal subject As String, ByVal email As String, ByVal bodyy As String)


        'Dim HtmlContent As String
        'HtmlContent = HtmlContent & "<HTML>"
        'HtmlContent = HtmlContent & "<HEAD>"
        'HtmlContent = HtmlContent & "<TITLE>STAFF APPRAISAL::Kick Off</TITLE>"
        'HtmlContent = HtmlContent & "<style type=""text/css"">"
        'HtmlContent = HtmlContent & "<!--"
        'HtmlContent = HtmlContent & ".style12 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; }"
        'HtmlContent = HtmlContent & ".style14 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; }"
        'HtmlContent = HtmlContent & "-->"
        'HtmlContent = HtmlContent & "</style>"
        'HtmlContent = HtmlContent & "</HEAD>"
        'HtmlContent = HtmlContent & "<BODY>"
        'HtmlContent = HtmlContent & "<div align=""center"">"
        'HtmlContent = HtmlContent & "<center>"
        'HtmlContent = HtmlContent & "<table width=""704"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"">"
        'HtmlContent = HtmlContent & "<tr>"
        'HtmlContent = HtmlContent & "<td width=""542"" align=""left"" valign=""top"">&nbsp;</td>"
        'HtmlContent = HtmlContent & "<td width=""162"" align=""left"" valign=""top"">&nbsp;</td>"
        'HtmlContent = HtmlContent & "</tr>"
        'HtmlContent = HtmlContent & "<tr>"
        'HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        'HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><img src=""http://www.royalexchangeplc.com/images/logo.jpg"" width=""162"" height=""28"" /></td>"
        'HtmlContent = HtmlContent & "</tr>"
        'HtmlContent = HtmlContent & " <tr>"
        'HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style14"">Dear " & fullname & ",</span></td>"
        'HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        'HtmlContent = HtmlContent & "</tr>"
        'HtmlContent = HtmlContent & " <tr>"
        'HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        'HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        'HtmlContent = HtmlContent & " </tr>"
        'HtmlContent = HtmlContent & "<tr>"
        'HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Please be informed that staff appraisal for the quarter has commenced</span></td>"
        'HtmlContent = HtmlContent & " </tr>"
        'HtmlContent = HtmlContent & "<tr>"
        'HtmlContent = HtmlContent & " <td align=""left"" valign=""top"">&nbsp;</td>"
        'HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        'HtmlContent = HtmlContent & "</tr>"
        'HtmlContent = HtmlContent & "<tr>"
        'HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">your userID is " & username & " while your password is 'royal'. Please make use of the UserID and password if you are logging in for the first time on the application. </Br>Any complaints should be directed to HR and/or ICT</span></td>"
        'HtmlContent = HtmlContent & "</tr>"
        'HtmlContent = HtmlContent & "<tr>"
        'HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top"">&nbsp;</td>"
        'HtmlContent = HtmlContent & "</tr>"
        'HtmlContent = HtmlContent & " <tr>"
        'HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Click to Log into <a href=""http://192.168.30.39/appraisemee""/> APPRAISE ME</a></span></td>"
        'HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        'HtmlContent = HtmlContent & " <tr>"
        'HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Regards,</span></td>"
        'HtmlContent = HtmlContent & "</tr>"
        'HtmlContent = HtmlContent & "<tr>"
        'HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Royal Exchange APPRAISEME </span></td>"
        'HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        'HtmlContent = HtmlContent & "</tr>"
        'HtmlContent = HtmlContent & "</table>"
        'HtmlContent = HtmlContent & "</center></div>"
        'HtmlContent = HtmlContent & "</body>"
        'HtmlContent = HtmlContent & "</html>"

        Dim ToEmail = email
        Const ToFrom As String = "appraiseme@royalexchangeplc.com"

        Dim mm As New MailMessage(ToFrom, ToEmail)


        mm.Subject = subject
        mm.Body = bodyy
        mm.IsBodyHtml = False
        mm.Priority = MailPriority.High


        Dim smtp As SmtpClient = New SmtpClient("172.16.1.2", 25)
        smtp.Send(mm)

    End Function
    Public Function AppSendMailAppraised(ByVal fullname As String, ByVal email As String)


        Dim HtmlContent As String
        HtmlContent = HtmlContent & "<HTML>"
        HtmlContent = HtmlContent & "<HEAD>"
        HtmlContent = HtmlContent & "<TITLE>STAFF APPRAISAL::SUPERVISOR APPRAISAL</TITLE>"
        HtmlContent = HtmlContent & "<style type=""text/css"">"
        HtmlContent = HtmlContent & "<!--"
        HtmlContent = HtmlContent & ".style12 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; }"
        HtmlContent = HtmlContent & ".style14 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; }"
        HtmlContent = HtmlContent & "-->"
        HtmlContent = HtmlContent & "</style>"
        HtmlContent = HtmlContent & "</HEAD>"
        HtmlContent = HtmlContent & "<BODY>"
        HtmlContent = HtmlContent & "<div align=""center"">"
        HtmlContent = HtmlContent & "<center>"
        HtmlContent = HtmlContent & "<table width=""704"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"">"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td width=""542"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td width=""162"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><img src=""http://www.royalexchangeplc.com/images/logo.jpg"" width=""162"" height=""28"" /></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style14"">Dear " & fullname & ",</span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Please be informed that your Supervisor has just CONCLUDED your appraisal for the quarter</span></td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">kindly log on to the application using your UserID and password to accept or reject your supervisors appraisal</span></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Click to Log into <a href=""http://192.168.30.32/appraiseme""/> APPRAISE ME</a></span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Regards,</span></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Royal Exchange APPRAISEME </span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "</table>"
        HtmlContent = HtmlContent & "</center></div>"
        HtmlContent = HtmlContent & "</body>"
        HtmlContent = HtmlContent & "</html>"

        Dim ToEmail = email
        Const ToFrom As String = "appraiseme@royalexchangeplc.com"

        Dim mm As New MailMessage(ToFrom, ToEmail)


        mm.Subject = "STAFF APPRAISAL::SUPERVISOR APPRAISAL"
        mm.Body = HtmlContent
        mm.IsBodyHtml = True
        mm.Priority = MailPriority.High


        Dim smtp As SmtpClient = New SmtpClient("172.16.1.2", 25)
        smtp.Send(mm)

    End Function
    Public Function AppSendMailAppraieAccept(ByVal fullname As String, ByVal email As String, ByVal username As String)


        Dim HtmlContent As String
        HtmlContent = HtmlContent & "<HTML>"
        HtmlContent = HtmlContent & "<HEAD>"
        HtmlContent = HtmlContent & "<TITLE>STAFF APPRAISAL::SUBORDINATE APPRAISAL ACCEPTANCE</TITLE>"
        HtmlContent = HtmlContent & "<style type=""text/css"">"
        HtmlContent = HtmlContent & "<!--"
        HtmlContent = HtmlContent & ".style12 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; }"
        HtmlContent = HtmlContent & ".style14 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; }"
        HtmlContent = HtmlContent & "-->"
        HtmlContent = HtmlContent & "</style>"
        HtmlContent = HtmlContent & "</HEAD>"
        HtmlContent = HtmlContent & "<BODY>"
        HtmlContent = HtmlContent & "<div align=""center"">"
        HtmlContent = HtmlContent & "<center>"
        HtmlContent = HtmlContent & "<table width=""704"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"">"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td width=""542"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td width=""162"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><img src=""http://www.royalexchangeplc.com/images/logo.jpg"" width=""162"" height=""28"" /></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style14"">Dear " & fullname & ",</span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Please be informed that " & username & " has ACCEPTED your appraisal of him/her</span></td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">kindly log on to the application using your UserID and password to append the appraisee final score on 'ACCEPTED APPRAISAL' tab</span></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Click to Log into <a href=""http://192.168.30.32/appraiseme""/> APPRAISE ME</a></span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Sincerely,</span></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Royal Exchange APPRAISEME </span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "</table>"
        HtmlContent = HtmlContent & "</center></div>"
        HtmlContent = HtmlContent & "</body>"
        HtmlContent = HtmlContent & "</html>"

        Dim ToEmail = email
        Const ToFrom As String = "appraiseme@royalexchangeplc.com"

        Dim mm As New MailMessage(ToFrom, ToEmail)


        mm.Subject = "STAFF APPRAISAL::SUBORDINATE APPRAISAL ACCEPTANCE"
        mm.Body = HtmlContent
        mm.IsBodyHtml = True
        mm.Priority = MailPriority.High


        Dim smtp As SmtpClient = New SmtpClient("172.16.1.2", 25)
        smtp.Send(mm)

    End Function
    Public Function AppSendMailAppraieReject(ByVal fullname As String, ByVal email As String, ByVal username As String)


        Dim HtmlContent As String
        HtmlContent = HtmlContent & "<HTML>"
        HtmlContent = HtmlContent & "<HEAD>"
        HtmlContent = HtmlContent & "<TITLE>STAFF APPRAISAL::SUBORDINATE APPRAISAL REJECTION</TITLE>"
        HtmlContent = HtmlContent & "<style type=""text/css"">"
        HtmlContent = HtmlContent & "<!--"
        HtmlContent = HtmlContent & ".style12 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; }"
        HtmlContent = HtmlContent & ".style14 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; }"
        HtmlContent = HtmlContent & "-->"
        HtmlContent = HtmlContent & "</style>"
        HtmlContent = HtmlContent & "</HEAD>"
        HtmlContent = HtmlContent & "<BODY>"
        HtmlContent = HtmlContent & "<div align=""center"">"
        HtmlContent = HtmlContent & "<center>"
        HtmlContent = HtmlContent & "<table width=""704"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"">"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td width=""542"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td width=""162"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><img src=""http://www.royalexchangeplc.com/images/logo.jpg"" width=""162"" height=""28"" /></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style14"">Dear " & fullname & ",</span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Please be informed that " & username & " has REJECTED your appraisal of him/her</span></td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">kindly log on to the application using your SUPERVISOR ID and Password to find out appraisee's comments on 'REJECTED APPRAISAL' tab.</span></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Click to Log into <a href=""http://192.168.30.32/appraiseme""/> APPRAISE ME</a></span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Sincerely,</span></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Royal Exchange APPRAISEME </span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "</table>"
        HtmlContent = HtmlContent & "</center></div>"
        HtmlContent = HtmlContent & "</body>"
        HtmlContent = HtmlContent & "</html>"

        Dim ToEmail = email
        Const ToFrom As String = "appraiseme@royalexchangeplc.com"

        Dim mm As New MailMessage(ToFrom, ToEmail)


        mm.Subject = "STAFF APPRAISAL::SUBORDINATE APPRAISAL REJECTION"
        mm.Body = HtmlContent
        mm.IsBodyHtml = True
        mm.Priority = MailPriority.High


        Dim smtp As SmtpClient = New SmtpClient("172.16.1.2", 25)
        smtp.Send(mm)

    End Function
    Public Function AppSendMailAppraieReject2(ByVal fullname As String, ByVal email As String, ByVal username As String)


        Dim HtmlContent As String
        HtmlContent = HtmlContent & "<HTML>"
        HtmlContent = HtmlContent & "<HEAD>"
        HtmlContent = HtmlContent & "<TITLE>STAFF APPRAISAL::SUBORDINATE APPRAISAL REJECTION</TITLE>"
        HtmlContent = HtmlContent & "<style type=""text/css"">"
        HtmlContent = HtmlContent & "<!--"
        HtmlContent = HtmlContent & ".style12 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; }"
        HtmlContent = HtmlContent & ".style14 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; }"
        HtmlContent = HtmlContent & "-->"
        HtmlContent = HtmlContent & "</style>"
        HtmlContent = HtmlContent & "</HEAD>"
        HtmlContent = HtmlContent & "<BODY>"
        HtmlContent = HtmlContent & "<div align=""center"">"
        HtmlContent = HtmlContent & "<center>"
        HtmlContent = HtmlContent & "<table width=""704"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"">"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td width=""542"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td width=""162"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><img src=""http://www.royalexchangeplc.com/images/logo.jpg"" width=""162"" height=""28"" /></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style14"">Dear " & fullname & ",</span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Please be informed that " & username & " has REJECTED Supervisors Appraisal MORE THAN ONCE, as such it has been sent to you</span></td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">kindly log on to the application using your BOSS ID and password to find his comments on 'BOSS APPRAISAL' tab. You may ask supervisor to re-appraise or you may accept the appraisal by Supervisor</span></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Click to Log into <a href=""http://192.168.30.32/appraiseme""/> APPRAISE ME</a></span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Regards,</span></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Royal Exchange APPRAISEME </span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "</table>"
        HtmlContent = HtmlContent & "</center></div>"
        HtmlContent = HtmlContent & "</body>"
        HtmlContent = HtmlContent & "</html>"

        Dim ToEmail = email
        Const ToFrom As String = "appraiseme@royalexchangeplc.com"

        Dim mm As New MailMessage(ToFrom, ToEmail)


        mm.Subject = "STAFF APPRAISAL::SUBORDINATE APPRAISAL MULTIPLE REJECTION"
        mm.Body = HtmlContent
        mm.IsBodyHtml = True
        mm.Priority = MailPriority.High


        Dim smtp As SmtpClient = New SmtpClient("172.16.1.2", 25)
        smtp.Send(mm)

    End Function
    Public Function AppSendMailAppraiePassReset(ByVal fullname As String, ByVal email As String)


        Dim HtmlContent As String
        HtmlContent = HtmlContent & "<HTML>"
        HtmlContent = HtmlContent & "<HEAD>"
        HtmlContent = HtmlContent & "<TITLE>STAFF APPRAISAL::SELF PASSWORD RESET</TITLE>"
        HtmlContent = HtmlContent & "<style type=""text/css"">"
        HtmlContent = HtmlContent & "<!--"
        HtmlContent = HtmlContent & ".style12 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; }"
        HtmlContent = HtmlContent & ".style14 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; }"
        HtmlContent = HtmlContent & "-->"
        HtmlContent = HtmlContent & "</style>"
        HtmlContent = HtmlContent & "</HEAD>"
        HtmlContent = HtmlContent & "<BODY>"
        HtmlContent = HtmlContent & "<div align=""center"">"
        HtmlContent = HtmlContent & "<center>"
        HtmlContent = HtmlContent & "<table width=""704"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"">"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td width=""542"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td width=""162"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><img src=""http://www.royalexchangeplc.com/images/logo.jpg"" width=""162"" height=""28"" /></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style14"">Dear " & fullname & ",</span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Please be informed that your password has been reset to 'royal'<br>Kindly login with this password and change it afterwards</span></td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        'HtmlContent = HtmlContent & "<tr>"
        'HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">kindly log on to the application using your BOSS ID and password to find his comments on 'BOSS APPRAISAL' tab. You may ask supervisor to re-appraise or you may accept the appraisal by Supervisor</span></td>"
        'HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Click to Log into <a href=""http://192.168.30.32/appraiseme""/> APPRAISE ME</a></span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Regards,</span></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Royal Exchange APPRAISEME </span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "</table>"
        HtmlContent = HtmlContent & "</center></div>"
        HtmlContent = HtmlContent & "</body>"
        HtmlContent = HtmlContent & "</html>"

        Dim ToEmail = email
        Const ToFrom As String = "appraiseme@royalexchangeplc.com"

        Dim mm As New MailMessage(ToFrom, ToEmail)


        mm.Subject = "STAFF APPRAISAL::SELF PASSWORD RESET"
        mm.Body = HtmlContent
        mm.IsBodyHtml = True
        mm.Priority = MailPriority.High


        Dim smtp As SmtpClient = New SmtpClient("172.16.1.2", 25)
        smtp.Send(mm)

    End Function
    Public Function AppSendMailAppraiePassResetAdmin(ByVal fullname As String, ByVal email As String)


        Dim HtmlContent As String
        HtmlContent = HtmlContent & "<HTML>"
        HtmlContent = HtmlContent & "<HEAD>"
        HtmlContent = HtmlContent & "<TITLE>STAFF APPRAISAL::ADMIN PASSWORD RESET</TITLE>"
        HtmlContent = HtmlContent & "<style type=""text/css"">"
        HtmlContent = HtmlContent & "<!--"
        HtmlContent = HtmlContent & ".style12 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; }"
        HtmlContent = HtmlContent & ".style14 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; }"
        HtmlContent = HtmlContent & "-->"
        HtmlContent = HtmlContent & "</style>"
        HtmlContent = HtmlContent & "</HEAD>"
        HtmlContent = HtmlContent & "<BODY>"
        HtmlContent = HtmlContent & "<div align=""center"">"
        HtmlContent = HtmlContent & "<center>"
        HtmlContent = HtmlContent & "<table width=""704"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"">"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td width=""542"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td width=""162"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><img src=""http://www.royalexchangeplc.com/images/logo.jpg"" width=""162"" height=""28"" /></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style14"">Dear " & fullname & ",</span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Please be informed that your password has been reset to 'royal'<br>Kindly login with this password and change it afterwards</span></td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        'HtmlContent = HtmlContent & "<tr>"
        'HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">kindly log on to the application using your BOSS ID and password to find his comments on 'BOSS APPRAISAL' tab. You may ask supervisor to re-appraise or you may accept the appraisal by Supervisor</span></td>"
        'HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Click to Log into <a href=""http://192.168.30.32/appraiseme""/> APPRAISE ME</a></span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Regards,</span></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Royal Exchange APPRAISEME </span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "</table>"
        HtmlContent = HtmlContent & "</center></div>"
        HtmlContent = HtmlContent & "</body>"
        HtmlContent = HtmlContent & "</html>"

        Dim ToEmail = email
        Const ToFrom As String = "appraiseme@royalexchangeplc.com"

        Dim mm As New MailMessage(ToFrom, ToEmail)


        mm.Subject = "STAFF APPRAISAL::ADMIN PASSWORD RESET"
        mm.Body = HtmlContent
        mm.IsBodyHtml = True
        mm.Priority = MailPriority.High


        Dim smtp As SmtpClient = New SmtpClient("172.16.1.2", 25)
        smtp.Send(mm)

    End Function
    Public Function AppSendMailScorecardEdit(ByVal fullname As String, ByVal email As String)


        Dim HtmlContent As String
        HtmlContent = HtmlContent & "<HTML>"
        HtmlContent = HtmlContent & "<HEAD>"
        HtmlContent = HtmlContent & "<TITLE>STAFF APPRAISAL::ADMIN PASSWORD RESET</TITLE>"
        HtmlContent = HtmlContent & "<style type=""text/css"">"
        HtmlContent = HtmlContent & "<!--"
        HtmlContent = HtmlContent & ".style12 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; }"
        HtmlContent = HtmlContent & ".style14 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; }"
        HtmlContent = HtmlContent & "-->"
        HtmlContent = HtmlContent & "</style>"
        HtmlContent = HtmlContent & "</HEAD>"
        HtmlContent = HtmlContent & "<BODY>"
        HtmlContent = HtmlContent & "<div align=""center"">"
        HtmlContent = HtmlContent & "<center>"
        HtmlContent = HtmlContent & "<table width=""704"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"">"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td width=""542"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td width=""162"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><img src=""http://www.royalexchangeplc.com/images/logo.jpg"" width=""162"" height=""28"" /></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style14"">Dear " & fullname & ",</span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Please be informed that your ScoreCard File has been Edited By Human Resources Admin"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        'HtmlContent = HtmlContent & "<tr>"
        'HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">kindly log on to the application using your BOSS ID and password to find his comments on 'BOSS APPRAISAL' tab. You may ask supervisor to re-appraise or you may accept the appraisal by Supervisor</span></td>"
        'HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Click to Log into <a href=""http://192.168.30.32/appraiseme""/> APPRAISE ME</a></span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Regards,</span></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Royal Exchange APPRAISEME </span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "</table>"
        HtmlContent = HtmlContent & "</center></div>"
        HtmlContent = HtmlContent & "</body>"
        HtmlContent = HtmlContent & "</html>"

        Dim ToEmail = email
        Const ToFrom As String = "appraiseme@royalexchangeplc.com"

        Dim mm As New MailMessage(ToFrom, ToEmail)


        mm.Subject = "STAFF APPRAISAL::ADMIN PASSWORD RESET"
        mm.Body = HtmlContent
        mm.IsBodyHtml = True
        mm.Priority = MailPriority.High


        Dim smtp As SmtpClient = New SmtpClient("192.168.10.2", 25)
        smtp.Send(mm)

    End Function
    Public Function AppSendMailBOB(ByVal fullname As String, ByVal email As String, ByVal SupUsername As String, ByVal username As String)


        Dim HtmlContent As String
        HtmlContent = HtmlContent & "<HTML>"
        HtmlContent = HtmlContent & "<HEAD>"
        HtmlContent = HtmlContent & "<TITLE>STAFF APPRAISAL::SUPERVISOR SUB APPRAISAL</TITLE>"
        HtmlContent = HtmlContent & "<style type=""text/css"">"
        HtmlContent = HtmlContent & "<!--"
        HtmlContent = HtmlContent & ".style12 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; }"
        HtmlContent = HtmlContent & ".style14 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; }"
        HtmlContent = HtmlContent & "-->"
        HtmlContent = HtmlContent & "</style>"
        HtmlContent = HtmlContent & "</HEAD>"
        HtmlContent = HtmlContent & "<BODY>"
        HtmlContent = HtmlContent & "<div align=""center"">"
        HtmlContent = HtmlContent & "<center>"
        HtmlContent = HtmlContent & "<table width=""704"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"">"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td width=""542"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td width=""162"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><img src=""http://www.royalexchangeplc.com/images/logo.jpg"" width=""162"" height=""28"" /></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style14"">Dear " & fullname & ",</span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Please be informed that " & username & " has been APPRAISED by supervisor " & SupUsername & "</span></td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">kindly log on to the application using your UserID and Password to ACCEPT or REJECT this appraisal on 'BOSS APPRAISAL' tab</span></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Click to Log into <a href=""http://192.168.30.32/appraiseme""/> APPRAISE ME</a></span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Regards,</span></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Royal Exchange APPRAISEME </span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "</table>"
        HtmlContent = HtmlContent & "</center></div>"
        HtmlContent = HtmlContent & "</body>"
        HtmlContent = HtmlContent & "</html>"

        Dim ToEmail = email
        Const ToFrom As String = "appraiseme@royalexchangeplc.com"

        Dim mm As New MailMessage(ToFrom, ToEmail)


        mm.Subject = "STAFF APPRAISAL::SUPERVISOR SUB APPRAISAL"
        mm.Body = HtmlContent
        mm.IsBodyHtml = True
        mm.Priority = MailPriority.High


        Dim smtp As SmtpClient = New SmtpClient("172.16.1.2", 25)
        smtp.Send(mm)

    End Function
    Public Function AppSendMailBOBRejected(ByVal fullname As String, ByVal email As String, ByVal Bossname As String, ByVal username As String)


        Dim HtmlContent As String
        HtmlContent = HtmlContent & "<HTML>"
        HtmlContent = HtmlContent & "<HEAD>"
        HtmlContent = HtmlContent & "<TITLE>STAFF APPRAISAL::BOSS REJECTION APPRAISAL</TITLE>"
        HtmlContent = HtmlContent & "<style type=""text/css"">"
        HtmlContent = HtmlContent & "<!--"
        HtmlContent = HtmlContent & ".style12 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; }"
        HtmlContent = HtmlContent & ".style14 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; }"
        HtmlContent = HtmlContent & "-->"
        HtmlContent = HtmlContent & "</style>"
        HtmlContent = HtmlContent & "</HEAD>"
        HtmlContent = HtmlContent & "<BODY>"
        HtmlContent = HtmlContent & "<div align=""center"">"
        HtmlContent = HtmlContent & "<center>"
        HtmlContent = HtmlContent & "<table width=""704"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"">"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td width=""542"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td width=""162"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><img src=""http://www.royalexchangeplc.com/images/logo.jpg"" width=""162"" height=""28"" /></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style14"">Dear " & fullname & ",</span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Please be informed that Boss " & Bossname & " has been REJECTED your Appraisal of " & username & "</span></td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">kindly log on to the application using your UserID and password to RE-APPRAISE " & username & " on 'REJECTED APPRAISAL' tab</span></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Click to Log into <a href=""http://192.168.30.32/appraiseme""/> APPRAISE ME</a></span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Regards,</span></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Royal Exchange APPRAISEME </span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "</table>"
        HtmlContent = HtmlContent & "</center></div>"
        HtmlContent = HtmlContent & "</body>"
        HtmlContent = HtmlContent & "</html>"

        Dim ToEmail = email
        Const ToFrom As String = "appraiseme@royalexchangeplc.com"

        Dim mm As New MailMessage(ToFrom, ToEmail)


        mm.Subject = "STAFF APPRAISAL::BOSS REJECTION APPRAISAL"
        mm.Body = HtmlContent
        mm.IsBodyHtml = True
        mm.Priority = MailPriority.High


        Dim smtp As SmtpClient = New SmtpClient("172.16.1.2", 25)
        smtp.Send(mm)

    End Function
    Public Function AppSendMailBOBaccepted(ByVal fullname As String, ByVal email As String, ByVal Bossname As String, ByVal username As String)


        Dim HtmlContent As String
        HtmlContent = HtmlContent & "<HTML>"
        HtmlContent = HtmlContent & "<HEAD>"
        HtmlContent = HtmlContent & "<TITLE>STAFF APPRAISAL::BOSS REJECTION APPRAISAL</TITLE>"
        HtmlContent = HtmlContent & "<style type=""text/css"">"
        HtmlContent = HtmlContent & "<!--"
        HtmlContent = HtmlContent & ".style12 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; }"
        HtmlContent = HtmlContent & ".style14 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; }"
        HtmlContent = HtmlContent & "-->"
        HtmlContent = HtmlContent & "</style>"
        HtmlContent = HtmlContent & "</HEAD>"
        HtmlContent = HtmlContent & "<BODY>"
        HtmlContent = HtmlContent & "<div align=""center"">"
        HtmlContent = HtmlContent & "<center>"
        HtmlContent = HtmlContent & "<table width=""704"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"">"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td width=""542"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td width=""162"" align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><img src=""http://www.royalexchangeplc.com/images/logo.jpg"" width=""162"" height=""28"" /></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style14"">Dear " & fullname & ",</span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Please be informed that Boss " & Bossname & " has ACCEPTED your Supervisor's (" & username & ") appraisal of you.<br> your scorecard file and appraisal comments have been forwarded to HR.</span></td>"
        HtmlContent = HtmlContent & " </tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & " <td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        'HtmlContent = HtmlContent & "<tr>"
        'HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">kindly log on to the application using your UserID and password to download your scoreCard and check your final grades on 'STAFF COMMENT' tab</span></td>"
        'HtmlContent = HtmlContent & "</tr>"
        'HtmlContent = HtmlContent & "<tr>"
        'HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top"">&nbsp;</td>"
        ' HtmlContent = HtmlContent & "</tr>"
        'HtmlContent = HtmlContent & " <tr>"
        'HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Click to Log into <a href=""http://192.168.30.32/appraiseme""/> APPRAISE ME</a></span></td>"
        'HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & " <tr>"
        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Regards,</span></td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "<tr>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Royal Exchange APPRAISEME </span></td>"
        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
        HtmlContent = HtmlContent & "</tr>"
        HtmlContent = HtmlContent & "</table>"
        HtmlContent = HtmlContent & "</center></div>"
        HtmlContent = HtmlContent & "</body>"
        HtmlContent = HtmlContent & "</html>"

        Dim ToEmail = email
        Const ToFrom As String = "appraiseme@royalexchangeplc.com"

        Dim mm As New MailMessage(ToFrom, ToEmail)


        mm.Subject = "STAFF APPRAISAL::HR RECEIPT OF YOUR SCORECARD"
        mm.Body = HtmlContent
        mm.IsBodyHtml = True
        mm.Priority = MailPriority.High


        Dim smtp As SmtpClient = New SmtpClient("172.16.1.2", 25)
        smtp.Send(mm)

    End Function
    Public Function Appraise_Sup_Fetch() As DataSet
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "Appraise_Sup_Fetch")
        Catch ex As Exception
            Return Nothing
        Finally
            cn.Close()
        End Try
    End Function
    Public Function Appraise_Boss_Fetch() As DataSet
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "Appraise_Boss_Fetch")
        Catch ex As Exception
            Return Nothing
        Finally
            cn.Close()
        End Try
    End Function
    Public Function Appraise_FullName(ByVal userName As String) As String
        Try

            Dim params() As SqlParameter = {New SqlParameter("@userName", userName)}

            Dim myReader As SqlDataReader = Nothing

            myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "Appraise_Name", params)

            If myReader.HasRows Then
                myReader.Read()
                Appraise_FullName = myReader.GetString(0)
            Else
                Appraise_FullName = "N/A"
            End If
            If myReader IsNot Nothing Then
                myReader.Close()
            End If
        Catch ex As Exception
            Appraise_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
        End Try

    End Function
    Public Function Appraise_GetHrDoc(ByVal userName As String) As String
        Try

            Dim params() As SqlParameter = {New SqlParameter("@userName", userName)}

            Dim myReader As SqlDataReader = Nothing

            myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "Appraise_GetDocuments_HR", params)

            If myReader.HasRows Then
                myReader.Read()
                Appraise_GetHrDoc = myReader.GetString(0)
            Else
                Appraise_GetHrDoc = "N/A"
            End If
            If myReader IsNot Nothing Then
                myReader.Close()
            End If
        Catch ex As Exception
            Appraise_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
        End Try

    End Function
    Public Function Appraise_GetHrDoc2(ByVal userName As String) As String
        Try

            Dim params() As SqlParameter = {New SqlParameter("@userName", userName)}

            Dim myReader As SqlDataReader = Nothing

            myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "Appraise_GetDocuments_HR", params)

            If myReader.HasRows Then
                myReader.Read()
                Appraise_GetHrDoc2 = myReader.GetString(1)
            Else
                Appraise_GetHrDoc2 = "N/A"
            End If
            If myReader IsNot Nothing Then
                myReader.Close()
            End If
        Catch ex As Exception
            Appraise_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
        End Try

    End Function
    Public Function GetScore(ByVal staffID As String, ByVal AppraiseQuater As String, ByVal AppraiseYear As String) As String
        Try

            Dim paramsccc() As SqlParameter = {New SqlParameter("@staffID", staffID), New SqlParameter("@ApprQtr", AppraiseQuater), New SqlParameter("@ApprYear", AppraiseYear)}


            Dim myReader As SqlDataReader = Nothing

            myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "Appraise_Staff_FinalScore_Fetch_HR", paramsccc)

            If myReader.HasRows Then
                myReader.Read()
                GetScore = myReader.GetDecimal(1)
                'myReader.GetString(1)
            Else
                GetScore = "N/A"
            End If
            If myReader IsNot Nothing Then
                myReader.Close()
            End If
        Catch ex As Exception
            Appraise_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
        End Try

    End Function

    Public Function Appraise_AllStaff() As DataSet
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "Appriase_AllStaff_Fetch")
        Catch ex As Exception
            Appraise_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
            Return Nothing
        Finally
            cn.Close()
        End Try
    End Function






    'Public Function HMO_Enrollee_Dependant_Limit(ByVal enrid As String) As Integer
    '        Try
    '            Dim flag As Integer
    '            Dim params() As SqlParameter = {New SqlParameter("@Enrollee_Number", enrid)}
    '            Dim rte As Object = SqlHelper.ExecuteScalar(cn, CommandType.StoredProcedure, "dbo.HMO_Enrollee_Dependants_Check", params)
    '            If (IsDBNull(rte)) Then
    '                flag = 0
    '            Else
    '                flag = Convert.ToInt32(rte)
    '            End If
    '            Return flag
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_FetchPlanCode(ByVal setup As String) As String
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@SetupID", setup)}
    '            Return SqlHelper.ExecuteScalar(cn, CommandType.StoredProcedure, "HMO_StaffSetup_FetchPlancode", params).ToString()
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_DynamicSQL_Execute(ByVal dSQL As String) As Boolean
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@dSQL", dSQL)}
    '            SqlHelper.ExecuteNonQuery(cn, CommandType.StoredProcedure, "HMO_DynamicSQL_Execute", params)
    '            Return True
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + ex.StackTrace)
    '            Return False
    '        Finally
    '            cn.Close()
    '        End Try

    '    End Function
    '    Public Function HMO_State_Filter(ByVal _HMO_StateInfo As HMO_StateInfo) As DataSet
    '        'Filter By : StateName, Zone
    '        Try
    '            Dim dSQL As String = ""
    '            Dim dSQL1 As String = ""
    '            With _HMO_StateInfo
    '                If .StateName <> "" Then
    '                    dSQL1 = dSQL1 & " Or (StateName LIKE '%' + '" & .StateName & "' + '%' ) "
    '                End If

    '                If .ZoneID <> 0 Then
    '                    dSQL1 = dSQL1 & " Or (ZoneID = '" & .ZoneID & "')"
    '                End If

    '                dSQL = "SELECT dbo.HMO_State.*, 'State.aspx?Updateid='+ cast(StateID as varchar(50)) as edit from HMO_State Where " & Right(dSQL1, Len(dSQL1) - 4) & " Order by StateName"

    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, dSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    'Public Function HMO_States_Fetch() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_State_FetchAll")
    '        Catch ex As Exception
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Drug_Form_Fetch() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Drug_Form_Fetch")
    '        Catch ex As Exception
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Premium_Delete(ByVal PremiumID As Integer) As Boolean
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@PremiumID", PremiumID), _
    '                                            New SqlParameter("@PostedBy", "Admin"), _
    '                                            New SqlParameter("@IPAddress", "10.10")}
    '            SqlHelper.ExecuteNonQuery(cn, CommandType.StoredProcedure, "HMO_Delete_Premium", params)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Premium_Payment_Delete(ByVal PaymentID As Integer) As Boolean
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@PaymentID", PaymentID), _
    '                                            New SqlParameter("@PostedBy", "Admin"), _
    '                                            New SqlParameter("@IPAddress", "10.10")}
    '            SqlHelper.ExecuteNonQuery(cn, CommandType.StoredProcedure, "HMO_Delete_Premium_Payment", params)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Limit_Delete(ByVal LimitID As Integer) As Boolean
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@LimitID", LimitID), _
    '                                            New SqlParameter("@PostedBy", "Admin"), _
    '                                            New SqlParameter("@IPAddress", "10.10")}
    '            SqlHelper.ExecuteNonQuery(cn, CommandType.StoredProcedure, "HMO_Delete_Limit", params)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Referral_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Referral_Fetch")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Premium_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Premium_Fetch")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Premium_Payment_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Premium_Payment_Fetch")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Prorate_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Prorate_Fetch")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Family_Prorate_FetchAll(ByVal Enrollee_Number As String) As DataSet
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@Enrollee_Number", Enrollee_Number)}
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Family_Prorate_Fetch", params)
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Limit_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Limit_Fetch")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Drug_Name() As DataSet
    '        Try

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_FULL_DRUG")
    '        Catch ex As Exception
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_Lab_Details_drpdown() As DataSet
    '        Try

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Lab_Details_Dropdown")
    '        Catch ex As Exception
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Opt_Detail_drpdown() As DataSet
    '        Try

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_oPT_Detail_Dropdown")
    '        Catch ex As Exception
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Den_Detail_drpdown() As DataSet
    '        Try

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Den_Detail_Dropdown")
    '        Catch ex As Exception
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Outp_Detail_drpdown() As DataSet
    '        Try

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Outp_Detail_Dropdown")
    '        Catch ex As Exception
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Drug_Dropdown() As DataSet
    '        Try

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Drug_Dropdown")
    '        Catch ex As Exception
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_Surg_Detail_drpdown() As DataSet
    '        Try

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Surg_Detail_Dropdown")
    '        Catch ex As Exception
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function


    '    Public Function HMO_Rad_Details_drpdown() As DataSet
    '        Try

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Rad_Details_Dropdown")
    '        Catch ex As Exception
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_DrugStrenght_ByFormID(ByVal DrugFormID As Integer) As DataSet
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@DrugFormID", DrugFormID)}
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Drug_Strenght_FetchByDrugForm", params)
    '        Catch ex As Exception
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_LGA_Fetch() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_LGA_FetchAll")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Plan_Fetch() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Plan_FetchAll")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Plan_FetchByCoy(ByVal CompanyID As Integer) As DataSet
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@CompanyID", CompanyID)}
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Plan_FetchallByCoy", params)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_RootAccessCheck(ByVal roleid As String, ByVal rootid As String) As String
    '        Try
    '            Dim flag As String
    '            flag = "Unknown"
    '            Dim params() As SqlParameter = {New SqlParameter("@RoleID", roleid), _
    '                                        New SqlParameter("@RootID", rootid)}
    '            Dim myReader As SqlDataReader = Nothing
    '            myReader = SqlHelper.ExecuteScalar(cn, CommandType.StoredProcedure, "HMO_RootFolderAccess_FetchByRoleID", params)
    '            If myReader.HasRows Then
    '                myReader.Read()

    '                flag = myReader.GetBoolean(1)

    '            Else

    '                flag = "Empty"
    '            End If

    '            Return flag
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_AccessCheck(ByVal RoleID As String, ByVal PageLink As String, ByVal Parent As String, ByVal Root As String) As Boolean()
    '        Try
    '            Dim flag(9) As Boolean

    '            Dim params() As SqlParameter = {New SqlParameter("@RoleID", RoleID), _
    '                                        New SqlParameter("@PageLink", PageLink), _
    '                                        New SqlParameter("@ParentFolder", Parent), _
    '                                        New SqlParameter("@RootFolder", Root)}
    '            Dim myReader As SqlDataReader = Nothing
    '            myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "dbo.HMO_vw_ACCESS_ALL_Fetch", params)
    '            If myReader.HasRows Then
    '                myReader.Read()

    '                flag(0) = True                          'To Verify If There is Data In The Access Table
    '                flag(1) = myReader.GetBoolean(0)        'ACCESS VALUES FOR ParentFolderAccess
    '                flag(2) = myReader.GetBoolean(1)        'ACCESS VALUES FOR RootFolderAccess   
    '                flag(3) = myReader.GetBoolean(2)        'ACCESS VALUES FOR Page ViewAccess
    '                flag(4) = myReader.GetBoolean(3)        'ACCESS VALUES FOR Page UpdateAccess
    '                flag(5) = myReader.GetBoolean(4)        'ACCESS VALUES FOR Page DeleteAccess
    '                flag(6) = myReader.GetBoolean(5)        'ACCESS VALUES FOR Page AddAccess
    '                flag(7) = myReader.GetBoolean(6)        'ACCESS VALUES FOR Page ApprovalAccess

    '            Else
    '                flag(0) = False

    '            End If

    '            Return flag

    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_Branch_Fetch() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Branch_FetchAll")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_Company_Branch_Fetch() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Company_Branch_FetchAll")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function ZoneName(ByVal ZoneID As Integer) As String
    '        Dim params() As SqlParameter = {New SqlParameter("@ZoneID", ZoneID)}
    '        Dim myReader As SqlDataReader = Nothing

    '        myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_ZoneName", params)

    '        If myReader.HasRows Then
    '            myReader.Read()
    '            ZoneName = myReader.GetString(0)
    '        Else
    '            ZoneName = "N/A"
    '        End If
    '        If myReader IsNot Nothing Then
    '            myReader.Close()
    '        End If
    '    End Function
    '    Public Function StateName(ByVal StateID As Integer) As String
    '        Dim params() As SqlParameter = {New SqlParameter("@StateID", StateID)}
    '        Dim myReader As SqlDataReader = Nothing

    '        myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_StateName", params)

    '        If myReader.HasRows Then
    '            myReader.Read()
    '            StateName = myReader.GetString(0)
    '        Else
    '            StateName = "N/A"
    '        End If
    '        If myReader IsNot Nothing Then
    '            myReader.Close()
    '        End If
    '    End Function

    '    Public Function DrugForm(ByVal DrugFormID As Integer) As String

    '        Dim params() As SqlParameter = {New SqlParameter("@DrugFormID", DrugFormID)}
    '        Dim myReader As SqlDataReader = Nothing

    '        myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_DrugFormName", params)

    '        If myReader.HasRows Then
    '            myReader.Read()
    '            DrugForm = myReader.GetString(0)
    '        Else
    '            DrugForm = "N/A"
    '        End If
    '        If myReader IsNot Nothing Then
    '            myReader.Close()
    '        End If
    '    End Function
    '    Public Function DrugFullName(ByVal DrugID As Integer) As String


    '        Dim params() As SqlParameter = {New SqlParameter("@DrugID", DrugID)}
    '        Dim myReader As SqlDataReader = Nothing

    '        myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_DrugFullName", params)

    '        If myReader.HasRows Then
    '            myReader.Read()
    '            DrugFullName = myReader.GetString(1)
    '        Else
    '            DrugFullName = "N/A"
    '        End If
    '        If myReader IsNot Nothing Then
    '            myReader.Close()
    '        End If
    '    End Function

    '    Public Function PharmName(ByVal GroupID As Integer) As String

    '        Dim params() As SqlParameter = {New SqlParameter("@GroupID", GroupID)}
    '        Dim myReader As SqlDataReader = Nothing

    '        myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_PharmName", params)
    '        If myReader.HasRows Then
    '            myReader.Read()
    '            PharmName = myReader.GetString(0)
    '        Else
    '            PharmName = "N/A"
    '        End If
    '        If myReader IsNot Nothing Then
    '            myReader.Close()
    '        End If
    '    End Function

    'Public Function HMO_State_Delete(ByVal StateID As Integer) As Boolean
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@StateID", StateID), _
    '                                            New SqlParameter("@PostedBy", "Admin"), _
    '                                            New SqlParameter("@IPAddress", "10.10")}
    '            SqlHelper.ExecuteNonQuery(cn, CommandType.StoredProcedure, "HMO_Delete_State", params)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_LGA_Delete(ByVal LGAID As Integer) As Boolean
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@LGAID", LGAID), _
    '                                            New SqlParameter("@PostedBy", "Admin"), _
    '                                            New SqlParameter("@IPAddress", "10.10")}
    '            SqlHelper.ExecuteNonQuery(cn, CommandType.StoredProcedure, "HMO_Delete_LGA", params)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_DrugStrenght_Delete(ByVal StrenghtID As Integer, ByVal IP As String, ByVal Username As String) As Boolean
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@StrenghtID", StrenghtID), _
    '                                            New SqlParameter("@PostedBy", Username), _
    '                                            New SqlParameter("@IPAddress", IP)}
    '            SqlHelper.ExecuteNonQuery(cn, CommandType.StoredProcedure, "HMO_Delete_DRUG_STRENGHT", params)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_Plan_Delete(ByVal PlanCode As String, ByVal Username As String, ByVal IP As String) As Boolean
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@PlanCode", PlanCode), _
    '                                            New SqlParameter("@PostedBy", Username), _
    '                                            New SqlParameter("@IPAddress", IP)}
    '            SqlHelper.ExecuteNonQuery(cn, CommandType.StoredProcedure, "HMO_Plan_Delete", params)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_ParentFolder_FetchByID(ByVal RootID As Integer, ByVal ParentFolderName As String) As String
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@RootID", RootID), _
    '                                            New SqlParameter("@ParentFolderName", ParentFolderName)}

    '            Return SqlHelper.ExecuteScalar(cn, CommandType.StoredProcedure, "HMO_ParentFolder_FetchID", params).ToString()
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function


    '    Public Function HMO_Zone_Fetch() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Zone_Fetch")
    '        Catch ex As Exception
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_Company_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Company_Fetch")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Premium_FetchAll(ByVal CompanyID As Integer) As DataSet
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@CompanyID", CompanyID)}
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Premium_Fetchall")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_CompanyGroupFetchAll_ByGroupStatus() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_CompanyGroupFetchAll_ByGroupStatus")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_DrugStrength_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Drug_Srenght_Fetch")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_DrugPriceFetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Drug_Price_Fetch")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_Pharm_Group_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Pharm_Group_Fetch")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Pharm_Group_FetchByDropdown() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_PharmGroup_FetchByDropDown")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_DrugForm_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Drug_Form_FetchAll")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_DrugSetUp_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_DrugSetup_FetchAll")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_ProviderTariff_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_ProviderTariff_Fetch")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Tariff_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Tariff_Fetch")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    Public Function Marine_Random() As String
        Dim sReturn As String = ""
        Randomize()
        Dim iRandom1 = CInt(9999 * Rnd())
        Dim iRandom2 = CInt(999999 * Rnd())
        Dim iRandom3 = CInt(99999 * Rnd())
        Const Alphabet As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        Dim s1 As String = Alphabet.Substring(iRandom1 Mod 26, 1)
        Dim s3 As String = Alphabet.Substring(iRandom2 Mod 26, 1)
        Dim s5 As String = Alphabet.Substring(iRandom3 Mod 26, 1)
        Dim s2 As String = iRandom1.ToString().Substring(0, 1)
        Dim s4 As String = iRandom2.ToString().Substring(0, 1)
        Dim s6 As String = iRandom3.ToString().Substring(0, 1)
        Return s1 & s2 & s3 & s4 & s5 & s6
    End Function
    '    Public Function HMO_ProviderService_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_ProviderService_FetchAll")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    Public Function ConvertString(ByVal ID As Object) As String
        If IsDBNull(ID) Then
            Return ("")
        Else
            Return CStr(ID)
        End If

    End Function

    '    Public Function CompanyName(ByVal CompanyID As Integer) As String
    '        Try

    '            Dim params() As SqlParameter = {New SqlParameter("@CompanyID", CompanyID)}

    '            Dim myReader As SqlDataReader = Nothing

    '            myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_CompanyName", params)

    '            If myReader.HasRows Then
    '                myReader.Read()
    '                CompanyName = myReader.GetString(0)
    '            Else
    '                CompanyName = "N/A"
    '            End If
    '            If myReader IsNot Nothing Then
    '                myReader.Close()
    '            End If
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        End Try

    '    End Function

    '    Public Function ProviderName(ByVal ProviderID As Integer) As String
    '        Try

    '            Dim params() As SqlParameter = {New SqlParameter("@ProviderID", ProviderID)}

    '            Dim myReader As SqlDataReader = Nothing

    '            myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_ProviderName", params)

    '            If myReader.HasRows Then
    '                myReader.Read()
    '                ProviderName = myReader.GetString(0)
    '            Else
    '                ProviderName = "N/A"
    '            End If
    '            If myReader IsNot Nothing Then
    '                myReader.Close()
    '            End If
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        End Try

    '    End Function

    '    Public Function BillCode(ByVal BillID As Integer) As String
    '        Try

    '            Dim params() As SqlParameter = {New SqlParameter("@BillID", BillID)}

    '            Dim myReader As SqlDataReader = Nothing

    '            myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_BillCode", params)

    '            If myReader.HasRows Then
    '                myReader.Read()
    '                BillCode = myReader.GetString(0)
    '            Else
    '                BillCode = "N/A"
    '            End If
    '            If myReader IsNot Nothing Then
    '                myReader.Close()
    '            End If
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        End Try

    '    End Function
    '    Public Function BenefitCode(ByVal DentalID As Integer) As String
    '        Try

    '            Dim params() As SqlParameter = {New SqlParameter("@DentalID", DentalID)}

    '            Dim myReader As SqlDataReader = Nothing

    '            myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_Den_BenefitCode", params)

    '            If myReader.HasRows Then
    '                myReader.Read()
    '                BenefitCode = myReader.GetString(0)
    '            Else
    '                BenefitCode = "N/A"
    '            End If
    '            If myReader IsNot Nothing Then
    '                myReader.Close()
    '            End If
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        End Try

    '    End Function
    '    Public Function LabBenefitCode(ByVal LabID As Integer) As String
    '        Try

    '            Dim params() As SqlParameter = {New SqlParameter("@LabID", LabID)}

    '            Dim myReader As SqlDataReader = Nothing

    '            myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_Lab_BenefitCode", params)

    '            If myReader.HasRows Then
    '                myReader.Read()
    '                LabBenefitCode = myReader.GetString(0)
    '            Else
    '                LabBenefitCode = "N/A"
    '            End If
    '            If myReader IsNot Nothing Then
    '                myReader.Close()
    '            End If
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        End Try

    '    End Function
    '    Public Function OptBenefitCode(ByVal OpticalID As Integer) As String
    '        Try

    '            Dim params() As SqlParameter = {New SqlParameter("@OpticalID", OpticalID)}

    '            Dim myReader As SqlDataReader = Nothing

    '            myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_Opt_BenefitCode", params)

    '            If myReader.HasRows Then
    '                myReader.Read()
    '                OptBenefitCode = myReader.GetString(0)
    '            Else
    '                OptBenefitCode = "N/A"
    '            End If
    '            If myReader IsNot Nothing Then
    '                myReader.Close()
    '            End If
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        End Try

    '    End Function
    '    Public Function OutpBenefitCode(ByVal OutpID As Integer) As String
    '        Try

    '            Dim params() As SqlParameter = {New SqlParameter("@OutpID", OutpID)}

    '            Dim myReader As SqlDataReader = Nothing

    '            myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_Outp_BenefitCode", params)

    '            If myReader.HasRows Then
    '                myReader.Read()
    '                OutpBenefitCode = myReader.GetString(0)
    '            Else
    '                OutpBenefitCode = "N/A"
    '            End If
    '            If myReader IsNot Nothing Then
    '                myReader.Close()
    '            End If
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        End Try

    '    End Function
    '    Public Function RadBenefitCode(ByVal RadID As Integer) As String
    '        Try

    '            Dim params() As SqlParameter = {New SqlParameter("@RadID", RadID)}

    '            Dim myReader As SqlDataReader = Nothing

    '            myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_Rad_BenefitCode", params)

    '            If myReader.HasRows Then
    '                myReader.Read()
    '                RadBenefitCode = myReader.GetString(0)
    '            Else
    '                RadBenefitCode = "N/A"
    '            End If
    '            If myReader IsNot Nothing Then
    '                myReader.Close()
    '            End If
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        End Try

    '    End Function
    '    Public Function SurgBenefitCode(ByVal SurgeryID As Integer) As String
    '        Try

    '            Dim params() As SqlParameter = {New SqlParameter("@SurgeryID", SurgeryID)}

    '            Dim myReader As SqlDataReader = Nothing

    '            myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_Surg_BenefitCode", params)

    '            If myReader.HasRows Then
    '                myReader.Read()
    '                SurgBenefitCode = myReader.GetString(0)
    '            Else
    '                SurgBenefitCode = "N/A"
    '            End If
    '            If myReader IsNot Nothing Then
    '                myReader.Close()
    '            End If
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        End Try

    '    End Function


    '    Public Function LabDetails(ByVal LabID As Integer) As String
    '        Try

    '            Dim params() As SqlParameter = {New SqlParameter("@LabID", LabID)}

    '            Dim myReader As SqlDataReader = Nothing

    '            myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_LabDetail_Name", params)

    '            If myReader.HasRows Then
    '                myReader.Read()
    '                LabDetails = myReader.GetString(0)
    '            Else
    '                LabDetails = "N/A"
    '            End If
    '            If myReader IsNot Nothing Then
    '                myReader.Close()
    '            End If
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        End Try

    '    End Function

    '    Public Function OptDetails(ByVal OpticalID As Integer) As String
    '        Try

    '            Dim params() As SqlParameter = {New SqlParameter("@OpticalID", OpticalID)}

    '            Dim myReader As SqlDataReader = Nothing

    '            myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_OptDetail_Name", params)

    '            If myReader.HasRows Then
    '                myReader.Read()
    '                OptDetails = myReader.GetString(0)
    '            Else
    '                OptDetails = "N/A"
    '            End If
    '            If myReader IsNot Nothing Then
    '                myReader.Close()
    '            End If
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        End Try

    '    End Function
    '    Public Function DenDetails(ByVal DentalID As Integer) As String
    '        Try

    '            Dim params() As SqlParameter = {New SqlParameter("@DentalID", DentalID)}

    '            Dim myReader As SqlDataReader = Nothing

    '            myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_DenDetail_Name", params)

    '            If myReader.HasRows Then
    '                myReader.Read()
    '                DenDetails = myReader.GetString(0)
    '            Else
    '                DenDetails = "N/A"
    '            End If
    '            If myReader IsNot Nothing Then
    '                myReader.Close()
    '            End If
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        End Try

    '    End Function
    '    Public Function OutpDetails(ByVal OutpID As Integer) As String
    '        Try

    '            Dim params() As SqlParameter = {New SqlParameter("@OutpID", OutpID)}

    '            Dim myReader As SqlDataReader = Nothing

    '            myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_OutpDetail_Name", params)

    '            If myReader.HasRows Then
    '                myReader.Read()
    '                OutpDetails = myReader.GetString(0)
    '            Else
    '                OutpDetails = "N/A"
    '            End If
    '            If myReader IsNot Nothing Then
    '                myReader.Close()
    '            End If
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        End Try

    '    End Function
    '    Public Function SurgDetails(ByVal SurgeryID As Integer) As String
    '        Try

    '            Dim params() As SqlParameter = {New SqlParameter("@SurgeryID", SurgeryID)}

    '            Dim myReader As SqlDataReader = Nothing

    '            myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_SurgDetail_Name", params)

    '            If myReader.HasRows Then
    '                myReader.Read()
    '                SurgDetails = myReader.GetString(0)
    '            Else
    '                SurgDetails = "N/A"
    '            End If
    '            If myReader IsNot Nothing Then
    '                myReader.Close()
    '            End If
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        End Try

    '    End Function

    '    Public Function HMO_Premium_Payment_Filter(ByVal _HMO_Premium_PaymentInfo As HMO_Premium_PaymentInfo) As DataSet
    '        'Filter By : Company Name, State
    '        Try
    '            Dim strSQL, strSQL2 As String

    '            With _HMO_Premium_PaymentInfo
    '                If .CompanyID <> 0 Then
    '                    strSQL2 = " where (CompanyID ='" & .CompanyID & "')"
    '                Else
    '                    strSQL2 = ""
    '                End If

    '                strSQL = "SELECT dbo.HMO_Premum_Payment.*, '~/admin/pages/Premium_Payment.aspx?Updateid='+ cast(PaymentID as varchar(50)) as edit from HMO_Premum_Payment"
    '                strSQL = strSQL & strSQL2
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_Premium_Filter(ByVal _HMO_PremiumInfo As HMO_PremiumInfo) As DataSet
    '        'Filter By : Company Name, State
    '        Try
    '            Dim strSQL, strSQL2 As String

    '            With _HMO_PremiumInfo
    '                If .CompanyID <> 0 Then
    '                    strSQL2 = " where (CompanyID ='" & .CompanyID & "')"
    '                Else
    '                    strSQL2 = ""
    '                End If

    '                strSQL = "SELECT dbo.HMO_Premium.*, '~/admin/pages/Premium_Reg.aspx?Updateid='+ cast(PremiumID as varchar(50)) as edit from HMO_Premium"
    '                strSQL = strSQL & strSQL2
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Referral_Filter(ByVal _HMO_ReferralInfo As HMO_ReferralInfo) As DataSet
    '        'Filter By : Referral Number, State
    '        Try
    '            Dim strSQL, strSQL2 As String

    '            With _HMO_ReferralInfo
    '                If .RefNumber <> "" Then
    '                    strSQL2 = " where (RefNumber like '%" & .RefNumber & "%')"

    '                Else
    '                    strSQL2 = ""
    '                End If

    '                strSQL = "SELECT dbo.HMO_Referal.*, '~/Claims/pages/Process_Referral.aspx?Updateid='+ cast(RefID as varchar(50)) as edit from HMO_Referal"
    '                strSQL = strSQL & strSQL2
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Proration_Filter(ByVal _HMO_ProrationInfo As HMO_ProrationInfo) As DataSet
    '        'Filter By : Company Name
    '        Try
    '            Dim strSQL, strSQL2 As String

    '            With _HMO_ProrationInfo
    '                If .CompanyID <> 0 Then
    '                    strSQL2 = " where (CompanyID ='" & .CompanyID & "')"
    '                Else
    '                    strSQL2 = ""
    '                End If

    '                strSQL = "SELECT dbo.HMO_Prorate.*, '~/Enrollee/pages/Activation.aspx?Updateid='+ cast(ProrateID as varchar(50)) as edit from HMO_Prorate"
    '                strSQL = strSQL & strSQL2
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_Limit_Filter(ByVal _HMO_LimitInfo As HMO_LimitInfo) As DataSet
    '        'Filter By : Company Name, State
    '        Try
    '            Dim strSQL, strSQL2 As String

    '            With _HMO_LimitInfo
    '                If .CompanyID <> 0 Then
    '                    strSQL2 = " where (CompanyID ='" & .CompanyID & "')"
    '                Else
    '                    strSQL2 = ""
    '                End If

    '                strSQL = "SELECT dbo.HMO_Limit.*, '~/admin/pages/Limit_Reg.aspx?Updateid='+ cast(LimitID as varchar(50)) as edit from HMO_Limit"
    '                strSQL = strSQL & strSQL2
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Attendee_Filter(ByVal _HMO_Attendee_DetailsInfo As HMO_Attendee_DetailsInfo) As DataSet
    '        'Filter By : Company Name, State
    '        'Try
    '        Dim strSQL, strSQL2 As String

    '        With _HMO_Attendee_DetailsInfo
    '            If .BillID <> 0 Then
    '                strSQL2 = " where (BillID ='" & .BillID & "')"
    '            Else
    '                strSQL2 = ""
    '            End If

    '            strSQL = "SELECT dbo.HMO_Attendees.*, '~/Claims/pages/Attendee_Details.aspx?Updateid='+ cast(AttendeeID as varchar(50)) as edit from HMO_Attendees"
    '            strSQL = strSQL & strSQL2
    '        End With

    '        Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        'Catch ex As Exception
    '        '    HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        '    Return Nothing
    '        'Finally
    '        '    cn.Close()
    '        'End Try
    '    End Function

    '    Public Function HMO_LGA_Filter(ByVal _HMO_LGAInfo As HMO_LGAInfo) As DataSet
    '        Try
    '            Dim strSQL1, strSQL, strSQL2 As String

    '            With _HMO_LGAInfo
    '                If .LGAName <> "" Then
    '                    strSQL1 = " where (LGAName like '%" & .LGAName & "%')"
    '                Else
    '                    strSQL1 = ""
    '                End If

    '                If .StateID <> 0 Then
    '                    If strSQL1 <> "" Then
    '                        strSQL2 = " Or (StateID ='" & .StateID & "')"
    '                    Else
    '                        strSQL2 = " where (StateID ='" & .StateID & "')"
    '                    End If
    '                Else
    '                    strSQL2 = ""
    '                End If

    '                strSQL = "SELECT dbo.HMO_LGA.*, '~/admin/pages/LGA.aspx?Updateid='+ cast(LGAID as varchar(50)) as edit from HMO_LGA"
    '                strSQL = strSQL & strSQL1 & strSQL2
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Provider_Filter(ByVal _HMO_ProviderInfo As HMO_ProviderInfo) As DataSet
    '        'Filter By : Provider Name, State
    '        Try
    '            Dim strSQL1, strSQL2, strSQL As String

    '            With _HMO_ProviderInfo
    '                If .ProviderName <> "" Then
    '                    strSQL1 = " where (ProviderName like '%" & .ProviderName & "%')"
    '                Else
    '                    strSQL1 = ""
    '                End If

    '                If .StateID <> "0" Then
    '                    If strSQL1 <> "" Then
    '                        strSQL2 = " and (StateID ='" & .StateID & "')"
    '                    Else
    '                        strSQL2 = " where (StateID ='" & .StateID & "')"
    '                    End If
    '                Else
    '                    strSQL2 = ""
    '                End If
    '                strSQL = "SELECT dbo.HMO_Provider.*, '~/Providers/pages/Providers.aspx?Updateid='+ cast(ProviderID as varchar(50)) as edit from HMO_Provider"
    '                strSQL = strSQL & strSQL1 & strSQL2
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Bill_Reg_Filter(ByVal _HMO_Bill_RegInfo As HMO_Bill_RegInfo) As DataSet
    '        'Filter By : BillCode, State
    '        Try
    '            Dim strSQL1, strSQL2, strSQL As String

    '            With _HMO_Bill_RegInfo
    '                If .BillCode <> "" Then
    '                    strSQL1 = " where (BillCode like '%" & .BillCode & "%')"
    '                Else
    '                    strSQL1 = ""
    '                End If

    '                If .BillMonth <> "" Then
    '                    If strSQL1 <> "" Then
    '                        strSQL2 = " and (BillMonth ='" & .BillMonth & "')"
    '                    Else
    '                        strSQL2 = " where (BillMonth ='" & .BillMonth & "')"
    '                    End If
    '                Else
    '                    strSQL2 = ""
    '                End If
    '                strSQL = "SELECT dbo.HMO_Bill_Reg.*, '~/Claims/pages/Bill_Registration.aspx?Updateid='+ cast(BillID as varchar(50)) as edit from HMO_Bill_Reg"

    '                strSQL = strSQL & strSQL1 & strSQL2
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_ProviderPersonnel_Filter(ByVal _HMO_ProviderInfo As HMO_ProviderInfo) As DataSet
    '        'Filter By : Provider , effective Date
    '        Try

    '            Dim strSQL1, strSQL As String

    '            With _HMO_ProviderInfo
    '                If .ProviderID <> 0 Then
    '                    strSQL1 = " where (ProviderID ='" & .ProviderID & "')"
    '                Else
    '                    strSQL1 = ""
    '                End If

    '                strSQL = "SELECT HMO_Provider_Personnel*, '~/Providers/pages/Provider_Personnel.aspx?Updateid='+ cast(ProvPersonnelID as varchar(50)) as edit from HMO_Provider_Personnel"
    '                strSQL = strSQL & strSQL1
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_ProviderCapitation_Filter(ByVal _HMO_ProviderInfo As HMO_ProviderInfo) As DataSet
    '        'Filter By : Provider , effective Date
    '        Try

    '            Dim strSQL1, strSQL As String

    '            With _HMO_ProviderInfo
    '                If .ProviderID <> 0 Then
    '                    strSQL1 = " where (ProviderID ='" & .ProviderID & "')"
    '                Else
    '                    strSQL1 = ""
    '                End If

    '                strSQL = "SELECT HMO_Capitation.*, '~/Providers/pages/Provider_Capitation.aspx?Updateid='+ cast(CapID as varchar(50)) as edit from HMO_Capitation"
    '                strSQL = strSQL & strSQL1
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Capitation_Payment_Filter(ByVal _HMO_ProviderInfo As HMO_ProviderInfo) As DataSet
    '        'Filter By : Provider , effective Date
    '        Try

    '            Dim strSQL1, strSQL As String

    '            With _HMO_ProviderInfo
    '                If .ProviderID <> 0 Then
    '                    strSQL1 = " where (ProviderID ='" & .ProviderID & "')"
    '                Else
    '                    strSQL1 = ""
    '                End If

    '                strSQL = "SELECT HMO_Capitation_Payment.*, '~/Claims/pages/Capitation.aspx?Updateid='+ cast(CapPayID as varchar(50)) as edit from HMO_Capitation_Payment"
    '                strSQL = strSQL & strSQL1
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_ProviderDrugPrice_Filter(ByVal _Provider_Drug_PriceInfo As HMO_Provider_Drug_PriceInfo) As DataSet
    '        'Filter By : Provider , effective Date
    '        Try

    '            Dim strSQL1, strSQL2, strSQL As String

    '            With _Provider_Drug_PriceInfo
    '                If .ProviderID <> 0 Then
    '                    strSQL1 = " where (ProviderID ='" & .ProviderID & "')"
    '                Else
    '                    strSQL1 = ""
    '                End If

    '                If .EffectiveDate <> "" Then
    '                    If strSQL1 <> "" Then
    '                        strSQL2 = " and (EffectiveDate = '" & .EffectiveDate & "')"
    '                    Else
    '                        strSQL2 = " where (EffectiveDate = '" & .EffectiveDate & "')"
    '                    End If
    '                Else
    '                    strSQL2 = ""
    '                End If
    '                strSQL = "SELECT HMO_Provider_Drug_Price.*, '~/Providers/pages/Provider_Drug_pricing.aspx?Updateid='+ cast(ProvDrugID as varchar(50)) as edit from HMO_Provider_Drug_Price"
    '                strSQL = strSQL & strSQL1 & strSQL2
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_ProviderLabPrice_Filter(ByVal _HMO_Provider_Lab_PriceInfo As HMO_Provider_Lab_PriceInfo) As DataSet
    '        'Filter By : Provider Name, State
    '        Try
    '            Dim strSQL1, strSQL2, strSQL As String

    '            With _HMO_Provider_Lab_PriceInfo
    '                If .ProviderID <> "0" Then
    '                    strSQL1 = " where (ProviderID ='" & .ProviderID & "')"
    '                Else
    '                    strSQL1 = ""
    '                End If
    '                If .EffectiveDate <> "" Then
    '                    If strSQL1 <> "" Then
    '                        strSQL2 = " and (EffectiveDate = '" & .EffectiveDate & "')"
    '                        'Else
    '                        '    strSQL2 = " where (EffectiveDate = '" & .EffectiveDate & "')"
    '                    End If
    '                Else
    '                    strSQL2 = ""
    '                End If
    '                strSQL = "SELECT HMO_Provider_Laboratory_Price.*, '~/Providers/pages/Provider_LabRegistration.aspx?Updateid='+ cast(ProLabID as varchar(50)) as edit from HMO_Provider_Laboratory_Price"
    '                strSQL = strSQL & strSQL1 & strSQL2
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_ProviderOptPrice_Filter(ByVal _HMO_Provider_Optical_PriceInfo As HMO_Provider_Optical_PriceInfo) As DataSet
    '        'Filter By : Provider Name, State
    '        Try
    '            Dim strSQL2, strSQL1, strSQL As String

    '            With _HMO_Provider_Optical_PriceInfo
    '                If .ProviderID <> "0" Then
    '                    strSQL1 = " where (ProviderID ='" & .ProviderID & "')"
    '                Else
    '                    strSQL1 = ""
    '                End If
    '                If .EffectiveDate <> "" Then
    '                    If strSQL1 <> "" Then
    '                        strSQL2 = " and (EffectiveDate = '" & .EffectiveDate & "')"
    '                        'Else
    '                        '    strSQL2 = " where (EffectiveDate = '" & .EffectiveDate & "')"
    '                    End If
    '                Else
    '                    strSQL2 = ""
    '                End If
    '                strSQL = "SELECT HMO_provider_Optical_Price.*, '~/Providers/pages/Provider_Optical_Price_Setup.aspx?Updateid='+ cast(ProOpticalID as varchar(50)) as edit from HMO_provider_Optical_Price"
    '                strSQL = strSQL & strSQL1 & strSQL2
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_ProviderDenPrice_Filter(ByVal _HMO_Provider_Dental_PriceInfo As HMO_Provider_Dental_PriceInfo) As DataSet
    '        'Filter By : Provider Name, effective date
    '        Try
    '            Dim strSQL2, strSQL1, strSQL As String

    '            With _HMO_Provider_Dental_PriceInfo
    '                If .ProviderID <> "0" Then
    '                    strSQL1 = " where (ProviderID ='" & .ProviderID & "')"
    '                Else
    '                    strSQL1 = ""
    '                End If
    '                If .EffectiveDate <> "" Then
    '                    If strSQL1 <> "" Then
    '                        strSQL2 = " and (EffectiveDate = '" & .EffectiveDate & "')"
    '                        'Else
    '                        '    strSQL2 = " where (EffectiveDate = '" & .EffectiveDate & "')"
    '                    End If
    '                Else
    '                    strSQL2 = ""
    '                End If
    '                strSQL = "SELECT HMO_Provider_Dental_Price.*, '~/Providers/pages/Provider_Dental_Price_Setup.aspx?Updateid='+ cast(ProvDenID as varchar(50)) as edit from HMO_Provider_Dental_Price"
    '                strSQL = strSQL & strSQL1 & strSQL2
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_ProviderOutPrice_Filter(ByVal _HMO_Provider_Outp_PriceInfo As HMO_Provider_Outp_PriceInfo) As DataSet
    '        'Filter By : Provider Name, State
    '        Try
    '            Dim strSQL2, strSQL1, strSQL As String

    '            With _HMO_Provider_Outp_PriceInfo
    '                If .ProviderID <> "0" Then
    '                    strSQL1 = " where (ProviderID ='" & .ProviderID & "')"
    '                Else
    '                    strSQL1 = ""
    '                End If
    '                If .EffectiveDate <> "" Then
    '                    If strSQL1 <> "" Then
    '                        strSQL2 = " and (EffectiveDate = '" & .EffectiveDate & "')"
    '                        'Else
    '                        '    strSQL2 = " where (EffectiveDate = '" & .EffectiveDate & "')"
    '                    End If
    '                Else
    '                    strSQL2 = ""
    '                End If
    '                strSQL = "SELECT HMO_Provider_Outp_Price.*, '~/Providers/pages/Provider_Outpatient_Price_Setup.aspx?Updateid='+ cast(ProvOutpID as varchar(50)) as edit from HMO_Provider_Outp_Price"
    '                strSQL = strSQL & strSQL1 & strSQL2
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_ProviderOutPrice_FilterByItem(ByVal _HMO_Provider_Outp_PriceInfo As HMO_Provider_Outp_PriceInfo) As DataSet
    '        'Filter By : Provider Name, State
    '        Try
    '            Dim strSQL1, strSQL As String

    '            With _HMO_Provider_Outp_PriceInfo
    '                If .ProvOutpID <> "0" Then
    '                    strSQL1 = " where (ProviderID ='" & .ProvOutpID & "')"
    '                Else
    '                    strSQL1 = ""
    '                End If

    '                strSQL = "SELECT HMO_Provider_Outp_Price.*, '~/Providers/pages/Provider_Outpatient_Price_Setup.aspx?Updateid='+ cast(ProvOutpID as varchar(50)) as edit from HMO_Provider_Outp_Price"
    '                strSQL = strSQL & strSQL1
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_ProviderSurgPrice_Filter(ByVal _HMO_Provider_Surgery_PriceInfo As HMO_Provider_Surgery_PriceInfo) As DataSet
    '        'Filter By : Provider Name, State
    '        Try
    '            Dim strSQL2, strSQL1, strSQL As String

    '            With _HMO_Provider_Surgery_PriceInfo
    '                If .ProviderID <> "0" Then
    '                    strSQL1 = " where (ProviderID ='" & .ProviderID & "')"
    '                Else
    '                    strSQL1 = ""
    '                End If
    '                If .EffectiveDate <> "" Then
    '                    If strSQL1 <> "" Then
    '                        strSQL2 = " and (EffectiveDate = '" & .EffectiveDate & "')"
    '                        'Else
    '                        '    strSQL2 = " where (EffectiveDate = '" & .EffectiveDate & "')"
    '                    End If
    '                Else
    '                    strSQL2 = ""
    '                End If
    '                strSQL = "SELECT HMO_Provider_Surgery_Price.*, '~/Providers/pages/Provider_Surgery_Price_Setup.aspx?Updateid='+ cast(ProvSurID as varchar(50)) as edit from HMO_Provider_Surgery_Price"
    '                strSQL = strSQL & strSQL1 & strSQL2
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_Company_Filter(ByVal _HMO_CompanyInfo As HMO_CompanyInfo) As DataSet
    '        'Filter By : Company Name, State
    '         Try
    '            Dim strSQL1, strSQL, strSQL2 As String

    '            With _HMO_CompanyInfo
    '                If .CompanyName <> "" Then
    '                    strSQL1 = " where (CompanyName like '%" & .CompanyName & "%')"
    '                Else
    '                    strSQL1 = ""
    '                End If

    '                If .StateID <> 0 Then
    '                    If strSQL1 <> "" Then
    '                        strSQL2 = " Or (StateID ='" & .StateID & "')"
    '                    Else
    '                        strSQL2 = " where (StateID ='" & .StateID & "')"
    '                    End If
    '                Else
    '                    strSQL2 = ""
    '                End If

    '                strSQL = "SELECT dbo.HMO_Company.*, '~/admin/pages/Company.aspx?Updateid='+ cast(CompanyID as varchar(50)) as edit from HMO_Company"
    '                strSQL = strSQL & strSQL1 & strSQL2
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_CompanyStaff_Filter(ByVal _HMO_CompanyInfo As HMO_CompanyInfo) As DataSet
    '        'Filter By : Company Name, State
    '        Try
    '            Dim strSQL1, strSQL As String

    '            With _HMO_CompanyInfo
    '                If .CompanyID <> 0 Then
    '                    strSQL1 = " where (CompanyID ='" & .CompanyID & "')"
    '                Else
    '                    strSQL1 = ""

    '                End If

    '                strSQL = "SELECT dbo.HMO_StaffSetup.*, 'Setup_Staff.aspx?Updateid='+ cast(SetupID as varchar(50)) as edit from HMO_StaffSetup"
    '                strSQL = strSQL & strSQL1
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)

    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_PharmGroup_Filter(ByVal _HMO_PharmGroupInfo As HMO_PharmGroupInfo) As DataSet
    '        'Filter By : Pharm Group
    '        Try
    '            Dim strSQL1, strSQL As String

    '            With _HMO_PharmGroupInfo
    '                If .GroupName <> "" Then
    '                    strSQL1 = " where (GroupName like '%" & .GroupName & "%')"
    '                Else
    '                    strSQL1 = ""
    '                End If

    '                strSQL = "SELECT dbo.HMO_PHARM_GROUP.*, '~/admin/pages/Pharmacological_Group.aspx?Updateid='+ cast(GroupID as varchar(50)) as edit from HMO_PHARM_GROUP"
    '                strSQL = strSQL & strSQL1
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)

    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Branch_Filter(ByVal _HMO_BranchInfo As HMO_BranchInfo) As DataSet
    '        Try
    '            Dim strSQL1, strSQL, strSQL2 As String

    '            With _HMO_BranchInfo
    '                If .BranchLocation <> "" Then
    '                    strSQL1 = " where (BranchLocation like '%" & .BranchLocation & "%')"
    '                Else
    '                    strSQL1 = ""
    '                End If

    '                If .StateID <> 0 Then
    '                    If strSQL1 <> "" Then
    '                        strSQL2 = " Or (StateID ='" & .StateID & "')"
    '                    Else
    '                        strSQL2 = " where (StateID ='" & .StateID & "')"
    '                    End If
    '                Else
    '                    strSQL2 = ""
    '                End If

    '                strSQL = "SELECT HMO_Branch.*, '~/admin/pages/Branch.aspx?Updateid='+ cast(BranchID as varchar(50)) as edit from HMO_Branch"
    '                strSQL = strSQL & strSQL1 & strSQL2
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)

    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_Company_Branch_Filter(ByVal _HMO_CompanyBranchInfo As HMO_Company_Branch) As DataSet
    '        Try
    '            Dim strSQL1, strSQL, strSQL2, strSQL3 As String

    '            With _HMO_CompanyBranchInfo
    '                If .BranchName <> "" Then
    '                    strSQL1 = " where (BranchName like '%" & .BranchName & "%')"
    '                Else
    '                    strSQL1 = ""
    '                End If

    '                If .StateID <> 0 Then
    '                    If strSQL1 <> "" Then
    '                        strSQL2 = " Or (StateID ='" & .StateID & "')"
    '                    Else
    '                        strSQL2 = " where (StateID ='" & .StateID & "')"
    '                    End If
    '                Else
    '                    strSQL2 = ""
    '                End If


    '                If .CompanyID <> 0 Then
    '                    If strSQL1 <> "" Or strSQL2 <> "" Then
    '                        strSQL3 = " Or (CompanyID ='" & .CompanyID & "')"
    '                    Else
    '                        strSQL3 = " where (CompanyID ='" & .CompanyID & "')"
    '                    End If
    '                Else
    '                    strSQL3 = ""
    '                End If


    '                strSQL = "SELECT HMO_CompanyBranch.*, '~/admin/pages/Company_Branch.aspx?Updateid='+ cast(BranchID as varchar(50)) as edit from HMO_CompanyBranch"
    '                strSQL = strSQL & strSQL1 & strSQL2 & strSQL3
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)

    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Form_Filter(ByVal _HMO_DrugStrenghtInfo As HMO_DrugStrenghtInfo) As DataSet
    '        'Filter By : Drug Form,
    '        Try
    '            Dim strSQL, strSQL2 As String

    '            With _HMO_DrugStrenghtInfo

    '                If .DrugFormID <> 0 Then
    '                    strSQL2 = " where (DrugFormID ='" & .DrugFormID & "')"
    '                Else
    '                    strSQL2 = ""
    '                End If


    '                strSQL = "SELECT dbo.HMO_DRUG_STRENGHT.*, '~/admin/pages/Drug_Strength.aspx?Updateid='+ cast(StrenghtID as varchar(50)) as edit from HMO_DRUG_STRENGHT"
    '                strSQL = strSQL & strSQL2
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)

    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Price_Filter(ByVal _HMO_DrugPriceInfo As HMO_DrugPriceInfo) As DataSet
    '        'Filter By : Drug Form,
    '        Try
    '            Dim strSQL, strSQL2 As String

    '            With _HMO_DrugPriceInfo

    '                If .DrugID <> 0 Then
    '                    strSQL2 = " where (DrugID ='" & .DrugID & "')"
    '                Else
    '                    strSQL2 = ""
    '                End If


    '                strSQL = "SELECT dbo.HMO_DRUG_PRICE.*, 'Drug_Price.aspx?Updateid='+ cast(PriceID as varchar(50)) as edit from HMO_DRUG_PRICE"
    '                strSQL = strSQL & strSQL2
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)

    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_DrugForm_Filter(ByVal _HMO_DrugFormInfo As HMO_DrugFormInfo) As DataSet
    '        'Filter By : Drug Form,
    '        Try
    '            Dim strSQL1, strSQL As String

    '            With _HMO_DrugFormInfo

    '                If .DrugForm <> "" Then
    '                    strSQL1 = " where (DrugForm like '%" & .DrugForm & "%')"
    '                Else
    '                    strSQL1 = ""
    '                End If
    '                strSQL = "SELECT dbo.HMO_DRUG_FORM.*, '~/admin/pages/Drug_Formation.aspx?Updateid='+ cast(DrugFormID as varchar(50)) as edit from HMO_DRUG_FORM"
    '                strSQL = strSQL & strSQL1
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_DrugSetup_Filter(ByVal _HMO_DrugSetupInfo As HMO_DrugSetUpInfo) As DataSet
    '        'Filter By : Drug Form,
    '        Try
    '            Dim strSQL1, strSQL2, strSQL As String

    '            With _HMO_DrugSetupInfo

    '                If .DrugName <> "" Then
    '                    strSQL1 = " where (DrugName like '%" & .DrugName & "%')"
    '                Else
    '                    strSQL1 = ""
    '                End If

    '                If .GroupID <> 0 Then
    '                    strSQL2 = " where (GroupID ='" & .GroupID & "')"
    '                Else
    '                    strSQL2 = ""
    '                End If

    '                strSQL = "SELECT HMO_DRUG.*, 'Drug_Setup.aspx?Updateid='+ cast(DrugID as varchar(50)) as edit from HMO_DRUG"
    '                strSQL = strSQL & strSQL1 & strSQL2

    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Provider_Delete(ByVal ProviderID As Integer) As Boolean
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@ProviderID", ProviderID)}
    '            SqlHelper.ExecuteNonQuery(cn, CommandType.StoredProcedure, "HMO_Delete_Provider", params)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_Branch_Delete(ByVal BranchID As Integer, ByVal IPAddress As String, ByVal Username As String) As Boolean
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@BranchID", BranchID), _
    '                                            New SqlParameter("@PostedBy", Username), _
    '                                            New SqlParameter("@IPAddress", IPAddress)}
    '            SqlHelper.ExecuteNonQuery(cn, CommandType.StoredProcedure, "HMO_Delete_Branch", params)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Provider_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Provider_FetchAll")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Provider_Capitation_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Capitation_FetchAll")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Capitation_Payment_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Capitation_Payment_FetchAll")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_ProviderPersonnel_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_ProviderPersonnel_FetchAll")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Bill_Reg_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Bill_Reg_FetchAll")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Prev_Claim_FetchAll(ByVal PolicyNumber As String) As DataSet
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@PolicyNumber", PolicyNumber)}
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Prev_Claim_FetchAll", params)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Attendee_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Attendee_FetchAll")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    'Public Function HMO_Refree_FetchAll() As DataSet
    '    '    Try
    '    '        Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Refree_FetchAll")
    '    '    Catch ex As Exception
    '    '        HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '    '        Return Nothing
    '    '    Finally
    '    '        cn.Close()
    '    '    End Try
    '    'End Function
    '    Public Function HMO_BasicTariff_FetchByDate(ByVal ProviderID As Integer) As DataSet
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@ProviderID", ProviderID)}
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Basic_Tariff_FetchByDate", params)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_RefNumber_FetchAll() As DataSet
    '        Try
    '            'Dim params() As SqlParameter = {New SqlParameter("@PolicyNumber", PolicyNumber)}
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_RefNumber_FetchAll")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_Provider_FetchByDropDown() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Provider_Fetch")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_ProvDrugPriceFetchAll() As DataSet
    '        'ByVal EffectiveDate As DateTime
    '        Try
    '            'Dim params() As SqlParameter = {New SqlParameter("@EffectiveDate", EffectiveDate)}
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Prov_Drug_Price_Fetch")
    '            'params
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_ProvLabPriceFetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Provider_Lab_Price_Fetch")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_ProvOptPriceFetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Provider_Opt_Price_Fetch")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_ProvDenPriceFetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Provider_Den_Price_Fetch")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_ProvOutpPriceFetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Provider_Outp_Price_Fetch")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_ProvSurgpPriceFetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Provider_Surg_Price_Fetch")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_ProvRadPriceFetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Provider_Rad_Price_Fetch")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_Benefit_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_BenefitTable_FetchAll")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Service_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_ServiceTable_FetchALL")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Files_Fetch(ByVal Root As String, ByVal RoleID As Integer) As DataSet
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@RootID", Root), _
    '                                            New SqlParameter("@RoleID", RoleID)}

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Files_Fetch", params)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Files_Fetch2(ByVal Root As String, ByVal RoleID As Integer) As DataSet
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@RootID", Root), _
    '                                            New SqlParameter("@RoleID", RoleID)}

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Files_Fetch2", params)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function EnrolleeName(ByVal Enrollee_Number As String) As String


    '        Dim params() As SqlParameter = {New SqlParameter("@Enrollee_Number", Enrollee_Number)}

    '        Dim retValue As Data.DataRow = SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Enrollee_Fullname", params).Tables(0).Rows(0)
    '        If retValue Is Nothing Then
    '            EnrolleeName = ""
    '        Else
    '            EnrolleeName = retValue.Table.Rows(0).Item("Fullname")
    '        End If
    '    End Function
    '    Public Function EnrolleeFullName(ByVal Enrollee_FamilyMemberNumber As String) As String


    '        Dim params() As SqlParameter = {New SqlParameter("@Enrollee_FamilyMemberNumber", Enrollee_FamilyMemberNumber)}

    '        Dim retValue As Data.DataRow = SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_EnrolleeFamily_Fullname", params).Tables(0).Rows(0)
    '        If retValue Is Nothing Then
    '            Enrollee_FamilyMemberNumber = ""
    '        Else
    '            Enrollee_FamilyMemberNumber = retValue.Table.Rows(0).Item("Fullname")
    '        End If
    '    End Function


    '    Public Function EnrolleeEmail(ByVal Username As String, ByVal Password As String, ByVal Email As String) As String

    '        Dim HtmlContent As String
    '        HtmlContent = HtmlContent & "<HTML>"
    '        HtmlContent = HtmlContent & "<HEAD>"
    '        HtmlContent = HtmlContent & "<TITLE>Royal Exchange Healthcare::Confirmation</TITLE>"
    '        HtmlContent = HtmlContent & "<style type=""text/css"">"
    '        HtmlContent = HtmlContent & "<!--"
    '        HtmlContent = HtmlContent & ".style12 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; }"
    '        HtmlContent = HtmlContent & ".style14 {font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold; }"
    '        HtmlContent = HtmlContent & "-->"
    '        HtmlContent = HtmlContent & "</style>"
    '        HtmlContent = HtmlContent & "</HEAD>"
    '        HtmlContent = HtmlContent & "<BODY>"
    '        HtmlContent = HtmlContent & "<div align=""center"">"
    '        HtmlContent = HtmlContent & "<center>"
    '        HtmlContent = HtmlContent & "<table width=""704"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"">"
    '        HtmlContent = HtmlContent & "<tr>"
    '        HtmlContent = HtmlContent & "<td width=""542"" align=""left"" valign=""top"">&nbsp;</td>"
    '        HtmlContent = HtmlContent & "<td width=""162"" align=""left"" valign=""top"">&nbsp;</td>"
    '        HtmlContent = HtmlContent & "</tr>"
    '        HtmlContent = HtmlContent & "<tr>"
    '        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
    '        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><img src=""www.royalexchangeplc.com/images/logo.jpg"" width=""162"" height=""28"" /></td>"
    '        HtmlContent = HtmlContent & "</tr>"
    '        HtmlContent = HtmlContent & " <tr>"
    '        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style14"">Dear " & EnrolleeName(Username) & ",</span></td>"
    '        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
    '        HtmlContent = HtmlContent & "</tr>"
    '        HtmlContent = HtmlContent & " <tr>"
    '        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
    '        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
    '        HtmlContent = HtmlContent & " </tr>"
    '        HtmlContent = HtmlContent & "<tr>"
    '        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">This is an automatic email from Royal Exchange Healthcare.</span></td>"
    '        HtmlContent = HtmlContent & " </tr>"
    '        HtmlContent = HtmlContent & "<tr>"
    '        HtmlContent = HtmlContent & " <td align=""left"" valign=""top"">&nbsp;</td>"
    '        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
    '        HtmlContent = HtmlContent & "</tr>"
    '        HtmlContent = HtmlContent & "<tr>"
    '        HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Thank you for registering with us. Please keep this email for your records. </span></td>"
    '        HtmlContent = HtmlContent & "</tr>"
    '        HtmlContent = HtmlContent & "<tr>"
    '        HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top"">&nbsp;</td>"
    '        HtmlContent = HtmlContent & "</tr>"
    '        HtmlContent = HtmlContent & " <tr>"
    '        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12""><strong>Username</strong> :" & Username & "  </span></td>"
    '        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
    '        HtmlContent = HtmlContent & "</tr>"
    '        HtmlContent = HtmlContent & "<tr>"
    '        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12""><strong>Password</strong> : " & Password & " </span></td>"
    '        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
    '        HtmlContent = HtmlContent & "</tr>"
    '        HtmlContent = HtmlContent & "<tr>"
    '        HtmlContent = HtmlContent & "<td colspan=""2"" align=""left"" valign=""top"">&nbsp;</td>"
    '        HtmlContent = HtmlContent & " </tr>"
    '        HtmlContent = HtmlContent & "<tr>"
    '        HtmlContent = HtmlContent & "</tr>"
    '        HtmlContent = HtmlContent & "<tr>"
    '        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
    '        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
    '        HtmlContent = HtmlContent & "</tr>"
    '        HtmlContent = HtmlContent & " <tr>"
    '        HtmlContent = HtmlContent & " <td colspan=""2"" align=""left"" valign=""top""><span class=""style12"">Sincerely,</span></td>"
    '        HtmlContent = HtmlContent & "</tr>"
    '        HtmlContent = HtmlContent & "<tr>"
    '        HtmlContent = HtmlContent & "<td align=""left"" valign=""top""><span class=""style12"">Royal Exchange Healthcare </span></td>"
    '        HtmlContent = HtmlContent & "<td align=""left"" valign=""top"">&nbsp;</td>"
    '        HtmlContent = HtmlContent & "</tr>"
    '        HtmlContent = HtmlContent & "</table>"
    '        HtmlContent = HtmlContent & "</center></div>"
    '        HtmlContent = HtmlContent & "</body>"
    '        HtmlContent = HtmlContent & "</html>"

    '        Dim ToEmail = Email
    '        Const ToFrom As String = "career@royalexchangeplc.com"

    '        Dim mm As New MailMessage(ToFrom, ToEmail)


    '        mm.Subject = "Royal Exchange::Confirmation"
    '        mm.Body = HtmlContent
    '        mm.IsBodyHtml = True
    '        mm.Priority = MailPriority.High


    '        Dim smtp As SmtpClient = New SmtpClient("192.168.10.2")
    '        smtp.Send(mm)

    '    End Function

    '    Public Function HMO_StaffLengthCheck(ByVal CompanyID As String) As Boolean
    '        Try
    '            Dim flag As Boolean
    '            Dim params() As SqlParameter = {New SqlParameter("@CompanyID", CompanyID)}
    '            Dim objlen As Integer = Convert.ToInt64(SqlHelper.ExecuteScalar(cn, CommandType.StoredProcedure, "dbo.HMO_Company_StaffLength", params))
    '            Dim objcount As Integer = Convert.ToInt32(SqlHelper.ExecuteScalar(cn, CommandType.StoredProcedure, "dbo.HMO_Company_StaffCount", params))


    '            If (objcount >= objlen) Then
    '                flag = True
    '            Else
    '                flag = False
    '            End If
    '            Return flag
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_CompanyAccessCode_Fetch(ByVal cmid As String) As String
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@CompanyID", cmid)}
    '            Return SqlHelper.ExecuteScalar(cn, CommandType.StoredProcedure, "dbo.HMO_PanelUser_FetchAccessCode", params).ToString()
    '        Catch ex As Exception
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function LabCat(ByVal LabCatID As Integer) As String

    '        Dim params() As SqlParameter = {New SqlParameter("@LabCatID", LabCatID)}
    '        Dim myReader As SqlDataReader = Nothing

    '        myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_Lab_Cat_Name", params)

    '        If myReader.HasRows Then
    '            myReader.Read()
    '            LabCat = myReader.GetString(0)
    '        Else
    '            LabCat = "N/A"
    '        End If
    '        If myReader IsNot Nothing Then
    '            myReader.Close()
    '        End If
    '    End Function
    '    Public Function RadCat(ByVal RadCatID As Integer) As String

    '        Dim params() As SqlParameter = {New SqlParameter("@RadCatID", RadCatID)}
    '        Dim myReader As SqlDataReader = Nothing

    '        myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_Rad_Cat_Name", params)

    '        If myReader.HasRows Then
    '            myReader.Read()
    '            RadCat = myReader.GetString(0)
    '        Else
    '            RadCat = "N/A"
    '        End If
    '        If myReader IsNot Nothing Then
    '            myReader.Close()
    '        End If
    '    End Function
    '    Public Function PlanName(ByVal PlanCode As String) As String

    '        Dim params() As SqlParameter = {New SqlParameter("@PlanCode", PlanCode)}
    '        Dim myReader As SqlDataReader = Nothing

    '        myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_PlanName", params)

    '        If myReader.HasRows Then
    '            myReader.Read()
    '            PlanName = myReader.GetString(0)
    '        Else
    '            PlanName = "N/A"
    '        End If
    '        If myReader IsNot Nothing Then
    '            myReader.Close()
    '        End If
    '    End Function
    '    Public Function PlanNameBySetupID(ByVal SetupID As Integer) As String

    '        Dim params() As SqlParameter = {New SqlParameter("@SetupID", SetupID)}
    '        Dim myReader As SqlDataReader = Nothing

    '        myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_PlanNameBySetupID", params)

    '        If myReader.HasRows Then
    '            myReader.Read()
    '            PlanNameBySetupID = myReader.GetString(0)
    '        Else
    '            PlanNameBySetupID = "N/A"
    '        End If
    '        If myReader IsNot Nothing Then
    '            myReader.Close()
    '        End If
    '    End Function
    '    Public Function CardPlanNameBySetupID(ByVal SetupID As Integer) As String

    '        Dim params() As SqlParameter = {New SqlParameter("@SetupID", SetupID)}
    '        Dim myReader As SqlDataReader = Nothing

    '        myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_CardPlanNameBySetupID", params)

    '        If myReader.HasRows Then
    '            myReader.Read()
    '            CardPlanNameBySetupID = myReader.GetString(0)
    '        Else
    '            CardPlanNameBySetupID = "N/A"
    '        End If
    '        If myReader IsNot Nothing Then
    '            myReader.Close()
    '        End If
    '    End Function
    '    Public Function PlanCodeSetupID(ByVal SetupID As Integer) As String

    '        Dim params() As SqlParameter = {New SqlParameter("@SetupID", SetupID)}
    '        Dim myReader As SqlDataReader = Nothing

    '        myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_PlanCodeBySetupID", params)

    '        If myReader.HasRows Then
    '            myReader.Read()
    '            PlanCodeSetupID = myReader.GetString(0)
    '        Else
    '            PlanCodeSetupID = "N/A"
    '        End If
    '        If myReader IsNot Nothing Then
    '            myReader.Close()
    '        End If
    '    End Function


    '    Public Function DependentName(ByVal DependentID As Integer) As String
    '        Dim params() As SqlParameter = {New SqlParameter("@DependentID", DependentID)}
    '        Dim myReader As SqlDataReader = Nothing

    '        myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_DependentName", params)

    '        If myReader.HasRows Then
    '            myReader.Read()
    '            DependentName = myReader.GetString(0)
    '        Else
    '            DependentName = "N/A"
    '        End If
    '        If myReader IsNot Nothing Then
    '            myReader.Close()
    '        End If

    '    End Function

    '    Public Function HMO_StaffSetup_FetchAll() As DataSet
    '        Try

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_StaffSetup_FetchAll")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_Dependency_FetchAll() As DataSet
    '        Try

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Dependent_FetchAll")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_StaffStrenght_Fetch() As DataSet
    '        Try

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_StaffStrenght_Fetch")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Dependent_Fetch() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_FullDependent")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    ' Public Function HMO_Enrollee_GetCompany(ByVal CompanyID As String) As String

    '        Try

    '            Dim params() As SqlParameter = {New SqlParameter("@CompanyID", CompanyID)}

    '            Dim myReader As SqlDataReader = Nothing

    '            myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_Enrollee_GetCompany", params)

    '            If myReader.HasRows Then
    '                myReader.Read()
    '                CompanyID = myReader.GetString(1)
    '            Else
    '                CompanyID = "N/A"
    '            End If
    '            If myReader IsNot Nothing Then
    '                myReader.Close()
    '            End If
    '            Return CompanyID
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        End Try
    '    End Function

    '    Public Function HMO_FederalScheme_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_FederalScheme_FetchAll")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_BenefitType_Filter(ByVal _HMO_BenefitTypeInfo As HMO_BenefitTypeInfo) As DataSet
    '        Try
    '            Dim strSQL1, strSQL As String

    '            With _HMO_BenefitTypeInfo
    '                If .BenefitType <> "" Then
    '                    strSQL1 = " where (BenefitType like '%" & .BenefitType & "%')"
    '                Else
    '                    strSQL1 = ""
    '                End If

    '                strSQL = "SELECT dbo.HMO_BenefitType.*, '~/product/pages/Setup_BenefitType.aspx?Updateid='+ cast(BenefitTypeID as varchar(50)) as edit from HMO_BenefitType"
    '                strSQL = strSQL & strSQL1
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)

    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_FederalScheme_Filter(ByVal _HMO_FederalSchemeInfo As HMO_FederalSchemeInfo) As DataSet
    '        'Filter By : SchemeName
    '        Try
    '            Dim strSQL1, strSQL As String

    '            With _HMO_FederalSchemeInfo
    '                If .SchemeName <> "" Then
    '                    strSQL1 = " where (SchemeName like '%" & .SchemeName & "%')"
    '                Else
    '                    strSQL1 = ""
    '                End If

    '                strSQL = "SELECT dbo.HMO_FederalScheme.*, '~/product/pages/Setup_FederalScheme.aspx?Updateid='+ cast(SchemeNameID as varchar(50)) as edit from HMO_FederalScheme"
    '                strSQL = strSQL & strSQL1
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)

    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_BenefitType_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_BenefitType_FetchAll")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_LGA_FetchByState(ByVal StateID As Integer) As DataSet
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@StateID", StateID)}
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_LGA_FetchByState", params)
    '        Catch ex As Exception
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_FederalScheme_FetchByDropDown() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_FederalScheme_FetchByDropDown")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_BenefitFetchByView() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_FetchBenefit_View")
    '        Catch ex As Exception
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_BenefitFetchForList(ByVal PlanCode As String) As DataSet
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@PlanCode", PlanCode)}
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Benefit_FetchByPlan", params)
    '        Catch ex As Exception
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function EmptyString(ByVal Value)
    '        If Value Is String.Empty Then
    '            Value = DBNull.Value
    '        Else
    '            EmptyString = Value
    '        End If
    '        EmptyString = Value
    '    End Function

    '    Public Function ConvertZero(ByVal Value)
    '        If Value = "0" Then
    '            Value = DBNull.Value
    '        Else
    '            ConvertZero = Value
    '        End If
    '        ConvertZero = Value
    '    End Function

    '    Public Function HMO_Plan_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Plan_FetchAll")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Provider_Personnel_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Provider_Personnel_Fetchall")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    ' Public Function LGAName(ByVal LGAID As Integer) As String

    '        Dim params() As SqlParameter = {New SqlParameter("@LGAID", LGAID)}
    '        Dim myReader As SqlDataReader = Nothing

    '        myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_LGAName", params)

    '        If myReader.HasRows Then
    '            myReader.Read()
    '            LGAName = myReader.GetString(0)
    '        Else
    '            LGAName = "N/A"
    '        End If
    '        If myReader IsNot Nothing Then
    '            myReader.Close()
    '        End If
    '    End Function

    '    Public Function HMO_LGAZone_Delete(ByVal LGZoneID As Integer) As Boolean
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@LGZoneID", LGZoneID)}
    '            SqlHelper.ExecuteNonQuery(cn, CommandType.StoredProcedure, "HMO_Delete_LGAZone", params)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    ' Public Function HMO_LGAZone_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_LGAZone_FetchAll")
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    'Public Function HMO_LGAZone_Filter(ByVal _HMO_LGAZoneInfo As HMO_LGAZoneInfo) As DataSet
    '        Try
    '            Dim strSQL1, strSQL, strSQL2 As String

    '            With _HMO_LGAZoneInfo
    '                If .StateID <> 0 Then
    '                    strSQL1 = " where (StateID ='" & .StateID & "')"
    '                Else
    '                    strSQL1 = ""
    '                End If

    '                If .ZoneName <> "" Then
    '                    If strSQL1 <> "" Then
    '                        strSQL2 = " Or (ZoneName like '%" & .ZoneName & "%')"
    '                    Else
    '                        strSQL2 = " where (ZoneName like '%" & .ZoneName & "%')"
    '                    End If
    '                Else
    '                    strSQL2 = ""
    '                End If

    '                strSQL = "SELECT dbo.HMO_LGAZone.*, '~/admin/pages/LGA_Zone.aspx?Updateid='+ cast(LGZoneID as varchar(50)) as edit from HMO_LGAZone"
    '                strSQL = strSQL & strSQL1 & strSQL2
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    ' Public Function ConvertStringZero(ByVal ID As Object) As String
    '        If IsDBNull(ID) Then
    '            Return (0)
    '        Else
    '            Return CStr(ID)
    '        End If

    '    End Function

    ' Public Function HMO_LGAZone_FetchByDropdown(ByVal LGAID As Integer, ByVal StateID As Integer) As DataSet
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@LGAID", LGAID), _
    '                                            New SqlParameter("@StateID", StateID)}

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_LGAZone_DropDown_Fetch", params)
    '        Catch ex As Exception
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function RoleName(ByVal RoleID As Integer) As String

    '        Dim params() As SqlParameter = {New SqlParameter("@RoleID", RoleID)}
    '        Dim myReader As SqlDataReader = Nothing
    '        myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_Role_FetchByID", params)

    '        If myReader.HasRows Then
    '            myReader.Read()
    '            RoleName = myReader.GetString(0)
    '        Else
    '            RoleName = "N/A"
    '        End If
    '        If myReader IsNot Nothing Then
    '            myReader.Close()
    '        End If


    '    End Function


    '    Public Function NoPhoto(ByVal EnrolleeNo)
    '        Dim sql As String = "select isNull(EnrolleePicture,'N/A') from HMO_Enrollee where Enrollee_Number ='" & EnrolleeNo & "'"
    '        Dim myReader As SqlDataReader = Nothing
    '        myReader = SqlHelper.ExecuteReader(cn, CommandType.Text, sql)
    '        If myReader.HasRows() Then
    '            myReader.Read()
    '            If myReader.GetString(0) = "N/A" Then
    '                NoPhoto = "../../images/NoPhoto.jpg"
    '            Else
    '                NoPhoto = myReader.GetString(0)
    '            End If
    '        End If
    '        If myReader IsNot Nothing Then
    '            myReader.Close()
    '        End If
    '    End Function

    '    Public Function NoPhoto2(ByVal EnrolleeNo)
    '        Dim sql As String = "select isNull(ImageUrl,'N/A') from HMO_Enrollee_FamilyMember where Enrollee_Number ='" & EnrolleeNo & "'"
    '        Dim myReader As SqlDataReader = Nothing
    '        myReader = SqlHelper.ExecuteReader(cn, CommandType.Text, sql)
    '        If myReader.HasRows() Then
    '            myReader.Read()
    '            If myReader.GetString(0) = "N/A" Then
    '                NoPhoto2 = "../../images/NoPhoto.jpg"
    '            Else
    '                NoPhoto2 = myReader.GetString(0)
    '            End If
    '        End If
    '        If myReader IsNot Nothing Then
    '            myReader.Close()
    '        End If
    '    End Function

    '    Public Function HMO_LabDetails_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Lab_Details_FetchAll")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_DenDetails_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Dental_Details_FetchAll")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Refree_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Refree_FetchAll")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_OptDetails_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Opt_Details_FetchAll")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_OutpDetails_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Outp_Details_FetchAll")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_SurgeryDetails_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Surgery_Details_FetchAll")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_LabDetails_Filter(ByVal _HMO_LabDetailsInfo As HMO_LabDetailsInfo) As DataSet
    '        'Filter By : Drug Form,
    '        Try
    '            Dim strSQL1, strSQL As String

    '            With _HMO_LabDetailsInfo

    '                If .LabDetails <> "" Then
    '                    strSQL1 = " where (LabDetails like '%" & .LabDetails & "%')"
    '                Else
    '                    strSQL1 = ""
    '                End If
    '                strSQL = "SELECT dbo.HMO_Provider_Lab_Registration.*, '~/admin/pages/LabRegistration_Details.aspx?Updateid='+ cast(LabID as varchar(50)) as edit from HMO_Provider_Lab_Registration"
    '                strSQL = strSQL & strSQL1
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_DenDetails_Filter(ByVal _HMO_DenDetailsInfo As HMO_DenDetailsInfo) As DataSet
    '        'Filter By : Drug Form,
    '        Try
    '            Dim strSQL1, strSQL As String

    '            With _HMO_DenDetailsInfo

    '                If .DentalDetail <> "" Then
    '                    strSQL1 = " where (DentalDetail like '%" & .DentalDetail & "%')"
    '                Else
    '                    strSQL1 = ""
    '                End If
    '                strSQL = "SELECT dbo.HMO_Dental_Registration.*, '~/admin/pages/Dental_Details.aspx?Updateid='+ cast(DentalID as varchar(50)) as edit from HMO_Dental_Registration"
    '                strSQL = strSQL & strSQL1
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_Refree_Filter(ByVal _HMO_RefreeInfo As HMO_RefreeInfo) As DataSet
    '        'Filter By : Drug Form,
    '        Try
    '            Dim strSQL1, strSQL As String

    '            With _HMO_RefreeInfo

    '                If .RefreeLname <> "" Then
    '                    strSQL1 = " where (RefreeLname like '%" & .RefreeLname & "%')"
    '                Else
    '                    strSQL1 = ""
    '                End If
    '                strSQL = "SELECT dbo.HMO_Refree.*, '~/admin/pages/Refree.aspx?Updateid='+ cast(RefreeID as varchar(50)) as edit from HMO_Refree"
    '                strSQL = strSQL & strSQL1
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_OptbDetails_Filter(ByVal _HMO_OptDetailsInfo As HMO_OptDetailsInfo) As DataSet
    '        'Filter By : Drug Form,
    '        Try
    '            Dim strSQL1, strSQL As String

    '            With _HMO_OptDetailsInfo

    '                If .OpticalDetail <> "" Then
    '                    strSQL1 = " where (OpticalDetail like '%" & .OpticalDetail & "%')"
    '                Else
    '                    strSQL1 = ""
    '                End If
    '                strSQL = "SELECT dbo.HMO_Optical_Registration.*, '~/admin/pages/Optical_Details.aspx?Updateid='+ cast(OpticalID as varchar(50)) as edit from HMO_Optical_Registration"
    '                strSQL = strSQL & strSQL1
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_OutpDetails_Filter(ByVal _HMO_OutpDetailsInfo As HMO_OutpDetailsInfo) As DataSet
    '        'Filter By : Drug Form,
    '        Try
    '            Dim strSQL1, strSQL As String

    '            With _HMO_OutpDetailsInfo

    '                If .OutpDetail <> "" Then
    '                    strSQL1 = " where (OutpDetail like '%" & .OutpDetail & "%')"
    '                Else
    '                    strSQL1 = ""
    '                End If
    '                strSQL = "SELECT dbo.HMO_Outp_Registration.*, '~/admin/pages/Outpatient_Details.aspx?Updateid='+ cast(OutpID as varchar(50)) as edit from HMO_Outp_Registration"
    '                strSQL = strSQL & strSQL1
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
    '    Public Function HMO_SurgeryDetails_Filter(ByVal _HMO_SurgeryDetailsInfo As HMO_SurgeryDetailsInfo) As DataSet
    '        'Filter By : Drug Form,
    '        Try
    '            Dim strSQL1, strSQL As String

    '            With _HMO_SurgeryDetailsInfo

    '                If .SurgeryDetail <> "" Then
    '                    strSQL1 = " where (SurgeryDetail like '%" & .SurgeryDetail & "%')"
    '                Else
    '                    strSQL1 = ""
    '                End If
    '                strSQL = "SELECT dbo.HMO_Surgery_Registration.*, '~/admin/pages/Surgery_Details.aspx?Updateid='+ cast(SurgeryID as varchar(50)) as edit from HMO_Surgery_Registration"
    '                strSQL = strSQL & strSQL1
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_RadDetails_Filter(ByVal _HMO_RadDetailsInfo As HMO_RadDetailsInfo) As DataSet
    '        'Filter By : Drug Form,
    '        Try
    '            Dim strSQL1, strSQL As String

    '            With _HMO_RadDetailsInfo

    '                If .RadDetails <> "" Then
    '                    strSQL1 = " where (RadiologicalDetails like '%" & .RadDetails & "%')"
    '                Else
    '                    strSQL1 = ""
    '                End If
    '                strSQL = "SELECT dbo.HMO_Radiological_Registration.*, '~/admin/pages/Radiological_Registration_View.aspx?Updateid='+ cast(RadID as varchar(50)) as edit from HMO_Radiological_Registration"
    '                strSQL = strSQL & strSQL1
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_RadDetails_FetchAll() As DataSet
    '        Try
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Rad_Details_FetchAll")
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function RadDetails(ByVal RadID As Integer) As String
    '        Try

    '            Dim params() As SqlParameter = {New SqlParameter("@RadID", RadID)}

    '            Dim myReader As SqlDataReader = Nothing

    '            myReader = SqlHelper.ExecuteReader(cn, CommandType.StoredProcedure, "HMO_RadDetail_Name", params)

    '            If myReader.HasRows Then
    '                myReader.Read()
    '                RadDetails = myReader.GetString(0)
    '            Else
    '                RadDetails = "N/A"
    '            End If
    '            If myReader IsNot Nothing Then
    '                myReader.Close()
    '            End If
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        End Try

    '    End Function

    '    Public Function HMO_ProviderRadPrice_Filter(ByVal _HMO_Provider_Radiology_PriceInfo As HMO_Provider_Radiology_PriceInfo) As DataSet
    '        'Filter By : Provider Name, Effective date
    '        Try
    '            Dim strSQL2, strSQL1, strSQL As String

    '            With _HMO_Provider_Radiology_PriceInfo
    '                If .ProviderID <> "0" Then
    '                    strSQL1 = " where (ProviderID ='" & .ProviderID & "')"
    '                Else
    '                    strSQL1 = ""
    '                End If
    '                If .EffectiveDate <> "" Then
    '                    If strSQL1 <> "" Then
    '                        strSQL2 = " and (EffectiveDate = '" & .EffectiveDate & "')"
    '                    Else
    '                        strSQL2 = " where (EffectiveDate = '" & .EffectiveDate & "')"
    '                    End If
    '                Else
    '                    strSQL2 = ""
    '                End If
    '                strSQL = "SELECT HMO_Provider_Radiological_Price.*, '~/Providers/pages/Provider_Radiological_Setup.aspx?Updateid='+ cast(ProRadID as varchar(50)) as edit from HMO_Provider_Radiological_Price"
    '                strSQL = strSQL & strSQL1 & strSQL2
    '            End With

    '            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, strSQL)
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '  Public Function HMO_CompanyPlan_FetchAll(ByVal CompanyID As Integer) As DataSet
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@CompanyID", CompanyID)}
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_PlanNameBy_Company", params)
    '        Catch ex As Exception
    '            Return Nothing
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    'Public Function HMO_Limit_FetchByCompany(ByVal CompanyID As Integer) As DataSet
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@CompanyID", CompanyID)}
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Limit_FetchByCompany", params)
    '        Catch ex As Exception
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_Premium_FetchByCompany(ByVal CompanyID As Integer) As DataSet
    '        Try
    '            Dim params() As SqlParameter = {New SqlParameter("@CompanyID", CompanyID)}
    '            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "HMO_Premium_FetchByCompany", params)
    '        Catch ex As Exception
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function

    '    Public Function HMO_Attendee_Limit(ByVal enrid As String) As Integer
    '        Try
    '            Dim flag As Integer
    '            Dim params() As SqlParameter = {New SqlParameter("@BillID", enrid)}
    '            Dim rte As Object = SqlHelper.ExecuteScalar(cn, CommandType.StoredProcedure, "dbo.HMO_Attendee_Check", params)
    '            If (IsDBNull(rte)) Then
    '                flag = 0
    '            Else
    '                flag = Convert.ToInt32(rte)
    '            End If
    '            Return flag
    '        Catch ex As Exception
    '            HMO_BLL.WriteLog(ex.Message + " : " + ex.StackTrace)
    '            Return Nothing
    '        Finally
    '            cn.Close()
    '        End Try
    '    End Function
End Class

