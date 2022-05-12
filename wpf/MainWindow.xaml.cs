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
using System.Windows.Shapes;

namespace wpf
{
     ///<summary>
    /// Interaction logic for ui.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string db = "gmis";
        private const string user = "gmis";
        private const string pass = "gmis";
        private const string server = "alacritas.cis.utas.edu.au";
        MySqlConnection conn;
        public MainWindow(string username)
        {
            InitializeComponent();
            userName.Text = (username);
        }

        private void SignOut(object sender, RoutedEventArgs e)
        {
            LoginScreen dashboard = new LoginScreen();
            dashboard.Show();
            this.Close();
        }


        private void viewStudentGroup(object sender, RoutedEventArgs e)
        {

            string connectionString = String.Format("Database={0};Data Source={1};User Id={2};Password={3}", db, server, user, pass);
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select * from  studentGroup", conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGrid.DataContext = dt;
            conn.Close();

        }
        private void viewClasses(Object sender, RoutedEventArgs e)
        {
            string connectionString = String.Format("Database={0};Data Source={1};User Id={2};Password={3}", db, server, user, pass);
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select * from  class", conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGrid.DataContext = dt;
            conn.Close();
        }

        private void viewMeeting(Object sender, RoutedEventArgs e)
        {

            string connectionString = String.Format("Database={0};Data Source={1};User Id={2};Password={3}", db, server, user, pass);
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select * from  meeting", conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGrid.DataContext = dt;
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
            dataGrid.DataContext = dt;
            conn.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string searchText = class_id.Text;
            group_id.Text = "";
            MySqlDataReader rdr;
            string connectionString = String.Format("Database={0};Data Source={1};User Id={2};Password={3}", db, server, user, pass);
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM class WHERE class_id LIKE '" + searchText + "%'";
            Console.WriteLine(query);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGrid.DataContext = dt;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string searchText = group_id.Text;
            class_id.Text = "";
            string connectionString = String.Format("Database={0};Data Source={1};User Id={2};Password={3}", db, server, user, pass);
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM student WHERE student_id LIKE '" + searchText + "%'";
            Console.WriteLine(query);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGrid.DataContext = dt;
        }

        private void Bsc(object sender, RoutedEventArgs e)
        {
            view_group_in_class.Visibility = Visibility.Visible;
            class_id.Visibility = Visibility.Visible;
            view_student_in_a_group.Visibility = Visibility.Visible;
            group_id.Visibility = Visibility.Visible;
            group_list.Visibility = Visibility.Hidden;
            class_list.Visibility = Visibility.Hidden;
            meeting_list.Visibility = Visibility.Hidden;
            student_list.Visibility = Visibility.Hidden;

        }

        private void Msc(object sender, RoutedEventArgs e)
        {
            view_group_in_class.Visibility = Visibility.Visible;
            class_id.Visibility = Visibility.Visible;
            view_student_in_a_group.Visibility = Visibility.Visible;
            group_id.Visibility = Visibility.Visible;
            group_list.Visibility = Visibility.Visible;
            class_list.Visibility = Visibility.Visible;
            meeting_list.Visibility = Visibility.Visible;
            student_list.Visibility = Visibility.Visible;

        }
    }
}