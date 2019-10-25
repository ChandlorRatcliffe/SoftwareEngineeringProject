using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NimbleWeb.Models
{
    public class Search
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Query { get; set; }
    }
}
