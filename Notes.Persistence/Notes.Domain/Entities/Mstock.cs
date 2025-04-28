using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Domain.Entities
{
    public class Mstock
    {
        [Key]
        public Guid Id { get; set; }    
        public Product Product { get; set; } =null!;
        public Store Store { get; set; } = null!;
        public int Quentity {  get; set; }

    }
}
