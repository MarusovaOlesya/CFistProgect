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
using System.Xml.Linq;

namespace ProectTwo
{
    /// <summary>
    /// Логика взаимодействия для SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }


        private void RegisterClick(object sender, RoutedEventArgs e)
        {
            string fiobox = fioBox.Text;
            string year = yearBox.Text;
            string document = documentBox.Text;
            User user = new User(fiobox, year, document);
            user.Show();
            this.Close();
        }
    }
}
