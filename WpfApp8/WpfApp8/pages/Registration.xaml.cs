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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp8.pages
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if ((Фамилия.Text.Length < 4) && (Имя.Text.Length < 4) && (Отчество.Text.Length < 4) && (Рождение.Text.Length < 4) && (Номер.Text.Length < 4) && (Пароль.Text.Length < 4))
            {
                MessageBox.Show("Не введены данные");
                return;
            }
            NavigationService.Navigate(Class1.PageLogin);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Class1.PageLogin);
        }
    }
}
