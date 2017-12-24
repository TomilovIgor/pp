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
    /// Логика взаимодействия для Reg1.xaml
    /// </summary>
    public partial class Reg1 : Window
    {
        private object mySql;

        public Reg1()
        {
            int status_id = 1;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int status_id = 1;
            string connection = "SERVER=localhost;DATABASE=inwork;UID=root;PASSWORD=root;";
            //MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlConnection mySql = new MySqlConnection(connection);
           // connection.Open();

            string profile_user_secondname = secondname.Text;
            string profile_user_firstname = firstname.Text;

            string profile_user_telephone = telephone.Text;
            string profile_user_address = address.Text;
            string profile_user_work_goal = work_goal.Text;
            string profile_user_work_price = work_price.Text;

            string user_login = login.Text;
            string user_password = password.Password;
            
            string insertUserCommand = "insert into authorization(user_login, " + "user_password, user_status_id, " + "user_firstname," +  "user_secondname," + "user_telephone," + "user_address," + "user_work_goal," + "user_work_price," + "values" + "('" + user_login + "','" + user_password + "'," + status_id + ");";
            MySqlCommand command = new MySqlCommand(insertUserCommand, mySql);

            try
            {
                if (mySql.State == System.Data.ConnectionState.Closed)
                {
                    mySql.Open();
                }

                //command.ExecuteReader();
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count == 0)
                {
                    MessageBox.Show("Регистрация прошла успешно!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Пользователь уже с таким логином существует!");



            }
            finally
            {
                mySql.Close();
            }


        }


        //MySqlCommand cmd = new MySqlCommand("insert into user_emploer(profile_user_secondname ,profile_user_firstname, profile_user_middlename,profile_user_telephone," +

        //"values( '" + user_login + "', '" + user_password + "'', '" + status_id + "');", connection);
        //connection.Close();


        // connection.Open();

    }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
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
