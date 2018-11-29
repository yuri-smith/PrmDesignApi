using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrmDesignApi.Models.WareHouse
{
    public class Action
    {
        public int Id { get; set; }

        public int AirbillRowId { get; set; }
        public AirbillRow AirbillRow { get; set; }

        public int Debit { get; set; }  //Приходящее к-во
        public int Credit { get; set; } //Уходящее к-во
    }
}