﻿using System;
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

        }

        private void CheckBtn_Click_1(object sender, RoutedEventArgs e)
        {
            if(AnswerTb.Text == "5")
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else
            {
                MessageBox.Show("Неправильно");
                CheckBtn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v2;

            }
        }

        private void p2_Click(object sender, RoutedEventArgs e)
        {
            if (RB2.IsChecked == true)
            {
                MessageBox.Show("Правильно!!");
                b = b + 1;


            }
            else
            {
                MessageBox.Show("Неправильно");
                p2.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v3;

            }
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
            else
            {
                MessageBox.Show("Неправильно");
                p2.Visibility = Visibility.Collapsed;
                //ProductsTc.SelectedItem = v4;

            }
        }

        private void p4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p11_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p12_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p13_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p14_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p15_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p16_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p17_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p18_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p19_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p20_Click(object sender, RoutedEventArgs e)
        {

        }

        private void p21_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
