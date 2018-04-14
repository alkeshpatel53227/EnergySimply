using EnergySimplyLib.ServiceDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnergySimply
{
    public partial class ListCustomersAndPlans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CustomerDal dal = new CustomerDal();
                gvCustomerEngeryPlan.DataSource = dal.GetAllCustomersWithPlanInfo();
                gvCustomerEngeryPlan.DataBind();
            }
        }
    }
}