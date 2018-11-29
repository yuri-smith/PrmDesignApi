using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrmDesignApi.Models.WareHouse;


namespace PrmDesignApi.Models.CRM
{
    public class Detail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int WareId { get; set; }
        public Ware Ware { get; set; }

    }
}
