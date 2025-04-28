using NotesPersistence.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesPersistence.Interfaces.Product
{
    internal interface IProduct
    {
        public bool Add(ProductDTO product);
        public bool Update(string kmat, ProductDTO updateProduct);
        public bool Delete(string kmat);
    }
}
