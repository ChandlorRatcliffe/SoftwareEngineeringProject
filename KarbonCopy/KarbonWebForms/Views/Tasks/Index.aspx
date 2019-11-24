﻿<%@ Page Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="KarbonWebForms.Views.Tasks.Index" %>

<asp:Content runat="server" ContentPlaceHolderID="DashboardContent">

<div>
    <h2>The Tasks List Page-Alpha</h2>
</div>

<div class="container">
    <div class="row">
        <div class="col-md-3">
            <div class="card text-center" style="width: 18rem;">
                <div class="card-body">
                    <h5 class="card-title">Task 1</h5>
                    <p class="card-text">Description of Task 1</p>
                    <a href="/Tasks/TaskPage" class="btn btn-primary">Go to Task view</a>
                </div>
            </div>
        </div>
        <div class="col-md-3">
            <div class="card text-center" style="width: 18rem;">
                <div class="card-body">
                    <h5 class="card-title">Task 2</h5>
                    <p class="card-text">Description of Task 2</p>
                    <a href="/Tasks/TaskPage" class="btn btn-primary">Go to Task view</a>
                </div>
            </div>
        </div>
        <div class="col-md-3">
            <div class="card text-center" style="width: 18rem;">
                <div class="card-body">
                    <h5 class="card-title">Task 3</h5>
                    <p class="card-text">Description of Task 3</p>
                    <a href="/Tasks/TaskPage" class="btn btn-primary">Go to Task view</a>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <div class="card text-center" style="width: 18rem;">
                <div class="card-body">
                    <h5 class="card-title">Task 4</h5>
                    <p class="card-text">Description of Task 4</p>
                    <a href="/Tasks/TaskPage" class="btn btn-primary">Go to Task view</a>
                </div>
            </div>
        </div>
        <div class="col-md-3">
            <div class="card text-center" style="width: 18rem;">
                <div class="card-body">
                    <h5 class="card-title">Task 5</h5>
                    <p class="card-text">Description of Task 5</p>
                    <a href="/Tasks/TaskPage" class="btn btn-primary">Go to Task view</a>
                </div>
            </div>
        </div>
        <br />
        <div class="col-md-3">
            <div class="card text-center" style="width: 18rem;">
                <div class="card-body">
                    <h5 class="card-title">Task 6</h5>
                    <p class="card-text">Description of Task 6</p>
                    <a href="/Tasks/TaskPage" class="btn btn-primary">Go to Task view</a>
                </div>
            </div>
        </div>
    </div>
</div>

</asp:Content>