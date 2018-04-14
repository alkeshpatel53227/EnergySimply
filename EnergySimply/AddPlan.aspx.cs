using EnergySimplyLib.Entities;
using EnergySimplyLib.ServiceDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnergySimply
{
    public partial class AddPlan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.Page.Title = "Add Customer";
                divError.Visible = false;
                divSuccess.Visible = false;
                EnergyPlanDal pdal = new EnergyPlanDal();
                gvPlan.DataSource = pdal.GetAllPlans();
                gvPlan.DataBind();
            }
        }

        protected void btnAddPlan_Click(object sender, EventArgs e)
        {
            divError.Visible = false;
            divSuccess.Visible = false;
            if (Page.IsValid)
            {
                if (!string.IsNullOrEmpty(txtEnergyPlanName.Text) && !string.IsNullOrEmpty(txtFixedCost.Text) && !string.IsNullOrEmpty(txtVarCost.Text))
                {
                    EnergyPlanDal pdal = new EnergyPlanDal();
                    EnergyPlan ep = new EnergyPlan();
                    ep.CreateDate = DateTime.Now;
                    ep.EnergyPlanName = txtEnergyPlanName.Text;
                    ep.EnergyPlanFixedCost = Decimal.Parse(String.Format("{0:N2}", txtFixedCost.Text));
                    ep.EnergyPlanVarCost = Decimal.Parse(String.Format("{0:N2}", txtVarCost.Text));
                    var savedPlan = pdal.SaveEnergyPlan(ep);
                    divSuccess.Visible = true;
                    if (savedPlan != null && savedPlan.EnergyPlanId > 0)
                    {
                        divSuccess.Visible = true;
                    }
                    gvPlan.DataSource = pdal.GetAllPlans();
                    gvPlan.DataBind();
                    ClearForm();
                }
                else
                {
                    divError.Visible = true;
                }
            }else
            {
                divError.Visible = true;
            }
        }

        public void ClearForm()
        {
            txtEnergyPlanName.Text = "";
            txtFixedCost.Text = "";
            txtVarCost.Text = "";
        }
    }
}