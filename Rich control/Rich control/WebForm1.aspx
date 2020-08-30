<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Rich_control.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            color: #FF0000;
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style2">MK Placements&nbsp; </span></h1>
        </div>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>java</asp:ListItem>
            <asp:ListItem>php</asp:ListItem>
            <asp:ListItem>python</asp:ListItem>
            <asp:ListItem>.net</asp:ListItem>
        </asp:CheckBoxList>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" Height="22px" Text="Ok" />
        <p>
            <asp:Label ID="Label1" runat="server" Text="Result: "></asp:Label>
        </p>
        <p>
            <asp:AdRotator ID="AdRotator1" runat="server" DataSourceID="XmlDataSource1" />
            <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/MK.xml"></asp:XmlDataSource>
        </p>
    </form>
</body>
</html>
