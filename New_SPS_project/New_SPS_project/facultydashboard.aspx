<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="facultydashboard.aspx.cs" Inherits="New_SPS_project.facultydashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 378px;
        }
        .auto-style2 {
            height: 59px;
            width: 253px;
        }
        .auto-style3 {
            height: 21px;
            width: 253px;
        }
        .auto-style4 {
            height: 62px;
            width: 253px;
        }
        .auto-style6 {
            float: left;
        }
        .inlineBlock {
            display: inline-block;
        }
        .floatLeft { 
            float: right; 

        }
        .auto-style11 {
            float: left;
        }
        .auto-style12 {
            height: 55px;
        }
        .auto-style13 {
            float: left;
            width: 591px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style12">
            Hello i am faculty here&nbsp;
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logout</asp:LinkButton>
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel2" runat="server" style="display: inline;" CssClass="auto-style11" Width="279px" >
            <table class="auto-style1" style="border:outset">
                <tr>
                    <td class="auto-style4" style="background-color:darksalmon">
                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Assignment Upload</asp:LinkButton>
                    </td>
                     <tr>
                    <td class="auto-style2" style="background-color:darksalmon">
                        <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/attendance.aspx">Attendance</asp:LinkButton>
                    &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3" style="background-color:darksalmon">
                         <asp:LinkButton ID="LinkButton4" runat="server">Exam</asp:LinkButton>
                    </td>
                </tr>
                    </table>
</asp:Panel>
             <asp:Panel ID="Panel1" runat="server" style="display: inline;" CssClass="auto-style6" Width="575px">
                
                     <table class="auto-style9" style="border:outset">
                    <tr>
                    <td rowspan="3" style="background-color:burlywood" class="auto-style13">&nbsp;<asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>.net</asp:ListItem>
                            <asp:ListItem>java</asp:ListItem>
                            <asp:ListItem>python</asp:ListItem>
                        </asp:DropDownList>
&nbsp;&nbsp;
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                        &nbsp;<asp:TextBox ID="TextBox2" runat="server" TextMode="Date" Width="122px"></asp:TextBox>
                        &nbsp;
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
                        &nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="View" />
                        &nbsp;
                        <asp:Button ID="Button3" runat="server" Text="Received Assignment" OnClick="Button3_Click" Width="148px" />
                        <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                            <AlternatingRowStyle BackColor="PaleGoldenrod" />
                            <FooterStyle BackColor="Tan" />
                            <HeaderStyle BackColor="Tan" Font-Bold="True" />
                            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                            <SortedAscendingCellStyle BackColor="#FAFAE7" />
                            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                            <SortedDescendingCellStyle BackColor="#E1DB9C" />
                            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
                        </asp:GridView>
                        
                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" Width="283px" OnRowCommand="GridView2_RowCommand">
                            <AlternatingRowStyle BackColor="#CCCCCC" />
                            <Columns>
                                <asp:TemplateField HeaderText="File">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="LinkButton6" runat="server" CommandArgument='<%# Eval("filename") %>' Text='<%# Eval("filename") %>'></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="type" HeaderText="Type" />
                                <asp:BoundField DataField="date" HeaderText="Date" />
                            </Columns>
                            <EmptyDataTemplate>
                                <asp:LinkButton ID="LinkButton5" runat="server" CommandArgument='<%# Eval("filename") %>' Text='<%# Eval("filename") %>'></asp:LinkButton>
                            </EmptyDataTemplate>
                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#808080" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#383838" />
                        </asp:GridView>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                        
                    </td>
                </tr>
               
           </table>
                 </asp:Panel>
            
            
        </div>
    </form>
</body>
</html>
