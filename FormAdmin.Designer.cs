
namespace DesignTutorial
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.text_username = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.button_woc1 = new ePOSOne.btnProduct.Button_WOC();
            this.label_userpass_check = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(293, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // text_username
            // 
            this.text_username.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.text_username.ForeColor = System.Drawing.SystemColors.GrayText;
            this.text_username.Location = new System.Drawing.Point(217, 207);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(319, 23);
            this.text_username.TabIndex = 2;
            this.text_username.Text = "Username";
            // 
            // text_password
            // 
            this.text_password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.text_password.ForeColor = System.Drawing.SystemColors.GrayText;
            this.text_password.Location = new System.Drawing.Point(217, 236);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(319, 23);
            this.text_password.TabIndex = 3;
            this.text_password.Text = "Password\r\n";
            this.text_password.UseSystemPasswordChar = true;
            // 
            // button_woc1
            // 
            this.button_woc1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            this.button_woc1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            this.button_woc1.FlatAppearance.BorderSize = 0;
            this.button_woc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_woc1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_woc1.Location = new System.Drawing.Point(217, 293);
            this.button_woc1.Name = "button_woc1";
            this.button_woc1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_woc1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(176)))), ((int)(((byte)(193)))));
            this.button_woc1.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_woc1.Size = new System.Drawing.Size(319, 25);
            this.button_woc1.TabIndex = 4;
            this.button_woc1.Text = "Login";
            this.button_woc1.TextColor = System.Drawing.Color.Black;
            this.button_woc1.UseVisualStyleBackColor = true;
            this.button_woc1.Click += new System.EventHandler(this.button_woc1_Click);
            // 
            // label_userpass_check
            // 
            this.label_userpass_check.AutoSize = true;
            this.label_userpass_check.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_userpass_check.ForeColor = System.Drawing.Color.Red;
            this.label_userpass_check.Location = new System.Drawing.Point(338, 262);
            this.label_userpass_check.Name = "label_userpass_check";
            this.label_userpass_check.Size = new System.Drawing.Size(198, 17);
            this.label_userpass_check.TabIndex = 5;
            this.label_userpass_check.Text = "Incorrect username or password";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(712, 418);
            this.Controls.Add(this.label_userpass_check);
            this.Controls.Add(this.button_woc1);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_username);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox text_username;
        private System.Windows.Forms.TextBox text_password;
        private ePOSOne.btnProduct.Button_WOC button_woc1;
        private System.Windows.Forms.Label label_userpass_check;
    }
}