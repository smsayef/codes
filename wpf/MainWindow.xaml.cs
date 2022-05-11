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

namespace wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string db = "gmis";
        private const string user = "gmis";
        private const string pass = "gmis";
        private const string server = "alacritas.cis.utas.edu.au";

        public MainWindow()
        {
            InitializeComponent();

        
        
        }
        private void viewMeeting(Object sender, RoutedEventArgs e)
        {
            MySqlDataReader rdr;
            string connectionString = String.Format("Database={0};Data Source={1};User Id={2};Password={3}", db, server, user, pass);
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select * from  meeting", conn);



            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            showdata.DataContext = dt;
            conn.Close();
        }

        private void viewStudentList(Object sender, RoutedEventArgs e)
        {
            MySqlDataReader rdr;
            string connectionString = String.Format("Database={0};Data Source={1};User Id={2};Password={3}", db, server, user, pass);
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select * from  student", conn);



            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            showdata.DataContext = dt;
            conn.Close();
        }

        private void viewStudentGroup(Object sender, RoutedEventArgs e)
        {
            MySqlDataReader rdr;
            string connectionString = String.Format("Database={0};Data Source={1};User Id={2};Password={3}", db, server, user, pass);
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select * from  studentGroup", conn);



            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            showdata.DataContext = dt;
            conn.Close();
        }

        private void viewClasses(Object sender, RoutedEventArgs e)
        {
            MySqlDataReader rdr;
            string connectionString = String.Format("Database={0};Data Source={1};User Id={2};Password={3}", db, server, user, pass);
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select * from  class", conn);



            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            showdata.DataContext = dt;
            conn.Close();
        }




    }

    
    
}

