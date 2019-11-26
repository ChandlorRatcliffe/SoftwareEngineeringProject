<%@ Page Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="PermissionsSetting.aspx.cs" Inherits="KarbonWebForms.Views.Permissions.PermissionsSetting" %>

<asp:Content runat="server" ContentPlaceHolderID="DashContent">
<div>
        <h2>The Permission Management View for a Project</h2>
    </div>

    <div class="container">
        <div class="row">
            <div class="col-3">
                <h4>Organization Members</h4>
                <div class="btn-group-vertical overflow-auto w-75">
                    <div class="input-group-prepend w-100">
                        <div class="input-group-text">
                            <input type="checkbox" aria-label="Checkbox for following text input">
                        </div>
                        <button type="button" class="btn btn-secondary btn-block">Member 1</button>
                    </div>
                    <div class="input-group-prepend w-100">
                        <div class="input-group-text">
                            <input type="checkbox" aria-label="Checkbox for following text input">
                        </div>
                        <button type="button" class="btn btn-secondary btn-block">Member 2</button>
                    </div>
                    <div class="input-group-prepend w-100">
                        <div class="input-group-text">
                            <input type="checkbox" aria-label="Checkbox for following text input">
                        </div>
                        <button type="button" class="btn btn-secondary btn-block">Member 3</button>
                    </div>
                    <div class="input-group-prepend w-100">
                        <div class="input-group-text">
                            <input type="checkbox" aria-label="Checkbox for following text input">
                        </div>
                        <button type="button" class="btn btn-secondary btn-block">Member 4</button>
                    </div>
                </div>
            </div>

            <div class="col-sm-5">
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <h4>Permission Option</h4>
                        <input type="text" class="form-control" placeholder="Organization Member" aria-label="Organization Member" aria-describedby="basic-addon1">
                    </div>
                </div>
                <div class="accordion" id="permissionAccordion">
                    <div class="card">
                        <div class="card-header" id="headingOne">
                            <h2 class="mb-0">
                                <button class="btn btn-link" type="button" data-toggle="collapse" data-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                                    Organization-wide Permissions
                                </button>
                            </h2>
                            <div class="input-group-prepend">
                                <input type="checkbox"  aria-label="Checkbox for following text input">
                                <label style="vertical-align:central">Select all</label>
                            </div>
                        </div>
                        <div id="collapseOne" class="collapse show" aria-labelledby="headingOne" data-parent="#permissionAccordion">
                            <div class="card-body">
                                <div class="row mb-2">
                                    <div class="col-6 input-group-prepend w-50">
                                        <div class="input-group-text">
                                            <input type="checkbox" aria-label="Checkbox for following text input">
                                        </div>
                                        <button type="button" class="btn btn-primary btn-block">Invite User</button>
                                    </div>
                                    <div class="col-6 input-group-prepend w-50">
                                        <div class="input-group-text">
                                            <input type="checkbox" aria-label="Checkbox for following text input">
                                        </div>
                                        <button type="button" class="btn btn-primary btn-block">Remove User</button>
                                    </div>
                                </div>
                                <div class="row  mb-2">
                                    <div class="col-6 input-group-prepend w-50">
                                        <div class="input-group-text">
                                            <input type="checkbox" aria-label="Checkbox for following text input">
                                        </div>
                                        <button type="button" class="btn btn-primary btn-block">Edit Users Permissions</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="card">
                        <div class="card-header" id="headingTwo">
                            <h2 class="mb-0">
                                <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
                                    Permissions for All Projects
                                </button>
                            </h2>
                            <div class="input-group-prepend">
                                <input type="checkbox"  aria-label="Checkbox for following text input">
                                <label style="vertical-align:central">Select all</label>
                            </div>
                        </div>
                        <div id="collapseTwo" class="collapse" aria-labelledby="headingTwo" data-parent="#permissionAccordion">
                            <div class="card-body">
                                <div class="row mb-2">
                                    <div class="col-6 input-group-prepend w-50">
                                        <div class="input-group-text">
                                            <input type="checkbox" aria-label="Checkbox for following text input">
                                        </div>
                                        <button type="button" class="btn btn-primary btn-block">Create Project</button>
                                    </div>
                                    <div class="col-6 input-group-prepend w-50">
                                        <div class="input-group-text">
                                            <input type="checkbox" aria-label="Checkbox for following text input">
                                        </div>
                                        <button type="button" class="btn btn-primary btn-block">Edit Project</button>
                                    </div>
                                </div>
                                <div class="row mb-2">
                                    <div class="col-6 input-group-prepend w-50">
                                        <div class="input-group-text">
                                            <input type="checkbox" aria-label="Checkbox for following text input">
                                        </div>
                                        <button type="button" class="btn btn-primary btn-block">Delete Project</button>
                                    </div>
                                    <div class="col-6 input-group-prepend w-50">
                                        <div class="input-group-text">
                                            <input type="checkbox" aria-label="Checkbox for following text input">
                                        </div>
                                        <button type="button" class="btn btn-primary btn-block">Assign Users to Project</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="card">
                        <div class="card-header" id="headingThree">
                            <h2 class="mb-0">
                                <button class="btn btn-link collapsed" type="button" data-toggle="collapse" data-target="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
                                    Permissions for All Tasks
                                </button>
                            </h2>
                            <div class="input-group-prepend">
                                <input type="checkbox"  aria-label="Checkbox for following text input">
                                <label style="vertical-align:central">Select all</label>
                            </div>
                        </div>
                        <div id="collapseThree" class="collapse" aria-labelledby="headingThree" data-parent="#permissionAccordion">
                            <div class="card-body">
                                <div class="row mb-2">
                                    <div class="col-6 input-group-prepend w-50">
                                        <div class="input-group-text">
                                            <input type="checkbox" aria-label="Checkbox for following text input">
                                        </div>
                                        <button type="button" class="btn btn-primary btn-block">Create Task</button>
                                    </div>
                                    <div class="col-6 input-group-prepend w-50">
                                        <div class="input-group-text">
                                            <input type="checkbox" aria-label="Checkbox for following text input">
                                        </div>
                                        <button type="button" class="btn btn-primary btn-block">Edit Task</button>
                                    </div>
                                </div>
                                <div class="row mb-2">
                                    <div class="col-6 input-group-prepend w-50">
                                        <div class="input-group-text">
                                            <input type="checkbox" aria-label="Checkbox for following text input">
                                        </div>
                                        <button type="button" class="btn btn-primary btn-block">Delete Project</button>
                                    </div>
                                    <div class="col-6 input-group-prepend w-50">
                                        <div class="input-group-text">
                                            <input type="checkbox" aria-label="Checkbox for following text input">
                                        </div>
                                        <button type="button" class="btn btn-primary btn-block">Assign Users to Project</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
