using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrmDesignApi.Models.Design
{
    public class Combination
    {
        public Combination()
        {
            CombinationParameters = new List<CombinationParameter>();
            CombinationWares = new List<CombinationWare>();

        }
        public int Id { get; set; }

        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }

        public string Name { get; set; }
        public string Descr { get; set; }

        public List<CombinationParameter> CombinationParameters { get; set; }
        public List<CombinationWare> CombinationWares { get; set; }
    }
}
