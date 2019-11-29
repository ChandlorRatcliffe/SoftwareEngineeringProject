<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="RecoverUsername.aspx.cs" Inherits="KarbonWebForms.Views.Accounts.RecoverUsername" Async="true" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="container my-5" style="max-width: 700px;">
        <h2 class="text-center mb-2">Username Recovery</h2>
        <asp:label runat="server" ID="RecoveryUsernameError" Text="" CssClass="text-danger" />
        <div class="form-group row">
            <asp:Label runat="server" AssociatedControlID="EmailEnter" CssClass="col-sm-2 col-form-label">Email</asp:Label>
            <div class="col-sm-10" style="padding:10px">
                <asp:TextBox runat="server" ID="EmailEnter" CssClass="form-control" placeholder="Enter email to recover username"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row text-center">
            <div class="col-sm-12 col-md-12 col-lg-12">
                <h6 class="pb-2" style="color: forestgreen">Your username will be sent to your email address.</h6>
                <button runat="server" onserverclick="RecoverMyUsername" type="submit" class="btn btn-primary px-5">Recover</button>
            </div>
        </div>
    </div>
</asp:Content>
