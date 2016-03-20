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
using System.Windows.Media.Imaging;

namespace MD
{
    public partial class Page14 : PhoneApplicationPage
    {
        public Page14()
        {
            InitializeComponent();
            System.Threading.Thread startupThread =
                             new System.Threading.Thread(new System.Threading.ThreadStart(pDelay));
            startupThread.Start();
        }
        BitmapImage im1 = new BitmapImage(new Uri("/MD;component/sds.png", UriKind.Relative));
        BitmapImage im2 = new BitmapImage(new Uri("/MD;component/Images/z.png", UriKind.Relative));
        void pDelay()
        {
            int k = 20, j = 1, m = 0;
            Boolean flag = true;
            for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(150);

                this.Dispatcher.BeginInvoke(() =>
                {
                    if (flag)
                    {

                        if (j == 0)
                        {
                            image2.Source = im1;
                            image2.Margin = new Thickness(k, 210, 0, 0); k = k + 10;
                            j = 1;
                            if (k > 685)
                                flag = false;

                        }
                        else
                        {
                            image2.Source = im2;
                            image2.Margin = new Thickness(k, 210, 0, 0); k = k + 10;
                            j = 0;
                            if (k > 685)
                                flag = false;
                        }
                    }
                    else
                    {
                        NavigationService.Navigate(new Uri("/Page15.xaml", UriKind.Relative));
                    }
                });
            }
            //    doStuff3();
        }

        private void image4_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }
    }
}