using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ShareSphere.Models.Enums;

namespace ShareSphere.Models
{
    public abstract class InvestmentPosition
    {
        public decimal Price { get; set; }
        public PositionType PositionType {get;set;}
        public Address Address { get; set; }

    }
}
