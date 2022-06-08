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

namespace DesignTutorial
{
    public partial class FormTicket_Admin : Form
    {
        public FormTicket_Admin()
        {
            InitializeComponent();
            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter("select * from TICKETS", connstr);
            DataTable table = new DataTable();
            oracleDataAdapter.Fill(table);
            dataGridView1.DataSource = table;


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
        string connstr = "data source=localhost:1521/xe;user id=SYSTEM;password=Dell1234;";

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = txtfname.Text;
                string lname = txtlname.Text;
                string nic = txtnic_no.Text;
                string contact_no = txtcontact_no.Text;
                string email_id = txtemail_id.Text;
                string match_no = txtmatch_no.Text;
                string enclosure_no = txtenclosure_no.Text;
                string ticket_id = txtticket_id.Text;

                OracleConnection oracleConnection1 = new OracleConnection(connstr);
                oracleConnection1.Open();

                string query1 = "insert into TICKETS(FNAME,LNAME,CONTACT_NUMBER,EMAIL_ID,NIC_NUMBER,MATCH_NUMBER,ENCLOSURE_NUMBER,TICKET_ID)values('" + fname + "', '" + lname + "', " + contact_no + ", '" + email_id + "' , " + nic + ",'" + match_no + "','" + enclosure_no + "'," + ticket_id + ")";

                OracleCommand oracleCommand1 = new OracleCommand();
                oracleCommand1.Connection = oracleConnection1;
                oracleCommand1.CommandText = query1;

                int x = oracleCommand1.ExecuteNonQuery();
                if (x > 0)
                {

                    MessageBox.Show("INFORMATION HAS BEEN INSERTED");

                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter("select * from TICKETS", connstr);
                    DataTable table = new DataTable();
                    oracleDataAdapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("PLEASE ENTER CORRECT INFORMATION");
                    return;
                }

                oracleConnection1.Close();
            }
            catch 
            {
                MessageBox.Show("Invalid Move");
            }
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = txtfname.Text;
                string lname = txtlname.Text;
                string nic = txtnic_no.Text;
                string contact_no = txtcontact_no.Text;
                string email_id = txtemail_id.Text;
                string match_no = txtmatch_no.Text;
                string enclosure_no = txtenclosure_no.Text;
                string ticket_id = txtticket_id.Text;

                OracleConnection oracleConnection1 = new OracleConnection(connstr);
                oracleConnection1.Open();

                string query1 = "update TICKETS set FNAME = '" + fname + "', LNAME = '" + lname + "', CONTACT_NUMBER = " + contact_no + ", EMAIL_ID = '" + email_id + "' , NIC_NUMBER = " + nic + ", MATCH_NUMBER = '" + match_no + "', ENCLOSURE_NUMBER = '" + enclosure_no + "', TICKET_ID = " + ticket_id + " where TICKET_ID = " + ticket_id + "";

                OracleCommand oracleCommand1 = new OracleCommand();
                oracleCommand1.Connection = oracleConnection1;
                oracleCommand1.CommandText = query1;

                int x = oracleCommand1.ExecuteNonQuery();
                if (x > 0)
                {

                    MessageBox.Show("INFORMATION HAS BEEN UPDATED");

                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter("select * from TICKETS", connstr);
                    DataTable table = new DataTable();
                    oracleDataAdapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("PLEASE ENTER CORRECT INFORMATION");
                    return;
                }

                oracleConnection1.Close();
            }
            catch
            {
                MessageBox.Show("Invalid Move");
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = txtfname.Text;
                string lname = txtlname.Text;
                string nic = txtnic_no.Text;
                string contact_no = txtcontact_no.Text;
                string email_id = txtemail_id.Text;
                string match_no = txtmatch_no.Text;
                string enclosure_no = txtenclosure_no.Text;
                string ticket_id = txtticket_id.Text;

                OracleConnection oracleConnection1 = new OracleConnection(connstr);
                oracleConnection1.Open();

                string query1 = "delete from TICKETS where TICKET_ID = " + ticket_id + "";

                OracleCommand oracleCommand1 = new OracleCommand();
                oracleCommand1.Connection = oracleConnection1;
                oracleCommand1.CommandText = query1;

                int x = oracleCommand1.ExecuteNonQuery();
                if (x > 0)
                {

                    MessageBox.Show("INFORMATION HAS BEEN DELETED");

                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter("select * from TICKETS", connstr);
                    DataTable table = new DataTable();
                    oracleDataAdapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("PLEASE ENTER CORRECT INFORMATION");
                    return;
                }

                oracleConnection1.Close();
            }
            catch
            {
                MessageBox.Show("Invalid Move");
            }
        }
    }
}
