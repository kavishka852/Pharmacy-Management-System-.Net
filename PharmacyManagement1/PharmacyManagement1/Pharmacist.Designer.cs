
namespace PharmacyManagement1
{
    partial class Pharmacist
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnlogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnsell = new Guna.UI2.WinForms.Guna2Button();
            this.btncheck = new Guna.UI2.WinForms.Guna2Button();
            this.btnmodify = new Guna.UI2.WinForms.Guna2Button();
            this.btnview = new Guna.UI2.WinForms.Guna2Button();
            this.btnadd = new Guna.UI2.WinForms.Guna2Button();
            this.btndash = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uC_P_MedicineValidityCheck1 = new PharmacyManagement1.PharmacistUC.UC_P_MedicineValidityCheck();
            this.uC_P_Updatemedicine1 = new PharmacyManagement1.PharmacistUC.UC_P_Updatemedicine();
            this.uC_P_ViewMedicines1 = new PharmacyManagement1.PharmacistUC.UC_P_ViewMedicines();
            this.uC_P_AddMedicine1 = new PharmacyManagement1.PharmacistUC.UC_P_AddMedicine();
            this.uC_P_Dashbord1 = new PharmacyManagement1.PharmacistUC.UC_P_Dashbord();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_P_SellMedicine1 = new PharmacyManagement1.PharmacistUC.UC_P_SellMedicine();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnsell);
            this.panel1.Controls.Add(this.btncheck);
            this.panel1.Controls.Add(this.btnmodify);
            this.panel1.Controls.Add(this.btnview);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.btndash);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 769);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(285, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1094, 768);
            this.panel2.TabIndex = 2;
            // 
            // btnlogout
            // 
            this.btnlogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnlogout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnlogout.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnlogout.CheckedState.Parent = this.btnlogout;
            this.btnlogout.CustomImages.Parent = this.btnlogout;
            this.btnlogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnlogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnlogout.HoverState.Parent = this.btnlogout;
            this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
            this.btnlogout.ImageSize = new System.Drawing.Size(30, 30);
            this.btnlogout.Location = new System.Drawing.Point(0, 660);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.ShadowDecoration.Parent = this.btnlogout;
            this.btnlogout.Size = new System.Drawing.Size(279, 45);
            this.btnlogout.TabIndex = 8;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnsell
            // 
            this.btnsell.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnsell.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnsell.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnsell.CheckedState.Parent = this.btnsell;
            this.btnsell.CustomImages.Parent = this.btnsell;
            this.btnsell.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnsell.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsell.ForeColor = System.Drawing.Color.White;
            this.btnsell.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnsell.HoverState.Parent = this.btnsell;
            this.btnsell.Image = ((System.Drawing.Image)(resources.GetObject("btnsell.Image")));
            this.btnsell.ImageSize = new System.Drawing.Size(40, 40);
            this.btnsell.Location = new System.Drawing.Point(0, 605);
            this.btnsell.Name = "btnsell";
            this.btnsell.ShadowDecoration.Parent = this.btnsell;
            this.btnsell.Size = new System.Drawing.Size(282, 45);
            this.btnsell.TabIndex = 7;
            this.btnsell.Text = "Sell Medicine";
            this.btnsell.Click += new System.EventHandler(this.btnsell_Click);
            // 
            // btncheck
            // 
            this.btncheck.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btncheck.CheckedState.FillColor = System.Drawing.Color.White;
            this.btncheck.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btncheck.CheckedState.Parent = this.btncheck;
            this.btncheck.CustomImages.Parent = this.btncheck;
            this.btncheck.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btncheck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.ForeColor = System.Drawing.Color.White;
            this.btncheck.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btncheck.HoverState.Parent = this.btncheck;
            this.btncheck.Image = ((System.Drawing.Image)(resources.GetObject("btncheck.Image")));
            this.btncheck.ImageSize = new System.Drawing.Size(30, 30);
            this.btncheck.Location = new System.Drawing.Point(3, 513);
            this.btncheck.Name = "btncheck";
            this.btncheck.ShadowDecoration.Parent = this.btncheck;
            this.btncheck.Size = new System.Drawing.Size(279, 86);
            this.btncheck.TabIndex = 6;
            this.btncheck.Text = "Medicine Validity Check";
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // btnmodify
            // 
            this.btnmodify.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnmodify.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnmodify.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnmodify.CheckedState.Parent = this.btnmodify;
            this.btnmodify.CustomImages.Parent = this.btnmodify;
            this.btnmodify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnmodify.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodify.ForeColor = System.Drawing.Color.White;
            this.btnmodify.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnmodify.HoverState.Parent = this.btnmodify;
            this.btnmodify.Image = ((System.Drawing.Image)(resources.GetObject("btnmodify.Image")));
            this.btnmodify.ImageSize = new System.Drawing.Size(30, 30);
            this.btnmodify.Location = new System.Drawing.Point(0, 471);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.ShadowDecoration.Parent = this.btnmodify;
            this.btnmodify.Size = new System.Drawing.Size(282, 45);
            this.btnmodify.TabIndex = 5;
            this.btnmodify.Text = "Modify Medicine";
            this.btnmodify.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // btnview
            // 
            this.btnview.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnview.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnview.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnview.CheckedState.Parent = this.btnview;
            this.btnview.CustomImages.Parent = this.btnview;
            this.btnview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnview.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.White;
            this.btnview.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnview.HoverState.Parent = this.btnview;
            this.btnview.Image = ((System.Drawing.Image)(resources.GetObject("btnview.Image")));
            this.btnview.ImageSize = new System.Drawing.Size(30, 30);
            this.btnview.Location = new System.Drawing.Point(0, 394);
            this.btnview.Name = "btnview";
            this.btnview.ShadowDecoration.Parent = this.btnview;
            this.btnview.Size = new System.Drawing.Size(282, 45);
            this.btnview.TabIndex = 4;
            this.btnview.Text = "View Medicine";
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnadd
            // 
            this.btnadd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnadd.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnadd.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnadd.CheckedState.Parent = this.btnadd;
            this.btnadd.CustomImages.Parent = this.btnadd;
            this.btnadd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnadd.HoverState.Parent = this.btnadd;
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnadd.Location = new System.Drawing.Point(0, 333);
            this.btnadd.Name = "btnadd";
            this.btnadd.ShadowDecoration.Parent = this.btnadd;
            this.btnadd.Size = new System.Drawing.Size(282, 45);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "Add Medicine";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndash
            // 
            this.btndash.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btndash.CheckedState.FillColor = System.Drawing.Color.White;
            this.btndash.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btndash.CheckedState.Parent = this.btndash;
            this.btndash.CustomImages.Parent = this.btndash;
            this.btndash.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btndash.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndash.ForeColor = System.Drawing.Color.White;
            this.btndash.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btndash.HoverState.Parent = this.btndash;
            this.btndash.Image = ((System.Drawing.Image)(resources.GetObject("btndash.Image")));
            this.btndash.ImageSize = new System.Drawing.Size(30, 30);
            this.btndash.Location = new System.Drawing.Point(0, 269);
            this.btndash.Name = "btndash";
            this.btndash.ShadowDecoration.Parent = this.btndash;
            this.btndash.Size = new System.Drawing.Size(279, 45);
            this.btndash.TabIndex = 2;
            this.btndash.Text = "Dashboard";
            this.btndash.Click += new System.EventHandler(this.btndash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pharmacist";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.uC_P_SellMedicine1);
            this.panel3.Controls.Add(this.uC_P_MedicineValidityCheck1);
            this.panel3.Controls.Add(this.uC_P_Updatemedicine1);
            this.panel3.Controls.Add(this.uC_P_ViewMedicines1);
            this.panel3.Controls.Add(this.uC_P_AddMedicine1);
            this.panel3.Controls.Add(this.uC_P_Dashbord1);
            this.panel3.Location = new System.Drawing.Point(282, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1097, 769);
            this.panel3.TabIndex = 2;
            // 
            // uC_P_MedicineValidityCheck1
            // 
            this.uC_P_MedicineValidityCheck1.BackColor = System.Drawing.Color.White;
            this.uC_P_MedicineValidityCheck1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_MedicineValidityCheck1.Name = "uC_P_MedicineValidityCheck1";
            this.uC_P_MedicineValidityCheck1.Size = new System.Drawing.Size(1107, 769);
            this.uC_P_MedicineValidityCheck1.TabIndex = 4;
            // 
            // uC_P_Updatemedicine1
            // 
            this.uC_P_Updatemedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_Updatemedicine1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_Updatemedicine1.Name = "uC_P_Updatemedicine1";
            this.uC_P_Updatemedicine1.Size = new System.Drawing.Size(1262, 1005);
            this.uC_P_Updatemedicine1.TabIndex = 3;
            // 
            // uC_P_ViewMedicines1
            // 
            this.uC_P_ViewMedicines1.BackColor = System.Drawing.Color.White;
            this.uC_P_ViewMedicines1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_ViewMedicines1.Name = "uC_P_ViewMedicines1";
            this.uC_P_ViewMedicines1.Size = new System.Drawing.Size(1097, 766);
            this.uC_P_ViewMedicines1.TabIndex = 2;
            // 
            // uC_P_AddMedicine1
            // 
            this.uC_P_AddMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_AddMedicine1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_AddMedicine1.Name = "uC_P_AddMedicine1";
            this.uC_P_AddMedicine1.Size = new System.Drawing.Size(1107, 769);
            this.uC_P_AddMedicine1.TabIndex = 1;
            // 
            // uC_P_Dashbord1
            // 
            this.uC_P_Dashbord1.BackColor = System.Drawing.Color.White;
            this.uC_P_Dashbord1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_Dashbord1.Name = "uC_P_Dashbord1";
            this.uC_P_Dashbord1.Size = new System.Drawing.Size(1107, 769);
            this.uC_P_Dashbord1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel3;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel3;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel3;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel3;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.panel3;
            // 
            // uC_P_SellMedicine1
            // 
            this.uC_P_SellMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_SellMedicine1.Location = new System.Drawing.Point(2, 3);
            this.uC_P_SellMedicine1.Name = "uC_P_SellMedicine1";
            this.uC_P_SellMedicine1.Size = new System.Drawing.Size(1095, 763);
            this.uC_P_SellMedicine1.TabIndex = 5;
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pharmacist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacist";
            this.Load += new System.EventHandler(this.Pharmacist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnlogout;
        private Guna.UI2.WinForms.Guna2Button btnsell;
        private Guna.UI2.WinForms.Guna2Button btncheck;
        private Guna.UI2.WinForms.Guna2Button btnmodify;
        private Guna.UI2.WinForms.Guna2Button btnview;
        private Guna.UI2.WinForms.Guna2Button btnadd;
        private Guna.UI2.WinForms.Guna2Button btndash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private PharmacistUC.UC_P_Dashbord uC_P_Dashbord1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private PharmacistUC.UC_P_AddMedicine uC_P_AddMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private PharmacistUC.UC_P_ViewMedicines uC_P_ViewMedicines1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private PharmacistUC.UC_P_Updatemedicine uC_P_Updatemedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private PharmacistUC.UC_P_MedicineValidityCheck uC_P_MedicineValidityCheck1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private PharmacistUC.UC_P_SellMedicine uC_P_SellMedicine1;
    }
}