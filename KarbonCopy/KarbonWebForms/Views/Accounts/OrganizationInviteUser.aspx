﻿<%@ Page Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="OrganizationInviteUser.aspx.cs" Inherits="KarbonWebForms.Views.Accounts.WebForm1" %>

<asp:Content runat="server" ContentPlaceHolderID="DashContent">
    <style>
        tbody tr:hover.selected td,
        tbody tr.selected td {
            background-color: lightgreen;
        }
    </style>

    <style>
        .my-custom-scrollbar {
            position: absolute;
            height: 400px;
            width: 1000px;
            overflow: auto;
        }

        .table-wrapper-scroll-y {
            display: block;
        }
    </style>
    <div class="container my-5" style="text-align: center;">
        <h1 class="text-center">Invite your Teammates (Employees)</h1>
        <br />
        <h2 class="text-center">Your Bussiness Code:</h2>
        <h2 class="text-success" id="BussinessCode">#RandomCode</h2>
        <br />
        <div class="container">
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
                <h5 class="text-center">Pick their permissions:</h5>
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
            <div class="col">
                <!-- email input -->
                <h5 class="text-center float-left">Enter your Temmates' (Employees') Email:</h5>
                <div class="input-group mb-3">
                    <input class="form-control float-left" type="text" id="Email" placeholder="name@example.com" aria-describedby="AddInviteUser">
                    <div class="input-group-append">
                        <button class="btn btn-primary" id="AddInviteUser" type="button">Add</button>
                    </div>
                    <!-- show the emails have entered -->
                    <script>
                        // keep track of row id
                        var rowID = 0;
                        // diable the refresh when enter with form
                        $(function () {
                            $("form").submit(function () { return false; });
                        });
                        // update in EmailTable
                        $("#AddInviteUser").on("update", function (event, email) {
                            $('#EmailTable tbody').append('<tr class="table-row text-center"><td id="' + rowID + '">' + email + '</td></tr><br />');
                            rowID += 1;
                        });
                        // for the textbox
                        $('#Email').on('keypress', function (event) {
                            if (event.keyCode == 13) {
                                $("#AddInviteUser").click();
                            }
                        });
                        // for the button
                        $("#AddInviteUser").click(function () {
                            $("#AddInviteUser").trigger("update", $('#Email').val());
                        });
                    </script>
                </div>
                <div class="col" style="height:450px">
                    <div class="table-wrapper-scroll-y my-custom-scrollbar">
                        <table class="table table-bordered table-hover" id="EmailTable">
                            <thead>
                                <tr>
                                    <th>Email List</th>
                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>

            <div class='col'>
                <div class="col text-center">
                    <button type="button" id='RemoveSelected' class="btn btn-primary" data-toggle="modal" data-target="#RemoveUserModal">Remove Selected User</button>
                    <button type="button" id='InviteSelected' class="btn btn-primary" data-toggle="modal" data-target="#InviteUserModal">Invite Selected User</button>
                </div>
                <!-- remove selected users -->
                <div class="modal fade" id="RemoveUserModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                    <div class="modal-dialog modal-dialog-centered" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <h5 class="modal-title">Are you sure to remove the selected users?</h5>
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span>
                                </button>
                            </div>
                            <br />
                            <div class="modal-footer">
                                <button type="button" class="btn btn-secondary" data-dismiss="modal">No</button>
                                <button type="button" class="btn btn-primary" data-dismiss="modal" id="RemoveButton">Yes</button>
                                <script>
                                    $("#RemoveButton").click(function () {
                                        var table = $('#EmailTable').DataTable();
                                        var rows = table
                                            .rows('.selected')
                                            .remove()
                                            .draw();
                                    });
                                </script>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- invite selected users -->
                <div class="modal fade" id="InviteUserModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                    <div class="modal-dialog modal-dialog-centered" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <h5 class="modal-title">Are you sure to remove the selected users?</h5>
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span>
                                </button>
                            </div>
                            <br />
                            <div class="modal-footer">
                                <button type="button" class="btn btn-secondary" data-dismiss="modal">No</button>
                                <button type="button" class="btn btn-primary" data-dismiss="modal" id="InviteButton">Invite</button>
                                <!-- TODO: invite selected users -->
                                <script>

                                </script>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
