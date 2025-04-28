using Notes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprises.Persistence.DTO
{
    internal class PriceDTO
    {
        public decimal Cena { get; set; }
        public string? ProductKmat  { get; set; }
    }
}
