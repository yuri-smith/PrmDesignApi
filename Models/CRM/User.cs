﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrmDesignApi.Models.CRM
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public UserProfile UserProfile { get; set; }
    }
}
