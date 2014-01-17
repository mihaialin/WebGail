using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MySql.Data.MySqlClient;


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

            string cs = @"server=localhost;userid=root;database=oop_project";

            

            MySqlConnection conn = null;
            MySqlDataReader rdr = null;
        }

        public class dbEntry {
            public int id;
            public string fname;
            public string lname;
            public string email;
            public string race;
            public int projectionPeriod;
            public int menarch;
            public int firstChild;
            public string hadBiopsy;
            public int biopsyNo;
            public string relatives;
            public string hyperplacia;
            public string result;
            public string lifeResult;            
            
        }
    
    
    }
}