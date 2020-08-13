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
    public partial class MainForm : Form
    {
     
        public MainForm()
        {
            InitializeComponent();
           
        }
        private string insertBar;
        public string InsertBar  
            {
            get { return insertBar; }
            set { insertBar = value; Label_GearBar.Text = insertBar; }
            }
        
        
        private void GearText_TextChanged(object sender, EventArgs e)
        {
            Label_GearBar.Text = Scraper.GearBar();
            Label_GearBar.Refresh();
        }

        private void Label_Search_Click(object sender, EventArgs e)
        {

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

        private void materialSingleLineTextField1_Click_1(object sender, EventArgs e)
        {

        }

        private void configForm1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void statusForm1_Load(object sender, EventArgs e)
        {

        }

        private void Button_Status_Click(object sender, EventArgs e)
        {

        }

        private void Label_GearBar_Click(object sender, EventArgs e)
        {

        }
    }
}
