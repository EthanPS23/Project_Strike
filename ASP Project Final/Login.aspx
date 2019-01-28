<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASP_Project_Final.Login" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <link href="Content/style.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Aleo" rel="stylesheet">
</head>
<body>
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <img src="Images/caribbean.jpg" width="100%"/>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-2">

            </div>
            <div class="col-md-8">
                <form class="form-group" id="form1" runat="server">
                    <h2 class="text-center mt-4"> Customer Login </h2>
                    <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                    <asp:TextBox CssClass="form-control" TextMode="Password" ID="txtPassword" runat="server"></asp:TextBox>
                    <p class="text-center mt-4">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:Button CssClass="btn btn-outline-primary" ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
                        <asp:Button CssClass="btn btn-outline-primary" ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" />
                        <asp:Button ID="btnMain" runat="server" OnClick="btnMain_Click" Text="Main" />
                    </p>
                </form>
            </div>
            <div class="col-md-2">

            </div>
        </div>
    </div>
    
</body>
</html>
