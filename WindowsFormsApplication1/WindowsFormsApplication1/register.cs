using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
       // private Boolean finished;
        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox8.Text;
            String fName = textBox1.Text;
            String sName = textBox2.Text;
            String fullname = fName + " " + sName;
            String uPass = textBox3.Text;
            String passCheck = textBox4.Text;
            String uEmail = textBox5.Text;
            String uDOB = textBox6.Text;
            long uCInfo = Convert.ToInt64(textBox7.Text);
            String uAddress = textBox9.Text;
            long uCardNo = Convert.ToInt64(textBox10.Text);
            if (uPass.Equals(passCheck))
            {
                DBConnection dBC = DBConnection.getInstance(); 
                dBC.addUserDetails(username, uPass, fullname, uEmail, uDOB, uCInfo, uAddress, uCardNo);
            }
            else
            {
              MessageBox.Show("The passwords do not match, please enter the same password in both textboxes");
            }
            DialogResult r =MessageBox.Show("Your account has been created successfully");
            Console.WriteLine("a?");
            if (r == DialogResult.OK)
            {
                this.Close();
               // finished = true;
              //  Console.WriteLine("enter>?");
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
//public Boolean getResult() 
      //  {
          //  return finished;
       // }
    }
}
