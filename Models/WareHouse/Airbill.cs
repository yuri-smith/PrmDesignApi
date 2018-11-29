using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrmDesignApi.Models.CRM;

namespace PrmDesignApi.Models.WareHouse
{
    //Накладная
    public class Airbill
    {
        public int Id { get; set; }

        public int SellerId { get; set; }
        public Company Seller { get; set; }
        public int ShopperId { get; set; }
        public Company Shopper { get; set; }

        public string Reason { get; set; }  //основание, обоснование

        public List<AirbillRow> AirbillRows { get; set; }

        public DateTime? DateOut { get; set; }   //Дата отправки
        public DateTime? DateIn { get; set; }    //Дата получения

    }
}
