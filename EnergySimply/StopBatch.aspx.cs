using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnergySimply
{
    public partial class StopBatch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStopBatch_Click(object sender, EventArgs e)
        {
            Global.batchRunner = "stop";
        }

        protected void btnSeconds_Click(object sender, EventArgs e)
        {
            Global.batchSeconds = int.Parse(txtSeconds.Text);
        }

        protected void btnStartBatch_Click(object sender, EventArgs e)
        {
            Global.batchRunner = "run";
            
        }
    }
}