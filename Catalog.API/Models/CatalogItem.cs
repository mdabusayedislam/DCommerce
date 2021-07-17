using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Models
{
    public class CatalogItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Decsription { get; set; }
        public decimal Price { get; set; }
        public string AvailableStock { get; set; }
        public string RestockThreshold { get; set; }
    }
}
