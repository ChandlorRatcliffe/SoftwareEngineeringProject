<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="KarbonWebForms.Views.Accounts.ChangePassword" Async="true" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="container my-5" style="max-width: 700px;">
        <h2 class="text-center mb-2">Change Password</h2>
        <asp:label runat="server" ID="ChangePasswordError" Text="" CssClass="text-danger" />
        <asp:Label runat="server" ID="AccountEmail" Text="" />
        <div class="form-group row">
            <asp:Label runat="server" AssociatedControlID="EnterPassword" CssClass="col-sm-2 col-form-label">Password</asp:Label>
            <div class="col-sm-10" style="padding:10px">
                <asp:TextBox runat="server" ID="EnterPassword" CssClass="form-control" placeholder="Enter your new password"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label runat="server" AssociatedControlID="EnterPasswordConfirm" CssClass="col-sm-2 col-form-label">Password</asp:Label>
            <div class="col-sm-10" style="padding:10px">
                <asp:TextBox runat="server" ID="EnterPasswordConfirm" CssClass="form-control" placeholder="Confirm new password"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row text-center">
            <div class="col-sm-12 col-md-12 col-lg-12">
                <button runat="server" onserverclick="ChangeMyPassword" type="submit" class="btn btn-primary px-5">Change Password</button>
            </div>
        </div>
    </div>
</asp:Content>

