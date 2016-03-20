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

namespace MD
{
    public partial class Page11 : PhoneApplicationPage
    {
        public Page11()
        {
            InitializeComponent();
        }
        int m = 2, i = 3;
        Boolean flag = true;
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (flag)
            {
                string s1;
                s1 = textBox1.Text;
                if (s1 == "time")
                {
                    button3.Content = "continue"; flag = false;
                    textBlock6.Text = "You got it Right.Press Continue";
                }
                else
                {
                    textBlock6.Text = "Sorry You are wrong !!!";
                    textBox1.Text = "";
                    if (m != 0)
                    {

                        if (m == 2)
                        {
                            textBlock6.Text = "Sorry You are wrong !!!";
                            textBlock5.Text = "2"; m--;
                        }
                        else if (m == 1)
                        {
                            textBlock6.Text = "Sorry You are wrong again !!!";
                            textBlock5.Text = "1"; m--;
                        }
                    }
                    else
                    {
                        NavigationService.Navigate(new Uri("/Page35.xaml", UriKind.Relative));
                    }
                }
            }

            else
            {
                NavigationService.Navigate(new Uri("/Page12.xaml", UriKind.Relative));
            }
        }
        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }
    }
}