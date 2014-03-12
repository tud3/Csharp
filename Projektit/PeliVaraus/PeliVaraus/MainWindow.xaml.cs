using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PeliVaraus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        MySqlDataAdapter da= new MySqlDataAdapter();
        Connection connection = new Connection();
        private void btnTestaus(object sender, RoutedEventArgs e)
        {
            connection.openConnection();
            if(connection.isOpen==true)
            {
              connection.closeConnection();
            }
        }

        private void btnHenk_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                string sql = "SELECT * FROM g7791.henkilo;";
                connection.openConnection();
                //MySqlCommandBuilder cmd = new MySqlCommandBuilder(da);
                da.SelectCommand = new MySqlCommand(sql);
                MessageBox.Show("toimii...");
                
            }
            catch 
            {
                MessageBox.Show("Virhe!!");
            }
            finally 
            {
                connection.closeConnection();
            }
        }
    }
}

