<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="RecoverPassword.aspx.cs" Inherits="KarbonWebForms.Views.Accounts.RecoverPassword" Async="true"%>
<asp:Content runat="server" ContentPlaceHolderID="MainContent">
<!-- Recreation of RecoveryPassword.cshtml -->
    <div class="container my-5" style="max-width: 700px;">
        <h2 class="text-center mb-2">Password Recovery</h2>
        <div <%--asp-validation-summary="All"--%> class="text-danger"></div>
        <div class="form-group row">
            <%--<label asp-for="Email" class="col-sm-2 col-form-label"></label>--%>
            <asp:Label runat="server" AssociatedControlID="EmailEnter" CssClass="col-sm-2 col-form-label text-center">Email</asp:Label>
            <div class="col-sm-10" style="padding:10px">
                <%--<input asp-for="Email" class="form-control" />
                <span asp-validation-for="Email" class="text-danger"></span>--%>
                <asp:TextBox runat="server" ID="EmailEnter" CssClass="form-control" placeholder="Enter the account email"></asp:TextBox>
            </div>
            <asp:Label runat="server" AssociatedControlID="UsernameEnter" CssClass="col-sm-2 col-form-label text-center">Username</asp:Label>
            <div class="col-sm-10" style="padding:10px">
                <asp:TextBox runat="server" ID="UsernameEnter" CssClass="form-control" placeholder="Enter the account username"></asp:TextBox>
                <asp:LinkButton runat="server" ID="RecoverUsername" CssClass="form-text text-muted text-right text-light" href="/Account/RecoverPassword">Forgot&nbsp;Password?</asp:LinkButton>
            </div>
        </div>
        <div class="form-group row text-center">
            <div class="col-sm-12 col-md-12 col-lg-12">
                <h6 class="pb-2">Your password recovery token will be sent to your email address.</h6>
                <button runat="server" onserverclick="RecoverMyPassword" type="submit" class="btn btn-primary px-5">Recover</button>
            </div>
        </div>
</div>
</asp:Content>