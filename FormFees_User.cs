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
    public partial class FormFees_User : Form
    {
        
        public FormFees_User()
        {
            InitializeComponent();
            label2.Hide();

            StreamReader streamReader1 = new StreamReader(Application.StartupPath + "\\TICKET\\" + "ticket_identity.txt");
            string ticket_id = streamReader1.ReadToEnd();
            streamReader1.Close();

            label2.Text = ticket_id;
            label2.Show();

            int ticket_updated = 0;
            Int32.TryParse(ticket_id, out ticket_updated);
            
            ticket_updated += 1;
            
            StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\TICKET\\" + "ticket_identity.txt");
            streamWriter.WriteLine(ticket_updated);
            streamWriter.Close();

            StreamReader streamReader2 = new StreamReader(Application.StartupPath + "\\FEES\\" + "total_fees.txt");
            string total_fees = streamReader2.ReadToEnd();
            streamReader2.Close();
            label3.Text = "Your bill is Rs." + total_fees;

        }
        

        

        

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            FormHome Form = new FormHome();
            Form.StartPosition = FormStartPosition.Manual;
            Form.Location = new Point(434, 216);
            Form.Show();
            this.Hide();
        }
    }
}
