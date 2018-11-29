using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrmDesignApi.Models;
using PrmDesignApi.Models.WareHouse;

namespace PrmDesignApi.Models.Design
{
    public class CombinationWare
    {
        public int Id { get; set; }

        public int CombinationId { get; set; }
        public Combination Combination { get; set; }

        public int WareId { get; set; }
        public Ware Ware { get; set; }

        public int DimId { get; set; }
        public Dim Dim { get; set; }

        public string Count { get; set; }   //Возможна формула
    }
}
