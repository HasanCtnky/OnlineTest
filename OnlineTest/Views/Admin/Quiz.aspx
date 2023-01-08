<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Quiz.aspx.cs" Inherits="OnlineTest.Views.Admin.Quiz" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    <div class ="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <h5 class="text-danger text-center">Testi Oluştur</h5>
                
  <div class="mb-3">
    <label for="QuizNameTb" class="form-label">Quiz Adı</label>
    <input type="text" class="form-control" id="QuizNameTb" runat="server" autocomplete="off"/>
</div>
   <div class="mb-3">
    <label for="QuestionsTb" class="form-label">Soru Sayısı</label>
    <input type="text" class="form-control" id="QuestionsTb" runat="server" autocomplete="off"/>
</div>
   <div class="mb-3">
    <label for="AnsByQuestTb" class="form-label">Cevap Sayısı</label>
    <input type="text" class="form-control" id="AnsByQuestTb" runat="server" autocomplete="off"/>
</div>
                    <div class="row">
                           <label id="ErrMsg" runat="server" class="text-danger"> </label>
                        <div class="d-grid mb-3">
                          <asp:Button ID ="EditBtn" runat="server" Text="Düzenle" class="btn btn-warning btn-block" OnClick="EditBtn_Click" />
                    </div>
                        <div class="d-grid mb-3">
                          <asp:Button ID ="SaveBtn" runat="server" Text="Kaydet" class="btn btn-primary btn-block" OnClick="SaveBtn_Click" />
                    </div>
                        <div class="d-grid mb-3">
                          <asp:Button ID ="DeleteBtn" runat="server" Text="Sil" class="btn btn-danger btn-block" OnClick="DeleteBtn_Click" />
                    </div>
                    </div>
                    


            </div>
            <div class="col-md-8">
                <h3 class="text-danger text-center">Quiz Listesi</h3>
                <asp:gridview class="table" id="QuizList" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="QuizList_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor = "White" />
                    <EditRowStyle BackColor = " #2461BF " />
                    <FooterStyle BackColor = "#507CD1" Font-Bold ="True" ForeColor="White" />
                    <HeaderStyle BackColor="#ff4444" Font-Bold ="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF"  ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:gridview>              
            </div>
        </div>
    </div>
</asp:Content>
