<%@ Page Language="VB" AutoEventWireup="false" CodeFile="PrintWeighOut.aspx.vb" Inherits="PrintWeighOut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script type = "text/javascript" >
      function preventBack(){window.history.forward();}
        setTimeout("preventBack()", 0);
         window.onunload = function () { null };
         </script>

        <script type="text/javascript">

        function PrintDiv() {
            var divToPrint = document.getElementById('printarea');
            var popupWin = window.open('', '_blank', 'width=600,height=500,location=no,left=200px');
            popupWin.document.open();
            popupWin.document.write('<html><body onload="window.print()">' + divToPrint.innerHTML + '</html>');
            popupWin.document.close();
        }
         </script>
</head>
    <style type="text/css">
        .auto-style1 {
            width: 66px;
        }
        .auto-style2 {
            width: 4px;
        }
        .auto-style3 {
            width: 750px;
        }
        .auto-style5 {
            width: 493px;
        }
        .auto-style6 {
            color: #FF0000;
        }
        .auto-style8 {
            color: #0066FF;
        }
    </style>
</head>
<body>
     <form id="form1" runat="server">
            
    <div>
         <div id="printarea">
    <asp:Panel ID="Panel1" runat="server">
        <asp:Label ID="lblError" runat="server" Text="" ForeColor="red"></asp:Label>
      <table width="900" border="1" rules="none" cellpadding="0" cellspacing="0" align="center" frame="Box" background="images/watermark2.png" bordercolor="blue">
            
            <tr>
              <td colspan="2" style="height: 22px">
                  &nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td colspan="2" height="22px">
                      </td>
            </tr>
            <tr>
              <td class="auto-style1"></td>
                <%--<td class="auto-style1"><img src="images/check.png" style="height: 1133px; margin-right: 0px;"/>                   </td>--%>
              <td class="auto-style2">&nbsp;              </td>
                <td class="auto-style3" border="1">      
                    &nbsp;
                    <table width: 823px">
                  <tr>
                  <td class="auto-style5" ><strong>SAVANNAH SUGAR CO. LTD NUMAN</strong></td>
                    <td align="center">
                    <img src="images/dangote.png" style="height: 108px; width: 184px" />
                        
                      </td>
                  </tr>
                        <tr>
                            <td class="fontcoyname" valign="top">
                                TICKET NO:
                                <asp:Label ID="lblCertID" runat="server"></asp:Label>
                                <br />
                                </td>
                                
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="2" class="style8">
                                <p style="font-family: Arial, Helvetica, sans-serif; font-size: xx-large; font-style: normal; color: #1E90FF; font-weight: lighter; text-transform: none; text-align: center;" >HTMS Department Harvest Ticket
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" class="fontcerttitle">
                                &nbsp;</td>
                        </tr>
                  <tr>
                    <td class="auto-style5"  border="1"><strong>DATE:</strong></td>
                    <td class="fontcertmain">
                        <asp:Label ID="lblDate" Width="400px" Style="word-wrap: normal; word-break: break-all;" runat="server"></asp:Label>
                      </td>
                  </tr>
                  <tr>
		
            <td class="auto-style5" style="font-weight: bold" >ZONE:</td>
                    <td class="fontcertmain">
                        <asp:Label ID="lblZone" Width="400px" Style="word-wrap: normal; word-break: break-all;" runat="server"></asp:Label>
                      </td>
                  </tr>
                  <tr>
            <td class="auto-style5" style="font-weight: bold" >SHIFT:</td>
                    <td class="fontcertmain">
                        <asp:Label ID="lblShift" runat="server" Width="400px" Style="word-wrap: normal; word-break: break-all;" ></asp:Label>
                      </td>
                  </tr>
                        <tr>
            <td class="auto-style5" style="font-weight: bold" >ESTATE:</td>
                    <td class="fontcertmain">
                        <asp:Label ID="lblEstate" runat="server" Width="400px" Style="word-wrap: normal; word-break: break-all;" ></asp:Label>
                      </td>
                  </tr>
                        <tr>
                            <td class="auto-style5" style="font-weight: bold">FIELD:</td>
                            <td class="fontcertmain"><asp:Label ID="lblField" runat="server" Width="400px" Style="word-wrap: normal; word-break: break-all;" ></asp:Label></td>
                        </tr>
                       
                        <tr>
                            <td class="auto-style5" style="font-weight: bold">SPACING:</td>
                            <td class="fontcertmain"><asp:Label ID="lblSpacing" runat="server" Width="400px" Style="word-wrap: normal; word-break: break-all;" ></asp:Label></td>
                        </tr>
                        <tr>
                            <td class="auto-style5" style="font-weight: bold">VARIETY:</td>
                            <td class="fontcertmain"><asp:Label ID="lblVariety" runat="server" Width="400px" Style="word-wrap: normal; word-break: break-all;" ></asp:Label></td>
                        </tr>
                        <tr>
                            <td class="auto-style5" style="font-weight: bold">CROP CYCLE:</td>
                            <td class="fontcertmain"><asp:Label ID="lblCycle" runat="server" Width="400px" Style="word-wrap: normal; word-break: break-all;" ></asp:Label></td>
                        </tr>
                        <tr>
                            <td class="auto-style5" style="font-weight: bold">TRANSACTION TYPE:</td>
                            <td class="fontcertmain"><asp:Label ID="lblTransType" runat="server" Width="400px" Style="word-wrap: normal; word-break: break-all;" ></asp:Label></td>
                        </tr>
                        <tr>
                            <td class="auto-style5" style="font-weight: bold">OG FARMER:</td>
                            <td class="fontcertmain"><asp:Label ID="lblOG" runat="server" Width="400px" Style="word-wrap: normal; word-break: break-all;" ></asp:Label></td>
                        </tr>


                  <tr>
        
			<td class="auto-style5" style="font-weight: bold" >LOADING NUMBER:</td>
                    <td class="fontcertmain">
                        <asp:Label ID="lblLoadNum" runat="server" Width="400px" Style="word-wrap: normal; word-break: break-all;"></asp:Label>
                      </td>
                  </tr>
                        <tr>
                            <td class="auto-style5" style="font-weight: bold">TRUCK/TRACTOR NUMBER:</td>
                            <td class="fontcertmain">
                        <asp:Label ID="lblTruckNum" runat="server" Width="400px" Style="word-wrap: normal; word-break: break-all;"></asp:Label>
                      </td>
                        </tr>
                        <tr>
                            <td class="auto-style5" style="font-weight: bold">BIN NUMBER:</td>
                            <td class="fontcertmain">
                        <asp:Label ID="lblBin" runat="server" Width="400px" Style="word-wrap: normal; word-break: break-all;"></asp:Label>
                      </td>
                        </tr>
                        <tr>
                            <td class="auto-style5" style="font-weight: bold">OPERATOR:</td>
                            <td class="fontcertmain">
                        <asp:Label ID="lblOperator" runat="server" Width="400px" Style="word-wrap: normal; word-break: break-all;"></asp:Label>
                      </td>
                        </tr>
                  <tr>
        
			<td class="auto-style5" style="font-weight: bold" >FIELD RECORD CLARK:</td>
                    <td class="fontcertmain">
                        <asp:Label ID="lblClark" runat="server" Width="400px" Style="word-wrap: normal; word-break: break-all;"></asp:Label>
                      </td>
                  </tr>
                        <tr>
                            <td class="auto-style5" style="font-weight: bold">
                                TIME IN:</td>
                            <td class="fontcertmain">
                                <asp:Label ID="lblTimeIn" Width="400px" Style="word-wrap: normal; word-break: break-all;" runat="server" Text=""></asp:Label></td>
                        </tr>
                        <tr>
                            <td class="auto-style5" style="font-weight: bold">GROSS WEIGHT:</td>
                            <td class="fontcertmain">
                        <asp:Label ID="lblGross" runat="server" Width="400px" Style="word-wrap: normal; word-break: break-all;"></asp:Label>
                      </td>
                        </tr>
                        <tr>
                            <td class="auto-style5" style="font-weight: bold">
                                TIME OUT:</td>
                            <td class="fontcertmain">
                                <asp:Label ID="lblTimeOut" Width="400px" Style="word-wrap: normal; word-break: break-all;" runat="server" Text=""></asp:Label></td>
                        </tr>
                        <tr>
                            <td class="auto-style5" style="font-weight: bold">TARE WEIGHT:</td>
                            <td class="fontcertmain">
                        <asp:Label ID="lblTare" runat="server" Width="400px" Style="word-wrap: normal; word-break: break-all;"></asp:Label>
                      </td>
                        </tr>
                        <tr>
                            <td class="auto-style5" style="font-weight: bold">NET WEIGHT:</td>
                            <td class="fontcertmain"><asp:Label ID="lblNet" Width="400px" Style="word-wrap: normal; word-break: break-all;" runat="server" Text=""></asp:Label></td>
                        </tr>
                        <tr>
                            <td class="auto-style5" style="font-weight: bold">FACTORY RECORD CLARK:</td>
                            <td class="fontcertmain"><asp:Label ID="lblRecClark" Width="400px" Style="word-wrap: normal; word-break: break-all;" runat="server" Text=""></asp:Label></td>
                        </tr>
                        <tr>
                            <td class="auto-style5">&nbsp;</td>
                            <td class="fontcertmain">&nbsp;</td>
                        </tr>
                        <tr>
                            <td align="center" class="auto-style8" valign="bottom" style="font-weight: bold;" colspan="2">
                                TRUCK-OUT TICKET</td>
                        </tr>
                        <tr>
                            <td class="auto-style5" valign="top">
                                &nbsp;</td>
                            <td class="fontcerttitle" valign="top">
                                <p>
                                    &nbsp;</p>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5" valign="top">&nbsp;</td>
                            <td class="fontcerttitle" valign="top">&nbsp;</td>
                        </tr>
                        <tr>
                            <td  style="text-align: left; font-weight: bold;" class="auto-style6" colspan="2">                            &nbsp;</td>
                        </tr>

                        <tr>
                            <td  style="text-align: left; font-weight: bold; font-size: large;" class="fontcertmain" colspan="2">                            &nbsp;</td>
                        </tr>

                        <tr>
                            <td  style="text-align: left; font-weight: bold;" class="auto-style5" valign="bottom">                            <br /> </td>
                            <td class="fontcertmain" align="center">  
                                &nbsp;</td>
                        </tr>

                        <tr>
                            <td class="set2" colspan="2" style="text-align: left">
                        
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="set2" colspan="2" style="text-align: center">Printed this
                                <asp:Label ID="lblDay" runat="server"></asp:Label>
                                &nbsp;day of&nbsp;
                                <asp:Label ID="lblMonth" runat="server"></asp:Label>
                                ,
                                <asp:Label ID="lblYear0" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="set2" style="text-align: left">&nbsp;</td>
                            <td class="set2" style="text-align: left"></td>
                        </tr>
                </table>
                <table style="width: 322px">
                          <tr>
                            <td style="height: 13px;" colspan="2">
                                &nbsp;</td>
                          </tr>
                      </table> 
                                  <tr>
              <td colspan="2">
                  </td>
                <td class="auto-style3"></td>
                <td colspan="2">
                    </td>
            </tr>
                      </table>
                   </asp:Panel>
        </div>
    </div>
      &nbsp &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp    &nbsp &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp    &nbsp &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp    &nbsp &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp   <asp:Button ID="btnprint" runat="server" OnClientClick="PrintDiv()" Text="Print" Height="29px" Width="94px" />      
        <asp:Button ID="Button1" runat="server" Text="Exit" Height="29px" Width="94px" />  <asp:HiddenField ID="hidcert" runat="server" />
        <asp:HiddenField ID="hidmpn" runat="server" />
        <asp:HiddenField ID="hidleadcoy" runat="server" />

        <asp:TextBox ID="txtCount" Visible="false" runat="server"></asp:TextBox>
    </form>
</body>
</html>
