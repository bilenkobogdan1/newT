using NotesPersistence.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesPersistence.Interfaces.Product
{
    public interface IProductMove
    {
        public void MoveProduct(StoreDTO oldStore, StoreDTO newStore,ProductDTO product);
        public void MoveProduct(StoreDTO oldStore, StoreDTO newStore, IEnumerable<ProductDTO> products);
        public void AddProduct(ProductDTO product, StoreDTO store);
        public void AddProduct(ProductDTO product, IEnumerable<StoreDTO> stores);
        public void RemoveProduct(ProductDTO product, StoreDTO store);
        public void RemoveProduct(ProductDTO product, IEnumerable<StoreDTO> stores);

    }
}
