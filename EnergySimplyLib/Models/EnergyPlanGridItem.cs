using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergySimplyLib.Models
{
    public class EnergyPlanGridItem
    {
        public int EnergyPlanId { get; set; }
        public string EnergyPlanName { get; set; }
        public decimal FixedCost { get; set; }
        public decimal varCost { get; set; }
    }
}
