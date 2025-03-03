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
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void AddStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.BodyFrame.Navigate(new Pages.AddStudentsPage());
        }

        private void AddGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.BodyFrame.Navigate(new Pages.AddGroupPage());
        }

        private void ListBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.BodyFrame.Navigate(new Pages.ListGroupPage());

        }

        private void DeliteBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.BodyFrame.Navigate(new Pages.DeliteStudentsPage());

        }

        private void EntryBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.BodyFrame.Navigate(new Pages.BodyPage());

        }
    }
}
