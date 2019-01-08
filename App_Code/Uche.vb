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

Public Class Uche
    Dim cn As SqlConnection
    Public Sub New()
        cn = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("connAppraise").ConnectionString)
    End Sub
    Public Sub Insert(CustomerName As String, Gender As String, City As String, State As String, CustomerType As String)
        ' Write your own Insert statement blocks 
    End Sub

    Public Function Fetch() As DataSet
        ' Write your own Fetch statement blocks, this method should return a DataTable 
        Try
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "Appraise_jobAccountability_Fetch")
        Catch ex As Exception
            Return Nothing
        Finally
            cn.Close()
        End Try
    End Function

    Public Sub Update(Seqno As Integer, jobAcc As String)
        ' Write your own Update statement blocks. 
    End Sub

    Public Sub Delete(CustomerCode As Integer)
        ' Write your own Delete statement blocks. 
    End Sub

    Public Function FetchCustomerType() As DataTable
        ' Write your own Fetch statement blocks to fetch Customer Type from its master table and this method should return a DataTable 
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
End Class
