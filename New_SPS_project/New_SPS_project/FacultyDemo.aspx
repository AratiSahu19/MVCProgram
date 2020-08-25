<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="facultydashboard.aspx.cs" Inherits="New_SPS_project.facultydashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 262px;
            height: 59px;
        }
        .auto-style3 {
            width: 262px;
            height: 153px;
        }
        .auto-style4 {
            width: 262px;
            height: 65px;
        }
        .auto-style5 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logout</asp:LinkButton>
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">
                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Assignment Upload</asp:LinkButton>
                    </td>
                    <td rowspan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>.net</asp:ListItem>
                            <asp:ListItem>java</asp:ListItem>
                            <asp:ListItem>python</asp:ListItem>
                        </asp:DropDownList>
&nbsp;&nbsp;
                        <asp:FileUpload ID="FileUpload1" runat="server" />
&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" TextMode="Date" Width="122px"></asp:TextBox>
                        &nbsp;
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
&nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                            <Columns>
                                <asp:TemplateField HeaderText="FileName">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="LinkButton4" runat="server" CommandArgument='<%# Eval("File") %>' Text='<%# Eval("File") %>'></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="size" HeaderText="Size in Byte" />
                                <asp:BoundField DataField="type" HeaderText="File Type" />
                                <asp:BoundField DataField="date" HeaderText="Date" />
                            </Columns>
                            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                            <RowStyle BackColor="White" ForeColor="#330099" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                            <SortedAscendingCellStyle BackColor="#FEFCEB" />
                            <SortedAscendingHeaderStyle BackColor="#AF0101" />
                            <SortedDescendingCellStyle BackColor="#F6F0C0" />
                            <SortedDescendingHeaderStyle BackColor="#7E0000" />
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:LinkButton ID="LinkButton3" runat="server">Attendance</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                </tr>
            </table>
            <div class="auto-style5">
            <br />
            <br />
            <br />
            Hello i am faculty here </div>
        </div>
    </form>
</body>
</html>
