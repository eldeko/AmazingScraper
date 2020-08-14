using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazingScraper
{
    public partial class ConfigForm : UserControl
    {
        
        public ConfigForm()
        {
            InitializeComponent();
                
        }    

        //private async void Button_Go_Click(object sender, EventArgs e)
        //{
        //    if (Button_Go.Enabled)
        //    {
        //        Button_Go.Enabled = false;
        //        Button_Go.Text = "...";
        //        Button_Go.Update();
        //        this.Hide();
        //        mainForm = new MainForm();
        //        mainForm.Button_Back.Enabled = true;
        //        await Task.Run(() => scraper.Scrape(TxtBox_User.Text, TxtBox_Password.Text, TxtBox_Search.Text));
        //        Application.DoEvents();
        //        Button_Go.Enabled = true;
        //        Button_Go.Text = "COMENZAR";
        //        Button_Go.Update();
                
        //    }
        //}

        private void TxtBox_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
