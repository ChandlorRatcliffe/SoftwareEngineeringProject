using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NimbleWeb.Models
{
    public class SearchQuery
    {
        [Required]
        [MaxLength(3)]
        public string Query { get; set; }
    }
}
