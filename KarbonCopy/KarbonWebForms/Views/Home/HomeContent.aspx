<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="HomeContent.aspx.cs" Inherits="KarbonWebForms.Views.Home.HomeContent" Title="Management" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div>
        <div class="jumbotron jumbotron-fluid jumbomod shadow">
            <div class="row" style="min-height: 50vh; display: flex; align-items: center;">
                <div class="col-1 order-first"></div>
                <div class="shadow container rounded col-10" style="background-color: rgba(255, 255, 255,.5); align-content: center; height: 75%; width: 80%">
                    <div class="row">
                        <div class="col-1 order-first"></div>
                        <div class="col-10">
                            <br />
                            <h1 class="display-4 text-dark">Take the Karbon out of management</h1>
                            <br />
                            <p class="h2 lead">
                                Organize and manage all your projects from your computer, tablet or smartphone!
                                <br />
                                Karbon Management makes it simple and easy to manage and organize your large project across any device, anywhere.
                            </p>
                            <br />

                                                        <!-- Button trigger modal -->
                            <button type="button" class="btn btn-outline-dark" data-toggle="modal" data-target="#exampleModal">
                                Register Your Organization!
                            </button>

                            <!-- Modal -->
                            <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                              <div class="modal-dialog" role="document">
                                <div class="modal-content">
                                  <div class="modal-header">
                                    <h5 class="modal-title" id="exampleModalLabel">Email Us!</h5>
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                      <span aria-hidden="true">&times;</span>
                                    </button>
                                  </div>
                                  <div class="modal-body">
                                    Email us at solutions@karbonManagement
                                  </div>
                                  <div class="modal-footer">
                                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                                  </div>
                                </div>
                              </div>
                            </div>

                            <button class="btn btn-outline-dark" type="button" onclick="location.href='/Views/Accounts/Create'">Sign Up!</button><br />
                            <br />
                        </div>
                        <div class="col-1 order-last"></div>
                    </div>
                </div>
                <div class="col-1 order-last"></div>
            </div>
        </div>

        <div class="container-fluid border rounded"><br />
            <div class="row mx-1 lead border-bottom d-sm-block d-md-none" style="font-size:4vw">
                Karbon Management is built as a project management solution to help businesses walk away from the hassle of managing people and their given task and focus more on completing that given task.
                Take the karbon out of management and accomplish what you set out to do!<br /><br />
            </div>
            <div class="row mx-1 lead border-bottom d-none d-md-block" style="font-size:2vw">
                Karbon Management is built as a project management solution to help businesses walk away from the hassle of managing people and their given task and focus more on completing that given task.
                Take the karbon out of management and accomplish what you set out to do!<br /><br />
            </div><br /><br />
            <div class="row mx-1">
                <div class="col-sm-12 col-md-7 col-first lead">
                    <div class="display-4">Scalable</div>
                    Designed with teams big and small in mind. With our use of Azure App Serivce and Databases, we can scale at a moments notice to meet your requirement and still maintain fair pricing!
                </div>
                <div class="col-1">
                    <br />
                </div>
                <div class="col-sm-12 col-md-4 col-last">
                    <asp:Image runat="server" ImageUrl="~/Views/Home/server_room.jpg" Width="100%" />
                </div>
            </div><br /><br />
            <div class="row mx-1">
                <div class="col-md-4 col-sm-12 order-xl-first order-last">
                    <asp:Image runat="server" ImageUrl="~/Views/Home/security.jpg" Width="100%" />
                </div>
                <div class="col-1">
                    <br />
                </div>
                <div class="col-md-7 col-sm-12 order-xl-last order-first lead">
                    <div class="display-4">Secure</div>
                    Forced SSL, and user tracking via cookies, we can ensure to keep your presenese secure. We also utilize email verification on account creation to make sure you are who you are!
                </div>
            </div><br /><br />
            <div class="row mx-1">
                <div class="col-sm-12 col-md-7 col-first lead">
                    <div class="display-4">Latest and Greatest</div>
                    Built using the latest web components such as HTML5, CSS3 and JavaScript all the while we have a backend using ASP.NET where all of our logic employs C# and MySQL for ease of future upgrades.
                </div>
                <div class="col-1">
                    <br />
                </div>
                <div class="col-sm-12 col-md-4 col-last">
                    <asp:Image runat="server" ImageUrl="~/Views/Home/code.jpg" Width="100%" />
                </div>
            </div><br /><br />
        </div>

    </div>
</asp:Content>
