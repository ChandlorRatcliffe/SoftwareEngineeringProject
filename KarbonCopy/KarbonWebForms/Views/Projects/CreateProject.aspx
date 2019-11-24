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
    <script type="text/javascript">
        $('#ProjectDescription').keyup(function () {
            var left = 150 - $(this).val().length;
            if (left < 0) {
                left = 0;
            }
            $('#Counter').text('Characters left: ' + left);
        });
        </script>
    <script>
        $('#datepicker').datepicker({
            uiLibrary: 'bootstrap4'
        });
        </script>
    <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
        <script src="https://unpkg.com/gijgo@1.9.13/js/gijgo.min.js" type="text/javascript"></script>
        <link href="https://unpkg.com/gijgo@1.9.13/css/gijgo.min.css" rel="stylesheet" type="text/css" />

<div class="container my-5" style="max-width: 700px;">
    <h3 class="text-center mb-2">Create New Project</h3>
    <!--<div asp-validation-summary="All" class="text-danger"></div>-->
    <!-- Project's Name-->
    <div class="row">
        <!-- asp-for="ProjectName" -->
        <input  class="form-control col" placeholder="Enter a Project's Name" />
        <small id="ProjectNameHelpBlock" class="form-text text-muted">
            Project name must be less than or equal to 50 characters long, contain letters and numbers, and must not contain spaces, special characters, or emoji.
        </small>
    </div>
    <br />
    <!-- Project's Deadline-->
    <div class="row">
        <input id="datepicker" class="form-control col" placeholder="Pick the Project's Deadline" style="width:300px" />
        <!-- asp-for="ProjectDeadline" -->
    </div>
    <br />
    <!-- Project's Description-->
    <div class="row">
        <!-- asp-for="ProjectDescription" -->
        <textarea class="col" id="ProjectDescription" style="max-height:300px;min-height:100px;"  placeholder="Project's Description (150 characters)"></textarea>
    </div>
    <br />
    <div class="row float-right">
        <p id="Counter"></p>
    </div>
    <br />
    <div class="row">
        <h5>Assemble your Team</h5>
    </div>
    <h6>Choose your Teammates Permissions</h6>
    <!-- Alignment need to be corrected-->
    <!-- Permissions Picker-->
    <div class="container" id="PermissionsPicker">
        <div class="row">
            <input class="col-sm-2" type="checkbox" />Create Project<br />
            <input class="col-sm-2" type="checkbox" />Delete Project<br />
            <input class="col-sm-2" type="checkbox" />Create Notes<br />
        </div>
        <div class="row">
            <input class="col-sm-2" type="checkbox" />Invite Users<br />
            <input class="col-sm-2" type="checkbox" />Remove Users<br />
            <input class="col-sm-2" type="checkbox" />Edit Project<br />
        </div>
        <div class="row">
            <input class="col-sm-2" type="checkbox" />Edit Task<br />
            <input class="col-sm-2" type="checkbox" />Assign To Project <br />
            <input class="col-sm-2" type="checkbox" />Assign to Task <br />
        </div>
    </div>
    <br />
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