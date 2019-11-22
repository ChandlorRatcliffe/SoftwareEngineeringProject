<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CashewWebForms.Login" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="container bg-light my-5" style="max-width: 500px;">
            <h2 class="text-center mb-2"><br />KARBON <b>Access</b><br /></h2>
            <div <%--asp-validation-summary="All"--%> class="text-danger"></div>
            <div class="form-group row">
                <div class="col-sm-1"></div>
                <div class="col-sm-10">
                    <%--<label asp-for="Username" class="col-sm-12 col-form-label"></label>--%>
                    <asp:Label runat="server" AssociatedControlID="EnterUsername" CssClass="col-sm-12 col-form-label">Username</asp:Label>
                    <%--<input asp-for="Username" class="form-control" placeholder="Username" />--%>
                    <asp:TextBox runat="server" ID="EnterUsername" CssClass="form-control" placeholder="Enter Username"></asp:TextBox>
                    <%--<a class="form-text text-muted text-right text-light" onclick="location.href='@Url.Action("RecoveryUsername", "Accounts")'">Forgot&nbsp;Username?</a>
                    <span asp-validation-for="Username" class="text-danger"></span>--%>
                    <asp:LinkButton runat="server" ID="RecoverUsername" CssClass="form-text text-muted text-right text-light" href="/Views/Accounts/RecoverUsername">Forgot&nbsp;Username?</asp:LinkButton>
                </div>
                <div class="col-sm-1"></div>
            </div>
            <div class="form-group row">
                <div class="col-sm-1"></div>
                <div class="col-sm-10">
                    <%--<label asp-for="Password" class="col-sm-12 col-form-label"></label>--%>
                    <asp:Label runat="server" ID="Password" AssociatedControlID="EnterPassword" CssClass="col-sm-12 col-form-label"></asp:Label>
                    <%--<input asp-for="Password" class="form-control" type="password" placeholder="Username" />--%>
                    <asp:TextBox runat="server" ID="EnterPassword" CssClass="form-control" placeholder="Enter Password"></asp:TextBox>
                    <%--<a class="form-text text-muted text-right text-light" onclick="location.href='@Url.Action("RecoveryPassword", "Accounts")'">Forgot&nbsp;Password?</a>
                    <span asp-validation-for="Password" class="text-danger"></span>--%>
                    <asp:LinkButton runat="server" ID="RecoverPassword" CssClass="form-text text-muted text-right text-light" href="/Views/Accounts/RecoverPassword">Forgot&nbsp;Password?</asp:LinkButton>
                </div>
                <div class="col-sm-1"></div>
            </div>
            <div class="form-group row text-center">
                <div class="col-sm-12 col-md-12 col-lg-12">
                    <%--<button type="submit" class="btn btn-primary mt-2 mx-2" style="width: 175px;">Sign&nbsp;In</button>--%>
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
            <button class="btn btn-primary text-light text-center mt-2 border mx-2" style="width: 175px;" onclick="location.href='/Views/Accounts/Create'">Create&nbsp;An&nbsp;Account</button>
        </div>
        <br />
        <br />
    </div>
</asp:Content>