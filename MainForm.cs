using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OracleClient;

namespace DesignTutorial
{
    //Creating the borders of main screen
    public partial class MainForm : Form
    {
        public int check;
        

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
                 int nHeightEllipse

          );
        public MainForm(String admin_check)
        {
            //Borders of main screen
            InitializeComponent();
            

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            
            PanelNav.Height = btnAdmin.Height;
            PanelNav.Top = btnAdmin.Top;
            PanelNav.Left = btnAdmin.Left;
            btnAdmin.BackColor = Color.FromArgb(46, 51, 73);

            check = 1;
            if ( admin_check == "admin") 
            {
                check = 2;
                btnBook.Text = "Ticket Information";
                btnCancel.Hide();
                btnEnclosure.Text = "Enclosure Info";
                btnSchedule.Text = "Schedule Info";
                btnFees.Show();
                btnAdmin.Text = "Logout";
                
            }

            if ( admin_check != "admin")
            {
                check = 1;
                btnBook.Text = "Book Ticket";
                btnCancel.Show();
                btnEnclosure.Text = "Enclosures";
                btnSchedule.Text = "Schedule";
                btnFees.Hide();
                btnAdmin.Text = "Login as Admin";
                

            }
        }
        


        private void btnBook_Click(object sender, EventArgs e)
        {
            

            PanelNav.Height = btnBook.Height;
            PanelNav.Top = btnBook.Top;
            btnBook.BackColor = Color.FromArgb(46, 51, 73);

            

            if (check == 1)
            {
               

                this.PanelMain.Controls.Clear();
                FormBook_User FormBook_Move = new FormBook_User { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                FormBook_Move.FormBorderStyle = FormBorderStyle.None;
                this.PanelMain.Controls.Add(FormBook_Move);
                FormBook_Move.Show();

            }

            if (check == 2)
            {
                this.PanelMain.Controls.Clear();
                FormTicket_Admin FormTicket_Move = new FormTicket_Admin { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                FormTicket_Move.FormBorderStyle = FormBorderStyle.None;
                this.PanelMain.Controls.Add(FormTicket_Move);
                FormTicket_Move.Show();
            }
            


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PanelNav.Height = btnCancel.Height;
            PanelNav.Top = btnCancel.Top;
            btnCancel.BackColor = Color.FromArgb(46, 51, 73);

           

            this.PanelMain.Controls.Clear();
            FormCancel_User FormCancel_Move = new FormCancel_User { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormCancel_Move.FormBorderStyle = FormBorderStyle.None;
            this.PanelMain.Controls.Add(FormCancel_Move);
            FormCancel_Move.Show();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            PanelNav.Height = btnSchedule.Height;
            PanelNav.Top = btnSchedule.Top;
            btnSchedule.BackColor = Color.FromArgb(46, 51, 73);

          
            if (check == 1)
            {
                this.PanelMain.Controls.Clear();
                FormSchedule_User FormSchedule_Move = new FormSchedule_User { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                FormSchedule_Move.FormBorderStyle = FormBorderStyle.None;
                this.PanelMain.Controls.Add(FormSchedule_Move);
                FormSchedule_Move.Show();
            }
            
            if (check == 2)
            {
                this.PanelMain.Controls.Clear();
                FormSchedule_Admin FormSchedule_Move = new FormSchedule_Admin { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                FormSchedule_Move.FormBorderStyle = FormBorderStyle.None;
                this.PanelMain.Controls.Add(FormSchedule_Move);
                FormSchedule_Move.Show();
            }
        }

        

        private void btnEnclosure_Click(object sender, EventArgs e)
        {
            PanelNav.Height = btnEnclosure.Height;
            PanelNav.Top = btnEnclosure.Top;
            btnEnclosure.BackColor = Color.FromArgb(46, 51, 73);

          
            if (check == 1)
            {
                this.PanelMain.Controls.Clear();
                FormEnclosure_User FormEnclosure_Move = new FormEnclosure_User { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                FormEnclosure_Move.FormBorderStyle = FormBorderStyle.None;
                this.PanelMain.Controls.Add(FormEnclosure_Move);
                FormEnclosure_Move.Show();
            }
            
            if (check == 2)
            {
                this.PanelMain.Controls.Clear();
                FormEnclosure_Admin FormEnclosure_Move = new FormEnclosure_Admin { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                FormEnclosure_Move.FormBorderStyle = FormBorderStyle.None;
                this.PanelMain.Controls.Add(FormEnclosure_Move);
                FormEnclosure_Move.Show();
            }
        }

        private void btnBook_Leave(object sender, EventArgs e)
        {
            btnBook.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCancel_Leave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSchedule_Leave(object sender, EventArgs e)
        {
            btnSchedule.BackColor = Color.FromArgb(24, 30, 54);
        }

        

        private void btnEnclosure_Leave(object sender, EventArgs e)
        {
            btnEnclosure.BackColor = Color.FromArgb(24, 30, 54); 
        }

        private void btnFees_Click(object sender, EventArgs e)
        {
            PanelNav.Height = btnFees.Height;
            PanelNav.Top = btnFees.Top;
            btnFees.BackColor = Color.FromArgb(46, 51, 73);

            if (check == 2)
            {
                this.PanelMain.Controls.Clear();
                FormFees_Admin FormFees_Move = new FormFees_Admin { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                FormFees_Move.FormBorderStyle = FormBorderStyle.None;
                this.PanelMain.Controls.Add(FormFees_Move);
                FormFees_Move.Show();
            }



            
        }

        private void btnFees_Leave(object sender, EventArgs e)
        {
            btnFees.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            PanelNav.Height = btnAdmin.Height;
            PanelNav.Top = btnAdmin.Top;
            PanelNav.Left = btnAdmin.Left;
            btnAdmin.BackColor = Color.FromArgb(46, 51, 73);

            if ( check == 2)
            {
                MainForm Form = new MainForm("user");
                Form.Show();
                this.Hide();
            }

          

            this.PanelMain.Controls.Clear();
            FormAdmin FormAdmin_Move = new FormAdmin { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormAdmin_Move.FormBorderStyle = FormBorderStyle.None;
            this.PanelMain.Controls.Add(FormAdmin_Move);
            FormAdmin_Move.Show();
        }

        private void btnAdmin_Leave(object sender, EventArgs e)
        {
            btnAdmin.BackColor = Color.FromArgb(24, 30, 54);
        }

        
        
        private void btnHome_Click(object sender, EventArgs e)
        {
            PanelNav.Height = btnHome.Height;
            PanelNav.Top = btnHome.Top;
            btnHome.BackColor = Color.FromArgb(46, 51, 73);

         

            this.PanelMain.Controls.Clear();
            FormHome FormHome_Move = new FormHome { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormHome_Move.FormBorderStyle = FormBorderStyle.None;
            this.PanelMain.Controls.Add(FormHome_Move);
            FormHome_Move.Show();
        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
