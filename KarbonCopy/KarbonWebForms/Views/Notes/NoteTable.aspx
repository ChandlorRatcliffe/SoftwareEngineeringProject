<%@ Page Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="NoteTable.aspx.cs" Inherits="KarbonWebForms.Views.Notes.CreateNote" %>

<asp:Content runat="server" ContentPlaceHolderID="DashContent">
    <!-- Row Color-->
    <style>
        .Done {
            background-color: green;
            color: #FFF;
        }

        .Discard {
            background-color: red;
            color: #FFF;
        }
    </style>


    <div class="container my-5" style="text-align: center;">
        <h1 class="text-center">Note Mangement</h1>
        <!-- Update Date text -->
        <script>
            $(function () {
                $('#date').text("Updated on " + Date())
            });
        </script>
        <br />
        <br />
        <!-- Note table -->
        <table class="table table-bordered table-hover" id="NoteView">
            <thead>
                <tr>
                    <th class="text-center" scope="col">ID</th>
                    <th class="text-center" scope="col">Date Created</th>
                    <th class="text-center" scope="col">Creator</th>
                    <th class="text-center" scope="col">Title</th>
                    <th class="text-center" scope="col">Status</th>
                </tr>
            </thead>
            <tbody>
                <tr class="table-row text-center" data-id="1" data-target="#NoteModal" data-toggle="modal">
                    <td>123</td>
                    <td>Date</td>
                    <td>User1</td>
                    <td>Note1</td>
                    <td>Done</td>
                </tr>
                <tr class="table-row text-center" data-id="2" data-target="#NoteModal" data-toggle="modal">
                    <td>123</td>
                    <td>Date</td>
                    <td>User2</td>
                    <td>Note2</td>
                    <td>Pending</td>
                </tr>
                <tr class="table-row text-center" data-id="3" data-target="#NoteModal" data-toggle="modal">
                    <td>123</td>
                    <td>Date</td>
                    <td>User3</td>
                    <td>Note3</td>
                    <td>Discard</td>
                </tr>
            </tbody>
        </table>
        <br />
        <button class="btn btn-primary float-right" id="NewNoteBtn" type="submit">Create Note</button>
    </div>

    <!-- Note pop up -->
    <div class="modal fade" id="NoteModal" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="NoteTitle" />
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close" />
                </div>
                <div class="modal-body" id="NoteDescription">
                    <div class="form-group">
                        <label class="col-form-label">Description:</label>
                        <textarea class="form-control" disabled id="exampleFormControlTextarea1" rows="5"></textarea>
                    </div>
                    <div class="form-group float-right">
                        <div class="btn-group">
                            <button type="button" class="btn btn-primary dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                Change Status
                            </button>
                            <div class="dropdown-menu">
                                <a class="dropdown-item">Done</a>
                                <a class="dropdown-item">Discard</a>
                                <a class="dropdown-item">Pending</a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <button type="button" id="UpdateStatusBtn" class="btn btn-primary">Update Status</button>
                </div>
            </div>
        </div>
        <!-- Show note's detail -->
        <script>
            $('#NoteModal').on('show.bs.modal', function (event) {
                /* eq value:
                   0: ID
                   1: Date
                   2: Creator Name
                   3: Title
                   4: Status
                */
                var getTitile = $(event.relatedTarget).find('td').eq(3).text();
                var modal = $(this);
                modal.find('.modal-title').text(getTitile)
                // get note description by using it ID --TODO
                var getDescription = $(event.relatedTarget).find('td').eq(0).text();
                modal.find('#orderDetails').html($('<b> Information for LP: ' + getDescription + '</b>'))
            });
        </script>


        <!-- Set note's color base on its status
        red: discard
        green: done
        white: TODO
        -->
        <script>
            $(function () {
                $("tr").each(function () {
                    var col_val = $(this).find('td').eq(4).text();
                    if (col_val == "Done") {
                        $(this).addClass('Done');
                    }
                    else if (col_val == "Discard") {
                        $(this).addClass('Discard');
                    }
                });
            });
        </script>

        <!--
        Select note's status
        -->
        <script>
            $('.dropdown-menu a').on('click', function () {
                $('.dropdown-toggle').html($(this).html());
            })
        </script>

        <!--
        Update note's status TODO

        <script>
            $('$UpdateStatusBtn').on('click', func(){

            })
        </script>        -->

    </div>
</asp:Content>
