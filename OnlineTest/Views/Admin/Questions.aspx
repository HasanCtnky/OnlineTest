<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Questions.aspx.cs" Inherits="OnlineTest.Views.Admin.Questions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    <div class ="container-fluid">
        <div class="row">
            <div class="col-md-3">
                <h5 class="text-danger text-center">Soru Oluştur</h5>
                
  <div class="mb-1">
    <label for="QNameTb" class="form-label">Quiz</label>
      <asp:DropDownList ID="QNameTb" class="form-control" runat="server">

      </asp:DropDownList>
</div>
   <div class="mb-1">
    <label for="QuestionsTb" class="form-label">Soru</label>
    <input type="text" class="form-control" id="QuestionTb" runat="server" autocomplete="off"/>
</div>
   <div class="mb-1">
    <label for="AnsByQuestTb" class="form-label">1.Seçenek</label>
    <input type="text" class="form-control" id="Ans1Tb" runat="server" autocomplete="off"/>
</div>
   <div class="mb-1">
    <label for="AnsByQuestTb" class="form-label">2.Seçenek</label>
    <input type="text" class="form-control" id="Ans2Tb" runat="server" autocomplete="off"/>
</div>
   <div class="mb-1">
    <label for="AnsByQuestTb" class="form-label">3.Seçenek</label>
    <input type="text" class="form-control" id="Ans3Tb" runat="server" autocomplete="off"/>
</div>
   <div class="mb-1">
    <label for="AnsByQuestTb" class="form-label">4.Seçenek</label>
    <input type="text" class="form-control" id="Ans4Tb" runat="server" autocomplete="off"/>
</div>
   <div class="mb-1">
    <label for="AnsByQuestTb" class="form-label">Doğru Seçenek</label>
    <input type="text" class="form-control" id="CorrectTb" runat="server" autocomplete="off"/>
</div>
                    <div class="row">
                           <label id="ErrMsg" runat="server" class="text-danger"> </label>
                        
                        <div class="col d-grid mb-3">
                          <asp:Button ID ="EditBtn" runat="server" Text="Düzenle" class="btn btn-warning btn-block" OnClick="EditBtn_Click" />
                    </div>
                        
                        <div class="col d-grid mb-3">
                          <asp:Button ID ="SaveBtn" runat="server" Text="Kaydet" class="btn btn-primary btn-block" OnClick="SaveBtn_Click"  />
                    </div>
                        
                        <div class="col d-grid mb-3">
                          <asp:Button ID ="DeleteBtn" runat="server" Text="Sil" class="btn btn-danger btn-block"  />
                    </div>

                    </div>
                    


            </div>
            <div class="col-md-9">
                <h3 class="text-danger text-center">Soru Listesi</h3>
                <asp:gridview class="table" id="QuestionList" runat="server" AutoGenerateSelectButton="True"  CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="QuestionList_SelectedIndexChanged" >
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
