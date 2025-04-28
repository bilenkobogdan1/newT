using Enterprises.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesPersistence.DTO
{
    public class ProductDTO
    {
        private const string notFoundProductLink = "https://cdn-icons-png.flaticon.com/512/9951/9951478.png";
        public string? Kmat { get; set; }

        public string? Name { get; set; }
        public string? Articule { get; set; }
        public string? Description { get; set; }
        public string? Path;

        public string Link
        {
            get
            {
                if (!String.IsNullOrEmpty(Path))
                {
                    return Path;
                }
                else
                {
                    return notFoundProductLink;
                }
            }
            set
            {
                if (value.StartsWith(@"https://drive.google.com/file"))
                {
                    Path = value;
                }
                else
                {
                    Path = notFoundProductLink;
                }
            }
        }

         public decimal Price { get; set; }

    }
}
