using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrmDesignApi.Models.CRM
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Build { get; set; }
        public string Office { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        //[ForeignKey("ProfileCompany")]
        //public int ProfileCompanyId { get; set; }
        //[NotMapped]
        //public ProfileCompany ProfileCompany { get; set; }

    }
}
