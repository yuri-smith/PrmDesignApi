using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrmDesignApi.Models.CRM;

namespace PrmDesignApi.Models.Design
{
    public class ProductParameterValue
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int ParameterId { get; set; }
        public Parameter Parameter { get; set; }

        public int Value { get; set; }
    }
}
