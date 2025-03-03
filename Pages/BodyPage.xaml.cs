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
    /// Логика взаимодействия для BodyPage.xaml
    /// </summary>
    public partial class BodyPage : Page
    {
        public BodyPage()
        {
            InitializeComponent();
        }

        private void StudentBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StudentBtn_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void TeacherBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.BodyFrame.Navigate(new Pages.TeacherPage());
        }
    }
}
