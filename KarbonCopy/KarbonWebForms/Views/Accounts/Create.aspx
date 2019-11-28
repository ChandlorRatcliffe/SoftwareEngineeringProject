<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="KarbonWebForms.Views.Accounts.Create" Title="Create" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
<!-- Recreation of Create.cshtml -->
    <div class="container bg-light my-5" style="max-width: 500px;">
        <h2 class="text-center mb-2"><br />KARBON <b>Create</b><br /></h2>
        <%-- 
            <div asp-validation-summary="All" class="text-danger"></div> 
            <span class="text-danger"></span> 
        --%>
        <div class="form-group row">
            <div class="col-sm-1"></div>
            <div class="col-sm-5">
                <label class="col-sm-12 col-form-label">Firstname</label>
                <asp:TextBox ID="FirstName" CssClass="form-control" placeholder="Firstname" runat="server" />
            </div>
            <div class="col-sm-5">
                <label class="col-sm-12 col-form-label">Firstname</label>
                <asp:TextBox ID="LastName" CssClass="form-control" placeholder="Lastname" runat="server" />
            </div>
            <div class="col-sm-1"></div>
        </div>
        <div class="form-group row">
            <div class="col-sm-1"></div>
            <div class="col-sm-10">
                <label class="col-sm-12 col-form-label">Business Code</label>
                <asp:TextBox ID="Buscode" CssClass="form-control" placeholder="Business Code" runat="server" />
            </div>
            <div class="col-sm-1"></div>
        </div>
        <div class="form-group row">
            <div class="col-sm-1"></div>
            <div class="col-sm-10">
                <label class="col-sm-12 col-form-label">Email</label>
                <asp:TextBox ID="Email" TextMode="Email" CssClass="form-control" placeholder="Email" runat="server" />
            </div>
            <div class="col-sm-1"></div>
        </div>
        <div class="form-group row">
            <div class="col-sm-1"></div>
            <div class="col-sm-10">
                <label class="col-sm-12 col-form-label">Username</label>
                <asp:TextBox ID="Username" CssClass="form-control" placeholder="Username" runat="server" />
            </div>
            <div class="col-sm-1"></div>
        </div>
        <div class="form-group row">
            <div class="col-sm-1"></div>
            <div class="col-sm-10">
                <label class="col-sm-12 col-form-label">Password</label>
                <asp:TextBox ID="Password" TextMode="Password" CssClass="form-control" Text="Username" runat="server" />
            </div>
            <div class="col-sm-1"></div>
        </div>
        <div class="form-group row">
            <div class="col-sm-1"></div>
            <div class="col-sm-10">
                <label class="col-sm-12 col-form-label">Confirm Password</label>
                <asp:TextBox ID="ConfirmPassword" TextMode="Password" CssClass="form-control" Text="Confirm Password" runat="server" />
            </div>
            <div class="col-sm-1"></div>
        </div>
        <br />
        <div class="form-group row text-center">
            <div class="col-sm-12 col-md-12 col-lg-12">
                <button type="submit" class="btn btn-primary px-5" runat="server" onserverclick="CreateAccount">Submit</button>
            </div>
        </div>
        <div class="row">
            <div class="col order-first"></div>
            <div class="col text-center">Already have an account?<br /><a href="~/Views/Accounts/Login">Click here to login</a></div>
            <div class="col order-last"></div>
        </div>
        <br />
</div>
</asp:Content>