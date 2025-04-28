using NotesPersistence.DTO;
using NotesPersistence.Interfaces.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notes.Aplication.EF;
using Notes.Domain.Entities;
using AutoMapper;
using System.Numerics;
using Enterprises.Domain.Entities;
using Enterprises.Persistence.DTO;
namespace NotesPersistence.Logic
{
    public class LogicProduct : IProductInStore, IProductMove, IProduct
    {
        private ProductDTO NouneObject()
        {
            return new ProductDTO()
            {
                Kmat = "",
                Name = "NotFound",
                Articule = "",
                Description = "",
                Link = "",
                Price = 0m

            };
        }
        public  List<ProductDTO> GetAllProduct()
        {
            List<ProductDTO> products;
            using (AppDbContext db = new AppDbContext())
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDTO>()).CreateMapper();

               products = mapper.Map<List<Product>, List<ProductDTO>>(db.Products.ToList());
            }
            foreach(var product in products)
            {
                product.Price = GetPrise(product?.Kmat ?? "1").Cena;
            }
            return products;
        }


        public ProductDTO GetProduct(string kmat)
        {
            return GetAllProduct()?.Where(x => x.Kmat == kmat)?.First() ?? NouneObject();
        }

        private List<PriceDTO> GetPrise() 
        {
            using (AppDbContext db = new AppDbContext())
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Price, PriceDTO>()).CreateMapper();

                return mapper.Map<List<Price>, List<PriceDTO>>(db.Prices.ToList());
            }
        }
        private PriceDTO GetPrise(string kmat)
        {
            return GetPrise()?.Where(x => x.ProductKmat == kmat)?.First() ?? new PriceDTO();
        }

        public List<ProductDTO> GetAllProduct(int IdStore)
        {
            throw new NotImplementedException();
        }
        public List<ProductDTO> GetProduct(IEnumerable<string> kmats)
        {
            throw new NotImplementedException();
        }
        public void MoveProduct(StoreDTO oldStore, StoreDTO newStore, ProductDTO product)
        {
            throw new NotImplementedException();
        }
        public void MoveProduct(StoreDTO oldStore, StoreDTO newStore, IEnumerable<ProductDTO> products)
        {
            throw new NotImplementedException();
        }
        public void AddProduct(ProductDTO product, StoreDTO store)
        {
            throw new NotImplementedException();
        }
        public void AddProduct(ProductDTO product, IEnumerable<StoreDTO> stores)
        {
            throw new NotImplementedException();
        }
        public void RemoveProduct(ProductDTO product, StoreDTO store)
        {
            throw new NotImplementedException();
        }
        public void RemoveProduct(ProductDTO product, IEnumerable<StoreDTO> stores)
        {
            throw new NotImplementedException();
        }
        public bool Add(ProductDTO product)
        {
            throw new NotImplementedException();
        }
        public bool Update(string kmat, ProductDTO updateProduct)
        {
            throw new NotImplementedException();
        }
        public bool Delete(string kmat)
        {
            throw new NotImplementedException();
        }
    }
}
