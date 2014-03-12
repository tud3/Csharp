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
        private string connString = "127.0.0.1;port=3306;username=root;";
        //private string connString = "server=mysql.labranet.jamk.fi;port=3306;username=G7791;password=zZ9EDWkh59HAOQe6odjx7znq7vIQDa1i";
        private MySqlConnection myConn;

       

        public void openConnection()
        {
                myConn = new MySqlConnection(connString);
                myConn.Open();
                MessageBox.Show("Nyt se on auki...");
                
        }

        public void closeConnection() 
        {
            myConn.Close();
            MessageBox.Show("...ja nyt se on kii!");
        }

    }
}
