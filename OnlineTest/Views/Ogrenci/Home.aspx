<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Ogrenci/OgrenciMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" CodeFile="Home.aspx.cs" Inherits="OnlineTest.Views.Ogrenci.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body{
            background-image:url("../../Assets/Images/kitaplar.jpg");
            background-size:cover;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">
    <div class="row" style="height:100px">

    </div> 

    <div class="row">
        <div class="col bg-light border-top-2 border-bottom-2">
            <div class="row pt-3 pb-3">
                <div class="col-2"></div>
                <div class="col-2"> <label class="form-label text-center text-success h4"> Sınavınızı seçiniz </label> </div>
                <div class="col-4">  
                    <asp:DropDownList ID="QuizTb" class="form-control" runat="server">

                    </asp:DropDownList> 
                </div>
                <div class="col-4">
                    <asp:Button Text="Teste Başla" class="btn btn-success" runat="server" ID="BaslaBtn" OnClick="BaslaBtn_Click"/>
                </div>
            </div>
            <div>
               

                
            </div>
         </div>
    </div>
</asp:Content>
