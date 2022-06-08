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
    public partial class FormFees_Admin : Form
    {
        public FormFees_Admin()
        {
            InitializeComponent();
            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter("select * from FEES", connstr);
            DataTable table = new DataTable();
            oracleDataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        string connstr = "data source=localhost:1521/xe;user id=SYSTEM;password=Dell1234;";

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string fees_no = txtfees_no.Text;
                string tax = txttax.Text;
                string enclosure_fees = txtenclosure_fees.Text;
                string total_fees = txttotal_fees.Text;
                
                OracleConnection oracleConnection1 = new OracleConnection(connstr);
                oracleConnection1.Open();

                string query1 = "insert into FEES(FEES_NUMBER,TAX,TOTAL_FEES,ENCLOSURE_FEES)values('" + fees_no + "', " + tax + ", " + total_fees + " , " + enclosure_fees + ")";

                OracleCommand oracleCommand1 = new OracleCommand();
                oracleCommand1.Connection = oracleConnection1;
                oracleCommand1.CommandText = query1;

                int x = oracleCommand1.ExecuteNonQuery();
                if (x > 0)
                {

                    MessageBox.Show("INFORMATION HAS BEEN INSERTED");

                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter("select * from FEES", connstr);
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
                string fees_no = txtfees_no.Text;
                string tax = txttax.Text;
                string enclosure_fees = txtenclosure_fees.Text;
                string total_fees = txttotal_fees.Text;

                OracleConnection oracleConnection1 = new OracleConnection(connstr);
                oracleConnection1.Open();

                string query1 = "update FEES set FEES_NUMBER = '" + fees_no + "',TAX =  "+ tax + ", TOTAL_FEES = " + total_fees + ",ENCLOSURE_FEES = " + enclosure_fees + " where FEES_NUMBER = '"+fees_no+"'";

                OracleCommand oracleCommand1 = new OracleCommand();
                oracleCommand1.Connection = oracleConnection1;
                oracleCommand1.CommandText = query1;

                int x = oracleCommand1.ExecuteNonQuery();
                if (x > 0)
                {

                    MessageBox.Show("INFORMATION HAS BEEN UPDATED");

                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter("select * from FEES", connstr);
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
                string fees_no = txtfees_no.Text;
                string tax = txttax.Text;
                string enclosure_fees = txtenclosure_fees.Text;
                string total_fees = txttotal_fees.Text;

                OracleConnection oracleConnection1 = new OracleConnection(connstr);
                oracleConnection1.Open();

                string query1 = "delete from FEES where FEES_NUMBER = '" + fees_no + "'";

                OracleCommand oracleCommand1 = new OracleCommand();
                oracleCommand1.Connection = oracleConnection1;
                oracleCommand1.CommandText = query1;

                int x = oracleCommand1.ExecuteNonQuery();
                if (x > 0)
                {

                    MessageBox.Show("INFORMATION HAS BEEN DELETED");

                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter("select * from FEES", connstr);
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
