<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentdashboard.aspx.cs" Inherits="New_SPS_project.studentdashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
   

    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 248px;
            height: 121px;
        }
        .auto-style5 {
            text-align: left;
        }
        .auto-style6 {
            text-align: left;
            height: 69px;
            width: 956px;
        }
        .auto-style8 {
            width: 248px;
            height: 124px;
        }
        .auto-style9 {
            text-align: center;
            height: 419px;
            width: 666px;
        }
        .auto-style4 {
            width: 726px;
            text-align: left;
            height: 349px;
        }
        .auto-style10 {
            text-align: center;
            height: 372px;
            width: 281px;
            margin-left: 0px;
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
        </style>
</head>
<body style="height: 672px">
    <form id="form1" runat="server">
        <div class="auto-style1">
             <asp:Label ID="Label4" runat="server" Text="Label" Font-Bold="True" Font-Names="Arial Black" Font-Size="15pt" ForeColor="#0066FF"></asp:Label>
        </div>
        <div class="auto-style6">
            <div class="auto-style5">
               
            <br />
            Hello I am student here
                        <br />
            <br />
              <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton1_Click" PostBackUrl="~/Homepage.aspx">Logout</asp:LinkButton>
             &nbsp;</div>
              <asp:Panel ID="Panel2" runat="server" style="display: inline;" CssClass="auto-style11" Width="279px" >
             <table class="auto-style10" style="border:outset">
                <tr>
                    <td class="auto-style2" style="background-color:darksalmon">
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Assignment</asp:LinkButton>
            &nbsp;
                        </td>
                   
                    </tr>
                 <caption>
                     <br />
                     <br />
                 </caption>
                 
                 <tr>
                     <td class="auto-style8" style="background-color:darksalmon">
                         <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton1_Click">Exam</asp:LinkButton>
                         &nbsp; </td>
                 </tr>
                 </table>
                  </asp:Panel>
            <asp:Panel ID="Panel1" runat="server" style="float: left; display: inline;">
                 <table class="auto-style9" style="border:outset">
                    <tr>
                        <td class="auto-style4" style="background-color:burlywood" rowspan="2">&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View Assignment" />
                            &nbsp;
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                            &nbsp;
                            <asp:TextBox ID="TextBox2" runat="server" TextMode="Date" Width="117px"></asp:TextBox>
                            &nbsp;&nbsp;
                            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="upload" Width="93px" />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" OnRowCommand="GridView1_RowCommand">
                                <Columns>
                                    <asp:TemplateField HeaderText="File">
                                        <EditItemTemplate>
                                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:LinkButton Name="fn" ID="LinkButton3" runat="server" CommandArgument='<%# Eval("filename") %>' CommandName="Download" Text='<%# Eval("filename") %>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Date" DataField="date" />
                                    <asp:BoundField HeaderText="Filename" DataField="filename" />
                                </Columns>
                                <EmptyDataTemplate>
                                    <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("filename") %>' CommandName="Download" Text='<%# Eval("filename") %>'></asp:LinkButton>
                                </EmptyDataTemplate>
                            </asp:GridView>
                            <br />
                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                            <br />
                        </td>
                    </tr>
              </table>
            </asp:Panel>
           </div>
    </form>
</body>
</html>
