<%@ Page Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="Projects.aspx.cs" Inherits="KarbonWebForms.Views.Projects.Projects" %>

<asp:Content runat="server" ContentPlaceHolderID="DashContent">
    <div>
        <h2>The Is the Projects View-Alpha</h2>
    </div>

    <div class="container">
        <div class="row">
            <script>
                document.addEventListener('DOMContentLoaded', function () {
                    var calendarEl = document.getElementById('calendar');

                    var calendar = new FullCalendar.Calendar(calendarEl, {
                        plugins: ['dayGrid, dayMonthGrid, list'],
                        header: {
                            left: 'title',
                            center: 'agendaDay,agendaWeek,month',
                            right: 'prev,next today'
                        },
                        editable: true,
                        firstDay: 0, //  1(Monday) this can be changed to 0(Sunday) for the USA system
                        selectable: true,
                        defaultView: 'month',
                        axisFormat: 'h:mm',
                        columnFormat: {
                            month: 'ddd', // Mon
                            week: 'ddd d', // Mon 7
                            day: 'dddd M/d', // Monday 9/7
                            agendaDay: 'dddd d'
                        },
                        titleFormat: {
                            month: 'MMMM yyyy', // September 2009
                            week: "MMMM yyyy", // September 2009
                            day: 'MMMM yyyy' // Tuesday, Sep 8, 2009
                        },
                        allDaySlot: false,
                        selectHelper: true,
                        select: function (start, end, allDay) {
                            var title = prompt('Event Title:');
                            if (title) {
                                calendar.fullCalendar('renderEvent', {
                                    title: title,
                                    start: start,
                                    end: end,
                                    allDay: allDay
                                },
                                    true // make the event "stick"
                                );
                            }
                            calendar.fullCalendar('unselect');
                        },
                        droppable: true, // this allows things to be dropped onto the calendar !!!
                        drop: function (date, allDay) { // this function is called when something is dropped
                            // retrieve the dropped element's stored Event Object
                            var originalEventObject = $(this).data('eventObject');
                            // we need to copy it, so that multiple events don't have a reference to the same object
                            var copiedEventObject = $.extend({}, originalEventObject);
                            // assign it the date that was reported
                            copiedEventObject.start = date;
                            copiedEventObject.allDay = allDay;
                            // render the event on the calendar
                            // the last `true` argument determines if the event "sticks" (http://arshaw.com/fullcalendar/docs/event_rendering/renderEvent/)
                            $('#calendar').fullCalendar('renderEvent', copiedEventObject, true);
                            // is the "remove after drop" checkbox checked?
                            if ($('#drop-remove').is(':checked')) {
                                // if so, remove the element from the "Draggable Events" list
                                $(this).remove();
                            }
                        },
                        events: [{
                            title: 'All Day Event',
                            start: new Date(y, m, 1)
                        },
                        {
                            id: 999,
                            title: 'Repeating Event',
                            start: new Date(y, m, d - 3, 16, 0),
                            allDay: false,
                            className: 'info'
                        },
                        {
                            id: 999,
                            title: 'Repeating Event',
                            start: new Date(y, m, d + 4, 16, 0),
                            allDay: false,
                            className: 'info'
                        },
                        {
                            title: 'Meeting',
                            start: new Date(y, m, d, 10, 30),
                            allDay: false,
                            className: 'important'
                        },
                        {
                            title: 'Lunch',
                            start: new Date(y, m, d, 12, 0),
                            end: new Date(y, m, d, 14, 0),
                            allDay: false,
                            className: 'important'
                        },
                        {
                            title: 'Birthday Party',
                            start: new Date(y, m, d + 1, 19, 0),
                            end: new Date(y, m, d + 1, 22, 30),
                            allDay: false,
                        },
                        {
                            title: 'Click for Google',
                            start: new Date(y, m, 28),
                            end: new Date(y, m, 29),
                            url: 'https://ccp.cloudaccess.net/aff.php?aff=5188',
                            className: 'success'
                        }
                        ],
                    });
                    calendar.render();
                });
        </script>
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
