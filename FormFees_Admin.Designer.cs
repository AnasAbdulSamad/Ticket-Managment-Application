
namespace DesignTutorial
{
    partial class FormFees_Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotal_fees = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtenclosure_fees = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfees_no = new System.Windows.Forms.TextBox();
            this.btn_delete = new ePOSOne.btnProduct.Button_WOC();
            this.btn_update = new ePOSOne.btnProduct.Button_WOC();
            this.btn_add = new ePOSOne.btnProduct.Button_WOC();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txttotal_fees);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtenclosure_fees);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txttax);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtfees_no);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 393);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(7, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Total Fees:";
            // 
            // txttotal_fees
            // 
            this.txttotal_fees.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txttotal_fees.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txttotal_fees.Location = new System.Drawing.Point(7, 260);
            this.txttotal_fees.Name = "txttotal_fees";
            this.txttotal_fees.Size = new System.Drawing.Size(252, 23);
            this.txttotal_fees.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(7, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Enclosure Fees:";
            // 
            // txtenclosure_fees
            // 
            this.txtenclosure_fees.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtenclosure_fees.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtenclosure_fees.Location = new System.Drawing.Point(7, 193);
            this.txtenclosure_fees.Name = "txtenclosure_fees";
            this.txtenclosure_fees.Size = new System.Drawing.Size(252, 23);
            this.txtenclosure_fees.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(7, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tax:";
            // 
            // txttax
            // 
            this.txttax.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txttax.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txttax.Location = new System.Drawing.Point(7, 124);
            this.txttax.Name = "txttax";
            this.txttax.Size = new System.Drawing.Size(252, 23);
            this.txttax.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fees Number:";
            // 
            // txtfees_no
            // 
            this.txtfees_no.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtfees_no.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtfees_no.Location = new System.Drawing.Point(7, 58);
            this.txtfees_no.Name = "txtfees_no";
            this.txtfees_no.Size = new System.Drawing.Size(252, 23);
            this.txtfees_no.TabIndex = 14;
            // 
            // btn_delete
            // 
            this.btn_delete.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_delete.ButtonColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.Location = new System.Drawing.Point(179, 324);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.OnHoverBorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delete.OnHoverButtonColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delete.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delete.Size = new System.Drawing.Size(80, 28);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_update.ButtonColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_update.Location = new System.Drawing.Point(93, 324);
            this.btn_update.Name = "btn_update";
            this.btn_update.OnHoverBorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_update.OnHoverButtonColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_update.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_update.Size = new System.Drawing.Size(80, 28);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "Update";
            this.btn_update.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_add.ButtonColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(7, 324);
            this.btn_add.Name = "btn_add";
            this.btn_add.OnHoverBorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_add.OnHoverButtonColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_add.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add.Size = new System.Drawing.Size(80, 28);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Add";
            this.btn_add.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(288, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(412, 394);
            this.dataGridView1.TabIndex = 3;
            // 
            // FormFees_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(712, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFees_Admin";
            this.Text = "FormFees_Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttotal_fees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtenclosure_fees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfees_no;
        private ePOSOne.btnProduct.Button_WOC btn_delete;
        private ePOSOne.btnProduct.Button_WOC btn_update;
        private ePOSOne.btnProduct.Button_WOC btn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}