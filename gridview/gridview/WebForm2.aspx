<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="gridview.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" />
                    <asp:BoundField DataField="sname" HeaderText="name" />
                    <asp:BoundField DataField="marks" HeaderText="marks" />
                    <asp:BoundField DataField="subject" HeaderText="subject" />
                    <asp:BoundField DataField="phonenumber" HeaderText="mobileno" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
