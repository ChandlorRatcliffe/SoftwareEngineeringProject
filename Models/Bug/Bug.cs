using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NimbleWeb.Models
{
    public class Bug
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
        public int User { get; set; }
    }
}
