<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="Book_Store_Project.AddBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #FF0000;
        }
        .auto-style2 {
            width: 847px;
        }
        .auto-style3 {
            width: 239px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="3" cellspacing="3" class="auto-style1">
        <tr>
            <td class="auto-style3">Book Form</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Book Name</td>
            <td>
                <asp:TextBox ID="txtbname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">MRP</td>
            <td>
                <asp:TextBox ID="txtmrp" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Author</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Chetan Bhagat</asp:ListItem>
                    <asp:ListItem>Charles Dickens</asp:ListItem>
                    <asp:ListItem>Rowling</asp:ListItem>
                    <asp:ListItem>George Orwell</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Category</td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>Comics</asp:ListItem>
                    <asp:ListItem>Novel</asp:ListItem>
                    <asp:ListItem>historical</asp:ListItem>
                    <asp:ListItem>Horror</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Publisher</td>
            <td>
                <asp:DropDownList ID="DropDownList3" runat="server">
                    <asp:ListItem>simon</asp:ListItem>
                    <asp:ListItem>penguin</asp:ListItem>
                    <asp:ListItem>howard</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
