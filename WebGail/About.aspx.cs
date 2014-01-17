using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NCI.DCEG.BCRA.ConsoleSample;
using NCI.DCEG.BCRA.Engine;

namespace WebGail
{
    public partial class About : Page
    {

        public static int prediction = 0;
        public static double predictionResult = 0.0;
        public static double averageRisk = 0.0;
        public static double absRisk = 0, avgRisk = 0, absRiskPctg = 0, avgRiskPctg = 0;
        public static string fname, lname, emailv, bday, racev, proj, men, fchild, bio, rel, hy;

      

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void evaluate_Click(object sender, EventArgs e) {
            fchild = firstChild.Text;
            if (Convert.ToInt32(fchild) > 0)
            {

            }
            else {
                fchild = "0";
            }
            rel = firstRelatives.Text;
            if (Convert.ToInt32(rel) > 0)
            {

            }
            else
            {
                rel = "0";
            }

            string[] qw = (birthDate.Text).Split('/');
            int xy = Convert.ToInt32(qw[0]);
            int ag = 2014 - xy;
            prediction = Convert.ToInt32(projection.Text);
            int currentAge = BcptConvert.GetCurrentAge(ag);

            int menarcheAge = BcptConvert.GetMenarcheAge(menarch.Text);
            int firstLiveBirthAge = BcptConvert.GetFirstLiveBirthAge(firstChild.Text);
            int firstDegreeRel = BcptConvert.GetFirstDegRelatives(firstRelatives.Text);
            int hadBiopsy = BcptConvert.GetEverHadBiopsy(biopsy.SelectedItem.ToString());

            int numBiopsy = BcptConvert.GetNumberOfBiopsy(numbByopsies.Text);
            int hyperPlasia = BcptConvert.GetHyperPlasia(hyper.SelectedItem.ToString());

            int race = BcptConvert.GetRace((raceInput.SelectedValue).ToString());
            // Calculate 5 year risk.
            Helper.RiskCalc(0, currentAge, currentAge + Convert.ToInt32(projection.Text), menarcheAge, firstLiveBirthAge, hadBiopsy, numBiopsy,
                hyperPlasia, firstDegreeRel, race, out absRisk, out avgRisk);
            Helper.CalcPercentage(absRisk, avgRisk, out absRiskPctg, out avgRiskPctg);

            predictionResult = absRiskPctg;
            averageRisk = avgRiskPctg;

           
            //System.Windows.Forms.MessageBox.Show(absRiskPctg.ToString());
            // Calculate lifetime risk.
            Helper.RiskCalc(0, currentAge, 90, menarcheAge, firstLiveBirthAge, hadBiopsy, numBiopsy, hyperPlasia, firstDegreeRel, race, out absRisk, out avgRisk);
            Helper.CalcPercentage(absRisk, avgRisk, out absRiskPctg, out avgRiskPctg);

            //fname, lname, emailv, bday, racev, proj, men, fchild, bio, rel, hy;
            fname = firstName.Text;
            lname = lastName.Text;
            emailv = email.Text;
            bday = birthDate.Text;
            racev = (raceInput.SelectedValue).ToString();
            proj = projection.Text;
            men = projection.Text;
            fchild = projection.Text;
            bio = numbByopsies.Text;
            rel = firstRelatives.Text;
            hy = hyper.SelectedItem.ToString();




            Response.Redirect("Contact.aspx");
        }

       
    }
}