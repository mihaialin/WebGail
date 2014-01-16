using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebGail
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = About.prediction.ToString() + " years prediction: ";
            Label2.Text = "Your risk: " + About.predictionResult.ToString() + "%";
            Label3.Text = "Average risk: " + About.averageRisk.ToString() + "%";
            Label4.Text = "Your risk: " + About.absRiskPctg.ToString() + "%";
            Label5.Text = "Average risk: " + About.avgRiskPctg.ToString() + "%";
            Label6.Text = "Based on the information provided (see below), the woman's estimated risk for developing invasive breast cancer over the next " + About.prediction.ToString() + ". years is " + About.predictionResult.ToString() + "% compared to a risk of " + About.averageRisk.ToString() + " for a woman of the same age and race/ethnicity from the general U.S. population. This calculation also means that the woman's risk of NOT getting breast cancer over the next "+ About.prediction.ToString() +" years is " + About.avgRiskPctg.ToString() +"%.";
        }
    }
}