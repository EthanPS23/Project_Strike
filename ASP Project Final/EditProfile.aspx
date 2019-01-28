<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="ASP_Project_Final.EditProfile" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Profile</title>
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
                    <h2 class="text-center mt-4">
                        Edit Profile <br />
                    </h2>
                    <asp:Label ID="lblCustomerID" CssClass="regFields" runat="server" Text="THis is invisible tetx"></asp:Label>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblEmail" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtFirstName" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtLastName" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblAddress" runat="server" Text="Address"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtAddress" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblCity" runat="server" Text="City"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtCity" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblProvince" runat="server" Text="Province"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtProvince" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblPostalCode" runat="server" Text="Postal Code"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtPostalCode" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblCountry" runat="server" Text="Country"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtCountry" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblHomePhone" runat="server" Text="Home Phone"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtHomePhone" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblBusinessPhone" runat="server" Text="Business Phone"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtBusinessPhone" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblFax" runat="server" Text="Fax Number"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtFax" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblPassword" runat="server" Text="Password"></asp:Label>
                    <asp:TextBox CssClass="form-control" TextMode="Password" ID="txtPassword" runat="server"></asp:TextBox>
                    <br />
                    <p class="text-center"> 
                        <asp:Button CssClass="btn btn-outline-primary" ID="btnRegister" runat="server" Text="Update" OnClick="btnRegister_Click" />
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </p>
                </form>
            </div>
            <div class="col-md-2">

            </div>
        </div>
    </div>
</body>
</html>
