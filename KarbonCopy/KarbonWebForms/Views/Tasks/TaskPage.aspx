<%@ Page Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="TaskPage.aspx.cs" Inherits="KarbonWebForms.Views.Tasks.TaskPage" %>

<asp:Content runat="server" ContentPlaceHolderID="DashContent">
    <div class="container">
        <div class="row">
            <div class="col-md-4">
                <!-- This is the Note portion-->
                <div class="card">
                    <h5 class="card-header">Note
                    </h5>
                    <div class="card-body">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Dictum at tempor commodo ullamcorper a lacus vestibulum sed arcu. Vulputate dignissim suspendisse in est. Viverra maecenas accumsan lacus vel. Viverra mauris in aliquam sem. Arcu bibendum at varius vel pharetra vel turpis nunc eget. Habitasse platea dictumst quisque sagittis. Tellus mauris a diam maecenas. Posuere lorem ipsum dolor sit amet consectetur adipiscing elit duis. Odio eu feugiat pretium nibh ipsum consequat. In eu mi bibendum neque egestas congue quisque egestas diam. Urna id volutpat lacus laoreet non curabitur gravida arcu ac.
                    <!-- Button trigger modal / Start Modal pack -->
                        <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#example1ModalLong">
                            Edit Note
                        </button>

                        <!-- Modal for Note -->
                        <div class="modal fade" id="example1ModalLong" tabindex="-1" role="dialog" aria-labelledby="example1ModalLongTitle" aria-hidden="true">
                            <div class="modal-dialog" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h5 class="modal-title" id="example1ModalLongTitle">Edit Note</h5>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>
                                    <div class="modal-body">
                                        <!-- This is where the note place holder will go/ the ability to input changes-->
                                        <input type="text" class="form-control" placeholder="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Dictum at tempor commodo ullamcorper a lacus vestibulum sed arcu. Vulputate dignissim suspendisse in est. Viverra maecenas accumsan lacus vel. Viverra mauris in aliquam sem. Arcu bibendum at varius vel pharetra vel turpis nunc eget. Habitasse platea dictumst quisque sagittis. Tellus mauris a diam maecenas. Posuere lorem ipsum dolor sit amet consectetur adipiscing elit duis. Odio eu feugiat pretium nibh ipsum consequat. In eu mi bibendum neque egestas congue quisque egestas diam. Urna id volutpat lacus laoreet non curabitur gravida arcu ac." aria-label="Note" aria-describedby="button-addon2">
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
                </div>
            </div>
            <div class="col-md-5">
                <!-- This is the Description portion-->
                <div class="card">
                    <div class="card-body">
                        Description - Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                <!-- Button trigger modal / Start Modal pack -->
                        <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModalLong">
                            Edit Description
                        </button>

                        <!-- Modal for Description -->
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
                                        <input type="text" class="form-control" placeholder="Description - Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." aria-label="Desc" aria-describedby="button-addon2">
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
                </div>
                <!--End of Note-->
                <br />
                <!--Start of Buttons-->
                <div class="row align-items-start">
                    <div class="col">
                        <!--This button will take you to the team management page/view; I assume this to be Permission based, so I have disabled the button as a standard-->
                        <button type="button" class="btn btn-info" disabled>Team Management</button>
                    </div>
                    <div class="col">
                        <!--Intentionally left blank to save my sanity, had issue centering buttons-->
                    </div>
                    <div class="col">
                        <!--This should take the user to the create note page-->
                        <button type="button" class="btn btn-primary">New Note</button>
                    </div>
                </div>
                <br />
                <div class="row align-items-center">
                    <div class="col">
                        <button type="button" class="btn btn-success">Complete Task</button>
                    </div>
                    <div class="col">
                        <!--we dont need this button any longer with the use of modals
                    <button type="button" class="btn btn-warning">Edit Task</button>
                    -->
                    </div>
                    <div class="col">
                        <button type="button" class="btn btn-danger">Delete Task</button>
                    </div>
                </div>
                <!--End of Buttons-->
            </div>
        </div>
    </div>

</asp:Content>
