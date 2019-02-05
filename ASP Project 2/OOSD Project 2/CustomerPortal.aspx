<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CustomerPortal.aspx.cs" Inherits="OOSD_Project_Phase_2.CustomerPortal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainBody" runat="server">
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="row">
                <div class="col-md-6">
                    Welcome, <asp:Label runat="server" ID="lblCustFirstName" />  
                </div>
                <div class="col-md-6">
                    <p class="text-right"> 
                        <asp:Button CssClass="btn btn-danger" ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
                    </p>
                </div>
            </div>
        </div>
    <div class="container mt-5">
        <div class="row">
            <div class="col-md-2">
                <asp:Button CssClass="btn btn-danger" ID="btnEditProfile" runat="server" OnClick="btnEditProfile_Click" Text="Edit Profile" />
            </div>
            <div class="col-md-2">
                <p class="text-right">  
                    <asp:Button CssClass="btn btn-danger" ID="btnPackage" runat="server" OnClick="btnPackage_Click" Text="Packaged Purchase" />
                </p>
            </div>
        </div>
    </div>
    </form>
</asp:Content>
