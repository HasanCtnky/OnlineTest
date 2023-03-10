<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="OnlineTest.Views.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <link rel="stylesheet" href="../Assets/Lib/Bootstrap/css/bootstrap.min.css" />
    <style>
        {
            font-family:Poppins;
        }
        body{
            background-image:url("../Assets/Images/kitaplar.jpg");
            background-size:cover;
        }
    </style>
</head>
<body>
    <div class="container-fluid">
          
        <div class="row" style="height:60px">

        </div>
        <div class="row">
            <div class="col-md-5"></div>
            <div class="col-md-3 bg-light rounded-3 mt-4 shadow-lg">
                <h4 class="text-danger text-center">Online Sinav Sistemi</h4>
                <h6 class="text-success text-center">Kayıt Ol</h6>
                <form runat="server">
    <div class="mb-3">
    <label for="NameTb" class="form-label">İsim</label>
    <input type="text" class="form-control" id="NameTb" runat="server" aria-describedby="emailHelp" autocomplete="off">
  
    </div>
  <div class="mb-3">
    <label for="EmailTb" class="form-label">Email Adresi</label>
    <input type="email" class="form-control" id="EmailTb" runat="server" aria-describedby="emailHelp" autocomplete="off">
    <div id="emailHelp" class="form-text">E-postanizi asla baskalariyla paylasmayiniz.</div>
  </div>

  <div class="mb-3">
    <label for="PasswordTb" class="form-label">Şifre</label>
    <input type="password" class="form-control" id="PasswordTb"  runat="server">
  </div>
    <div class="mb-3">
    <label for="SchoolTb" class="form-label">Okul İsmi</label>
    <input type="text" class="form-control" id="SchoolTb"  autocomplete="off" runat="server"> 
  
    </div>
  <div class="mb-3 form-check">

   <label class="form-check-label text-center"><a href ="Login.aspx" class="text-danger">Giriş Yap</a> </label>
  </div>
                    <div class="d-grid mb-3">
                            <label id="ErrMsg" class="text-danger" runat="server"> </label>
                        <asp:Button ID ="RegisterBtn" runat="server" Text="Kayıt Ol" class="btn btn-success btn-block" OnClick="RegisterBtn_Click"/>
                    </div>

</form>
            </div>
            <div class="col-md4"></div>
        </div>
    </div>
<!--    <form id="form1">
    <div>

    </div>
    </form>    
--> 
</body>
</html>
