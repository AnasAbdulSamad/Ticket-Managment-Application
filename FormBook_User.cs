using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.IO;

namespace DesignTutorial
{
    public partial class FormBook_User : Form
    {
        //public int ticket_id = 000;
        public FormBook_User()
        {
            InitializeComponent();

            {
                

                //StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\TICKET\\" + "ticket_identity.txt");
                //streamWriter.WriteLine(001);
                //streamWriter.Close();

                


                OracleConnection oracleConnection2 = new OracleConnection(connstr);
                oracleConnection2.Open();
                string query2 = "select MATCH_NUMBER from SCHEDULE";
                OracleCommand oracleCommand2 = new OracleCommand();
                oracleCommand2.Connection = oracleConnection2;
                oracleCommand2.CommandText = query2;
                OracleDataReader oracleDataReader2 = oracleCommand2.ExecuteReader();
                while (oracleDataReader2.Read())
                {
                    object match_number = oracleDataReader2["MATCH_NUMBER"];
                    txtmatch_no.Items.Add(match_number);
                }
                oracleConnection2.Close();

                OracleConnection oracleConnection3 = new OracleConnection(connstr);
                oracleConnection3.Open();
                string query3 = "select ENCLOSURE_NUMBER from ENCLOSURE";
                OracleCommand oracleCommand3 = new OracleCommand();
                oracleCommand3.Connection = oracleConnection3;
                oracleCommand3.CommandText = query3;
                OracleDataReader oracleDataReader3 = oracleCommand3.ExecuteReader();
                while (oracleDataReader3.Read())
                {
                    object enclosure_number = oracleDataReader3["ENCLOSURE_NUMBER"];
                    txtenclosure_no.Items.Add(enclosure_number);
                }
                oracleConnection3.Close();
            }
        }
        string connstr = "data source=localhost:1521/xe;user id=SYSTEM;password=Dell1234;";

       
        

        

