using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrmDesignApi.Models.Design
{
    public class Parameter
    {
        public Parameter()
        {
            ProductTypeParameters = new List<ProductTypeParameter>();
            ProductParameterValues = new List<ProductParameterValue>();
            CombinationParameters = new List<CombinationParameter>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }

        public int DimId { get; set; }
        public Dim Dim { get; set; }

        public List<ProductTypeParameter> ProductTypeParameters { get; set; }
        public List<ProductParameterValue> ProductParameterValues { get; set; }
        public List<CombinationParameter> CombinationParameters { get; set; }
    }
}
