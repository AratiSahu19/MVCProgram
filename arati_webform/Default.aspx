<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 58%;
            border: 1px solid #808080;
            background-color: #999966;
        }
        .auto-style4 {
            font-size: medium;
        }
        .auto-style6 {
            width: 107px;
        }
        .auto-style7 {
            width: 122px;
        }
        .auto-style8 {
            font-size: medium;
            width: 122px;
        }
    </style>
</head>
<body style="font-size: x-large">
     <div class="auto-style1">
    
        MK PLACEMENT AND EDUCATION SERVICES</div>
        <hr>
    <form id="form1" runat="server">
   
        <table class="auto-style2">
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label1" runat="server" CssClass="auto-style4" Text="Account no:"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label2" runat="server" Text="Amount:"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:RadioButton ID="RadioButton1" runat="server" CssClass="auto-style4" GroupName="rd1" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Deposit" />
                    <asp:RadioButton ID="RadioButton2" runat="server" CssClass="auto-style4" GroupName="rd1" Text="withdrawl" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ok" Width="49px" />
                </td>
            </tr>
        </table>
        <asp:Label ID="Label3" runat="server" CssClass="auto-style4" Text="balance:"></asp:Label>
   
    </form>
    </body>
</html>
