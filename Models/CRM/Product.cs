using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrmDesignApi.Models.Design;

namespace PrmDesignApi.Models.CRM
{
    //Изделие в заказе
    public class Product
    {
        public Product()
        {
            Details = new List<Detail>();
            ProductParameterValues = new List<ProductParameterValue>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }

        public List<Detail> Details { get; set; }
        public List<ProductParameterValue> ProductParameterValues { get; set; }
    }
}
