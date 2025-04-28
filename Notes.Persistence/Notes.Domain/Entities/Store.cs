using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Notes.Domain.Entities
{
    public class Store
    {
        [Key]
        public int IdStore {  get; set; }
        public string? Name { get; set; }

    }
}
