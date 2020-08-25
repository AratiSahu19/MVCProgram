<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgetPassword.aspx.cs" Inherits="New_SPS_project.ForgetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .Button
{
background-color :#FF5A00;
color: #FFFFFF;
font-weight: bold;
margin-right: 2px;
padding: 4px 20px 4px 21px;
}
</style>
</head>
<body>
<form id="form1" runat="server">
<div>
    <center>

  
<table cellspacing="2" cellpadding="2" border="0">
<tr><td></td><td><b>Forgot Password</b></td></tr>
  <tr><td><b>Enter Email:</b></td><td><asp:TextBox ID="TextBox3" runat="server" /></td></tr>
<tr><td><b>Enter Password:</b></td><td><asp:TextBox ID="TextBox1" runat="server" /></td></tr>
    <tr><td><b>Re-Enter Password:</b></td><td>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td></tr>
<tr><td>&nbsp;</td><td><asp:button ID="btnSubmit" Text="Submit"  runat="server" CssClass="Button" OnClick="btnSubmit_Click"/></td></tr>
    <tr><td colspan="2" style=" color:red">
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Login.aspx">Back to Login</asp:LinkButton>
        </td></tr>
<tr><td colspan="2" style=" color:red"><asp:Label ID="lbltxt" runat="server"/></td></tr>
</table>
          </center>
</div>
    </form>
</body>
</html>
