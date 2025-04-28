using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Domain.Entities
{
        public class HistoryMstock
        {
            [Key]
             public Guid idHitory{ get; set; }
             public Store? store { get; set; }
             public Product? product { get; set; }    
             public DateTime? Date_d { get; set; }
             public int action {  get; set; }
        }
        enum ActionHistory
        {
        Add =0,
        Remove=1,
        }
}
