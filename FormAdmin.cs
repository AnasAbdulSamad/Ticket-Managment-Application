using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignTutorial
{
    public partial class FormAdmin : Form
    {


        public FormAdmin()
        {
            InitializeComponent();
            label_userpass_check.Hide();
        }

        

        private void button_woc1_Click(object sender, EventArgs e)
        {
            if ( text_username.Text == "admin" && text_password.Text == "admin" )  
            {
                MainForm Form = new MainForm("admin");
                Form.Show();
                this.Hide();
            }
            else
            {
                label_userpass_check.Show();
            }
        }
    }
}
