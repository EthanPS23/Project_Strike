<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Package.aspx.cs" Inherits="OOSD_Project_Phase_2.Package" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="mainBody" ContentPlaceHolderID="mainBody" runat="server">
    <script>
        window.onload  = function () {
            document.getElementById("login").innerHTML = "New text!";
        }
    </script>
    <h1 class="text-left mt-5 mb-5 ml-5">Package Purchased History</h1>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </div>
            </div>
        </div>

    </form>
</asp:Content>
