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
    public partial class Page19 : PhoneApplicationPage
    {
        public Page19()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page20.xaml", UriKind.Relative));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string s1;
            s1 = textBox1.Text;

            if (s1 == "accept")
            {
                button3.Visibility = Visibility;
                textBlock3.Text = "The door is open !!! press continue to walk through...";
            }
            else
            {
                textBlock3.Text = "You got it wrong !!! Try again";
            }

        }
    }
}