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
                <asp:TextBox runat="server" ID="changeUser" CssClass="form-control" Text="New Username"></asp:TextBox>
                <div class="input-group-append">
                    <asp:button runat="server" class="btn btn-dark" Text="Submit" OnCommand="changeUsername_Click"></asp:button>
                </div>
            </div>
            <br />
            <!-- Change Email Section-->
            <div class="col-1 font-weight-bold">
                Email
            </div>
            <div class="input-group mb-4">
                <asp:TextBox runat="server" ID="changeEmail" CssClass="form-control" Text="New Email"></asp:TextBox>
                <div class="input-group-append">
                    <asp:button runat="server" class="btn btn-dark" Text="Submit" OnCommand="changeEmail_Click"></asp:button>
                </div>
            </div>
            <br />
            <!-- Change Password Section -->
            <div class="col-1 font-weight-bold">
                Password
            </div>
            <div class="input-group mb-4">
                <asp:TextBox runat="server" ID="changePassword" CssClass="form-control" Text="New Password"></asp:TextBox>
            </div>
            <div class="input-group mb-4">
                <asp:TextBox runat="server" ID="confirmPassword" CssClass="form-control" Text="Confirm New Password" ></asp:TextBox>
                <div class="input-group-append">
                    <asp:button runat="server" class="btn btn-warning" Text="Submit" OnCommand="changePassword_Click"></asp:button>
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
