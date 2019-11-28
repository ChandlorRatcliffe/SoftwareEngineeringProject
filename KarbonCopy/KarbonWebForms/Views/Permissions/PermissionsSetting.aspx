<%@ Page Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="PermissionsSetting.aspx.cs" Inherits="KarbonWebForms.Views.Permissions.PermissionsSetting" %>

<asp:Content runat="server" ContentPlaceHolderID="DashContent">

    <div>
        <h2>The Permission Management View for a Project</h2>
    </div>

    <div class="container">
        <div class="row">
            <div class="col-3">
                <h4>Organization Members</h4>
                <div class="btn-group-vertical w-75" style="overflow-y: auto; max-height: 400px">
                    <asp:Repeater runat="server" ID="OrgMemRptr" OnPreRender="OrgMemRptr_PreRender">
                        <ItemTemplate>
                            <div class="input-group-prepend w-100">
                                <div class="input-group-text">
                                    <asp:CheckBox runat="server" param='<%# DataBinder.Eval(Container.DataItem, "Username") %>'></asp:CheckBox>
                                </div>
                                <button type="button" class="btn btn-sm btn-secondary btn-block"><%# DataBinder.Eval(Container.DataItem, "Username") %>  </button>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        

        <div class="col-7">
            <div class="input-group mb-3">
                <div class="input-group-prepend">
                    <h4>Permission Options</h4>
                    <input type="text" class="form-control" placeholder="Organization Member" aria-label="Organization Member" aria-describedby="basic-addon1">
                </div>
            </div>
            <asp:Panel CssClass="accordion" runat="server" ClientIDMode="Static" ID="permissionAccordion">
                <div class="card">
                    <div class="card-header" id="headingOne">
                        <h2 class="mb-0">
                            <button class="btn btn-link" type="button" data-toggle="collapse" data-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                                Organization-wide Permissions
                            </button>
                        </h2>
                        <div class="input-group-prepend">
                            <asp:CheckBox runat="server" ClientIDMode="Static" ID="OrgnPermsAll"></asp:CheckBox>
                            <label style="text-align:center">Select all</label>
                        </div>
                    </div>
                    <div id="collapseOne" class="collapse show" aria-labelledby="headingOne" data-parent="#permissionAccordion">
                        <div class="card-body">
                            <div class="row mb-2">
                                <div class="col-6 input-group-prepend w-50">
                                    <div class="input-group-text">
                                        <asp:CheckBox runat="server" ClientIDMode="Static" ID="OrgnInviteUser"></asp:CheckBox>
                                    </div>
                                    <button type="button" class="btn btn-primary btn-block">Invite User</button>
                                </div>
                                <div class="col-6 input-group-prepend w-50">
                                    <div class="input-group-text">
                                        <asp:CheckBox runat="server" ClientIDMode="Static" ID="OrgnRemoveUser"></asp:CheckBox>
                                    </div>
                                    <button type="button" class="btn btn-primary btn-block">Remove User</button>
                                </div>
                            </div>
                            <div class="row  mb-2">
                                <div class="col-6 input-group-prepend w-50">
                                    <div class="input-group-text">
                                        <asp:CheckBox runat="server" ClientIDMode="Static" ID="OrgnPermissionsEditing"></asp:CheckBox>
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
                            <asp:CheckBox runat="server" ClientIDMode="Static" ID="ProjPermsAll"></asp:CheckBox>
                            <label style="vertical-align: central">Select all</label>
                        </div>
                    </div>
                    <div id="collapseTwo" class="collapse" aria-labelledby="headingTwo" data-parent="#permissionAccordion">
                        <div class="card-body">
                            <div class="row mb-2">
                                <div class="col-6 input-group-prepend w-50">
                                    <div class="input-group-text">
                                        <asp:CheckBox runat="server" ClientIDMode="Static" ID="ProjCreateProject"></asp:CheckBox>
                                    </div>
                                    <button type="button" class="btn btn-primary btn-block">Create Project</button>
                                </div>
                                <div class="col-6 input-group-prepend w-50">
                                    <div class="input-group-text">
                                        <asp:CheckBox runat="server" ClientIDMode="Static" ID="ProjProjectEditing"></asp:CheckBox>
                                    </div>
                                    <button type="button" class="btn btn-primary btn-block">Edit Project</button>
                                </div>
                            </div>
                            <div class="row mb-2">
                                <div class="col-6 input-group-prepend w-50">
                                    <div class="input-group-text">
                                        <asp:CheckBox runat="server" ClientIDMode="Static" ID="ProjDeleteProject"></asp:CheckBox>
                                    </div>
                                    <button type="button" class="btn btn-primary btn-block">Delete Project</button>
                                </div>
                                <div class="col-6 input-group-prepend w-50">
                                    <div class="input-group-text">
                                        <asp:CheckBox runat="server" ClientIDMode="Static" ID="ProjAssignmentEditing"></asp:CheckBox>
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
                            <asp:CheckBox runat="server" ClientIDMode="Static" ID="TaskPermsAll"></asp:CheckBox>
                            <label style="vertical-align: central">Select all</label>
                        </div>
                    </div>
                    <div id="collapseThree" class="collapse" aria-labelledby="headingThree" data-parent="#permissionAccordion">
                        <div class="card-body">
                            <div class="row mb-2">
                                <div class="col-6 input-group-prepend w-50">
                                    <div class="input-group-text">
                                        <asp:CheckBox runat="server" ClientIDMode="Static" ID="TaskCreateTask"></asp:CheckBox>
                                    </div>
                                    <button type="button" class="btn btn-primary btn-block">Create Task</button>
                                </div>
                                <div class="col-6 input-group-prepend w-50">
                                    <div class="input-group-text">
                                        <asp:CheckBox runat="server" ClientIDMode="Static" ID="TaskTaskEditing"></asp:CheckBox>
                                    </div>
                                    <button type="button" class="btn btn-primary btn-block">Edit Task</button>
                                </div>
                            </div>
                            <div class="row mb-2">
                                <div class="col-6 input-group-prepend w-50">
                                    <div class="input-group-text">
                                        <asp:CheckBox runat="server" ClientIDMode="Static" ID="TaskDeleteTask"></asp:CheckBox>
                                    </div>
                                    <button type="button" class="btn btn-primary btn-block">Delete Project</button>
                                </div>
                                <div class="col-6 input-group-prepend w-50">
                                    <div class="input-group-text">
                                        <asp:CheckBox runat="server" ClientIDMode="Static" ID="TaskAssignmentEditing"></asp:CheckBox>
                                    </div>
                                    <button type="button" class="btn btn-primary btn-block">Assign Users to Project</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
        </div>
        </div>
        <asp:LinkButton runat="server" CssClass="btn btn-primary btn-block" ID="UpdateBtn" OnClick="UpdateBtn_Click">Update Permissions </asp:LinkButton>
    </div>
</asp:Content>
