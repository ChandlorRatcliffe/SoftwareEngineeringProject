﻿<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="HomeContent.aspx.cs" Inherits="KarbonWebForms.Views.Home.HomeContent" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div>
        <div class="jumbotron jumbotron-fluid" style="background: url(~/static/tempBanner1.jpg) fixed center no-repeat; background-size: cover; min-height: 557px;">
            <div class="row" style="min-height: 50vh; display: flex; align-items: center;">
                <div class="col-1 order-first"></div>
                <div class="shadow container rounded col-10" style="background-color: rgba(255, 255, 255,.3); align-content: center; height: 75%; width: 80%">
                    <div class="row">
                        <div class="col-1 order-first"></div>
                        <div class="col-10">
                            <h1 class="text-dark">Take the Karbon out of management</h1>
                            <br />
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                            <button class="btn btn-outline-light" type="button" onclick="location.href='~/Views/Accounts/Create'">Sign Up!</button><br />
                            <br />
                        </div>
                        <div class="col-1 order-last"></div>
                    </div>
                </div>
                <div class="col-1 order-last"></div>
            </div>
        </div>

        <div class="card-deck">
            <div class="card">
                <div class="card-body">
                    <h5 class="card-title">Card title</h5>
                    <p class="card-text">This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                    <p class="card-text"><small class="text-muted">Last updated 3 mins ago</small></p>
                </div>
            </div>
            <div class="card">
                <div class="card-body">
                    <h5 class="card-title">Card title</h5>
                    <p class="card-text">This card has supporting text below as a natural lead-in to additional content.</p>
                    <p class="card-text"><small class="text-muted">Last updated 3 mins ago</small></p>
                </div>
            </div>
            <div class="card">
                <div class="card-body">
                    <h5 class="card-title">Card title</h5>
                    <p class="card-text">This is a wider card with supporting text below as a natural lead-in to additional content. This card has even longer content than the first to show that equal height action.</p>
                    <p class="card-text"><small class="text-muted">Last updated 3 mins ago</small></p>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
