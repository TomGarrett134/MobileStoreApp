using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://facebook.com/");
            Process.Start(sInfo);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://twitter.com/");
            Process.Start(sInfo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeForm homepage = new HomeForm();
            this.Hide();
            homepage.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            register registerPanel = new register();
            registerPanel.ShowDialog();
        }
    }
}
