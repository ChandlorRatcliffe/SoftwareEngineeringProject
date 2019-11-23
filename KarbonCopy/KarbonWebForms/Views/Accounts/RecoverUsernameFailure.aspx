<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RecoverUsernameFailure.aspx.cs" Inherits="CashewWebForms.RecoverUsername" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
<!-- Recreation of RecoveryUsernameFailure.cshtml -->
<!-- Main Text -->
<div class="center-welcome">
    <article class="welcome-info">
        <div style="text-align:center">
            <h1>Username Recovery</h1>
            <p>Recover your Karbon account</p>
            <p class="text-danger">Error: User not Found</p>
        </div>
    </article>
    </div>
    <!-- Email field, to try again -->
    <div class="form-group row">
    <label <%--asp-for="Email"--%> class="col-sm-4 col-form-label"></label>
        <div class="col-sm-5">
            <input <%--asp-for="Email"--%> class="form-control" placeholder="Email" />
            <span <%--asp-validation-for="Email"--%> class="text-danger"></span>
        </div>
    </div>
    <!-- Forgot Password, Submit, & New User Buttons -->
    <div class="row justify-content-around">
        <div class="d-none col-sm-3 d-lg-block pt-1" style="height: 875px;">
            <button class="btn btn-secondary rounded-0 mt-1" type="button" onclick="location.href='~/Views/Accounts/RecoverPassword'" style="min-width: 145px;">Forgot Password?</button>
        </div>
        <div class="d-none col-sm-3 d-lg-block pt-1" style="height: 875px;">
            <button class="btn btn-secondary rounded-0 mt-1" type="button" onclick="" style="min-width: 145px;">Submit</button>
            <button class="btn btn-secondary rounded-0 mt-1" type="button" onclick="location.href'~/Views/Accounts/Create'" style="min-width: 145px;">New User</button>
        </div>
</div>
</asp:Content>
