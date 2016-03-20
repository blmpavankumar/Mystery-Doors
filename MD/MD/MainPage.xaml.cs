using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace levelf
{
    
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }
        int i = 3, m = 2;
        private void button3_Click(object sender, RoutedEventArgs e)
        {
           
            string s1;
            s1 = textBox1.Text;
            if (s1 == "top secret")
            {
                button1.Visibility = Visibility;
                textBlock5.Text = "You got it Right.Press Continue";
            }
            else
            {
                textBlock5.Text = "Sorry You are wrong !!!";
                textBox1.Text = "";
                if (m != 0)
                {
                    
                    if (m == 2)
                    {
                        textBlock5.Text = "Sorry You are wrong !!!";
                        textBlock3.Text = "2"; m--;
                    }
                    else if (m == 1)
                    {
                        textBlock5.Text = "Sorry You are wrong again !!!";
                        textBlock3.Text = "1"; m--;
                    }
                }
                else
                {

                }
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
        }
    }
}