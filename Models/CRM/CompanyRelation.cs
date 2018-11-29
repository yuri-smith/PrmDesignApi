using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrmDesignApi.Models.CRM
{
    public class CompanyRelation
    {
        public int SellerId { get; set; }
        public Company Seller { get; set; }
        public int ShopperId { get; set; }
        public Company Shopper { get; set; }

        public string Contract { get; set; }
        public DateTime DateContract { get; set; }
    }
}
