using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Aplication.Interface
{
    internal interface IRepository<T> where T : class 
    {
      IEnumerable<T> GetAll();
      IEnumerable<T> Find(Func<T, Boolean> predicate);
    }
}
