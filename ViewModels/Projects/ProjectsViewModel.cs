using CashewWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace CashewWeb.ViewModels
{
    /// <summary>
    /// Data Dependencies for Projects Index View, Creator: Nicholas Jones
    /// </summary>
    public class ProjectsViewModel
    {
        public Projects Projects { get; set; }
        public string PageTitle { get; set; }

        public string Date { get; set; }

        public bool BusinessHours { get; set; }

        public bool NavLinks { get; set; }

        public List<CalendarEvent> CalendarEvents { get; set; }


    }

    public class CalendarEvent
    {
        public CalendarEvent(string title, string deadline)
        {
            Title = title;
            Start = deadline;
            //Description = description;
        }

        public string Title { get; set; }

        public string Start { get; set; }

        //public string Description { get; set; }
    }

    public static class JavaScriptConvert
    {
        public static IHtmlString SerializeObject(object value)
        {
            using (var stringWriter = new StringWriter())
            using (var jsonWriter = new JsonTextWriter(stringWriter))
            {
                var serializer = new JsonSerializer
                {
                    // Let's use camelCasing as is common practice in JavaScript
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                };

                // We don't want quotes around object names
                jsonWriter.QuoteName = false;
                serializer.Serialize(jsonWriter, value);

                return new HtmlString(stringWriter.ToString());
            }
        }
    }


}
