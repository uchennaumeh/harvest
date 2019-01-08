<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Dashboard.aspx.vb" Inherits="Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="page-content-wrap">
        <div class="row">
            <div class="col-md-3">
                <div class="widget widget-default" >
                    <div class="widget-title">Welcome to HCC Collector Pro</div>                                                                        
                    <div class="widget-subtitle"> <asp:Label ID="lblLoggedUser" runat="server" Font-Bold="True" Font-Size="Medium"></asp:Label></div>
                </div>
            </div>

            <div class="col-md-3">
                <div class="widget widget-default" >
                    <div class="widget-title"><asp:Label ID="Label2" runat="server" Text="GROSS WEIGHMENT COUNT" ForeColor="#3333CC" Font-Bold="True"></asp:Label></div>
                    <div class="widget-subtitle">Today</div>
                    <div class="widget-int"><asp:Label ID="lblGrossToday" runat="server" Text="" ForeColor="#3333CC"></asp:Label></div>
                </div>
            </div>

            <div class="col-md-3">
                <div class="widget widget-default" >
                    <div class="widget-title"><asp:Label ID="Label1" runat="server" Text="TARE WEIGHMENT COUNT" ForeColor="#006600" Font-Bold="True"></asp:Label></div>
                    <div class="widget-subtitle">Today</div>
                    <div class="widget-int"><asp:Label ID="lblTareToday" runat="server" Text="" ForeColor="#006600"></asp:Label></div>
                </div>
            </div>

            <div class="col-md-3">
                <div class="widget widget-danger widget-padding-sm">
                    <div class="widget-big-int plugin-clock">00:00</div>                            
                    <div class="widget-subtitle plugin-date">Loading...</div>
                    <div class="widget-buttons widget-c3">
                        <div class="col">
                            <a href="#"><span class="fa fa-clock-o"></span></a>
                        </div>
                        <div class="col">
                            <a href="#"><span class="fa fa-bell"></span></a>
                        </div>
                        <div class="col">
                            <a href="#"><span class="fa fa-calendar"></span></a>
                        </div>
                    </div>                            
                </div>                        
            </div>

            <div class="col-md-3">
                <div class="widget widget-default" >
                    <div class="widget-title"><asp:Label ID="Label3" runat="server" Text="TOTAL GROSS WEIGHT" ForeColor="#660033" Font-Bold="True"></asp:Label></div>
                    <div class="widget-subtitle">Today</div>
                    <div class="widget-int"><asp:Label ID="lblGrossWeighToday" runat="server" Text="" ForeColor="#660033"></asp:Label><asp:Label ID="Label6" runat="server" Text="KG"
                    ForeColor="#660033"></asp:Label></div>
                </div>
            </div>

            <div class="col-md-3">
                <div class="widget widget-default" >
                    <div class="widget-title"><asp:Label ID="Label4" runat="server" Text="TOTAL TARE WEIGHT" ForeColor="#663300" Font-Bold="True"></asp:Label></div>
                    <div class="widget-subtitle">Today</div>
                    <div class="widget-int"><asp:Label ID="lblTareWeighToday" runat="server" Text="" ForeColor="#663300"></asp:Label><asp:Label ID="Label5" runat="server" Text="KG"
                     ForeColor="#663300"></asp:Label></div>
                </div>
            </div>

            <div class="col-md-3">
                <div class="widget widget-default widget-item-icon" onclick="location.href='pages-address-book.html';">
                    <div class="widget-item-left">
                        <span class="fa fa-user"></span>
                    </div>
                    <div class="widget-data">
                        <div class="widget-int num-count"><asp:Label ID="lblCount" runat="server" Text="Label"></asp:Label></div>
                        <div class="widget-title">Registred users</div>
                        <div class="widget-subtitle">On your App</div>
                    </div>
                </div>                            
            </div>
        </div>
 

<%--        
        <div class="block-full-width">
            <div id="dashboard-chart" style="height: 250px; width: 100%; float: left;"></div>
            <div class="chart-legend">
                <div id="dashboard-legend"></div>
            </div>                                                
        </div>
--%>                   
                    
    </div>
                 
</asp:Content>

