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
        Scraper scraper;
        public ConfigForm()
        {
            InitializeComponent();
            this.scraper = new Scraper();
        }

        private async void Button_Go_Click(object sender, EventArgs e)
        {
            if (Button_Go.Enabled)
            {
                Button_Go.Enabled = false;             
                Button_Go.Update();
                this.Hide();
                await Task.Run(() => scraper.Scrape(TxtBox_User.Text, TxtBox_Password.Text, TxtBox_Search.Text));
                Application.DoEvents();
                Button_Go.Enabled = true;
                Button_Go.Update();
            }
        }

        private void TxtBox_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {

        }
    }
}
