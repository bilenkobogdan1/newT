using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Controllers;
using NotesPersistence.DTO;
using NotesPersistence.Logic;

namespace Enterprises.API.Controllers
{
    public class ProductController : BaseControl
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<ProductDTO> GetProducts()
        {
            return new LogicProduct().GetAllProduct();
        }
        [HttpGet]
        public ProductDTO GetProduct(string kmat)
        {
            return new LogicProduct().GetProduct(kmat);
        }
    }
}
