using EnergySimplyLib.ServiceDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnergySimply
{
    public partial class ViewFiles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.Page.Title = "View Files";
                DocumentDal dal = new DocumentDal();
                EnergyPlanDal pdal = new EnergyPlanDal();

                gvFiles.DataSource = dal.GetAllFiles();
                gvFiles.DataBind();
            }
        }
    }
}