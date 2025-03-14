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
    /// Логика взаимодействия для Test1Page.xaml
    /// </summary>
    public partial class Test1Page : Page
    {
        int b = 0;
        int c = 0;
        public Test1Page()
        {
            InitializeComponent();
        }

        private void CheckBtn_Click(object sender, RoutedEventArgs e)
        {

            if (AnswerTb.Text == "5")
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else MessageBox.Show("Неправильно");

            CheckBtn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v2;

            
        }

    

        private void p2_Click(object sender, RoutedEventArgs e)
        {
            if (RB2.IsChecked == true)
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else MessageBox.Show("Неправильно");

                p2.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v3;

            
        }

        private void p3_Click(object sender, RoutedEventArgs e)
        {

            if (ChB1.IsChecked == false && ChB2.IsChecked == false
                && ChB3.IsChecked == false &&
                ChB4.IsChecked == false && ChB5.IsChecked == true )
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else MessageBox.Show("Неправильно");
            
                p3.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v4;

            
        }

        private void p4_Click(object sender, RoutedEventArgs e)
        {
            if (RB4.IsChecked == true)
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else MessageBox.Show("Неправильно");
            
                p4.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v5;

            
        }

        private void p5_Click(object sender, RoutedEventArgs e)
        {
            if (RB5.IsChecked == true)
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else MessageBox.Show("Неправильно");
                p5.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v6;

            
        }

        private void p7_Click(object sender, RoutedEventArgs e)
        {
            if (RB7.IsChecked == true)
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else MessageBox.Show("Неправильно");
                p7.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v8;

            
        }

        private void p8_Click(object sender, RoutedEventArgs e)
        {
            if (RB8.IsChecked == true)
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else MessageBox.Show("Неправильно");
                p8.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v9;

            
        }

        private void p9_Click(object sender, RoutedEventArgs e)
        {
            if (RB9.IsChecked == true)
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else MessageBox.Show("Неправильно");
                p9.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v10;

            
        }

        private void p10_Click(object sender, RoutedEventArgs e)
        {
            if (RB10.IsChecked == true)
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else MessageBox.Show("Неправильно");
                p10.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v11;

            
        }

        private void p11_Click(object sender, RoutedEventArgs e)
        {
            if (RB11.IsChecked == true)
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else MessageBox.Show("Неправильно");
                p11.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v12;

            
        }

        private void p12_Click(object sender, RoutedEventArgs e)
        {
            if (RB12.IsChecked == true)
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else MessageBox.Show("Неправильно");
                p12.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v13;

            
        }

        private void p13_Click(object sender, RoutedEventArgs e)
        {
            if (RB13.IsChecked == true)
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else MessageBox.Show("Неправильно");
                p13.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v14;

            
        }

        private void p14_Click(object sender, RoutedEventArgs e)
        {
            if (RB14.IsChecked == true)
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else MessageBox.Show("Неправильно");
                p14.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v15;

            
        }

        private void p15_Click(object sender, RoutedEventArgs e)
        {
            if (ChB6.IsChecked == false && ChB7.IsChecked == true && 
                ChB8.IsChecked == false && ChB9.IsChecked == true && 
                ChB10.IsChecked == false
                && ChB11.IsChecked == true)
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else MessageBox.Show("Неправильно");
                p15.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v16;

            
        }

        private void p16_Click(object sender, RoutedEventArgs e)
        {
            if (RB16.IsChecked == true)
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else MessageBox.Show("Неправильно");
                p16.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v17;

            
        }

        private void p17_Click(object sender, RoutedEventArgs e)
        {
            if (RB17.IsChecked == true)
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else MessageBox.Show("Неправильно");
                p17.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v18;

            
        }

        private void p18_Click(object sender, RoutedEventArgs e)
        {
            if (RB18.IsChecked == true)
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else MessageBox.Show("Неправильно");
                p18.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v19;

            
        }

        private void p19_Click(object sender, RoutedEventArgs e)
        {
            if (RB19.IsChecked == true)
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else MessageBox.Show("Неправильно");
                p19.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v20;

            
        }

        private void p20_Click(object sender, RoutedEventArgs e)
        {
            if (RB20.IsChecked == true)
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else MessageBox.Show("Неправильно");

                p20.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v21;

            
        }

        private void p21_Click(object sender, RoutedEventArgs e)
        {
            if (RB21.IsChecked == true)
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else MessageBox.Show("Неправильно");
            
               
                p21.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = Result;

            
        }

        private void p6_Click(object sender, RoutedEventArgs e)
        {
            if (RB6.IsChecked == true)
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else MessageBox.Show("Неправильно");
            
                p6.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v7;

            
        }

        private void ResultBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultTb.Text = Convert.ToString(b);

            if (b >= 20) c = 5;
            if (b < 11 && b<20) c = 4;
            if (b > 5 && b < 12) c = 3;
            if (b < 6 && b>0) c = 2;
            if (b == 0) c = 1;

            MarkTb.Text = Convert.ToString(c);

        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            Journal journal = new Journal()
            {
                DataTest = DateTime.Now,
                Mark = c,
                IdStudent = ClassVariable.classman,
                IdTest = 1

            };

            App.context.Journal.Add(journal);
            App.context.SaveChanges();

            FrameHelper.BodyFrame.Navigate(new Pages.BodyPage());


        }
    }
}
