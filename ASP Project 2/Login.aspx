<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OOSD_Project_Phase_2.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="mainBody" ContentPlaceHolderID="mainBody" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-2">

            </div>
            <div class="col-md-8">
                <form class="form-group" id="form1" runat="server">
                    <h2 class="text-center mt-4"> Customer Login</h2>
                    <h2 class="text-center mt-4"> &nbsp;<asp:Label ID="lblErrorMsg" runat="server" Text="Label"></asp:Label>
                    </h2>
                    <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                    <asp:TextBox CssClass="form-control" TextMode="Password" ID="txtPassword" runat="server"></asp:TextBox>
                    <p class="text-center mt-4">
                        <asp:Button CssClass="btn btn-danger" ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
                        <asp:Button CssClass="btn btn-danger" ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" />
                       </p>
                </form>
            </div>
            <div class="col-md-2">

            </div>
        </div>
    </div>
</asp:Content>
