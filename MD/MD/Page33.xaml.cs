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
    public partial class Page33 : PhoneApplicationPage
    {
        public Page33()
        {
            InitializeComponent();
            System.Threading.Thread startupThread =
                          new System.Threading.Thread(new System.Threading.ThreadStart(pDelay));
            startupThread.Start();
        }
        BitmapImage im1 = new BitmapImage(new Uri("/MD;component/Images/d.png", UriKind.Relative));
        BitmapImage im2 = new BitmapImage(new Uri("/MD;component/Images/dhj.png", UriKind.Relative));
        BitmapImage im3 = new BitmapImage(new Uri("/MD;component/Images/asa.png", UriKind.Relative));
        BitmapImage im4 = new BitmapImage(new Uri("/MD;component/Images/asb.png", UriKind.Relative));
        void pDelay()
        {
            int k = 0, j = 1, m = 0,k1=460,k2=300,k3=400;
            Boolean flag = true;
            Boolean flag1 = true;
            for (int i = 0; i < 500; i++)
            {
                System.Threading.Thread.Sleep(150);

                this.Dispatcher.BeginInvoke(() =>
                {
                    if (flag)
                    {
                        if (flag1)
                        {
                            if (j == 0)
                            {
                                image3.Source = im3;
                                image2.Source = im1;
                                image2.Margin = new Thickness(k, 222, 0, 0); k = k + 5;
                                image3.Margin = new Thickness(k1, 170, 0, 0); k1 = k1 - 5;
                                j = 1;
                                if (k > 240 && k1 < 255)
                                    flag1 = false;

                            }
                            else
                            {
                                image3.Source = im4;
                                image2.Source = im2;
                                image3.Margin = new Thickness(k1, 170, 0, 0); k1 = k1 - 10;
                                image2.Margin = new Thickness(k, 210, 0, 0); k = k + 10;
                                j = 0;
                                if (k > 240 && k1 < 260)
                                    flag1 = false;
                            }
                        }
                        else
                        {
                            image4.Margin = new Thickness(111,k2, 0, 0); k2 = k2 - 5;
                            image5.Margin = new Thickness(27, k2, 0, 0); k2 = k2 - 5;
                            if (k3 > 270)
                            {
                                image6.Margin = new Thickness(277, k3, 0, 0); k3 = k3 - 5;
                            }
                            else
                                flag = false;

                        }
                    }
                    else
                    {
                        NavigationService.Navigate(new Uri("/Page34.xaml", UriKind.Relative));
                    }
                });
            }
            //    doStuff3();
        }
    }
}