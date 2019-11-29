<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Verification.aspx.cs" Inherits="KarbonWebForms.Views.Accounts.Verification" Title="Account Verification" Async="true" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="container my-5" style="max-width: 700px;">
        <h2 class="text-center mb-2">Account Verification</h2>
        <div class="form-group row">
            <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-sm-2 col-form-label text-center">Email</asp:Label>
            <div class="col-sm-10" style="padding:10px">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control" placeholder="Enter the account email"></asp:TextBox>
            </div>
            <asp:Label runat="server" AssociatedControlID="VerificationInput" CssClass="col-sm-2 col-form-label text-center">Verfication Code</asp:Label>
            <div class="col-sm-10" style="padding:10px">
                <asp:TextBox runat="server" ID="VerificationInput" CssClass="form-control" placeholder="Enter Verification Code"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row text-center">
            <div class="col-sm-12 col-md-12 col-lg-12">
                <button runat="server" onserverclick="VerifyAccount" type="submit" class="btn btn-primary px-5">Validate</button>
            </div>
        </div>
</div>

</asp:Content>
