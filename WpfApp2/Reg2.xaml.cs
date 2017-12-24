using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Reg2.xaml
    /// </summary>
    public partial class Reg2 : Window
    {
        public Reg2()
        {
            int status_id = 2;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int status_id = 2;
            string connectionString = "SERVER=localhost;DATABASE=inwork;UID=root;PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            string profile_user_secondname = secondname1.Text;
            string profile_user_firstname = firstname1.Text;
      
            string profile_user_telephone = telephone1.Text;
            string profile_user_work_profile = work_profile.Text;
          
            string user_login = login1.Text;
            string user_password = password1.Password;
          



            MySqlCommand cmd = new MySqlCommand("insert into user_employ (employ_user_firstname ,employ_user_secondname, employ_user_telephone," +

              "values( '" + user_login + "', '" + user_password + "'', '" + status_id + "');", connection);
            connection.Close();


            connection.Open();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Reg Window = new Reg();
            Window.Show();
            this.Close();
        }
    }
}
