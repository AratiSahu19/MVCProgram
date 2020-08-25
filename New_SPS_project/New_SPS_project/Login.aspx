<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="New_SPS_project.Login" %>

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

	  </head>

<body style="background-image:url(loginbg.jpg)">
    <form id="form2" runat="server">
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
    
    <style type="text/css">
        .auto-style1 {
            width: 435px;
            height: 250px;
        }
        .auto-style2 {
            width: 356px;
            height: 22px;
            text-align: center;
        }
        .auto-style3 {
            width: 356px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
            width: 212px;
        }
        .auto-style5 {
            width: 212px;
            height: 22px;
        }
        </style>
       

        <div class="text-center">
          
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
             <br />
            <br />
            
            <center>
            <table class="auto-style1">
                <tr  style="border:ridge">
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="Email" Font-Bold="True" ForeColor="White"></asp:Label>
                    </td>
            
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox2" runat="server" Width="175px" OnTextChanged="TextBox2_TextChanged" BorderStyle="Inset" CssClass="offset-sm-0"></asp:TextBox>
                    </td>
                </tr>
                <tr style="border:ridge">
                    <td class="auto-style3"  >
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label2" Font-Bold="true" runat="server" Text="Password" ForeColor="White"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox1" runat="server" Width="176px" BorderStyle="Inset"></asp:TextBox>
                    </td>
                </tr>
               <tr style="border:ridge">
                     
                   <br />
                </tr>
              
            </table>
                </center>
            <asp:LinkButton ID="LinkButton1" runat="server" Text="Forget Password..??" OnClick="LinkButton1_Click" PostBackUrl="~/ForgetPassword.aspx" ></asp:LinkButton>
             <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" BackColor="#FF9999" EnableTheming="True" Font-Bold="True" Font-Names="Californian FB" Height="35px" Width="141px" />
            <br />
            <asp:Label ID="Label3" runat="server" ForeColor="White"></asp:Label>

        </div>
    </form>
</body>
</html>
