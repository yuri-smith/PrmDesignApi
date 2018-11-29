using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrmDesignApi.Models.CRM
{
    public class UserProfile
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
    }
}
