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
    public partial class FormSchedule_Admin : Form
    {
        public FormSchedule_Admin()
        {
            InitializeComponent();
            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter("select * from SCHEDULE", connstr);
            DataTable table = new DataTable();
            oracleDataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        string connstr = "data source=localhost:1521/xe;user id=SYSTEM;password=Dell1234;";

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string match_no = txtmatch_no.Text;
                string match_team1 = txtmatch_team1.Text;
                string mathc_team2 = txtmatch_team2.Text;
                string match_date = txtdate.Text;
                string match_time = txttime.Text;

                OracleConnection oracleConnection1 = new OracleConnection(connstr);
                oracleConnection1.Open();

                string query1 = "insert into SCHEDULE(MATCH_NUMBER,MATCH_TEAM_1,MATCH_TEAM_2,MATCH_DATE,MATCH_TIME)values('" + match_no + "', '" + match_team1 + "', '" + mathc_team2 + "' , '" + match_date + "','" + match_time + "')";

                OracleCommand oracleCommand1 = new OracleCommand();
                oracleCommand1.Connection = oracleConnection1;
                oracleCommand1.CommandText = query1;

                int x = oracleCommand1.ExecuteNonQuery();
                if (x > 0)
                {

                    MessageBox.Show("INFORMATION HAS BEEN INSERTED");

                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter("select * from SCHEDULE", connstr);
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
                string match_no = txtmatch_no.Text;
                string match_team1 = txtmatch_team1.Text;
                string mathc_team2 = txtmatch_team2.Text;
                string match_date = txtdate.Text;
                string match_time = txttime.Text;

                OracleConnection oracleConnection1 = new OracleConnection(connstr);
                oracleConnection1.Open();

                string query1 = "update SCHEDULE set MATCH_NUMBER = '" + match_no + "', MATCH_TEAM_1 = '" + match_team1 + "' , MATCH_TEAM_2 = '" + mathc_team2 + "', MATCH_DATE = '" + match_date + "', MATCH_TIME = '" + match_time + "' where MATCH_NUMBER = '" + match_no + "'";

                OracleCommand oracleCommand1 = new OracleCommand();
                oracleCommand1.Connection = oracleConnection1;
                oracleCommand1.CommandText = query1;

                int x = oracleCommand1.ExecuteNonQuery();
                if (x > 0)
                {

                    MessageBox.Show("INFORMATION HAS BEEN UPDATED");

                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter("select * from SCHEDULE", connstr);
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
                string match_no = txtmatch_no.Text;
                string match_team1 = txtmatch_team1.Text;
                string mathc_team2 = txtmatch_team2.Text;
                string match_date = txtdate.Text;
                string match_time = txttime.Text;

                OracleConnection oracleConnection1 = new OracleConnection(connstr);
                oracleConnection1.Open();

                string query1 = "delete from SCHEDULE where MATCH_NUMBER = '" + match_no + "'"; 

                OracleCommand oracleCommand1 = new OracleCommand();
                oracleCommand1.Connection = oracleConnection1;
                oracleCommand1.CommandText = query1;

                int x = oracleCommand1.ExecuteNonQuery();
                if (x > 0)
                {

                    MessageBox.Show("INFORMATION HAS BEEN DELETED");

                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter("select * from SCHEDULE", connstr);
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
