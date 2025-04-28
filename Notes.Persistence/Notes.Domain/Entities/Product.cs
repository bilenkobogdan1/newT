using Enterprises.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Domain.Entities
{
    public class Product
    {
        [Key]
        public string? Kmat { get; set; }
        [Required]
        public string? Articule { get; set; }
        public string? Name { get; set;  }
        public string? Description {  get; set; }
        public string? Path { get; set; }

        public List<Price> Prices { get; set; } = new List<Price>();
    }
}
