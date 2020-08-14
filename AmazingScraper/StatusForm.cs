using AmazingScraper.Helpers;
using System;
using System.Windows.Forms;

namespace AmazingScraper
{
    public partial class StatusForm : UserControl
    {       
        public StatusForm()
        {
            InitializeComponent();            
        }

        private void Gear_Click(object sender, EventArgs e)
        {

        }    

        private void StatusForm_Load(object sender, EventArgs e)
        {
            Console.SetOut(new TextBoxWriter(txtConsole));
            Console.WriteLine("Amazing Scraper 0.9a");
        }

        private void Panel_Status_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Gear_Click_1(object sender, EventArgs e)
        {

        }

        private void txtConsole_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConsole_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
