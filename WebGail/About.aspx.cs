using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebGail
{
    public partial class About : Page
    {

        public static double absRiskS;
        public static double avgRiskS;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void evaluate_Click(object sender, EventArgs e) {
            Response.Redirect("Contact.aspx");
        }
       
    }
}