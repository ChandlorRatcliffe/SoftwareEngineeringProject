﻿<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="KarbonWebForms.Views.Accounts.Create" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
<!-- Recreation of Create.cshtml -->
    <div class="container bg-light my-5" style="max-width: 500px;">
        <h2 class="text-center mb-2"><br />KARBON <b>Create</b><br /></h2>
        <div <%--asp-validation-summary="All"--%> class="text-danger"></div>
        <div class="form-group row">
            <div class="col-sm-1"></div>
            <div class="col-sm-5">
                <label <%--asp-for="FirstName"--%> class="col-sm-12 col-form-label"></label>
                <input <%--asp-for="FirstName"--%> class="form-control" placeholder="First Name" />
                <span <%--asp-validation-for="FirstName"--%> class="text-danger"></span>
            </div>
            <div class="col-sm-5">
                <label <%--asp-for="LastName"--%> class="col-sm-12 col-form-label"></label>
                <input <%--asp-for="LastName"--%> class="form-control" placeholder="Last Name" />
                <span <%--asp-validation-for="LastName"--%> class="text-danger"></span>
            </div>
            <div class="col-sm-1"></div>
        </div>
        <div class="form-group row">
            <div class="col-sm-1"></div>
            <div class="col-sm-10">
                <label <%--asp-for="Email"--%> class="col-sm-12 col-form-label"></label>
                <input <%--asp-for="Email"--%> class="form-control" placeholder="Email" />
                <span <%--asp-validation-for="Email"--%> class="text-danger"></span>
            </div>
            <div class="col-sm-1"></div>
        </div>
        <div class="form-group row">
            <div class="col-sm-1"></div>
            <div class="col-sm-10">
                <label <%--asp-for="Username"--%> class="col-sm-12 col-form-label"></label>
                <input <%--asp-for="Username"--%> class="form-control" placeholder="Username" />
                <span <%--asp-validation-for="Username"--%> class="text-danger"></span>
            </div>
            <div class="col-sm-1"></div>
        </div>
        <div class="form-group row">
            <div class="col-sm-1"></div>
            <div class="col-sm-10">
                <label <%--asp-for="Password"--%> class="col-sm-12 col-form-label"></label>
                <input <%--asp-for="Password"--%> class="form-control" type="password" placeholder="Password" />
                <span <%--asp-validation-for="Password"--%> class="text-danger"></span>
            </div>
            <div class="col-sm-1"></div>
        </div>
        <div class="form-group row">
            <div class="col-sm-1"></div>
            <div class="col-sm-10">
                <label <%--asp-for="Password2"--%> class="col-sm-12 col-form-label"></label>
                <input <%--asp-for="Password2"--%> class="form-control" type="password" placeholder="Confirm Password" />
                <span <%--asp-validation-for="Password2"--%> class="text-danger"></span>
            </div>
            <div class="col-sm-1"></div>
        </div>
        <br />
        <div class="form-group row text-center">
            <div class="col-sm-12 col-md-12 col-lg-12">
                <button type="submit" class="btn btn-primary px-5">Submit</button>
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