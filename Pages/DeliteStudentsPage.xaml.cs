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
    /// Логика взаимодействия для DeliteStudentsPage.xaml
    /// </summary>
    public partial class DeliteStudentsPage : Page
    {
        public DeliteStudentsPage()
        {
            InitializeComponent();


            GroupCmb.SelectedValuePath = "Id";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();

            GroupDg.ItemsSource = App.context.Student.ToList();
        }

        private void DeliteStudents_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeliteStudents_Click_1(object sender, RoutedEventArgs e)
        {
            if (GroupDg.SelectedItem == null)
            {
                MessageBox.Show("Выберите товар для удаления");
                return;
            }

            Student selectedStident = GroupDg.SelectedItem as Student;

            var res = MessageBox.Show($"Вы уверены, что хотите удалить?", "Подтверждение", MessageBoxButton.YesNo);

            if (res == MessageBoxResult.Yes)
            {
                App.context.Student.Remove(selectedStident);
                App.context.SaveChanges();
                MessageBox.Show("Удалено");
                GroupDg.ItemsSource = App.context.Student.ToList();
            }
        }

        private void EntryBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.BodyFrame.Navigate(new Pages.MenuPage());
        }

        private void GroupDg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            int SelectedGroup = Convert.ToInt32(GroupCmb.SelectedValue);

            GroupDg.ItemsSource = App.context.Student.Where(x => x.IdGroup == SelectedGroup).ToList();
        }
    }
}
