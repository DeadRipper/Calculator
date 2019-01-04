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
			MainText_1.Text += button1.Content.ToString();
		}

		private void button2_Click(object sender, RoutedEventArgs e)
		{
			MainText_1.Text += button2.Content.ToString();
		}

		private void button3_Click(object sender, RoutedEventArgs e)
		{
			MainText_1.Text += button3.Content.ToString();
		}

		private void button4_Click(object sender, RoutedEventArgs e)
		{
			MainText_1.Text += button4.Content.ToString();
		}

		private void button5_Click(object sender, RoutedEventArgs e)
		{
			MainText_1.Text += button5.Content.ToString();
		}

		private void button6_Click(object sender, RoutedEventArgs e)
		{
			MainText_1.Text += button6.Content.ToString();
		}

		private void button7_Click(object sender, RoutedEventArgs e)
		{
			MainText_1.Text += button7.Content.ToString();
		}

		private void button8_Click(object sender, RoutedEventArgs e)
		{
			MainText_1.Text += button8.Content.ToString();
		}

		private void button9_Click(object sender, RoutedEventArgs e)
		{
			MainText_1.Text += button9.Content.ToString();
		}

		private void button0_Click(object sender, RoutedEventArgs e)
		{
			MainText_1.Text += button0.Content.ToString();
		}

		private void Button_clear_Click(object sender, RoutedEventArgs e)
		{
			MainText_0.Clear();
			MainText_1.Clear();
			Operation_textbox.Clear();
			MainText_result.Clear();
		}

		private void Buttonplus_Click(object sender, RoutedEventArgs e)
		{
			Operation_textbox.Text = buttonplus.Content.ToString();
			MainText_0.Text = MainText_1.Text;
			MainText_1.Clear();
		}

		private void Buttonminus_Click(object sender, RoutedEventArgs e)
		{
			Operation_textbox.Text = buttonminus.Content.ToString();
			MainText_0.Text = MainText_1.Text;
			MainText_1.Clear();
		}

		private void Buttonravno_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				double i = Convert.ToDouble(MainText_0.Text);
				double j = Convert.ToDouble(MainText_1.Text);
				for (; ;)
				{
					if (Operation_textbox.Text.Contains("+"))
					{						
						MainText_0.Text = $"{i}" + "+" + $"{j}";
						MainText_1.Clear();
						Operation_textbox.Clear();
						MainText_result.Text += cl.Sum(i, j).ToString();
						break;
					}
					else if (Operation_textbox.Text.Contains("-"))
					{
						MainText_0.Text = $"{i}" + "-" + $"{j}";
						MainText_1.Clear();
						Operation_textbox.Clear();
						MainText_result.Text += cl.Raznitsa(i, j).ToString();
						break;
					}
				}
				}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

	}
}

