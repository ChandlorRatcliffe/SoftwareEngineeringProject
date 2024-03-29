﻿<%@ Page Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="ProjectProgress.aspx.cs" Inherits="KarbonWebForms.Views.Progress.Index" %>
<asp:Content runat="server" ContentPlaceHolderID="DashContent">
<div>
    <h2>Progress of the Project</h2>
</div>

<!-- This is the progress bar, portions : "style="width: XX%;" aria-valuenow="XX"" will need to be generated to be in line with users progress-->
<div class="container">
    <div class="row justify-content-center">
        <div class="col-8">
            <div class="progress" style="height: 40px;">
                <div class="progress-bar bg-success" role="progressbar" style="width: 30%" aria-valuenow="30" aria-valuemin="0" aria-valuemax="100">Completed</div>
                <div class="progress-bar bg-danger" role="progressbar" style="width: 70%" aria-valuenow="70" aria-valuemin="0" aria-valuemax="100">Remaining</div>
            </div>
        </div>
    </div>
</div>

<div>
    <h2>Task History of the Project</h2>
</div>

<div class="accordion" id="taskAccordion">
    <div class="card">
        <div class="card-header" id="headingOne">
            <h2 class="mb-0">
                <button class="btn btn-link" type="button" data-toggle="collapse" data-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                    Collapsible Update Item #1
                </button>
            </h2>
        </div>

        <div id="collapseOne" class="collapse show" aria-labelledby="headingOne" data-parent="#taskAccordion">
            <div class="card-body">
                This is the most recent update
            </div>
        </div>
    </div>
    <div class="card">
        <div class="card-header" id="headingTwo">
            <h2 class="mb-0">
                <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
                    Collapsible Update Item #2
                </button>
            </h2>
        </div>
        <div id="collapseTwo" class="collapse" aria-labelledby="headingTwo" data-parent="#taskAccordion">
            <div class="card-body">
                This update happened recently, but its not the newest... This update is also not the oldest...
            </div>
        </div>
    </div>
    <div class="card">
        <div class="card-header" id="headingThree">
            <h2 class="mb-0">
                <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
                    Collapsible Update Item #3
                </button>
            </h2>
        </div>
        <div id="collapseThree" class="collapse" aria-labelledby="headingThree" data-parent="#taskAccordion">
            <div class="card-body">
               This is the oldest update. 
            </div>
        </div>
    </div>
</div>


</asp:Content>
