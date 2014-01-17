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

            
            dbEntry currentUser = new dbEntry();
            currentUser.fname = About.fname;
            currentUser.lname = About.lname;
            currentUser.email = About.emailv;
            currentUser.race = About.racev;
            currentUser.projectionPeriod = About.prediction.ToString();
            currentUser.menarch = About.men;
            currentUser.firstChild = About.fchild;
            //currentUser.hadBiopsy = About.bio;
            currentUser.biopsyNo = About.bio;
            currentUser.hyperplacia = About.hy;
            currentUser.result = About.predictionResult.ToString();
            currentUser.lifeResult = About.absRiskPctg.ToString();


            string cs = @"server=wildmedia.ro;userid=wildmedi_oop;password=ayo1993;database=wildmedi_oop";
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO users(fname,lname,email,race,projectionPeriod,menarch,firstChild,biopsyNo,hyperplacia,result,lifeResult) VALUES(@fname,@lname,@email,@race,@projectionPeriod,@menarch,@firstChild,@biopsyNo,@hyperplacia,@result,@lifeResult)";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@fname", currentUser.fname);
            cmd.Parameters.AddWithValue("@lname", currentUser.lname);
            cmd.Parameters.AddWithValue("@email", currentUser.email);
            cmd.Parameters.AddWithValue("@race", currentUser.race);
            cmd.Parameters.AddWithValue("@projectionPeriod", currentUser.projectionPeriod);
            cmd.Parameters.AddWithValue("@menarch", currentUser.menarch);
            cmd.Parameters.AddWithValue("@firstChild", currentUser.firstChild);
            cmd.Parameters.AddWithValue("@biopsyNo", currentUser.biopsyNo);
            cmd.Parameters.AddWithValue("@hyperplacia", currentUser.hyperplacia);
            cmd.Parameters.AddWithValue("@result", currentUser.result);
            cmd.Parameters.AddWithValue("@lifeResult", currentUser.lifeResult);

            cmd.ExecuteNonQuery();
        }

        public class dbEntry {
            public int id;
            public string fname;
            public string lname;
            public string email;
            public string race;
            public string projectionPeriod;
            public string menarch;
            public string firstChild;
            public string hadBiopsy;
            public string biopsyNo;
            public string relatives;
            public string hyperplacia;
            public string result;
            public string lifeResult;            
            
        }
    
    
    }
}