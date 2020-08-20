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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Panel_Top = new System.Windows.Forms.Panel();
            this.Label_GearBar = new System.Windows.Forms.Label();
            this.Button_Big = new System.Windows.Forms.Button();
            this.StatusForm = new AmazingScraper.StatusForm();
            this.configForm = new AmazingScraper.ConfigForm();
            this.Pic_CsvOpts = new System.Windows.Forms.PictureBox();
            this.PictureBox_ShowBrowser = new System.Windows.Forms.PictureBox();
            this.Button_Forward = new System.Windows.Forms.PictureBox();
            this.Button_Back = new System.Windows.Forms.PictureBox();
            this.PictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.Panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_CsvOpts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ShowBrowser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Forward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Top
            // 
            this.Panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Panel_Top.Controls.Add(this.Pic_CsvOpts);
            this.Panel_Top.Controls.Add(this.PictureBox_ShowBrowser);
            this.Panel_Top.Controls.Add(this.Button_Forward);
            this.Panel_Top.Controls.Add(this.Button_Back);
            this.Panel_Top.Controls.Add(this.Label_GearBar);
            this.Panel_Top.Controls.Add(this.PictureBox_Logo);
            this.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top.Location = new System.Drawing.Point(0, 0);
            this.Panel_Top.Name = "Panel_Top";
            this.Panel_Top.Size = new System.Drawing.Size(781, 111);
            this.Panel_Top.TabIndex = 8;
            // 
            // Label_GearBar
            // 
            this.Label_GearBar.AutoSize = true;
            this.Label_GearBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Label_GearBar.ForeColor = System.Drawing.Color.Chocolate;
            this.Label_GearBar.Location = new System.Drawing.Point(730, 59);
            this.Label_GearBar.Name = "Label_GearBar";
            this.Label_GearBar.Size = new System.Drawing.Size(41, 40);
            this.Label_GearBar.TabIndex = 2;
            this.Label_GearBar.Text = "--";
            this.Label_GearBar.TextChanged += new System.EventHandler(this.GearText_TextChanged);
            this.Label_GearBar.Click += new System.EventHandler(this.Label_GearBar_Click);
            // 
            // Button_Big
            // 
            this.Button_Big.BackColor = System.Drawing.Color.Green;
            this.Button_Big.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Button_Big.ForeColor = System.Drawing.Color.MintCream;
            this.Button_Big.Location = new System.Drawing.Point(0, 625);
            this.Button_Big.Name = "Button_Big";
            this.Button_Big.Size = new System.Drawing.Size(781, 58);
            this.Button_Big.TabIndex = 12;
            this.Button_Big.Text = "COMENZAR";
            this.Button_Big.UseVisualStyleBackColor = false;
            this.Button_Big.Click += new System.EventHandler(this.Button_Big_Click);
            // 
            // StatusForm
            // 
            this.StatusForm.Location = new System.Drawing.Point(12, 117);
            this.StatusForm.Name = "StatusForm";
            this.StatusForm.Size = new System.Drawing.Size(757, 502);
            this.StatusForm.TabIndex = 14;
            this.StatusForm.Load += new System.EventHandler(this.statusForm1_Load_1);
            // 
            // configForm
            // 
            this.configForm.Location = new System.Drawing.Point(0, 117);
            this.configForm.Name = "configForm";
            this.configForm.Size = new System.Drawing.Size(781, 502);
            this.configForm.TabIndex = 13;
            this.configForm.Load += new System.EventHandler(this.configForm_Load);
            // 
            // Pic_CsvOpts
            // 
            this.Pic_CsvOpts.Image = global::AmazingScraper.Properties.Resources.MultiCSV;
            this.Pic_CsvOpts.Location = new System.Drawing.Point(428, 17);
            this.Pic_CsvOpts.Name = "Pic_CsvOpts";
            this.Pic_CsvOpts.Size = new System.Drawing.Size(78, 82);
            this.Pic_CsvOpts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_CsvOpts.TabIndex = 6;
            this.Pic_CsvOpts.TabStop = false;
            this.Pic_CsvOpts.Click += new System.EventHandler(this.Pic_CsvOpts_Click);
            // 
            // PictureBox_ShowBrowser
            // 
            this.PictureBox_ShowBrowser.Image = global::AmazingScraper.Properties.Resources.blind_chrome_fw;
            this.PictureBox_ShowBrowser.Location = new System.Drawing.Point(354, 37);
            this.PictureBox_ShowBrowser.Name = "PictureBox_ShowBrowser";
            this.PictureBox_ShowBrowser.Size = new System.Drawing.Size(53, 50);
            this.PictureBox_ShowBrowser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_ShowBrowser.TabIndex = 5;
            this.PictureBox_ShowBrowser.TabStop = false;
            this.PictureBox_ShowBrowser.Click += new System.EventHandler(this.pictureBox_ShowBrowser_Click);
            // 
            // Button_Forward
            // 
            this.Button_Forward.Image = global::AmazingScraper.Properties.Resources.ToRight;
            this.Button_Forward.Location = new System.Drawing.Point(606, 37);
            this.Button_Forward.Name = "Button_Forward";
            this.Button_Forward.Size = new System.Drawing.Size(63, 62);
            this.Button_Forward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Button_Forward.TabIndex = 4;
            this.Button_Forward.TabStop = false;
            this.Button_Forward.Click += new System.EventHandler(this.Button_Forward_Click);
            // 
            // Button_Back
            // 
            this.Button_Back.Image = global::AmazingScraper.Properties.Resources.ToLeft;
            this.Button_Back.Location = new System.Drawing.Point(537, 37);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(63, 62);
            this.Button_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Button_Back.TabIndex = 3;
            this.Button_Back.TabStop = false;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(781, 683);
            this.Controls.Add(this.configForm);
            this.Controls.Add(this.Button_Big);
            this.Controls.Add(this.Panel_Top);
            this.Controls.Add(this.StatusForm);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AmazingScraper (TM) - for Anshus";
            this.TopMost = true;
            this.Panel_Top.ResumeLayout(false);
            this.Panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_CsvOpts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ShowBrowser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Forward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Logo)).EndInit();
            this.ResumeLayout(false);

        }

       

        #endregion
        private System.Windows.Forms.Panel Panel_Top;
        private System.Windows.Forms.PictureBox PictureBox_Logo;
        private System.Windows.Forms.Label Label_GearBar;
        public System.Windows.Forms.PictureBox Button_Forward;
        public System.Windows.Forms.PictureBox Button_Back;
        private System.Windows.Forms.Button Button_Big;
        private ConfigForm configForm;
        private StatusForm StatusForm;
        private System.Windows.Forms.PictureBox PictureBox_ShowBrowser;
        private System.Windows.Forms.PictureBox Pic_CsvOpts;
    }
}

