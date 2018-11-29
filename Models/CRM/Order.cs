using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrmDesignApi.Models.CRM
{
    public class Order
    {
        public Order()
        {
            Products = new List<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public int SellerId { get; set; }
        public Company Seller { get; set; }
        public int ShopperId { get; set; }
        public Company Shopper { get; set; }

        public List<Product> Products { get; set; }
    }
}
