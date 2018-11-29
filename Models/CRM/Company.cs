using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrmDesignApi.Models.WareHouse;

namespace PrmDesignApi.Models.CRM
{
    public class Company
    {
        public Company()
        {
            Sellers = new List<CompanyRelation>();
            Shoppers = new List<CompanyRelation>();
            OrdersAsSeller = new List<Order>();
            OredersAsShopper = new List<Order>();
            AirbillsAsSeller = new List<Airbill>();
            AirbillsAsShopper = new List<Airbill>();
            Wares = new List<WaresSeller>();
            Users = new List<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string INN { get; set; }


        public CompanyProfile CompanyProfile { get; set; }

        public List<CompanyRelation> Sellers { get; set; }
        public List<CompanyRelation> Shoppers { get; set; }

        public List<Order> OrdersAsSeller { get; set; }
        public List<Order> OredersAsShopper { get; set; }

        public List<Airbill> AirbillsAsSeller { get; set; }
        public List<Airbill> AirbillsAsShopper { get; set; }


        public List<WaresSeller> Wares { get; set; }

        public List<User> Users { get; set; }
    }
}
