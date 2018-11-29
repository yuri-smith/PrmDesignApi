using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrmDesignApi.Models.Design
{
    public class ProductTypeParameter
    {
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }

        public int ParameterId { get; set; }
        public Parameter Parameter { get; set; }

        public int DefaultValue { get; set; }
    }
}
