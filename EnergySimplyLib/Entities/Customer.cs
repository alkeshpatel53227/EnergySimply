//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnergySimplyLib.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public Nullable<int> EnergyPlanId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public System.DateTime CreateDate { get; set; }
        public bool Active { get; set; }
    
        public virtual EnergyPlan EnergyPlan { get; set; }
    }
}
