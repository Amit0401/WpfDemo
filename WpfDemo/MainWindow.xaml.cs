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

namespace WpfDemo
{
    /// Test data
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                new BitmapImage(new Uri("C:\\Users\\pragnesh\\source\\repos\\WpfDemo\\WpfDemo\\images\\smokeffect.jpg"));
            this.Background = myBrush;
        }

        private void slValue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = slValue.Value;
            txtblock1.Text = Convert.ToString(value);
        }

        private void txtblock1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                string name;
                name = txtblock1.Text;
                if (String.IsNullOrEmpty(name))
                {
                    slValue.Value = 20.0;
                }
                else 
                    slValue.Value = Convert.ToDouble(name);
            }
            catch(Exception ex)
            {
                string test = "enter value greater than 20";
                MessageBox.Show(test+ex.ToString());
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string name = "amit";
            txtblock2.Text = name;
            txtblock2.Foreground = Brushes.Red;
            txtblock2.Background = Brushes.Green;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //if(txtblock1.Text!=null)
            //{
            //    string name1 = "";
            //   txtblock1.Text=name1;
            //}
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //string name = "amit patel";
            //txtblock1.Text = name;
        }

        private void imagechange_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
