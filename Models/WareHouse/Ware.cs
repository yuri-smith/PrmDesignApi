using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrmDesignApi.Models.CRM;
using PrmDesignApi.Models.Design;

namespace PrmDesignApi.Models.WareHouse
{
    public class Ware
    {
        public Ware()
        {
            Sellers = new List<WaresSeller>();
            AirbillRows = new List<AirbillRow>();
            Details = new List<Detail>();
            CombinationWares = new List<CombinationWare>();
        }

        public int Id { get; set; }
        public string Article { get; set; }
        public string Descr { get; set; }

        public List<WaresSeller> Sellers { get; set; }
        public List<AirbillRow> AirbillRows { get; set; }
        public List<Detail> Details { get; set; }
        public List<CombinationWare> CombinationWares { get; set; }
    }
}
