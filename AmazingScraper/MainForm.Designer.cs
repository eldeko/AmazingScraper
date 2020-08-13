using System;

namespace AmazingScraper
{
    public partial class MainForm
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

        private string GearText = Scraper.GearBar();

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Button_Go = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_GearBar = new System.Windows.Forms.Label();
            this.PictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.configForm = new AmazingScraper.ConfigForm();
            this.StatusForm = new AmazingScraper.StatusForm();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Go
            // 
            this.Button_Go.Location = new System.Drawing.Point(0, 0);
            this.Button_Go.Name = "Button_Go";
            this.Button_Go.Size = new System.Drawing.Size(75, 23);
            this.Button_Go.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.Label_GearBar);
            this.panel1.Controls.Add(this.PictureBox_Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 111);
            this.panel1.TabIndex = 8;
            // 
            // Label_GearBar
            // 
            this.Label_GearBar.AutoSize = true;
            this.Label_GearBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Label_GearBar.ForeColor = System.Drawing.Color.Chocolate;
            this.Label_GearBar.Location = new System.Drawing.Point(730, 59);
            this.Label_GearBar.Name = "Label_GearBar";
            this.Label_GearBar.Size = new System.Drawing.Size(27, 40);
            this.Label_GearBar.TabIndex = 2;
            this.Label_GearBar.Text = "!";
            this.Label_GearBar.TextChanged += new System.EventHandler(this.GearText_TextChanged);
            this.Label_GearBar.Click += new System.EventHandler(this.Label_GearBar_Click);
            // 
            // PictureBox_Logo
            // 
            this.PictureBox_Logo.Image = global::AmazingScraper.Properties.Resources.ico_fw;
            this.PictureBox_Logo.Location = new System.Drawing.Point(12, 0);
            this.PictureBox_Logo.Name = "PictureBox_Logo";
            this.PictureBox_Logo.Size = new System.Drawing.Size(175, 111);
            this.PictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Logo.TabIndex = 1;
            this.PictureBox_Logo.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // configForm
            // 
            this.configForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configForm.Location = new System.Drawing.Point(0, 111);
            this.configForm.Name = "configForm";
            this.configForm.Size = new System.Drawing.Size(781, 572);
            this.configForm.TabIndex = 10;
            this.configForm.Load += new System.EventHandler(this.configForm1_Load);
            // 
            // StatusForm
            // 
            this.StatusForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusForm.Location = new System.Drawing.Point(0, 0);
            this.StatusForm.Name = "StatusForm";
            this.StatusForm.Size = new System.Drawing.Size(781, 683);
            this.StatusForm.TabIndex = 11;
            this.StatusForm.Load += new System.EventHandler(this.statusForm1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(781, 683);
            this.Controls.Add(this.configForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Button_Go);
            this.Controls.Add(this.StatusForm);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AmazingScraper (TM) - for Anshus";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Logo)).EndInit();
            this.ResumeLayout(false);

        }

       

        #endregion
        private System.Windows.Forms.Button Button_Go;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PictureBox_Logo;
        public ConfigForm configForm;
        public StatusForm StatusForm;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label Label_GearBar;
        
    }
}

