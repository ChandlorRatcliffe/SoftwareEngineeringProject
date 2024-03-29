﻿<%@ Page Language="C#"  MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="PermissionManagement.aspx.cs" Inherits="KarbonWebForms.Views.Projects.PermissionManagement" %>
<asp:Content runat="server" ContentPlaceHolderID="DashContent">
<div>
    <h2>The Permission Management View for a Project</h2>
</div>

<div class="container">
    <div class="row">
        <div class="col-sm-4">
            <h4>Team Members</h4>
            <div class="btn-group-vertical">
                <button type="button" class="btn btn-secondary">Member 1</button>
                <button type="button" class="btn btn-secondary">Member 2</button>
                <button type="button" class="btn btn-secondary">Member 3</button>
                <button type="button" class="btn btn-secondary">Member 4</button>
                <button type="button" class="btn btn-secondary">Member 5</button>
                <button type="button" class="btn btn-secondary">Member 6</button>
                <button type="button" class="btn btn-secondary">Member 7</button>
                <button type="button" class="btn btn-secondary">Member 8</button>
                <button type="button" class="btn btn-secondary">Member 9</button>
            </div>
        </div>

        <div class="col-sm-5">
            <div class="input-group mb-3">
                <div class="input-group-prepend">
                    <h4>Permission Option</h4>
                    <input type="text" class="form-control" placeholder="Team Member" aria-label="Team Member" aria-describedby="basic-addon1">
                </div>
            </div>
            <div class="accordion" id="taskAccordion">
                <div class="card">
                    <div class="card-header" id="headingOne">
                        <h2 class="mb-0">
                            <button class="btn btn-link" type="button" data-toggle="collapse" data-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                                Basic Permissions
                            </button>
                        </h2>
                    </div>
                    <div id="collapseOne" class="collapse show" aria-labelledby="headingOne" data-parent="#taskAccordion">
                        <div class="card-body">
                            <button type="button" class="btn btn-primary">Invite User</button>
                            <button type="button" class="btn btn-primary">Remove User</button>
                        </div>
                    </div>
                </div>
                <div class="card">
                    <div class="card-header" id="headingTwo">
                        <h2 class="mb-0">
                            <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
                                Give Permission
                            </button>
                        </h2>
                    </div>
                    <div id="collapseTwo" class="collapse" aria-labelledby="headingTwo" data-parent="#taskAccordion">
                        <div class="card-body">
                            <button type="button" class="btn btn-primary">Create Task</button>
                            <button type="button" class="btn btn-primary">Delete Task</button>
                            <button type="button" class="btn btn-primary">Assign Task</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

</asp:Content>
