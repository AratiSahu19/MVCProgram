<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        ADVERTISEMENT<br />
    
    </div>
        <hr />

        <asp:AdRotator ID="AdRotator1" runat="server" DataSourceID="XmlDataSource2" Height="200px" Width="400px" />
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/advertisement.xml"></asp:XmlDataSource>

    </form>
</body>
</html>
