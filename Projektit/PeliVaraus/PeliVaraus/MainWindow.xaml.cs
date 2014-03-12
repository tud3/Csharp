using MySql.Data.MySqlClient;
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
        Connection connection = new Connection();
        private void btnTestaus(object sender, RoutedEventArgs e)
        {
            try
            {
                connection.openConnection();                
            }
    
            catch
            {
                MessageBox.Show("Virhe!");
            }

            finally
            {
                connection.closeConnection();
            }
        }

        private void btnHenk_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                string sql = "use g7791; SELECT * FROM henkilo;";
                connection.openConnection();
                MySqlDataAdapter myDA = new MySqlDataAdapter();
                MySqlCommandBuilder cmd = new MySqlCommandBuilder(myDA);
                DataSet ds = new DataSet();
                
                

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

