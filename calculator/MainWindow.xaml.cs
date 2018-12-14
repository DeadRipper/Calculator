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



namespace calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

		static CalcLogic cl = new CalcLogic();

		private void button1_Click(object sender, RoutedEventArgs e)
        {
			MainText.Text += button1.Content.ToString();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
			MainText.Text += button2.Content.ToString();
		}

        private void button3_Click(object sender, RoutedEventArgs e)
        {
			MainText.Text += button3.Content.ToString();
		}

        private void button4_Click(object sender, RoutedEventArgs e)
        {
			MainText.Text += button4.Content.ToString();
		}

        private void button5_Click(object sender, RoutedEventArgs e)
        {
			MainText.Text += button5.Content.ToString();
		}

        private void button6_Click(object sender, RoutedEventArgs e)
        {
			MainText.Text += button6.Content.ToString();
		}

        private void button7_Click(object sender, RoutedEventArgs e)
        {
			MainText.Text += button7.Content.ToString();
		}

        private void button8_Click(object sender, RoutedEventArgs e)
        {
			MainText.Text += button8.Content.ToString();
		}

        private void button9_Click(object sender, RoutedEventArgs e)
        {
			MainText.Text += button9.Content.ToString();
		}

        private void button0_Click(object sender, RoutedEventArgs e)
        {
			MainText.Text += button0.Content.ToString();
		}

		private void Button_clear_Click(object sender, RoutedEventArgs e)
		{
			MainText.Clear();
		}

		private void Buttonplus_Click(object sender, RoutedEventArgs e)
		{
			MainText.Text = "+";
			if (MainText.Text == "+")
			{
				static ulong b = Convert.ToUInt64(MainText.Text);
			}
			else
			{
				var a = Convert.ToUInt64(MainText.Text);
			}
			var res = cl.Sum(a, b);
			MainText_result.Text = res.ToString();
		}

		private void Buttonravno_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}