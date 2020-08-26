<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="grid_view.list" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="first_name" HeaderText="first_name" SortExpression="first_name" />
                    <asp:BoundField DataField="last_name" HeaderText="last_name" SortExpression="last_name" />
                    <asp:BoundField DataField="Dob" HeaderText="Dob" SortExpression="Dob" />
                    <asp:BoundField DataField="phone_number" HeaderText="phone_number" SortExpression="phone_number" />
                    <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                    <asp:BoundField DataField="gender" HeaderText="gender" SortExpression="gender" />
                    <asp:BoundField DataField="course" HeaderText="course" SortExpression="course" />
                    <asp:BoundField DataField="role" HeaderText="role" SortExpression="role" />
                    <asp:BoundField DataField="email_id" HeaderText="email_id" SortExpression="email_id" />
                    <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
                    <asp:BoundField DataField="confirm_pwd" HeaderText="confirm_pwd" SortExpression="confirm_pwd" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:student_databaseConnectionString %>" DeleteCommand="DELETE FROM [Register_db] WHERE [id] = @id" InsertCommand="INSERT INTO [Register_db] ([first_name], [last_name], [Dob], [phone_number], [address], [gender], [course], [role], [email_id], [password], [confirm_pwd]) VALUES (@first_name, @last_name, @Dob, @phone_number, @address, @gender, @course, @role, @email_id, @password, @confirm_pwd)" SelectCommand="SELECT * FROM [Register_db]" UpdateCommand="UPDATE [Register_db] SET [first_name] = @first_name, [last_name] = @last_name, [Dob] = @Dob, [phone_number] = @phone_number, [address] = @address, [gender] = @gender, [course] = @course, [role] = @role, [email_id] = @email_id, [password] = @password, [confirm_pwd] = @confirm_pwd WHERE [id] = @id">
                <DeleteParameters>
                    <asp:Parameter Name="id" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="first_name" Type="String" />
                    <asp:Parameter Name="last_name" Type="String" />
                    <asp:Parameter DbType="Date" Name="Dob" />
                    <asp:Parameter Name="phone_number" Type="String" />
                    <asp:Parameter Name="address" Type="String" />
                    <asp:Parameter Name="gender" Type="String" />
                    <asp:Parameter Name="course" Type="String" />
                    <asp:Parameter Name="role" Type="String" />
                    <asp:Parameter Name="email_id" Type="String" />
                    <asp:Parameter Name="password" Type="String" />
                    <asp:Parameter Name="confirm_pwd" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="first_name" Type="String" />
                    <asp:Parameter Name="last_name" Type="String" />
                    <asp:Parameter DbType="Date" Name="Dob" />
                    <asp:Parameter Name="phone_number" Type="String" />
                    <asp:Parameter Name="address" Type="String" />
                    <asp:Parameter Name="gender" Type="String" />
                    <asp:Parameter Name="course" Type="String" />
                    <asp:Parameter Name="role" Type="String" />
                    <asp:Parameter Name="email_id" Type="String" />
                    <asp:Parameter Name="password" Type="String" />
                    <asp:Parameter Name="confirm_pwd" Type="String" />
                    <asp:Parameter Name="id" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
