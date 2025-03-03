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
using TestEyp.AppDate;

namespace TestEyp.Pages
{
    /// <summary>
    /// Логика взаимодействия для TeacherPage.xaml
    /// </summary>
    public partial class TeacherPage : Page
    {
        public TeacherPage()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordPb.Password == "123")
            {
                MessageBox.Show("Вы вошли в аккаунт!");
                FrameHelper.BodyFrame.Navigate(new Pages.MenuPage());
            }
            else
            {
                MessageBox.Show("Пароль не верный");
                FrameHelper.BodyFrame.Navigate(new Pages.BodyPage());

            }

        }
    }
}
