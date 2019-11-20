<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RecoverUsername.aspx.cs" Inherits="CashewWebForms.RecoverUsername" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <!-- Username recovery form -->
    <div class="container my-5" style="max-width: 700px;">
        <h2 class="text-center mb-2">Username Recovery</h2>
        <div <%--asp-validation-summary="All"--%> class="text-danger"></div>
        <div class="form-group row">
            <%--<label asp-for="Email" class="col-sm-2 col-form-label"></label>--%>
            <asp:Label runat="server" AssociatedControlID="EmailEnter" CssClass="col-sm-2 col-form-label">Email</asp:Label>
            <div class="col-sm-10" style="padding:10px">
                <%--<input asp-for="Email" class="form-control" />--%>
                <asp:TextBox runat="server" ID="EmailEnter" CssClass="form-control" placeholder="Enter email to recover username"></asp:TextBox>
                <%--<span asp-validation-for="Email" class="text-danger"></span>--%>
            </div>
        </div>
        <div class="form-group row text-center">
            <div class="col-sm-12 col-md-12 col-lg-12">
                <h6 class="pb-2" style="color: forestgreen">Your username will be sent to your email address.</h6>
                <button type="submit" class="btn btn-primary px-5">Recover</button>
            </div>
        </div>
    </div>
</asp:Content>
