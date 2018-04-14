using EnergySimplyLib.Entities;
using EnergySimplyLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergySimplyLib.ServiceDal
{
    public class CustomerDal
    {

        /*
         * Get All Customers
         * 
         * */
        public List<CustomerGridItem> GetAllCustomers()
        {
            try
            {
                using (var ctx = new DB_121539_alkeshpatelfEntities())
                {
                    var customers = (from c in ctx.Customers
                            orderby c.CustomerName
                            select new CustomerGridItem()
                            {
                                CustomerId = c.CustomerId,
                                CustomerName = c.CustomerName,
                                CustomerPlanId = c.EnergyPlanId,
                                Email = c.CustomerEmail
                            });
                    if (customers.Any())
                    {
                        return customers.ToList();
                    }else
                    {
                        return new List<CustomerGridItem>();
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
        public Customer GetCustomerById(int customerId)
        {
            try
            {
                using (var ctx = new DB_121539_alkeshpatelfEntities())
                {
                    return ctx.Customers.Where(c => c.CustomerId == customerId).FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /*
         * Save Customer
         * 
         * */
        public Customer SaveCustomer(Customer customer)
        {
            try
            {
                using (var ctx = new DB_121539_alkeshpatelfEntities())
                {
                    customer.CreateDate = DateTime.Now;
                    ctx.Customers.Add(customer);
                    ctx.SaveChanges();
                    return customer;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*
        * Save Customer with Plan Info
        * 
        * */
        public List<CustomerPlanGridItem> GetAllCustomersWithPlanInfo()
        {
            try
            {
                using (var ctx = new DB_121539_alkeshpatelfEntities())
                {
                    var customers= (from c in ctx.Customers
                            join p in ctx.EnergyPlans on c.EnergyPlanId equals p.EnergyPlanId
                            orderby c.CustomerName
                            select new CustomerPlanGridItem()
                            {
                                CustomerId = c.CustomerId,
                                CustomerName = c.CustomerName,
                                CustomerPlanId = c.EnergyPlanId,
                                Email = c.CustomerEmail,
                                EnergyPlanName = p.EnergyPlanName,
                                FixedCost = p.EnergyPlanFixedCost,
                                varCost = p.EnergyPlanVarCost
                            });
                    if (customers.Any())
                    {
                        return customers.ToList();
                    }
                    else
                    {
                        return new List<CustomerPlanGridItem>();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
