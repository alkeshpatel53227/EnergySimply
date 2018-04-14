using EnergySimplyLib.Entities;
using EnergySimplyLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergySimplyLib.ServiceDal
{
    public class EnergyPlanDal
    {
        /*
        * Get All Plans
        * 
        * */
        public List<EnergyPlanGridItem> GetAllPlans()
        {
            try
            {
                using (var ctx = new DB_121539_alkeshpatelfEntities())
                {
                    var plans =  (from p in ctx.EnergyPlans
                            orderby p.EnergyPlanId
                            select new EnergyPlanGridItem()
                            {
                                EnergyPlanId = p.EnergyPlanId,
                                EnergyPlanName = p.EnergyPlanName,
                                FixedCost = p.EnergyPlanFixedCost,
                                varCost = p.EnergyPlanVarCost
                            });
                    if (plans.Any())
                    {
                        return plans.ToList();
                    }
                    else
                    {
                        return new List<EnergyPlanGridItem>();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*
         * Get Customer By Id
         * 
         * */
        public EnergyPlan GetEnergyPlanById(int energyPlanId)
        {
            try
            {
                using (var ctx = new DB_121539_alkeshpatelfEntities())
                {
                    return ctx.EnergyPlans.Where(c => c.EnergyPlanId == energyPlanId).FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /*
         * Save EnergyPlan
         * 
         * */
        public EnergyPlan SaveEnergyPlan(EnergyPlan energyPlan)
        {
            try
            {
                using (var ctx = new DB_121539_alkeshpatelfEntities())
                {
                    energyPlan.CreateDate = DateTime.Now;
                    ctx.EnergyPlans.Add(energyPlan);
                    ctx.SaveChanges();
                    return energyPlan;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
