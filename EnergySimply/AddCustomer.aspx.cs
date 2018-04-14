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
    public partial class AddCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.Page.Title = "Add Customer";
                divError.Visible = false;
                divSuccess.Visible = false;
                CustomerDal dal = new CustomerDal();
                EnergyPlanDal pdal = new EnergyPlanDal();
                ddlEnergyPlans.DataSource = pdal.GetAllPlans();
                ddlEnergyPlans.DataBind();
                gvCustomers.DataSource = dal.GetAllCustomers();
                gvCustomers.DataBind();
            }
        }

        protected void btnAddCustomer_Click(object sender, EventArgs e)
        {
            divError.Visible = false;
            divSuccess.Visible = false;
            if (Page.IsValid)
            {
                if (!string.IsNullOrEmpty(txtCustomerName.Text) && !string.IsNullOrEmpty(txtCustomerEmail.Text) && !string.IsNullOrEmpty(ddlEnergyPlans.SelectedValue))
                {
                    CustomerDal dal = new CustomerDal();
                    Customer customer = new Customer();
                    customer.CreateDate = DateTime.Now;
                    customer.CustomerName = txtCustomerName.Text;
                    customer.EnergyPlanId = int.Parse(ddlEnergyPlans.SelectedValue);
                    customer.CustomerEmail = txtCustomerEmail.Text;
                    var savedCustomer = dal.SaveCustomer(customer);
                    if(savedCustomer != null && savedCustomer.CustomerId > 0)
                    {
                        divSuccess.Visible = true;
                    }
                    gvCustomers.DataSource = dal.GetAllCustomers();
                    gvCustomers.DataBind();
                    ClearForm();
                }
                else
                {
                    divError.Visible = true;
                }
            }
            else
            {
                divError.Visible = true;
            }
        }

        public void ClearForm()
        {
            txtCustomerName.Text = "";
            txtCustomerEmail.Text = "";
            ddlEnergyPlans.SelectedIndex = 0 ;
        }
    }
}