using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrmDesignApi.Models.CRM;

namespace PrmDesignApi.Models.Design
{
    public class ProductType
    {
        public ProductType()
        {
            Products = new List<Product>();
            ProductTypeParameters = new List<ProductTypeParameter>();
            Combinations = new List<Combination>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public int? ParentId { get; set; }
        public ProductType Parent { get; set; }

        public List<ProductType> Childs { get; set; }

        public List<Product> Products { get; set; }
        public List<ProductTypeParameter> ProductTypeParameters { get; set; }
        public List<Combination> Combinations { get; set; }
    }
}
