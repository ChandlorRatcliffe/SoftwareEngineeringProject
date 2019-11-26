<%@ Page Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="CreateTask.aspx.cs" Inherits="KarbonWebForms.Views.Tasks.CreateTask" %>

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
        <h3 class="text-center mb-2">Create New Task</h3>
        <!--asp-validation-summary="All"-->
        <div class="text-danger"></div>
        <!-- Task's Name-->
        <div class="row">
            <!--asp-for="TaskName"-->
            <input class="form-control col" id="TaskName" placeholder="Enter a Task's Name" />
            <small id="TaskNameHelpBlock" class="form-text text-muted">Task name must be less than or equal to 50 characters long, contain letters and numbers, and must not contain spaces, special characters, or emoji.
            </small>
        </div>
        <br />
        <!-- Task's Deadline-->
        <div class="row">
            <input id="Datepicker" class="form-control col" placeholder="Pick the Task's Deadline" style="width: 300px;" />
            <!--  asp-for="TaskDeadline" -->
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
        <!-- Task's Description-->
        <div class="row">
            <!-- asp-for="TaskDescription" -->
            <textarea class="col" id="TaskDescription" style="max-height: 300px; min-height: 100px;" placeholder="Task's Description (150 characters)"></textarea>
        </div>
        <br />
        <div class="row float-right">
            <p id="Counter"></p>
            <script type="text/javascript">
                $('#TaskDescription').keyup(function () {
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
            <h5>Assign a User</h5>
        </div>
        <h6>Choose his/her Permissions</h6>
        <!-- Alignment need to be corrected-->
        <!-- Permissions Picker-->
        <div class="col">
            <!-- 
                permissions input 
                 0: Create Notes
                 1: Edit Task
            -->
            <table class="table table-bordered table-hover" id="PermissionTable">
                <tbody>
                    <tr class="table-row text-center" data-id="0">
                        <td>Create Notes</td>
                    </tr>
                    <tr class="table-row text-center" data-id="1">
                        <td>Edit Task</td>
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
        <br />
        <!-- Teammates Picker-->
        <h6>Choose a User (you can only pick 1)</h6>
        <div class="container" id="TeammatesPicker">
            <input id="option1" type="checkbox" />This is checkbox<br />
            <input id="option2" type="checkbox" />This is checkbox<br />
            <input id="option3" type="checkbox" />This is checkbox<br />
            <input id="option4" type="checkbox" />This is checkbox<br />
            <input id="option5" type="checkbox" />This is checkbox<br />
            <input id="option6" type="checkbox" />This is checkbox<br />
            <!-- limit to 1 user per task -->
            <script>
                $('#TeammatesPicker input:checkbox').click(function () {
                    var $inputs = $('#TeammatesPicker input:checkbox');
                    // check if clicked box is currently checked
                    if ($(this).is(':checked')) {
                        //disable all but checked checkbox
                        $inputs.not(this).prop('disabled', true);
                    }
                    // if checkbox was unchecked
                    else {
                        // enable all checkboxes
                        $inputs.prop('disabled', false);
                    }
                })
            </script>
        </div>
        <br />
        <div class="row float-right">
            <button id="ConfirmInvite" type="button" class="btn btn-primary">Invite selected member</button>
        </div>
        <br />
        <br />
        <div class="row justify-content-center">
            <button id="CreateTask" type="button" class="btn btn-primary">Create Task</button>
        </div>
    </div>
</asp:Content>
