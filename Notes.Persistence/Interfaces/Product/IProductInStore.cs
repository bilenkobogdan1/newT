using NotesPersistence.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesPersistence.Interfaces.Product
{
    public interface IProductInStore
    {
        public List<ProductDTO> GetAllProduct();
        public List<ProductDTO> GetAllProduct(int IdStore);
        public ProductDTO GetProduct(string kmat);
        public List<ProductDTO> GetProduct(IEnumerable<string> kmats);

    }

}
