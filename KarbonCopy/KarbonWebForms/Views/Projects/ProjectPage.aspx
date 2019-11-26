<%@ Page Language="C#"  MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="ProjectPage.aspx.cs" Inherits="KarbonWebForms.Views.Projects.ProjectPage" %>
<asp:Content runat="server" ContentPlaceHolderID="DashContent">
<div>
    <h2>The View of an Individual Project-Alpha</h2>
</div>

<div class="container">
    <div class="row">
        <div class="col-md-3">
            <div class="card">
                <h4 class="card-header">
                    Deadline:
                </h4>
                <p id="Deadline" runat="server"></p>
            </div>
            <h5 style="padding:10px">Team Members</h5>
            <div class="overflow-auto">
                <!-- MemberRptr_PreRender method called, handles data population and binding -->
                <asp:Repeater runat="server" ID="MemberRptr" OnPreRender="MemberRptr_PreRender">
                <ItemTemplate>
                    <div class="flex-column-sm-4" runat="server">
                        <label> <%# DataBinder.Eval(Container.DataItem, "Username") %> </label>
                    </div>
                </ItemTemplate>
                </asp:Repeater>
            </div>
            <!--This button will take you to the team management page/view; I assume this to be Permission based, so I have disabled the button as a standard-->
            <button type="button" class="btn btn-info" onclick="location.href'~/Views/Projects/TeamManagement'">Team Management</button>
        </div>
        <div class="col-md-7">
            <!--This is the Description of the Project-->
            <div class="card">
                <!--The id Description is referenced in the code-behind to set its InnerText -->
                <div class="card-body w-100" style="max-height:300px; overflow-y:scroll;" id="Description" runat="server"></div>
                    
                    <!-- Button trigger modal / Start Modal pack -->
<button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModalLong">
  Edit Description
</button>

<!-- Modal -->
<div class="modal fade" id="exampleModalLong" tabindex="-1" role="dialog" aria-labelledby="exampleModalLongTitle" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLongTitle">Edit Description</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        <!-- This is where the description place holder will go/ the ability to input changes-->
        <input type="text" class="form-control" placeholder="Description - Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." aria-label="Description" aria-describedby="button-addon2">
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary">Save changes</button>
      </div>
    </div>
  </div>
</div>
<!--End Modal pack-->
                    
            </div>
            <br />
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
            <!--End of progress bar-->
            <br />
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            
        </div>
        <div class="col-md-5">
            <!--This is the Highest Priority Note-->
            <!-- Notes have been designated for tasks only for ease of database maintainability
            <div class="card">
                <div class="card-body">
                    Note Example - Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                </div>
            </div>
            -->
        </div>
    </div>
</div>

</asp:Content>
