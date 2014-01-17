using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebGail
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
            dbEntry[] users = new dbEntry[100];

            string cs = @"server=wildmedia.ro;userid=wildmedi_oop;password=ayo1993;database=wildmedi_oop";
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();

            string stm = "SELECT * FROM users";
            MySqlCommand cmd = new MySqlCommand(stm, conn);
            MySqlDataReader rdr = null;
            rdr = cmd.ExecuteReader();

            TableRow trh = new TableRow();
            TableCell[] tch = new TableCell[6];



            tch[0] = new TableCell();
            tch[0].Text = "Id";
            trh.Cells.Add(tch[0]);
            tch[1] = new TableCell();
            tch[1].Text = "First name";
            trh.Cells.Add(tch[1]);
            tch[2] = new TableCell();
            tch[2].Text = "Last name";
            trh.Cells.Add(tch[2]);
            tch[3] = new TableCell();
            tch[3].Text = "Email";
            trh.Cells.Add(tch[3]);
            tch[4] = new TableCell();
            tch[4].Text = "Projection period";
            trh.Cells.Add(tch[4]);
            tch[5] = new TableCell();
            tch[5].Text = "Result";
            trh.Cells.Add(tch[5]);


            userTable.Rows.Add(trh);

           
            int i=0;
            int x = 0;
            while (rdr.Read())
            {
                users[i] = new dbEntry();

                users[i].id = rdr.GetInt32(0);
                users[i].fname = rdr.GetString(1);
                users[i].lname = rdr.GetString(2);
                users[i].race = rdr.GetString(3);
                users[i].projectionPeriod = rdr.GetString(4);
                users[i].result = rdr.GetString(12);

                TableRow tr = new TableRow();



                TableCell[] tcw = new TableCell[6];
                tcw[0] = new TableCell();
                tcw[0].Text = users[i].id.ToString() + " ";
                tr.Cells.Add(tcw[0]);
                tcw[1] = new TableCell();
                tcw[1].Text = users[i].fname + " ";
                tr.Cells.Add(tcw[1]);
                tcw[2] = new TableCell();
                tcw[2].Text = users[i].lname + " ";
                tr.Cells.Add(tcw[2]);
                tcw[3] = new TableCell();
                tcw[3].Text = users[i].race + " ";
                tr.Cells.Add(tcw[3]);
                tcw[4] = new TableCell();
                tcw[4].Text = users[i].projectionPeriod + " ";
                tr.Cells.Add(tcw[4]);
                tcw[5] = new TableCell();
                tcw[5].Text = users[i].result + " %";
                tr.Cells.Add(tcw[5]);
               

                userTable.Rows.Add(tr);
                
                
                

                i++;
            }

        }

        public class dbEntry
        {
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
