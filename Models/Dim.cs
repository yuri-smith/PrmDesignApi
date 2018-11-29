using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrmDesignApi.Models.WareHouse;
using PrmDesignApi.Models.Design;

namespace PrmDesignApi.Models
{
    public class Dim
    {
        public Dim()
        {
            WaresSellers = new List<WaresSeller>();
            Parameters = new List<Parameter>();
            CombinationWares = new List<CombinationWare>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public List<WaresSeller> WaresSellers { get; set; }
        public List<Parameter> Parameters { get; set; }
        public List<CombinationWare> CombinationWares { get; set; }
    }
}
