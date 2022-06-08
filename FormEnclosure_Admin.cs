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
    public partial class FormEnclosure_Admin : Form
    {
        public FormEnclosure_Admin()
        {
            InitializeComponent();
            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter("select * from ENCLOSURE", connstr);
            DataTable table = new DataTable();
            oracleDataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        string connstr = "data source=localhost:1521/xe;user id=SYSTEM;password=Dell1234;";

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string enclosure_no = txtenclosure_no.Text;
                string enclosure_name = txtenclosure_name.Text;
                string enclosure_category = txtenclosure_category.Text;
                string enclosure_fees = txtenclosure_fees.Text;
                string no_of_seats = txtno_seats.Text;

                OracleConnection oracleConnection1 = new OracleConnection(connstr);
                oracleConnection1.Open();

                string query1 = "insert into ENCLOSURE(ENCLOSURE_NUMBER,ENCLOSURE_NAME,ENCLOSURE_CATEGORY,ENCLOSURE_FEES,NUMBER_OF_SEATS)values('" + enclosure_no + "', '" + enclosure_name + "', '" + enclosure_category + "' , " + enclosure_fees + "," + no_of_seats + ")";

                OracleCommand oracleCommand1 = new OracleCommand();
                oracleCommand1.Connection = oracleConnection1;
                oracleCommand1.CommandText = query1;

                int x = oracleCommand1.ExecuteNonQuery();
                if (x > 0)
                {

                    MessageBox.Show("INFORMATION HAS BEEN INSERTED");

                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter("select * from ENCLOSURE", connstr);
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
                string enclosure_no = txtenclosure_no.Text;
                string enclosure_name = txtenclosure_name.Text;
                string enclosure_category = txtenclosure_category.Text;
                string enclosure_fees = txtenclosure_fees.Text;
                string no_of_seats = txtno_seats.Text;

                OracleConnection oracleConnection1 = new OracleConnection(connstr);
                oracleConnection1.Open();

                string query1 = "update ENCLOSURE set ENCLOSURE_NUMBER = '" + enclosure_no + "', ENCLOSURE_NAME = '" + enclosure_name + "' , ENCLOSURE_CATEGORY = '" + enclosure_category + "', ENCLOSURE_FEES = " + enclosure_fees + ", NUMBER_OF_SEATS = " + no_of_seats + " where ENCLOSURE_NUMBER = '" + enclosure_no + "'";
                  
                OracleCommand oracleCommand1 = new OracleCommand();
                oracleCommand1.Connection = oracleConnection1;
                oracleCommand1.CommandText = query1;

                int x = oracleCommand1.ExecuteNonQuery();
                if (x > 0)
                {

                    MessageBox.Show("INFORMATION HAS BEEN UPDATED");

                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter("select * from ENCLOSURE", connstr);
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
                string enclosure_no = txtenclosure_no.Text;
                string enclosure_name = txtenclosure_name.Text;
                string enclosure_category = txtenclosure_category.Text;
                string enclosure_fees = txtenclosure_fees.Text;
                string no_of_seats = txtno_seats.Text;

                OracleConnection oracleConnection1 = new OracleConnection(connstr);
                oracleConnection1.Open();

                string query1 = "delete from ENCLOSURE where ENCLOSURE_NUMBER = '" + enclosure_no + "'";

                OracleCommand oracleCommand1 = new OracleCommand();
                oracleCommand1.Connection = oracleConnection1;
                oracleCommand1.CommandText = query1;

                int x = oracleCommand1.ExecuteNonQuery();
                if (x > 0)
                {

                    MessageBox.Show("INFORMATION HAS BEEN DELETED");

                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter("select * from ENCLOSURE", connstr);
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
