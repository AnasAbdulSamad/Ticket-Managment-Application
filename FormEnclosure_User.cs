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
    public partial class FormEnclosure_User : Form
    {
        public FormEnclosure_User()
        {
            InitializeComponent();
            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter("select * from ENCLOSURE", connstr);
            DataTable table = new DataTable();
            oracleDataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        string connstr = "data source=localhost:1521/xe;user id=SYSTEM;password=Dell1234;";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
