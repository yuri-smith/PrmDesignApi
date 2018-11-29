using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrmDesignApi.Models.CRM
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public List<City> Cities { get; set; }
    }
}
