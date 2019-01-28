<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="ASP_Project_Final.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Travel Experts Pvt. Ltd.</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <link href="Content/style.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Aleo" rel="stylesheet"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>

</head>
<body>
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-3 mt-2 mb-2">
                <a href="Main.aspx"> 
                    <img style="height:60px; width:50%;" src="Images/LogoMakr_1emSAT.png" />
                </a>
            </div>
            <div class="col-md-9 mt-2 mb-2">
              <ul class="nav justify-content-end">
                <li class="nav-item">
                  <h5> <a class="nav-link" href="main.aspx">Home </a> </h5>
                </li>
                <li class="nav-item">
                  <h5> 
                      <a class="nav-link" href="Registration.aspx">  
                          Sign Up 
                      </a>
                  </h5>
                </li>
                <li class="nav-item">
                  <h5> 
                      <a class="nav-link" href="Login.aspx">  
                          Login 
                      </a>
                  </h5>
                </li>
              </ul>
            </div>
        </div>  
    </div>
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <img src="Images/caribbean.jpg" width="100%"/>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-3 mt-3">
                <div class="card" style="width:400px">
                  <img class="card-img-top" src="img_avatar1.png" alt="Card image">
                  <div class="card-body">
                    <h4 class="card-title">John Doe</h4>
                    <p class="card-text">Some example text.</p>
                    <a href="#" class="btn btn-primary">See Profile</a>
                  </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
