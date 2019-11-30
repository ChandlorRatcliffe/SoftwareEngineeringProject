<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ChangePasswordVerification.aspx.cs" Inherits="KarbonWebForms.Views.Accounts.ChangePasswordVerification" Async="true" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="container my-5" style="max-width: 700px;">
        <h2 class="text-center mb-2">Password Change Verification</h2>
        <asp:label runat="server" ID="ChangePasswordVerificationError" Text="" CssClass="text-danger" />
        <div class="form-group row">
            <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-sm-2 col-form-label text-center">Email</asp:Label>
            <div class="col-sm-10" style="padding:10px">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control" placeholder="Enter the account email"></asp:TextBox>
            </div>
            <asp:Label runat="server" AssociatedControlID="VerificationInput" CssClass="col-sm-2 col-form-label text-center">Password Change Code</asp:Label>
            <div class="col-sm-10" style="padding:10px">
                <asp:TextBox runat="server" ID="PasswordChangeCode" CssClass="form-control" placeholder="Enter Verification Code"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row text-center">
            <div class="col-sm-12 col-md-12 col-lg-12">
                <button runat="server" onserverclick="ChangePassword" type="submit" class="btn btn-primary px-5">Verify</button>
            </div>
        </div>
</div>

</asp:Content>

