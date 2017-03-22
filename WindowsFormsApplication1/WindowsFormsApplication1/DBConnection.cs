using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class DBConnection
    {
        private static DBConnection instance = null;
        String connString;
        OleDbConnection myConnection;

        private DBConnection()
        {
            connString = @"Provider=Microsoft.ACE.OLEDB.12.0; 
				 Data Source = AppDatabase.accdb";
            myConnection = new OleDbConnection(connString);
        }

        public static DBConnection getInstance()
        {
            if (instance == null)
            {
                instance = new DBConnection();
            }
            return instance;
        }

        public UserAccount getUserDetails(string username, string password)
        {
            UserAccount user = new UserAccount();
            string myQuery = "SELECT * FROM UserAccount WHERE Username = '" + username + "' AND Password = " + password + "'";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            myConnection.Open();
            try
            {
                user.setUsername(username);
                user.setPassword(password);
                OleDbDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    user.setEMailAddress(myReader["EMailAddress"].ToString());
                    user.setDateOfBirth(Convert.ToDateTime(myReader["DateofBirth"].ToString()));
                    user.setBillID(Convert.ToInt32(myReader["BillID"].ToString()));
                    user.setPaymentDetailsID(Convert.ToInt32(myReader["PaymentDetailsID"].ToString()));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Login failed");
                user = null;
            }
            finally
            {
                myConnection.Close();
            }
            return user;
        }

        public void amendUserDetails(string username, string password)
        {
            //UserAccount user = new UserAccount();
            //string myQuery = "SELECT * FROM UserAccount WHERE Username = '" + username + "' AND Password = " + password + "'";
            //OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            //myConnection.Open();
            //try
            //{
            //    OleDbDataReader myReader = myCommand.ExecuteReader();
            //    while (myReader.Read())
            //    {
            //        user.setEMailAddress(myReader["EMailAddress"].ToString());
            //        user.setDateOfBirth(Convert.ToDateTime(myReader["DateofBirth"].ToString()));
            //        user.setBillID(Convert.ToInt32(myReader["BillID"].ToString()));
            //        user.setPaymentDetailsID(Convert.ToInt32(myReader["PaymentDetailsID"].ToString()));
            //    }
            //}
            //catch (Exception e)
            //{

            //}
            //finally
            //{
            //    myConnection.Close();
            //}
        }

        public void addUserDetails(string username, string password, string name, string email, string dob, long contactNo, string address, long cardNo)
        {
            int id = 0;
            string myQuery1 = "INSERT INTO PaymentDetails (CustomerName,CardNumber,BillingAddress) VALUES ('" + name + "'," + cardNo + ",'" + address + "');";
            OleDbCommand myCommand = new OleDbCommand(myQuery1, myConnection);
            string myQuery2 = "SELECT * from PaymentDetails WHERE CardNumber = '" + cardNo + "'";
            OleDbCommand myCommand2 = new OleDbCommand(myQuery2, myConnection);
            string myQuery3 = "INSERT INTO UserAccount (username,password,EMailAddress,DateOfBirth,ContactNo,PaymentDetailsID) VALUES ('" + username + "','" + password + "','" + email + "','" + dob + "'," + contactNo + "," + id + ")";
            OleDbCommand myCommand3 = new OleDbCommand(myQuery3, myConnection);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                OleDbDataReader myReader = myCommand2.ExecuteReader();
                while (myReader.Read())
                {
                    id = Convert.ToInt32(myReader["ID"].ToString());
                }
                myCommand3.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("The system could not register you " + e);
            }
            finally
            {
                myConnection.Close();
            }
        }


        //public Bill getBillDetails(user User)
        //{
        //    Bill bill = new Bill();
        //    string myQuery = "";
        //    OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
        //    myConnection.Open();
        //    try
        //    {
        //        OleDbDataReader myReader = myCommand.ExecuteReader();
        //        while (myReader.Read())
        //        {
        //        
        //        }
        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    finally
        //    {
        //        myConnection.Close();
        //    }
        //    return bill;
        //}
    }
}
