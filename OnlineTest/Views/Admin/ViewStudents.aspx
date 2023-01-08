<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ViewStudents.aspx.cs" Inherits="OnlineTest.Views.Admin.ViewStudents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    
    <div class="container-fluid">
        <div class="row" style ="height:10px">

        </div>
        <div class="row">
            <div class="col-md-1"></div>
            <div class="col-md-10">
               <h3 class="text-center text-danger"> Kaydolmuş Öğrencilerin Listesi </h3>
                <asp:GridView ID="StudentsList" runat="server" class="table table-bordered table-dark table-hover"></asp:GridView>
            </div>
            <div class="col-md-1"></div>
        </div>
    </div>
</asp:Content>
