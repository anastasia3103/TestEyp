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
using TestEyp.Model;

namespace TestEyp.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListGroupPage.xaml
    /// </summary>
    public partial class ListGroupPage : Page
    {
        public ListGroupPage()
        {
            InitializeComponent();


            GroupCmb.SelectedValuePath = "Id";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();

            StudentCmb.SelectedValuePath = "Id";
            StudentCmb.DisplayMemberPath = "Name";
            StudentCmb.ItemsSource = App.context.Student.ToList();

            GroupDg.ItemsSource = App.context.Journal.ToList();
        }

        private void GroupDg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void PrintBtn_Click(object sender, RoutedEventArgs e)
        {

            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true) printDialog.PrintVisual(GroupDg, "Студенты");
        }

        private void EntryBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.BodyFrame.Navigate(new Pages.MenuPage());
        }

        private void GroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            int SelectedGroup = Convert.ToInt32(GroupCmb.SelectedValue);
            StudentCmb.ItemsSource = App.context.Journal.Where(x => x.Student.IdGroup == SelectedGroup).ToList();
            GroupDg.ItemsSource = App.context.Journal.Where(x => x.Student.IdGroup == SelectedGroup).ToList();

            //int SelectedGroupCmb = Convert.ToInt32(GroupCmb.SelectedValue);

        }

        private void StudentCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            int SelectedStudent = Convert.ToInt32(StudentCmb.SelectedValue);
            GroupDg.ItemsSource = App.context.Journal.Where(x => x.IdStudent == SelectedStudent).ToList();
        }
    }
}
