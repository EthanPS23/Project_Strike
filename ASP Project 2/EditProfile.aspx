<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="OOSD_Project_Phase_2.EditProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainBody" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-2">

            </div>
            <div class="col-md-8">
                <form class="form-group" id="form1" runat="server">
                    <h2 class="text-center mt-4">
                        Edit Profile <br />
                    </h2>
                    <asp:Label CssClass="regFields" ID="lblEmail" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email is required" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="RegularExpressionValidator" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtFirstName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="First Name is required" ControlToValidate="txtFirstName"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtLastName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Last name is required." ControlToValidate="txtLastName"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblAddress" runat="server" Text="Address"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtAddress" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Address is required" ControlToValidate="txtAddress"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblCity" runat="server" Text="City"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtCity" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="City is required" ControlToValidate="txtCity"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblProvince" runat="server" Text="Province"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtProvince" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Province is required" ControlToValidate="txtProvince"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblPostalCode" runat="server" Text="Postal Code"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtPostalCode" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Postal Code is required" ControlToValidate="txtPostalCode"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblCountry" runat="server" Text="Country"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtCountry" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Country is required" ControlToValidate="txtCountry"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblHomePhone" runat="server" Text="Home Phone"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtHomePhone" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Home Phone is required" ControlToValidate="txtHomePhone"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblBusinessPhone" runat="server" Text="Business Phone"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtBusinessPhone" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblFax" runat="server" Text="Fax Number"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtFax" runat="server"></asp:TextBox>
                    <br />
                    <!--
                    <asp:Label CssClass="regFields" ID="lblPassword" runat="server" Text="Password"></asp:Label>
                    <asp:TextBox CssClass="form-control" TextMode="Password" ID="txtPassword" runat="server"></asp:TextBox>
                    <br />-->
                    <asp:Label ID="lblErrorMsg" runat="server" Text="Label"></asp:Label>
                    <br />
                    <p class="text-center"> 
                        <asp:Button CssClass="btn btn-danger" ID="btnRegister" runat="server" Text="Update" OnClick="btnRegister_Click" />
                    </p>
                </form>
            </div>
            <div class="col-md-2">

            </div>
        </div>
    </div>
</asp:Content>
