using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class LoadUpForm : Form
    {
        public LoadUpForm()
        {
            InitializeComponent();
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.timer2.Enabled = true;
            this.timer2.Interval = 2100;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            this.timer3.Enabled = true;
            this.timer3.Interval = 2200;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loginForm homepage = new loginForm();
            homepage.ShowDialog();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
        }
    }
}
