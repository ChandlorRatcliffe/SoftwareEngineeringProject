<%@ Page Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="TasksList.aspx.cs" Inherits="KarbonWebForms.Views.Tasks.Index" %>

<asp:Content runat="server" ContentPlaceHolderID="DashContent">

    <div>
        <h2>The Tasks List Page-Alpha</h2>
    </div>

    <div class="container">
        <div class="row">
            <asp:Repeater runat="server" ID="TaskCardRptr" OnPreRender="TaskCardRptr_PreRender">
                <ItemTemplate>
                    <div class="col-md-3" style="padding: 10px">
                        <div class="card text-center" style="width: 18rem;">
                            <div class="card-body">
                                <h5 class="card-title"><%# DataBinder.Eval(Container.DataItem, "TaskId") %></h5>
                                <p class="card-text" style="overflow-y: auto; height: 250px; max-width: inherit; white-space: normal; display: block;">
                                    <%# DataBinder.Eval(Container.DataItem, "TaskDescription") %>
                                </p>
                                <p class="card-text"><%# DataBinder.Eval(Container.DataItem, "TaskDeadline") %></p>
                                <asp:LinkButton runat="server" OnClick="TaskCardRptr_Click"
                                    param='<%# DataBinder.Eval(Container.DataItem, "TaskId") %>'
                                    CssClass="btn btn-primary">Go to Task view</asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

</asp:Content>
