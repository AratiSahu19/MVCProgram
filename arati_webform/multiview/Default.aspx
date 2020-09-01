<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Login" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Signup" />
    
    </div>

        <br />
        <asp:MultiView ID="UNIVERSITY" runat="server" OnActiveViewChanged="MultiView1_ActiveViewChanged">
            <asp:View ID="LOGIN" runat="server">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; UserName:&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                &nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" Text="Login" />
                <br />
                <br />
            </asp:View>

            <asp:View ID="SIGNUP" runat="server">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; UserName:&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                &nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button4" runat="server" Text="Signup" />
                <br />
                <br />
            </asp:View>
        </asp:MultiView><br />
        <br />


        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="2" Height="168px" OnFinishButtonClick="Wizard1_FinishButtonClick" Width="438px">
            <WizardSteps>
                <asp:WizardStep runat="server" title="Step 1">
                    &nbsp;&nbsp;&nbsp; Username:&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    &nbsp;
                </asp:WizardStep>
                <asp:WizardStep runat="server" title="Step 2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password:
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    &nbsp;
                </asp:WizardStep>
                <asp:WizardStep runat="server" StepType="Finish" Title="Step 3">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; submit:<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    &nbsp;
                </asp:WizardStep>
                <asp:WizardStep runat="server" StepType="Complete" Title="End">
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>


    </form>
</body>
</html>
