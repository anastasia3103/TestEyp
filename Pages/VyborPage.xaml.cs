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
    /// Логика взаимодействия для VyborPage.xaml
    /// </summary>
    public partial class VyborPage : Page
    {
        public VyborPage()
        {
            InitializeComponent();

            GroupCmb.SelectedValuePath = "Id";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();

            StudentCmb.SelectedValuePath = "Id";
            StudentCmb.DisplayMemberPath = "Name";
            StudentCmb.ItemsSource = App.context.Student.ToList();

            TestCmb.SelectedValuePath = "Id";
            TestCmb.DisplayMemberPath = "Name";
            TestCmb.ItemsSource = App.context.Test.ToList();
        }

        private void GroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelecrtedGroup = Convert.ToInt32(GroupCmb.SelectedValue);
            StudentCmb.ItemsSource = App.context.Student.
                Where(x => x.IdGroup == SelecrtedGroup).ToList();
        }

        private void StudentCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TestCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(GroupCmb.Text))
                mes += "Выберете группу\n";
            if (string.IsNullOrWhiteSpace(StudentCmb.Text))
                mes += "Выберете студента\n";
            if (string.IsNullOrWhiteSpace(TestCmb.Text))
                mes += "Выберете тест\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            else if (TestCmb.Text == "Общие основы функционирования субъектов хозяйствования")
            {
                FrameHelper.BodyFrame.Navigate(new Pages.Test1Page());
            }
            else if (TestCmb.Text == "Сущность и структура основного капитала и оборотных средств предриятия")
            {
                FrameHelper.BodyFrame.Navigate(new Pages.Test2Page());
            }
            else if (TestCmb.Text == "Формы и системы оплаты труда")
            {
                FrameHelper.BodyFrame.Navigate(new Pages.Test3Page());
            }
            else if (TestCmb.Text == "Результаты коммерческой деятельности")
            {
                FrameHelper.BodyFrame.Navigate(new Pages.Test4Page());
            }
        }
    }
}
