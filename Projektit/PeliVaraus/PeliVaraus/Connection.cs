using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PeliVaraus
{
    class Connection
    {
        private string connString = "server=127.0.0.1;port=3306;username=root;";
        //private string connString = "server=mysql.labranet.jamk.fi;port=3306;username=G7791;password=zZ9EDWkh59HAOQe6odjx7znq7vIQDa1i";
        private MySqlConnection myConn;
        public bool isOpen = false;
       

        public void openConnection()
        {
            try
            {

                myConn = new MySqlConnection(connString);
                myConn.Open();
                isOpen = true;
                MessageBox.Show("Nyt se on auki...");
            }

            catch 
            {
                MessageBox.Show("virhe :(");
            }
        }

        public void closeConnection() 
        {
            try
            {
                myConn.Close();
                isOpen = false;
                MessageBox.Show("...ja nyt se on kii!");
            }

            catch 
            { 
                MessageBox.Show("ei saatu suljettua"); 
            }
        }


    }
}
