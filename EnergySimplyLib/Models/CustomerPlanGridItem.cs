using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergySimplyLib.Models
{
    public class CustomerPlanGridItem : CustomerGridItem
    {

        public string EnergyPlanName { get; set; }
        public decimal FixedCost { get; set; }
        public decimal varCost { get; set; }
    }
}
