using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Notes.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enterprises.Domain.Entities
{
    public class Price
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        public decimal Cena { get; set; }
        public string? ProductKmat { get; set; }

    }
}
