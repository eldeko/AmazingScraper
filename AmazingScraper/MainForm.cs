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
         Scraper scraper;

        public MainForm()
        {
            InitializeComponent();
            scraper = new Scraper();            
        }
        
        
        private string insertBar;
        private bool showChrome = false;
        public string InsertBar  
        {
            get { return insertBar; }
            set { insertBar = value; Label_GearBar.Text = insertBar; }
        }
        
        public void Button_Back_Enable()
        {
            Button_Back.Enabled = true;
        }

        public void Button_Back_Disable()
        {
            Button_Back.Enabled = false;
        }

        private void GearText_TextChanged(object sender, EventArgs e)
        {
            Label_GearBar.Text = insertBar;
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

        private void TxtBox_Search_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void configForm1_Load(object sender, EventArgs e)
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

        private void Button_Back_Click(object sender, EventArgs e)
        {
            configForm.Visible = true;
            StatusForm.Visible = false;           
        }

        private void Button_Forward_Click(object sender, EventArgs e)
        {
            configForm.Visible = false;
            StatusForm.Visible = true;           
        }

        private void statusForm1_Load_1(object sender, EventArgs e)
        {

        }

        private void configForm_Load(object sender, EventArgs e)
        {

        }

        private async void Button_Big_Click(object sender, EventArgs e)
        {
            if (Button_Big.Text == "COMENZAR")
            {
                PictureBox_ShowBrowser.Enabled = false;
                Button_Big.Text = "CANCELAR";
                Button_Big.BackColor = Color.FromArgb(255, Color.DarkRed);

                configForm.TxtBox_User.Enabled = false;
                configForm.TxtBox_Password.Enabled = false;
                configForm.Hide();
                StatusForm.Show();

                await Task.Run(() => scraper.Scrape(configForm.TxtBox_User.Text, configForm.TxtBox_Password.Text, configForm.TxtBox_Search.Text, showChrome));
                Application.DoEvents();

                Button_Big.BackColor = Color.Green;
                Button_Big.Enabled = true;
                Button_Big.Text = "COMENZAR";
                PictureBox_ShowBrowser.Enabled = true;
                configForm.TxtBox_User.Enabled = true;
                configForm.TxtBox_Password.Enabled = true;
            }

            if (Button_Big.Text == "CANCELAR")
            {
                Button_Big.Enabled = false;
                Console.WriteLine("Se envió señal de cancelación");
                Scraper.GreenLight = false;
                Button_Big.BackColor = Color.FromArgb(100, Color.DarkRed);

            }
        }
        private void Icon_Amazing_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox_ShowBrowser_Click(object sender, EventArgs e)
        {
            if (showChrome == false)
            {
                showChrome = true;
                PictureBox_ShowBrowser.Image = AmazingScraper.Properties.Resources.good_chrome_fw;
                PictureBox_ShowBrowser.Refresh();
                return;
            }

            if (showChrome == true)
            {
                showChrome = false;
                PictureBox_ShowBrowser.Image = AmazingScraper.Properties.Resources.blind_chrome_fw;
                PictureBox_ShowBrowser.Refresh();
                return;           
            }

            PictureBox_ShowBrowser.Refresh();

        }
    }
}
