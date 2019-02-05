<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="OOSD_Project_Phase_2.Registration" %>
<%@ Register TagPrefix="recaptcha" Namespace="Recaptcha" Assembly="Recaptcha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainBody" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-2">

            </div>
            <div class="col-md-8">
                <form class="form-group" id="RegistrationForm" runat="server">
                    <h2>
                        Customer Registration<br />
                    </h2>
                    <asp:Label CssClass="regFields" ID="lblEmail" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email Format is wrong. Use something like john@travelexperts.com" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Password is required." ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblPassword" runat="server" Text="Password"></asp:Label>
                    <asp:TextBox CssClass="form-control" TextMode="Password" ID="txtPassword" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password is required." ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password should contain at least 8 characters, one digit, one special character" ValidationExpression="^.*(?=.{8,})(?=.*[\d])(?=.*[\W]).*$"></asp:RegularExpressionValidator>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblRetypePassword" runat="server" Text="Retype Password"></asp:Label>
                    <asp:TextBox CssClass="form-control" TextMode="Password" ID="txtRetypePassword" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtRetypePassword" ErrorMessage="Password doesn't match"></asp:CompareValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Password is required." ControlToValidate="txtRetypePassword"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtRetypePassword" ErrorMessage="Password should contain at least 8 characters, one digit, one special character" ValidationExpression="^.*(?=.{8,})(?=.*[\d])(?=.*[\W]).*$"></asp:RegularExpressionValidator>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtFirstName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="First Name is required." ControlToValidate="txtFirstName"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtLastName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Last Name is required." ControlToValidate="txtLastName"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblAddress" runat="server" Text="Address"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtAddress" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Address is required." ControlToValidate="txtAddress"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblCity" runat="server" Text="City"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtCity" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="City is required." ControlToValidate="txtCity"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblProvince" runat="server" Text="Province"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtProvince" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Province is required." ControlToValidate="txtProvince"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblPostalCode" runat="server" Text="Postal Code"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtPostalCode" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="Postal Code is required." ControlToValidate="txtPostalCode"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblCountry" runat="server" Text="Country"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtCountry" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Country is required." ControlToValidate="txtCountry"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblHomePhone" runat="server" Text="Home Phone"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtHomePhone" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Phone is required." ControlToValidate="txtHomePhone"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="txtHomePhone" ErrorMessage="The Phone should be only digit." ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="txtHomePhone" ErrorMessage="Phone number format could be like this: 1-(123)-123-1234 | 123 123 1234 | 1-800-ALPHNUM " ValidationExpression="^([0-9]( |-)?)?(\(?[0-9]{3}\)?|[0-9]{3})( |-)?([0-9]{3}( |-)?[0-9]{4}|[a-zA-Z0-9]{7})$"></asp:RegularExpressionValidator>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblBusinessPhone" runat="server" Text="Business Phone"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtBusinessPhone" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtBusinessPhone" ErrorMessage="The Phone should be only digit." ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="txtBusinessPhone" ErrorMessage="Phone number format could be like this: 1-(123)-123-1234 | 123 123 1234 | 1-800-ALPHNUM " ValidationExpression="^([0-9]( |-)?)?(\(?[0-9]{3}\)?|[0-9]{3})( |-)?([0-9]{3}( |-)?[0-9]{4}|[a-zA-Z0-9]{7})$"></asp:RegularExpressionValidator>
                    <br />
                    <asp:Label CssClass="regFields" ID="lblFax" runat="server" Text="Fax Number"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtFax" runat="server"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtFax" ErrorMessage="Fax Number should be between 3 to 7 digit long" MaximumValue="9999999" MinimumValue="100" SetFocusOnError="True"></asp:RangeValidator>
                    <br />
                    <br />
                    <!--<recaptcha:RecaptchaControl ID="recaptcha" runat="server" PublicKey="6LfyBY8UAAAAAA1qnHjIo6J13HjTpnYpmsl27Fa0" PrivateKey="6LfyBY8UAAAAAGJnjV_snb1IlbMMjOB7NVHSTx5b" />-->
                    <br />
                    <br />
                    <p class="text-center"> 
                        <asp:Button CssClass="btn btn-danger" ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
                        <asp:Label ID="lblMessage" runat="server"></asp:Label>
                    </p>
                </form>
            </div>
            <div class="col-md-2">

            </div>
        </div>
    </div>
</asp:Content>
