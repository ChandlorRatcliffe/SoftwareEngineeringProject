<%@ Page Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="Projects.aspx.cs" Inherits="KarbonWebForms.Views.Projects.Projects" %>

<asp:Content runat="server" ContentPlaceHolderID="DashContent">
    <div>
        <h2>Projects List View - Alpha</h2>
    </div>

    <div class="container">
        <div class="row">
            <!-- asp:Repeater is a server control that enables repetition of displaying html elements. -->
            <asp:Repeater runat="server" ID="PrjCardRptr" OnPreRender="PrjCardRptr_PreRender">
                <ItemTemplate>
                    <div class="col-4" style="padding: 10px">
                        <div class="card text-center" style="width: 18rem;">
                            <div class="card-body">
                                <h5 class="card-title"><%# DataBinder.Eval(Container.DataItem, "ProjectId") %></h5>
                                <p class="card-text" style="overflow-y: auto; height: 250px; max-width: inherit; white-space: normal; display: block;">
                                    <%# DataBinder.Eval(Container.DataItem, "ProjectDescription") %>
                                </p>
                                <p class="card-text"><%# DataBinder.Eval(Container.DataItem, "ProjectDeadline") %></p>
                                <asp:LinkButton runat="server" OnClick="PrjCardRptr_Click"
                                    param='<%# DataBinder.Eval(Container.DataItem, "ProjectId") %>'
                                    CssClass="btn btn-primary">Go to Project view</asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
