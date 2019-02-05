<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="OOSD_Project_Phase_2.Default" %>


<asp:Content ID="z" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="y" ContentPlaceHolderID="mainBody" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

    <h1 class="text-center mt-5"> Favourite Destinations </h1>
    <div class="container mt-5">
        <div class="row">
            <div class="col-md-3">
                <div class="card">
                    <img class="card-img-top img-fluid" src="Images/so.jpg" alt="Card image">
                    <div class="card-body">
                        <h4 class="card-title">Package Name</h4>
                        <p class="card-text">Package Price</p>
                    </div>
                </div>
            </div>
            <div class="col-md-3">
                <div class="card">
                    <img class="card-img-top img-fluid" src="Images/1417534972.jpg" alt="Card image">
                    <div class="card-body">
                        <h4 class="card-title">Package Name</h4>
                        <p class="card-text">Package Price</p>
                    </div>
                </div>
            </div>
            <div class="col-md-3">
                <div class="card">
                    <img class="card-img-top img-fluid" src="Images/o-5.jpg" alt="Card image">
                    <div class="card-body">
                        <h4 class="card-title">Package Name</h4>
                        <p class="card-text">Package Price</p>
                    </div>
                </div>
            </div>
            <div class="col-md-3">
                <div class="card">
                    <img class="card-img-top img-fluid" src="Images/santorini-greece-oia-white-blue.jpg" alt="Card image">
                    <div class="card-body">
                        <h4 class="card-title">Package Name</h4>
                        <p class="card-text">Package Price</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
