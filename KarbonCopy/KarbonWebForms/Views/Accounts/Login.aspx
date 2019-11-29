<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="KarbonWebForms.Views.Accounts.Login" Title="Login" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="container bg-light my-5" style="max-width: 500px;">
            <h2 class="text-center mb-2"><br />KARBON <b>Access</b><br /></h2>
            <asp:label runat="server" ID="LoginError" Text="" CssClass="text-danger" />
            <asp:label runat="server" ID="LoginSuccess" Text="" CssClass="text-success" />
            <div class="form-group row">
                <div class="col-sm-1"></div>
                <div class="col-sm-10">
                    <asp:Label runat="server" AssociatedControlID="EnterUsername" CssClass="col-sm-12 col-form-label">Username</asp:Label>
                    <asp:TextBox runat="server" ID="EnterUsername" CssClass="form-control" placeholder="Enter Username"></asp:TextBox>
                    <asp:LinkButton runat="server" ID="RecoverUsername" CssClass="form-text text-muted text-right text-light" href="/Views/Accounts/RecoverUsername">Forgot&nbsp;Username?</asp:LinkButton>
                </div>
                <div class="col-sm-1"></div>
            </div>
            <div class="form-group row">
                <div class="col-sm-1"></div>
                <div class="col-sm-10">
                    <asp:Label runat="server" ID="Password" AssociatedControlID="EnterPassword" CssClass="col-sm-12 col-form-label"></asp:Label>
                    <asp:TextBox runat="server" ID="EnterPassword" TextMode="Password" CssClass="form-control" placeholder="Enter Password"></asp:TextBox>
                    <asp:LinkButton runat="server" ID="RecoverPassword" CssClass="form-text text-muted text-right text-light" href="/Views/Accounts/RecoverPassword">Forgot&nbsp;Password?</asp:LinkButton>
                </div>
                <div class="col-sm-1"></div>
            </div>
            <div class="form-group row text-center">
                <div class="col-sm-12 col-md-12 col-lg-12">
                    <asp:Button runat="server" ID="SignIn" CssClass="btn btn-primary mt-2 mx-2" style="width: 175px" Text="Sign In" OnCommand="SignIn_Command" />
                </div>
            </div><br />
        <hr style="border-color: gray;" />
            <div class="text-center">
                <a runat="server" href="~/Views/Projects/Projects.aspx"><b>To Dashboard</b></a>
            </div>
        <hr style="border-color: gray;" />

        <!-- Authentication Navigation -->
        <h2 class="text-center mb-2"><br /><b>New</b> Karbon?</h2>
        <div class="mt-3 text-center">
            <a runat="server" class="btn btn-primary text-light text-center mt-2 border mx-2" style="width: 175px;" href="~/Views/Accounts/Create.aspx">Create&nbsp;An&nbsp;Account</a>
        </div>

        <br />
        <br />
    </div>
</asp:Content>