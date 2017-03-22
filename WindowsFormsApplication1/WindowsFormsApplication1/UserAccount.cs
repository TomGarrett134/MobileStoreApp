using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class UserAccount
    {
        private string Username;
        private string Password;
        private string eMailAddress;
        private DateTime dateOfBirth;
        private int PaymentDetailsID;
        private int BillID;

        public void setUsername(string user)
        {
            Username = user;
        }

        public string getUsername()
        {
            return Username;
        }

        public void setPassword(string pass)
        {
            Password = pass;
        }

        public string getPassword()
        {
            return Password;
        }

        public void setEMailAddress(string address)
        {
            eMailAddress = address;
        }

        public string getEMailAddress()
        {
            return eMailAddress;
        }

        public void setDateOfBirth(DateTime DoB)
        {
            dateOfBirth = DoB;
        }

        public DateTime getDateofBirth()
        {
            return dateOfBirth;
        }

        public void setBillID(int id)
        {
            BillID = id;
        }

        public int getBillID()
        {
            return BillID;
        }

        public void setPaymentDetailsID(int id)
        {
            PaymentDetailsID = id;
        }

        public int getBPaymentDetailsID()
        {
            return PaymentDetailsID;
        }
    }
}
