namespace AmazingScraper
{
    partial class ConfigForm
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



        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtBox_Password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtBox_User = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtBox_Search = new System.Windows.Forms.TextBox();
            this.Button_Go = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBox_Password
            // 
            this.TxtBox_Password.Depth = 0;
            this.TxtBox_Password.Hint = "";
            this.TxtBox_Password.Location = new System.Drawing.Point(110, 140);
            this.TxtBox_Password.MaxLength = 32767;
            this.TxtBox_Password.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBox_Password.Name = "TxtBox_Password";
            this.TxtBox_Password.PasswordChar = '\0';
            this.TxtBox_Password.SelectedText = "";
            this.TxtBox_Password.SelectionLength = 0;
            this.TxtBox_Password.SelectionStart = 0;
            this.TxtBox_Password.Size = new System.Drawing.Size(524, 32);
            this.TxtBox_Password.TabIndex = 10;
            this.TxtBox_Password.TabStop = false;
            this.TxtBox_Password.UseSystemPasswordChar = true;
            // 
            // TxtBox_User
            // 
            this.TxtBox_User.AccessibleName = "Usuario";
            this.TxtBox_User.Depth = 0;
            this.TxtBox_User.Hint = "";
            this.TxtBox_User.Location = new System.Drawing.Point(110, 56);
            this.TxtBox_User.MaxLength = 32767;
            this.TxtBox_User.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBox_User.Name = "TxtBox_User";
            this.TxtBox_User.PasswordChar = '\0';
            this.TxtBox_User.SelectedText = "";
            this.TxtBox_User.SelectionLength = 0;
            this.TxtBox_User.SelectionStart = 0;
            this.TxtBox_User.Size = new System.Drawing.Size(524, 32);
            this.TxtBox_User.TabIndex = 9;
            this.TxtBox_User.TabStop = false;
            this.TxtBox_User.UseSystemPasswordChar = false;
            // 
            // TxtBox_Search
            // 
            this.TxtBox_Search.Location = new System.Drawing.Point(20, 281);
            this.TxtBox_Search.Multiline = true;
            this.TxtBox_Search.Name = "TxtBox_Search";
            this.TxtBox_Search.Size = new System.Drawing.Size(731, 206);
            this.TxtBox_Search.TabIndex = 12;
            this.TxtBox_Search.TextChanged += new System.EventHandler(this.TxtBox_Search_TextChanged);
            // 
            // Button_Go
            // 
            this.Button_Go.AutoSize = true;
            this.Button_Go.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_Go.Depth = 0;
            this.Button_Go.Icon = null;
            this.Button_Go.Location = new System.Drawing.Point(617, 502);
            this.Button_Go.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Go.Name = "Button_Go";
            this.Button_Go.Primary = true;
            this.Button_Go.Size = new System.Drawing.Size(134, 36);
            this.Button_Go.TabIndex = 13;
            this.Button_Go.Text = "COMENZAR";
            this.Button_Go.UseVisualStyleBackColor = true;
            this.Button_Go.Click += new System.EventHandler(this.Button_Go_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AmazingScraper.Properties.Resources.search_12_128;
            this.pictureBox3.Location = new System.Drawing.Point(691, 245);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AmazingScraper.Properties.Resources.llave;
            this.pictureBox2.Location = new System.Drawing.Point(48, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AmazingScraper.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(48, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Button_Go);
            this.Controls.Add(this.TxtBox_Search);
            this.Controls.Add(this.TxtBox_Password);
            this.Controls.Add(this.TxtBox_User);
            this.Name = "ConfigForm";
            this.Size = new System.Drawing.Size(767, 568);
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBox_Password;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBox_User;
        private System.Windows.Forms.TextBox TxtBox_Search;
        private MaterialSkin.Controls.MaterialRaisedButton Button_Go;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
