using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrmDesignApi.Models;
using PrmDesignApi.Models.CRM;

namespace PrmDesignApi.Models.WareHouse
{
    //Товары-Поставщики
    public class WaresSeller
    {
        public int WareId { get; set; }
        public Ware Ware { get; set; }

        public int SellerId { get; set; }
        public Company Seller { get; set; }

        public int? DimId { get; set; }
        public Dim Dim { get; set; }
        public double? Cost { get; set; }
    }
}
