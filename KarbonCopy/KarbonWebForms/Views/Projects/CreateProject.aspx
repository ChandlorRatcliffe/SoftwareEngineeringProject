<%@ Page Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="CreateProject.aspx.cs" Inherits="KarbonWebForms.Views.Projects.CreateProject" %>

<asp:Content runat="server" ContentPlaceHolderID="DashContent">
    <style>
        #TeammatesPicker {
            border: 1px solid #c3c3c3;
            width: 700px;
            height: 150px;
            overflow-y: scroll;
        }
    </style>

    <!-- multiple selected row -->
    <style>
        tbody tr:hover.selected td,
        tbody tr.selected td {
            background-color: lightgreen;
        }
    </style>

    <div class="container my-5" style="max-width: 700px;">
        <h3 class="text-center mb-2">Create New Project</h3>
        <!--<div asp-validation-summary="All" class="text-danger"></div>-->
        <!-- Project's Name-->
        <div class="row">
            <!-- asp-for="ProjectName" -->
            <input class="form-control col" id="ProjectName" placeholder="Enter a Project's Name" />
            <small id="ProjectNameHelpBlock" class="form-text text-muted">Project name must be less than or equal to 50 characters long, contain letters and numbers, and must not contain spaces, special characters, or emoji.
            </small>
        </div>
        <br />
        <!-- Project's Deadline -->
        <div class="row">
            <input id="Datepicker" class="form-control col" placeholder="Pick the Project's Deadline" style="width: 300px" />
            <!-- asp-for="ProjectDeadline" -->
            <!-- I can figure how to make this works with BundleConfig.cs -->
            <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
            <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
            <script src="https://unpkg.com/gijgo@1.9.13/js/gijgo.min.js" type="text/javascript"></script>
            <link href="https://unpkg.com/gijgo@1.9.13/css/gijgo.min.css" rel="stylesheet" type="text/css" />
            <script>
                $('#Datepicker').datepicker({
                    uiLibrary: 'bootstrap4'
                });
            </script>
        </div>
        <br />
        <!-- Project's Description-->
        <div class="row">
            <!-- asp-for="ProjectDescription" -->
            <textarea class="col" id="ProjectDescription" style="max-height: 300px; min-height: 100px;" placeholder="Project's Description (150 characters)"></textarea>
        </div>
        <br />
        <div class="row float-right">
            <p id="Counter"></p>
            <!-- word counter -->
            <script type="text/javascript">
                $('#ProjectDescription').keyup(function () {
                    var left = 150 - $(this).val().length;
                    if (left < 0) {
                        left = 0;
                    }
                    $('#Counter').text('Characters left: ' + left);
                });
            </script>
        </div>
        <br />
        <div class="row">
            <h5>Assemble your Team</h5>
        </div>
        <h6>Choose your Teammates Permissions</h6>
        <!-- Alignment need to be corrected-->
        <!-- Permissions Picker-->
        <div class="col">
            <!-- permissions input 
                        0: Create Project
                        1: Delete Project
                        2: Create Notes
                        3: Invite Users
                        4: Remove Users
                        5: Edit Project
                        6: Edit Task
                        7: Assign To Project
                        8: Assign to Task
                    -->
            <table class="table table-bordered table-hover" id="PermissionTable">
                <tbody>
                    <tr class="table-row text-center" data-id="0">
                        <td>Create Project</td>
                    </tr>
                    <tr class="table-row text-center" data-id="1">
                        <td>Delete Project</td>
                    </tr>
                    <tr class="table-row text-center" data-id="2">
                        <td>Create Notes</td>
                    </tr>
                    <tr class="table-row text-center" data-id="3">
                        <td>Invite Users</td>
                    </tr>
                    <tr class="table-row text-center" data-id="4">
                        <td>Remove Users</td>
                    </tr>
                    <tr class="table-row text-center" data-id="5">
                        <td>Edit Project</td>
                    </tr>
                    <tr class="table-row text-center" data-id="6">
                        <td>Edit Task</td>
                    </tr>
                    <tr class="table-row text-center" data-id="7">
                        <td>Assign To Project</td>
                    </tr>
                    <tr class="table-row text-center" data-id="8">
                        <td>Assign to Task</td>
                    </tr>
                </tbody>
            </table>
            <!-- Show show selected permission -->
            <script>
                $('#PermissionTable').ready(function () {
                    var table = $('#example').DataTable();

                    $('tbody').on('click', 'tr', function () {
                        $(this).toggleClass('selected');
                    });
                });
            </script>
        </div>
        <!-- Teammates Picker-->
        <h6>Choose your Teammates</h6>
        <div class="container" id="TeammatesPicker">
            <input type="checkbox" />This is checkbox<br />
            <input type="checkbox" />This is checkbox<br />
            <input type="checkbox" />This is checkbox<br />
            <input type="checkbox" />This is checkbox<br />
            <input type="checkbox" />This is checkbox<br />
            <input type="checkbox" />This is checkbox<br />
            <input type="checkbox" />This is checkbox<br />
            <input type="checkbox" />This is checkbox<br />
            <input type="checkbox" />This is checkbox<br />
            <input type="checkbox" />This is checkbox<br />
        </div>
        <br />
        <div class="row float-right">
            <button id="ConfirmInvite" type="button" class="btn btn-primary">Invite selected members</button>
        </div>
        <br />
        <br />
        <div class="row justify-content-center">
            <button id="CreateProject" type="button" class="btn btn-primary">Create Project</button>
        </div>
    </div>
</asp:Content>