        private void btn_proceed_Click_1(object sender, EventArgs e)
        {
            
            string fname = txtfname.Text;
            string lname = txtlname.Text;
            string nic = txtnic_no.Text;
            string contact_no = txtcontact_no.Text;
            string email_id = txtemail_id.Text;
            string match_no = txtmatch_no.Text;
            string enclosure_no = txtenclosure_no.Text;

            StreamReader streamReader = new StreamReader(Application.StartupPath + "\\TICKET\\" + "ticket_identity.txt");
            string ticket_id = streamReader.ReadToEnd();
            streamReader.Close();


            OracleConnection oracleConnection1 = new OracleConnection(connstr);
            oracleConnection1.Open();

            string query1 = "insert into TICKETS(FNAME,LNAME,CONTACT_NUMBER,EMAIL_ID,NIC_NUMBER,MATCH_NUMBER,ENCLOSURE_NUMBER,TICKET_ID)values('" + fname + "', '" + lname + "', " + contact_no + ", '" + email_id + "' , " + nic + ",'" + match_no + "','" + enclosure_no + "'," + ticket_id + ")";

            OracleCommand oracleCommand1 = new OracleCommand();
            oracleCommand1.Connection = oracleConnection1;
            oracleCommand1.CommandText = query1;
            int x = oracleCommand1.ExecuteNonQuery();
            if (x > 0)
            {
                
                MessageBox.Show("YOUR INFORMATION HAS BEEN STORED \nPRESS OK TO PROCEED TO FEES PAYMENT");
            }
            else
            {
                MessageBox.Show("PLEASE ENTER CORRECT INFORMATION");
                return;
            }

            oracleConnection1.Close();


            if (enclosure_no == "S-001")
            {
                string taxS001 = "3900";
                string enclfeesS001 = "30000";
                string totalfeesS001 = "33900";

                OracleConnection oracleConnectionS001 = new OracleConnection(connstr);
                oracleConnectionS001.Open();
                string queryS001 = "insert into FEES(FEES_NUMBER,TAX,TOTAL_FEES,ENCLOSURE_FEES)values('" + ticket_id + "' , '" + taxS001 + "' , '" + totalfeesS001 + "' , '" + enclfeesS001 + "')";
                OracleCommand oracleCommandS001 = new OracleCommand();
                oracleCommandS001.Connection = oracleConnectionS001;
                oracleCommandS001.CommandText = queryS001;
                int S001 = oracleCommandS001.ExecuteNonQuery();
                oracleConnectionS001.Close();

                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\FEES\\" + "total_fees.txt");
                streamWriter.WriteLine(totalfeesS001);
                streamWriter.Close();
            }

            else if (enclosure_no == "S-002")
            {
                string taxS002 = "3575";
                string enclfeesS002 = "27500";
                string totalfeesS002 = "30075";

                OracleConnection oracleConnectionS002 = new OracleConnection(connstr);
                oracleConnectionS002.Open();
                string queryS002 = "insert into FEES(FEES_NUMBER,TAX,TOTAL_FEES,ENCLOSURE_FEES)values('" + ticket_id + "' , '" + taxS002 + "' , '" + totalfeesS002 + "' , '" + enclfeesS002 + "')";
                OracleCommand oracleCommandS002 = new OracleCommand();
                oracleCommandS002.Connection = oracleConnectionS002;
                oracleCommandS002.CommandText = queryS002;
                int S002 = oracleCommandS002.ExecuteNonQuery();
                oracleConnectionS002.Close();

                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\FEES\\" + "total_fees.txt");
                streamWriter.WriteLine(totalfeesS002);
                streamWriter.Close();
            }

            else if (enclosure_no == "S-003")
            {
                string taxS003 = "3250";
                string enclfeesS003 = "25000";
                string totalfeesS003 = "28250";

                OracleConnection oracleConnectionS003 = new OracleConnection(connstr);
                oracleConnectionS003.Open();
                string queryS003 = "insert into FEES(FEES_NUMBER,TAX,TOTAL_FEES,ENCLOSURE_FEES)values('" + ticket_id + "' , '" + taxS003 + "' , '" + totalfeesS003 + "' , '" + enclfeesS003 + "')";
                OracleCommand oracleCommandS003 = new OracleCommand();
                oracleCommandS003.Connection = oracleConnectionS003;
                oracleCommandS003.CommandText = queryS003;
                int S003 = oracleCommandS003.ExecuteNonQuery();
                oracleConnectionS003.Close();

                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\FEES\\" + "total_fees.txt");
                streamWriter.WriteLine(totalfeesS003);
                streamWriter.Close();
            }

            else if (enclosure_no == "S-004")
            {
                string taxS004 = "2925";
                string enclfeesS004 = "22500";
                string totalfeesS004 = "25425";

                OracleConnection oracleConnectionS004 = new OracleConnection(connstr);
                oracleConnectionS004.Open();
                string queryS004 = "insert into FEES(FEES_NUMBER,TAX,TOTAL_FEES,ENCLOSURE_FEES)values('" + ticket_id + "' , '" + taxS004 + "' , '" + totalfeesS004 + "' , '" + enclfeesS004 + "')";
                OracleCommand oracleCommandS004 = new OracleCommand();
                oracleCommandS004.Connection = oracleConnectionS004;
                oracleCommandS004.CommandText = queryS004;
                int S004 = oracleCommandS004.ExecuteNonQuery();
                oracleConnectionS004.Close();

                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\FEES\\" + "total_fees.txt");
                streamWriter.WriteLine(totalfeesS004);
                streamWriter.Close();
            }

            else if (enclosure_no == "S-005")
            {
                string taxS005 = "2600";
                string enclfeesS005 = "20000";
                string totalfeesS005 = "22600";

                OracleConnection oracleConnectionS005 = new OracleConnection(connstr);
                oracleConnectionS005.Open();
                string queryS005 = "insert into FEES(FEES_NUMBER,TAX,TOTAL_FEES,ENCLOSURE_FEES)values('" + ticket_id + "' , '" + taxS005 + "' , '" + totalfeesS005 + "' , '" + enclfeesS005 + "')";
                OracleCommand oracleCommandS005 = new OracleCommand();
                oracleCommandS005.Connection = oracleConnectionS005;
                oracleCommandS005.CommandText = queryS005;
                int S005 = oracleCommandS005.ExecuteNonQuery();
                oracleConnectionS005.Close();

                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\FEES\\" + "total_fees.txt");
                streamWriter.WriteLine(totalfeesS005);
                streamWriter.Close();
            }

            else if (enclosure_no == "S-006")
            {
                string taxS006 = "2275";
                string enclfeesS006 = "17500";
                string totalfeesS006 = "19775";

                OracleConnection oracleConnectionS006 = new OracleConnection(connstr);
                oracleConnectionS006.Open();
                string queryS006 = "insert into FEES(FEES_NUMBER,TAX,TOTAL_FEES,ENCLOSURE_FEES)values('" + ticket_id + "' , '" + taxS006 + "' , '" + totalfeesS006 + "' , '" + enclfeesS006 + "')";
                OracleCommand oracleCommandS006 = new OracleCommand();
                oracleCommandS006.Connection = oracleConnectionS006;
                oracleCommandS006.CommandText = queryS006;
                int S006 = oracleCommandS006.ExecuteNonQuery();
                oracleConnectionS006.Close();

                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\FEES\\" + "total_fees.txt");
                streamWriter.WriteLine(totalfeesS006);
                streamWriter.Close();
            }

            else if (enclosure_no == "S-007")
            {
                string taxS007 = "1950";
                string enclfeesS007 = "15000";
                string totalfeesS007 = "16950";

                OracleConnection oracleConnectionS007 = new OracleConnection(connstr);
                oracleConnectionS007.Open();
                string queryS007 = "insert into FEES(FEES_NUMBER,TAX,TOTAL_FEES,ENCLOSURE_FEES)values('" + ticket_id + "' , '" + taxS007 + "' , '" + totalfeesS007 + "' , '" + enclfeesS007 + "')";
                OracleCommand oracleCommandS007 = new OracleCommand();
                oracleCommandS007.Connection = oracleConnectionS007;
                oracleCommandS007.CommandText = queryS007;
                int S007 = oracleCommandS007.ExecuteNonQuery();
                oracleConnectionS007.Close();

                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\FEES\\" + "total_fees.txt");
                streamWriter.WriteLine(totalfeesS007);
                streamWriter.Close();
            }

            else if (enclosure_no == "S-008")
            {
                string taxS008 = "1625";
                string enclfeesS008 = "12500";
                string totalfeesS008 = "14125";

                OracleConnection oracleConnectionS008 = new OracleConnection(connstr);
                oracleConnectionS008.Open();
                string queryS008 = "insert into FEES(FEES_NUMBER,TAX,TOTAL_FEES,ENCLOSURE_FEES)values('" + ticket_id + "' , '" + taxS008 + "' , '" + totalfeesS008 + "' , '" + enclfeesS008 + "')";
                OracleCommand oracleCommandS008 = new OracleCommand();
                oracleCommandS008.Connection = oracleConnectionS008;
                oracleCommandS008.CommandText = queryS008;
                int S008 = oracleCommandS008.ExecuteNonQuery();
                oracleConnectionS008.Close();

                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\FEES\\" + "total_fees.txt");
                streamWriter.WriteLine(totalfeesS008);
                streamWriter.Close();
            }

            else if (enclosure_no == "S-009")
            {
                string taxS009 = "1300";
                string enclfeesS009 = "10000";
                string totalfeesS009 = "11300";

                OracleConnection oracleConnectionS009 = new OracleConnection(connstr);
                oracleConnectionS009.Open();
                string queryS009 = "insert into FEES(FEES_NUMBER,TAX,TOTAL_FEES,ENCLOSURE_FEES)values('" + ticket_id + "' , '" + taxS009 + "' , '" + totalfeesS009 + "' , '" + enclfeesS009 + "')";
                OracleCommand oracleCommandS009 = new OracleCommand();
                oracleCommandS009.Connection = oracleConnectionS009;
                oracleCommandS009.CommandText = queryS009;
                int S009 = oracleCommandS009.ExecuteNonQuery();
                oracleConnectionS009.Close();

                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\FEES\\" + "total_fees.txt");
                streamWriter.WriteLine(totalfeesS009);
                streamWriter.Close();
            }

            else if (enclosure_no == "S-010")
            {
                string taxS010 = "975";
                string enclfeesS010 = "7500";
                string totalfeesS010 = "8475";

                OracleConnection oracleConnectionS010 = new OracleConnection(connstr);
                oracleConnectionS010.Open();
                string queryS010 = "insert into FEES(FEES_NUMBER,TAX,TOTAL_FEES,ENCLOSURE_FEES)values('" + ticket_id + "' , '" + taxS010 + "' , '" + totalfeesS010 + "' , '" + enclfeesS010 + "')";
                OracleCommand oracleCommandS010 = new OracleCommand();
                oracleCommandS010.Connection = oracleConnectionS010;
                oracleCommandS010.CommandText = queryS010;
                int S010 = oracleCommandS010.ExecuteNonQuery();
                oracleConnectionS010.Close();

                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\FEES\\" + "total_fees.txt");
                streamWriter.WriteLine(totalfeesS010);
                streamWriter.Close();
            }

            else if (enclosure_no == "S-011")
            {
                string taxS011 = "650";
                string enclfeesS011 = "5000";
                string totalfeesS011 = "5650";

                OracleConnection oracleConnectionS011 = new OracleConnection(connstr);
                oracleConnectionS011.Open();
                string queryS011 = "insert into FEES(FEES_NUMBER,TAX,TOTAL_FEES,ENCLOSURE_FEES)values('" + ticket_id + "' , '" + taxS011 + "' , '" + totalfeesS011 + "' , '" + enclfeesS011 + "')";
                OracleCommand oracleCommandS011 = new OracleCommand();
                oracleCommandS011.Connection = oracleConnectionS011;
                oracleCommandS011.CommandText = queryS011;
                int S011 = oracleCommandS011.ExecuteNonQuery();
                oracleConnectionS011.Close();

                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\FEES\\" + "total_fees.txt");
                streamWriter.WriteLine(totalfeesS011);
                streamWriter.Close();
            }

            else if (enclosure_no == "S-012")
            {
                string taxS012 = "325";
                string enclfeesS012 = "2500";
                string totalfeesS012 = "2825";

                OracleConnection oracleConnectionS012 = new OracleConnection(connstr);
                oracleConnectionS012.Open();
                string queryS012 = "insert into FEES(FEES_NUMBER,TAX,TOTAL_FEES,ENCLOSURE_FEES)values('" + ticket_id + "' , '" + taxS012 + "' , '" + totalfeesS012 + "' , '" + enclfeesS012 + "')";
                OracleCommand oracleCommandS012 = new OracleCommand();
                oracleCommandS012.Connection = oracleConnectionS012;
                oracleCommandS012.CommandText = queryS012;
                int S012 = oracleCommandS012.ExecuteNonQuery();
                oracleConnectionS012.Close();

                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\FEES\\" + "total_fees.txt");
                streamWriter.WriteLine(totalfeesS012);
                streamWriter.Close();
            }

            else if (enclosure_no == "S-013")
            {
                string taxS013 = "130";
                string enclfeesS013 = "1000";
                string totalfeesS013 = "1130";

                OracleConnection oracleConnectionS013 = new OracleConnection(connstr);
                oracleConnectionS013.Open();
                string queryS013 = "insert into FEES(FEES_NUMBER,TAX,TOTAL_FEES,ENCLOSURE_FEES)values('" + ticket_id + "' , '" + taxS013 + "' , '" + totalfeesS013 + "' , '" + enclfeesS013 + "')";
                OracleCommand oracleCommandS013 = new OracleCommand();
                oracleCommandS013.Connection = oracleConnectionS013;
                oracleCommandS013.CommandText = queryS013;
                int S013 = oracleCommandS013.ExecuteNonQuery();
                oracleConnectionS013.Close();

                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\FEES\\" + "total_fees.txt");
                streamWriter.WriteLine(totalfeesS013);
                streamWriter.Close();
            }

            else if (enclosure_no == "S-014")
            {
                string taxS014 = "65";
                string enclfeesS014 = "500";
                string totalfeesS014 = "565";

                OracleConnection oracleConnectionS014 = new OracleConnection(connstr);
                oracleConnectionS014.Open();
                string queryS014 = "insert into FEES(FEES_NUMBER,TAX,TOTAL_FEES,ENCLOSURE_FEES)values('" + ticket_id + "' , '" + taxS014 + "' , '" + totalfeesS014 + "' , '" + enclfeesS014 + "')";
                OracleCommand oracleCommandS014 = new OracleCommand();
                oracleCommandS014.Connection = oracleConnectionS014;
                oracleCommandS014.CommandText = queryS014;
                int S014 = oracleCommandS014.ExecuteNonQuery();
                oracleConnectionS014.Close();

                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\FEES\\" + "total_fees.txt");
                streamWriter.WriteLine(totalfeesS014);
                streamWriter.Close();
            }






            this.panel1.Controls.Clear();
            FormFees_User FormFees_Move = new FormFees_User { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormFees_Move.FormBorderStyle = FormBorderStyle.None;
            FormFees_Move.Size = new Size(712, 418);
            this.panel1.Controls.Add(FormFees_Move);
            FormFees_Move.Show();
        }

        

        
    }
}
