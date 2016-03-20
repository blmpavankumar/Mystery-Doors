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
    public partial class Page34 : PhoneApplicationPage
    {
        public Page34()
        {
            InitializeComponent();
            System.Threading.Thread startupThread =
                          new System.Threading.Thread(new System.Threading.ThreadStart(pDelay));
            startupThread.Start();
        }
        void pDelay()
        {
            int k = 692, j = 1, g=5,m = 0, n = 5, k1 = 420, k2 = 420, k3 = 420, k4 = 420, k5 = 420, k6 = 420, k7 = 420, k8 = 420;
            Boolean flag = false;
            Boolean flag1 = true;
            Boolean flag2 = false;
            for (int z = 0; z < 400;z++)
            {
                System.Threading.Thread.Sleep(150);

                this.Dispatcher.BeginInvoke(() =>
                {
                    if (flag)
                    {
                        if (flag1)
                        {
                            image1.Width = k;
                            k = k - 20;
                            if (k < 326)
                                flag1 = false;
                        }
                        else
                        {
                            if (k1 > 117)
                            {
                                textBlock1.Visibility = Visibility;
                                textBlock1.Margin = new Thickness(451, k1, 0, 0); k1 = k1 - 20;
                            }
                            else if (k2 > 183)
                            {
                                textBlock1.Margin = new Thickness(451, 119, 0, 0);
                                textBlock2.Visibility = Visibility;
                                textBlock2.Margin = new Thickness(451, k2, 0, 0); k2 = k2 - 20;
                            }
                            else if (k3 > 236)
                            {
                                textBlock2.Margin = new Thickness(451, 184, 0, 0);
                                textBlock3.Visibility = Visibility;
                                textBlock3.Margin = new Thickness(451, k3, 0, 0); k3 = k3 - 20;
                            }
                            else if (k4 > 286)
                            {
                                textBlock3.Margin = new Thickness(451,238, 0, 0);
                                textBlock4.Visibility = Visibility;
                                textBlock4.Margin = new Thickness(451, k4, 0, 0); k4 = k4 - 20;
                            }
                            else if (k5 > 335)
                            {
                                textBlock4.Margin = new Thickness(451, 287, 0, 0);
                                textBlock5.Visibility = Visibility;
                                textBlock5.Margin = new Thickness(451, k5, 0, 0); k5 = k5 - 20;
                            }
                            else
                            {
                                g--;
                                if (g == 0)
                                {
                                    flag2 = true;
                                }
                                if (flag2)
                                {
                                    textBlock1.Visibility = Visibility.Collapsed;
                                    textBlock2.Visibility = Visibility.Collapsed;
                                    textBlock3.Visibility = Visibility.Collapsed;
                                    textBlock4.Visibility = Visibility.Collapsed;
                                    textBlock5.Visibility = Visibility.Collapsed;
                                    textBlock5.Margin = new Thickness(451, 336, 0, 0);
                                    if (k6 > 117)
                                    {
                                        textBlock6.Visibility = Visibility;
                                        textBlock6.Margin = new Thickness(451, k6, 0, 0); k6 = k6 - 20;
                                    }
                                    else if (k7 > 183)
                                    {
                                        textBlock6.Margin = new Thickness(451, 119, 0, 0);
                                        textBlock7.Visibility = Visibility;
                                        textBlock7.Margin = new Thickness(451, k7, 0, 0); k7 = k7 - 20;
                                    }
                                    else if (k8 > 236)
                                    {
                                        textBlock7.Margin = new Thickness(428, 184, 0, 0);
                                        textBlock8.Visibility = Visibility;
                                        textBlock8.Margin = new Thickness(428, k8, 0, 0); k8 = k8 - 20;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        n--;
                        if (n == 0)
                        {
                            flag = true;
                        }
                       // NavigationService.Navigate(new Uri("/Page34.xaml", UriKind.Relative));
                    }
                });
            }
            //    doStuff3();
        }
    }
}