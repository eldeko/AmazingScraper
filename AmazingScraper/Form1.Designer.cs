namespace AmazingScraper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label_Search = new MaterialSkin.Controls.MaterialLabel();
            this.Button_Go = new System.Windows.Forms.Button();
            this.Label_User = new MaterialSkin.Controls.MaterialLabel();
            this.Label_password = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBox_User = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtBox_Password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtBox_Search = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label_Search
            // 
            this.Label_Search.AccessibleName = "";
            this.Label_Search.AutoSize = true;
            this.Label_Search.Depth = 0;
            this.Label_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Label_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Search.Location = new System.Drawing.Point(65, 283);
            this.Label_Search.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_Search.Name = "Label_Search";
            this.Label_Search.Size = new System.Drawing.Size(82, 20);
            this.Label_Search.TabIndex = 1;
            this.Label_Search.Text = "Búsqueda";
            this.Label_Search.Click += new System.EventHandler(this.label1_Click);
            // 
            // Button_Go
            // 
            this.Button_Go.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Go.Location = new System.Drawing.Point(308, 615);
            this.Button_Go.Name = "Button_Go";
            this.Button_Go.Size = new System.Drawing.Size(183, 58);
            this.Button_Go.TabIndex = 2;
            this.Button_Go.Text = "Scrape!";
            this.Button_Go.UseVisualStyleBackColor = true;
            this.Button_Go.Click += new System.EventHandler(this.Button_Go_Click);
            // 
            // Label_User
            // 
            this.Label_User.AutoSize = true;
            this.Label_User.Depth = 0;
            this.Label_User.Font = new System.Drawing.Font("Arial", 8F);
            this.Label_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_User.Location = new System.Drawing.Point(65, 45);
            this.Label_User.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_User.Name = "Label_User";
            this.Label_User.Size = new System.Drawing.Size(62, 18);
            this.Label_User.TabIndex = 3;
            this.Label_User.Text = "Usuario";
            this.Label_User.Click += new System.EventHandler(this.Label_User_Click);
            // 
            // Label_password
            // 
            this.Label_password.AutoSize = true;
            this.Label_password.Depth = 0;
            this.Label_password.Font = new System.Drawing.Font("Microsoft Yi Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_password.Location = new System.Drawing.Point(65, 168);
            this.Label_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_password.Name = "Label_password";
            this.Label_password.Size = new System.Drawing.Size(84, 20);
            this.Label_password.TabIndex = 4;
            this.Label_password.Text = "Contraseña";
            // 
            // TxtBox_User
            // 
            this.TxtBox_User.Depth = 0;
            this.TxtBox_User.Hint = "";
            this.TxtBox_User.Location = new System.Drawing.Point(70, 82);
            this.TxtBox_User.MaxLength = 32767;
            this.TxtBox_User.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBox_User.Name = "TxtBox_User";
            this.TxtBox_User.PasswordChar = '\0';
            this.TxtBox_User.SelectedText = "";
            this.TxtBox_User.SelectionLength = 0;
            this.TxtBox_User.SelectionStart = 0;
            this.TxtBox_User.Size = new System.Drawing.Size(421, 32);
            this.TxtBox_User.TabIndex = 5;
            this.TxtBox_User.TabStop = false;
            this.TxtBox_User.UseSystemPasswordChar = false;
            // 
            // TxtBox_Password
            // 
            this.TxtBox_Password.Depth = 0;
            this.TxtBox_Password.Hint = "";
            this.TxtBox_Password.Location = new System.Drawing.Point(70, 205);
            this.TxtBox_Password.MaxLength = 32767;
            this.TxtBox_Password.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBox_Password.Name = "TxtBox_Password";
            this.TxtBox_Password.PasswordChar = '\0';
            this.TxtBox_Password.SelectedText = "";
            this.TxtBox_Password.SelectionLength = 0;
            this.TxtBox_Password.SelectionStart = 0;
            this.TxtBox_Password.Size = new System.Drawing.Size(421, 32);
            this.TxtBox_Password.TabIndex = 6;
            this.TxtBox_Password.TabStop = false;
            this.TxtBox_Password.UseSystemPasswordChar = true;
            // 
            // TxtBox_Search
            // 
            this.TxtBox_Search.Location = new System.Drawing.Point(70, 313);
            this.TxtBox_Search.Multiline = true;
            this.TxtBox_Search.Name = "TxtBox_Search";
            this.TxtBox_Search.Size = new System.Drawing.Size(697, 296);
            this.TxtBox_Search.TabIndex = 7;
            this.TxtBox_Search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 683);
            this.Controls.Add(this.TxtBox_Search);
            this.Controls.Add(this.TxtBox_Password);
            this.Controls.Add(this.TxtBox_User);
            this.Controls.Add(this.Label_password);
            this.Controls.Add(this.Label_User);
            this.Controls.Add(this.Button_Go);
            this.Controls.Add(this.Label_Search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AmazingScraper (TM) - for Anshus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel Label_Search;
        private System.Windows.Forms.Button Button_Go;
        private MaterialSkin.Controls.MaterialLabel Label_User;
        private MaterialSkin.Controls.MaterialLabel Label_password;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBox_User;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBox_Password;
        private System.Windows.Forms.TextBox TxtBox_Search;
    }
}

