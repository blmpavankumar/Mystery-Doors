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
    public partial class Page21 : PhoneApplicationPage
    {
        public Page21()
        {
            InitializeComponent();
        }
        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page22.xaml", UriKind.Relative));
        }
    }
}