using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazingScraper
{
    public partial class Form1 : Form
    {
        Scraper scraper;
        public Form1()
        {
            InitializeComponent();
            this.scraper = new Scraper();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_Go_Click(object sender, EventArgs e)
        {
            if (Button_Go.Enabled)
            {
                Button_Go.Enabled = false;
                Button_Go.Update();
                scraper.Scrape(TxtBox_User.Text, TxtBox_Password.Text, TxtBox_Search.Text);

            }
        }

        private void Label_User_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void TxtBox_Search_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
