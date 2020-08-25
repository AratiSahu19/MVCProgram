<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="New_SPS_project.Register" %>

<!DOCTYPE html>

<html>
<head runat="server">
  
	<title>Mk Placement</title>
	<meta charset="UTF-8">
	<meta name="description" content="WebUni Education Template">
	<meta name="keywords" content="webuni, education, creative, html">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<!-- Favicon -->   
	<link href="img/favicon.ico" rel="shortcut icon"/>

	<!-- Google Fonts -->
	<link href="https://fonts.googleapis.com/css?family=Raleway:400,400i,500,500i,600,600i,700,700i,800,800i" rel="stylesheet">

	<!-- Stylesheets -->
	<link rel="stylesheet" href="css/bootstrap.min.css"/>
	<link rel="stylesheet" href="css/font-awesome.min.css"/>
	<link rel="stylesheet" href="css/owl.carousel.css"/>
	<link rel="stylesheet" href="css/style.css"/>


	<!--[if lt IE 9]>
	  <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
	  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
	<![endif]-->

	  <style type="text/css">
          .auto-style1 {
              width: 819px;
          }
          .auto-style2 {
              width: 360px;
          }
          .auto-style3 {
              width: 362px;
          }
          .auto-style5 {
              width: 360px;
              height: 33px;
          }
          .auto-style6 {
              width: 694px;
              height: 33px;
          }
          .auto-style7 {
              width: 694px;
          }
      </style>
    <script>
        $(document).ready(function () {
            $("#TextBox8").keyup(validate);
        });


        function validate() {
            var password1 = $("#TextBox7").val();
            var password2 = $("#TextBox8").val();



            if (password1 == password2) {
                $("#validate-status").text("valid");
            }
            else {
                $("#validate-status").text("invalid");
            }

        }

    </script>

	  </head>

<body style="background-image:url(bg2.jpg);">
    <form id="form1" runat="server">
        <div class="text-center">
        <header class="header-section">
		<div class="container">
			<div class="row">
				<div class="col-lg-3 col-md-3">
					<div class="site-logo">
						
					</div>
					<div class="nav-switch">
						<i class="fa fa-bars"></i>
					</div>
				</div>
				<div class="col-lg-9 col-md-9">
					<a href="Login.aspx" class="site-btn header-btn">Login</a>
					<nav class="main-menu">
						<ul>
							<li><a href="HomePage.aspx">Home</a></li>
							<li><a href="#">About us</a></li>
							<li><a href="Register.aspx">Register</a></li>
							<li><a href="#">Contact</a></li>
						</ul>
					</nav>
				</div>
			</div>
		</div>
	</header>
        <div>
           
      
            
            <br />

            <br />
            <br />
            <br />
            <br />
            <br />
           
             <center>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="first name"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox1" runat="server" Width="204px" Height="24px"></asp:TextBox>
                  
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage=" First_Name Required" ForeColor="Red" Font-Italic="True" Font-Size="Small"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Last name"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox2" runat="server" Width="202px"></asp:TextBox>
                 
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Last_Name Required" ForeColor="Red" Font-Italic="True" Font-Size="Small"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text="DOB"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox9" runat="server" TextMode="Date" CssClass="offset-sm-0" Width="203px"></asp:TextBox>
                    
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label4" runat="server" Text="Phone number"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox4" runat="server" Width="203px"></asp:TextBox>
                   
                       <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"  
                ControlToValidate="TextBox4" ErrorMessage="Please enter currect phone number"  
                ValidationExpression="[0-9]{10}" Font-Italic="True" Font-Size="Small" ForeColor="Red"></asp:RegularExpressionValidator>  
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label5" runat="server" Text="Address"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox5" runat="server" Width="205px"></asp:TextBox>
                   
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="Address is required" Font-Italic="True" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label7" runat="server" Text="Gender"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="r1" Text="Male" />

                        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="r1" Text="Female" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label8" runat="server" Text="Course"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="41px" Width="192px">
                            <asp:ListItem>.Net</asp:ListItem>
                            <asp:ListItem>Java</asp:ListItem>
                            <asp:ListItem>Python</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label9" runat="server" Text="Role"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="r2" Text="Student" />
                        <asp:RadioButton ID="RadioButton4" runat="server" GroupName="r2" Text="Teacher" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label10" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        &nbsp;<asp:TextBox ID="TextBox6" runat="server" Width="211px"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox6" ErrorMessage="Please enter correct email id" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Font-Italic="True" Font-Size="Small" ForeColor="Red"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label11" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBox7" runat="server" TextMode="Password" Width="199px" OnTextChanged="TextBox7_TextChanged"></asp:TextBox>
                      <asp:RequiredFieldValidator id="passwordReq"
              runat="server"
              ControlToValidate="TextBox7"
              ErrorMessage="Password is required!"
              SetFocusOnError="True" Display="Dynamic" Font-Italic="True" Font-Size="Small" ForeColor="Red" />

  
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label12" runat="server" Text="Confirm Password"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        
                        <asp:TextBox ID="TextBox8" runat="server" TextMode="Password" Width="203px" OnTextChanged="TextBox8_TextChanged"></asp:TextBox>
                        <asp:RequiredFieldValidator id="confirmPasswordReq"
              runat="server" 
              ControlToValidate="TextBox8"
              ErrorMessage="Password confirmation is required!"
              SetFocusOnError="True" 
              Display="Dynamic" Font-Italic="True" Font-Size="Small" ForeColor="Red" />
                        <br />
                        <asp:CompareValidator id="comparePasswords" 
              runat="server"
              ControlToCompare="TextBox7"
              ControlToValidate="TextBox8"
              ErrorMessage="Your passwords do not match up!"
              Display="Dynamic" Font-Italic="True" Font-Size="Small" ForeColor="Red" />
        
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
            </table>
                </center>
        </div>
        
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" BackColor="#FF6699" Font-Bold="True" Font-Names="Book Antiqua" />
            <br />
            <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
