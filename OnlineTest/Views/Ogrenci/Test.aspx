<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Ogrenci/OgrenciMaster.Master" AutoEventWireup="true" CodeFile="Test.aspx.cs" CodeBehind="Test.aspx.cs" Inherits="OnlineTest.Views.Ogrenci.Test" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
       body{
           background-image:url("../../Assets/Images/kitaplar.jpg");
           background-size:cover;
       }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">
    <div class="container-fluid">
        <div class="row" style:"height:100px;">

        </div>
        <div class="row">
            <div class="col-md-3">

            </div>
            <div class ="col-md-6 bg-white rounded-3">
                <div class="row bg-success">
                    <h4 class="text-light" runat="server" id="QuesTb">Question Here</h4>
                </div>
                <div class="row">
                  <div class="m-1 m-3 form-check">
                    <label for="AnslRb" id="Ans1Lbl" runat="server" class="form-check-label text-success">Answer 1</label>
                    <input type="radio" name="Ans" class="form-check-input" id="Ans1Rb" runat="server"/>
                  </div>

                    <div class="m-1 m-3 form-check">
                    <label for="Ans2Rb" id="Ans2Lbl" runat="server" class="form-check-label text-success">Answer 2</label>
                    <input type="radio" name="Ans" class="form-check-input" id="Ans2Rb" runat="server"/>
                  </div>

                    <div class="m-1 m-3 form-check">
                    <label for="Ans3Rb"  id="Ans3Lbl" runat="server" class="form-check-label text-success">Answer 3</label>
                    <input type="radio" name="Ans" class="form-check-input" id="Ans3Rb" runat="server"/>
                  </div>

                    <div class="m-1 m-3 form-check">
                    <label for="Ans4Rb" id="Ans4Lbl" runat="server" class="form-check-label text-success">Answer 4</label>
                    <input type="radio" name="Ans" class="form-check-input" id="Ans4Rb" runat="server"/>
                  </div>
                </div>

                <div class="row">
                <div class="col-md-6">
                    <label runat="server" id="ErrMsg"></label>
                </div>
                <div class="col-md-4">
                    <label id="InfoMsg" runat="server" class="text-danger h5"></label>
                </div>
                <div class="col-md-2 mb-3">
                   
                   <asp:button text="Sonraki" class="btn btn-success" runat="server" OnClick="Unnamed1_Click" />
                </div>
            </div>

            </div>
            
            <div class="col-md-3">

            </div>

        </div>

    </div>
</asp:Content>
