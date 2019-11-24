﻿<%@ Page Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="TaskPage.aspx.cs" Inherits="KarbonWebForms.Views.Tasks.TaskPage" %>

<asp:Content runat="server" ContentPlaceHolderID="DashboardContent">
<div class="container">
    <div class="row">
        <div class="col-md-4">
            <!-- This is the Note portion-->
            <div class="card">
                <h5 class="card-header">
                    Note
                </h5>
                <div class="card-body">
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Dictum at tempor commodo ullamcorper a lacus vestibulum sed arcu. Vulputate dignissim suspendisse in est. Viverra maecenas accumsan lacus vel. Viverra mauris in aliquam sem. Arcu bibendum at varius vel pharetra vel turpis nunc eget. Habitasse platea dictumst quisque sagittis. Tellus mauris a diam maecenas. Posuere lorem ipsum dolor sit amet consectetur adipiscing elit duis. Odio eu feugiat pretium nibh ipsum consequat. In eu mi bibendum neque egestas congue quisque egestas diam. Urna id volutpat lacus laoreet non curabitur gravida arcu ac.
                </div>
            </div>
        </div>
        <div class="col-md-5">
            <!-- This is the Description portion-->
            <div class="card">
                <div class="card-body">
                    Description - Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                </div>
            </div>
            <!--End of Note-->
            <br />
            <!--Start of Buttons-->
            <div class="row align-items-start">
                <div class="col">
                    <!--This button will take you to the team management page/view; I assume this to be Permission based, so I have disabled the button as a standard-->
                    <button type="button" class="btn btn-info" disabled>Team Management</button>
                </div>
                <div class="col">
                    <!--Intentionally left blank to save my sanity, had issue centering buttons-->
                </div>
                <div class="col">
                    <button type="button" class="btn btn-primary">New Note</button>
                </div>
            </div>
            <br />
            <div class="row align-items-center">
                <div class="col">
                    <button type="button" class="btn btn-success">Complete Task</button>
                </div>
                <div class="col">
                    <button type="button" class="btn btn-warning">Edit Task</button>
                </div>
                <div class="col">
                    <button type="button" class="btn btn-danger">Delete Task</button>
                </div>
            </div>
            <!--End of Buttons-->
        </div>
    </div>
</div>

</asp:Content>