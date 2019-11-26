﻿<%@ Page Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="KarbonWebForms.Views.Accounts.Settings" %>

<asp:Content runat="server" ContentPlaceHolderID="DashContent">

<div class="Settings-Page">
        <center>
            <article class="Title-info">
                <h1>User Settings</h1>
            </article>
            <!-- Main Settings -->
            <!-- Change Username Section-->
            <div class="col-1">
                Username
            </div>
            <div class="input-group col-6 md-3">
                <br />
                <input type="text" class="form-control" placeholder="New Username" aria-label="New Username" aria-describedby="button-addon2">
                <div class="input-group-append">
                    <button class="btn btn-dark" type="button" id="button-addon2">Submit</button>
                </div>
            </div>
            <br />
            <!-- Change Email Section-->
            <div class="col-1">
                Email
            </div>
            <div class="input-group col-6 mb-3">
                <input type="text" class="form-control" placeholder="New Email" aria-label="New Email" aria-describedby="button-addon2">
                <div class="input-group-append">
                    <button class="btn btn-dark" type="button" id="button-addon2">Submit</button>
                </div>
            </div>
            <br />
            <!-- Change Password Section -->
            <div class="col-1">
                Password
            </div>
            <div class="input-group col-6 mb-3">
                <input type="text" class="form-control" placeholder="New Password" aria-label="New Password" aria-describedby="button-addon2">
            </div>
            <div class="input-group col-6 mb-3">
                <input type="text" class="form-control" placeholder="Confirm New Password" aria-label="Confirm New Password" aria-describedby="button-addon2">
                <div class="input-group-append">
                    <button class="btn btn-warning" type="button" id="button-addon2">Submit</button>
                </div>
            </div>
            <!-- Change Theme Section-->
            <div class="col-1">
                Themes
            </div>
            <button type="button" class="btn btn-light" data-toggle="button" aria-pressed="false" autocomplete="off">
                Light Mode
            </button>
            <button type="button" class="btn btn-dark" data-toggle="button" aria-pressed="false" autocomplete="off">
                Dark Mode
            </button>
        </center>
    </div>
</asp:Content>