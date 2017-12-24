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
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        public Reg()
        {
            InitializeComponent();
        }


    
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Window Reg1 = new Reg1();
            this.Close();
            Reg1.Show();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            Window Reg2 = new Reg2();
            this.Close();
            Reg2.Show();
        }
    }
    }

