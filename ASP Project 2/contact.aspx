<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="OOSD_Project_Phase_2.contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainBody" runat="server">
    <div class="container mt-5">
        <div class="row">
            <div class="col-md-12">
                <h1 class="text-center">Let's get connected </h1>
            </div>
        </div>
        <div class="container-fluid mt-5">
            <form action="/" method="post">
                <div class="row">
                    <div class="col-md-6">
                        <label>Name </label>
                        <input class="form-control" type="text" name="name" value="" />
                    </div>
                    <div class="col-md-6">
                        <label>Email </label>
                        <input class="form-control" type="email" name="name" value="" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <label>Message </label>
                        <br />
                        <textarea class="form-control"></textarea>
                    </div>
                    <div class="col-md-12">
                        <p class="text-right">   
                            <button type="button" class="btn btn-danger mt-5"> Submit </button>
                        </p>
                    </div>
                </div>
            </form>

        </div>
    </div>
</asp:Content>
