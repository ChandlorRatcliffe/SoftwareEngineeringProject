﻿<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="RecoverPasswordSuccess.aspx.cs" Inherits="KarbonWebForms.Views.Accounts.RecoverPasswordSuccess" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">

<div class="center-welcome">
    <article class="welcome-info">
        <div style="text-align:center;">
            <h1>Password Recovery</h1>
            <p>Recover your Karbon account</p>
            <p class="text-success">Your account has been found and an email encompassing your password has been deployed!</p>
        </div>
    </article>
    </div>
    <!-- Login & Go Back Buttons-->
    <div class="row justify-content-around">
        <div class="d-none col-sm-3 d-lg-block pt-1" style="height: 875px;">
            <button class="btn btn-secondary rounded-0 mt-1" type="button" onclick="" style="min-width: 145px;">Login</button>
        </div>
        <div class="d-none col-sm-3 d-lg-block pt-1" style="height: 875px;">
            <button class="btn btn-secondary rounded-0 mt-1" type="button" onclick="location.href='~/Views/Accounts/Login'" style="min-width: 145px;">Go Back</button>
        </div>
</div>
</asp:Content>