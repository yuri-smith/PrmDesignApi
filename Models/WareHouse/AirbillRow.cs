using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrmDesignApi.Models;

namespace PrmDesignApi.Models.WareHouse
{
    //Срока накладной
    public class AirbillRow
    {
        public int Id { get; set; }

        public int AirbillId { get; set; }
        public Airbill Airbill { get; set; }

        public int WareId { get; set; }
        public Ware Ware { get; set; }

        public int DimId { get; set; }
        public Dim Dim { get; set; }

        public int Count { get; set; }

        public double Price { get; set; }

        public List<Action> Astions { get; set; }
    }
}
