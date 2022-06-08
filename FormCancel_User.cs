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
    public partial class FormCancel_User : Form
    {
        public FormCancel_User()
        {
            InitializeComponent();
            dataGridView1.Hide();
        }
        string connstr = "data source=localhost:1521/xe;user id=SYSTEM;password=Dell1234;";
        

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            int ticket_id = 0;
            Int32.TryParse(textBox1.Text, out ticket_id);

            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter("select * from TICKETS where TICKET_ID = " + ticket_id + "", connstr);
            DataTable table = new DataTable();
            oracleDataAdapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Show();
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            int ticket_id = 0;
            Int32.TryParse(textBox1.Text, out ticket_id);


            OracleConnection oracleConnection = new OracleConnection(connstr);
            oracleConnection.Open();
            string query = "delete from TICKETS where TICKET_ID = " + ticket_id + "";
            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.Connection = oracleConnection;
            oracleCommand.CommandText = query;
            int cancel = oracleCommand.ExecuteNonQuery();
            MessageBox.Show("Your Ticket has been cancelled");
            oracleConnection.Close();


            this.panel1.Controls.Clear();
            FormHome FormHome_Move = new FormHome { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormHome_Move.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(FormHome_Move);
            FormHome_Move.Show();
        }
    }
}
