﻿<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="RecoverPasswordFailure.aspx.cs" Inherits="KarbonWebForms.Views.Accounts.RecoverPasswordSuccess" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">

<div class="center-welcome">
    <article class="welcome-info">
        <div style="text-align:center;">
            <h1>Password Recovery</h1>
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
    <!-- Forgot Username, Submit, & New User Buttons -->
    <div class="row justify-content-around">
        <div class="d-none col-sm-3 d-lg-block pt-1" style="height: 875px;">
            <button class="btn btn-secondary rounded-0 mt-1" type="button" onclick="location.href='~/Views/Accounts/RecoverUsername'" style="min-width: 145px;">Forgot Username?</button>
        </div>
        <div class="d-none col-sm-3 d-lg-block pt-1" style="height: 875px;">
            <button class="btn btn-secondary rounded-0 mt-1" type="button" onclick="" style="min-width: 145px;">Submit</button>
            <button class="btn btn-secondary rounded-0 mt-1" type="button" onclick="location.href='~/Views/Accounts/Create'" style="min-width: 145px;">New User</button>
        </div>
</div>
</asp:Content>