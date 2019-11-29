<%@ Page Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="KarbonWebForms.Views.Accounts.Settings" %>

<asp:Content runat="server" ContentPlaceHolderID="DashContent">
    <div class="row">
    <div class="col order-first col-xl-4 col-lg-3 col-md-2 col-sm-1"></div>
    <div class="Settings-Page col-xl-4 col-lg-6 col-md-8 col-sm-10" style="justify-content:center">
            <article class="Title-info mb-5">
                <h1>User Settings</h1>
            </article>
            <!-- Main Settings -->
            <!-- Change Username Section-->
            <div class="col-1 font-weight-bold">
                Username
            </div>
            <div class="input-group mb-4">
                <br />
                <asp:TextBox runat="server" ID="changeUser" class="form-control" Text="New Username" aria-label="New Username" aria-describedby="button-addon1"></asp:TextBox>
                <div class="input-group-append">
                    <button runat="server" class="btn btn-dark" type="button" id="button-addon1" onclick="changeUsername">Submit</button>
                </div>
            </div>
            <br />
            <!-- Change Email Section-->
            <div class="col-1 font-weight-bold">
                Email
            </div>
            <div class="input-group mb-4">
                <asp:TextBox ID="changeEmail" runat="server" class="form-control" Text="New Email" aria-label="New Email" aria-describedby="button-addon2"></asp:TextBox>
                <div class="input-group-append">
                    <button runat="server" class="btn btn-dark" type="button" id="button-addon2" onclick="changeEmail">Submit</button>
                </div>
            </div>
            <br />
            <!-- Change Password Section -->
            <div class="col-1 font-weight-bold">
                Password
            </div>
            <div class="input-group mb-4">
                <asp:TextBox ID="changePassword" runat="server" class="form-control" Text="New Password" aria-label="New Password" aria-describedby="button-addon3"></asp:TextBox>
            </div>
            <div class="input-group mb-4">
                <asp:TextBox ID="confirmPassword" class="form-control" Text="Confirm New Password" aria-label="Confirm New Password" aria-describedby="button-addon2"></asp:TextBox>
                <div class="input-group-append">
                    <button runat="server" class="btn btn-warning" type="button" id="button-addon3" onclick="changePassword">Submit</button>
                </div>
            </div>
            <!-- Change Theme Section-->
            <div class="col-1 font-weight-bold">
                Themes
            </div>
            <asp:button runat="server" ID="light" type="button" class="btn btn-light" Text="Light Mode" OnCommand="light_Click" />
            <asp:button runat="server" ID="dark" type="button" class="btn btn-dark" Text="Dark Mode" OnCommand="dark_Click" />
    </div>
    <div class="col order-last col-xl-4 col-lg-3 col-md-2 col-sm-1"></div>
    </div>
</asp:Content>
