using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrmDesignApi.Models.Design
{
    public class CombinationParameter
    {
        public int CombinationId { get; set; }
        public Combination Combination { get; set; }

        public int ParameterId { get; set; }
        public Parameter Parameter { get; set; }

        public int MinValue { get; set; }
        public int MaxValue { get; set; }
    }
}
