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
    /// Логика взаимодействия для AddStudentsPage.xaml
    /// </summary>
    public partial class AddStudentsPage : Page
    {
        public AddStudentsPage()
        {
            InitializeComponent();


            GroupCmb.SelectedValuePath = "Id";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();
        }

        private void EntryBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.BodyFrame.Navigate(new Pages.MenuPage());
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(FullnameTb.Text))
                mes += "Введите имя\n";
            if (string.IsNullOrWhiteSpace(GroupCmb.Text))
                mes += "Выберите название группы\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;

            }

            Student student = new Student()
            {
                Name = FullnameTb.Text,
                Group = GroupCmb.SelectedItem as Group

            };

            App.context.Student.Add(student);
            App.context.SaveChanges();
            MessageBox.Show("Студент добавлен");

            FullnameTb.Text = "";
            GroupCmb = null;
        }

    }
}
