﻿using System;
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
    public partial class Page27 : PhoneApplicationPage
    {
        public Page27()
        {
            InitializeComponent();
        }
        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page28.xaml", UriKind.Relative));
        }
    }
}