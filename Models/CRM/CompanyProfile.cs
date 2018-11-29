using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrmDesignApi.Models.CRM
{
    public class CompanyProfile
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        //[ForeignKey("LegalAddress")]
        public int LegalAddressId { get; set; }
        public Address LegalAddress { get; set; }

        //[ForeignKey("ActualAddress")]
        public int? ActualAddressId { get; set; }
        public Address ActualAddress { get; set; }
    }
}
