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
using System.Threading;
using System.Windows.Media.Imaging;

namespace MD
{
    
    public partial class Page2 : PhoneApplicationPage
    {
        public Page2()
        {
            InitializeComponent();

            
        }
        void leve1()
        {

        }
        public void doStuff()
        {
           
            System.Threading.Thread startupThread =
                             new System.Threading.Thread(new System.Threading.ThreadStart(pDelay2));
            startupThread.Start();
        }
        public void doStuff2()
        {

            System.Threading.Thread startupThread =
                             new System.Threading.Thread(new System.Threading.ThreadStart(pDelay3));
            startupThread.Start();
        }
        public void doStuff3()
        {
            button2.Visibility = Visibility;
        }
        BitmapImage im2 = new BitmapImage(new Uri("/MD;component/Images/sds.png", UriKind.Relative));
        BitmapImage im1 = new BitmapImage(new Uri("/MD;component/Images/z.png", UriKind.Relative));
        BitmapImage im3 = new BitmapImage(new Uri("/MD;component/q.png", UriKind.Relative));
        BitmapImage im4 = new BitmapImage(new Uri("/MD;component/w.png", UriKind.Relative));
        BitmapImage im5 = new BitmapImage(new Uri("/MD;component/Xtvv.jpg", UriKind.Relative));
        BitmapImage im6 = new BitmapImage(new Uri("/MD;component/dhaka2.png", UriKind.Relative));
        BitmapImage im7 = new BitmapImage(new Uri("/MD;component/ww.png", UriKind.Relative));
        BitmapImage im8 = new BitmapImage(new Uri("/MD;component/v1.png", UriKind.Relative));
        BitmapImage im9 = new BitmapImage(new Uri("/MD;component/v2.png", UriKind.Relative));
 
        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            
            System.Threading.Thread startupThread =
                              new System.Threading.Thread(new System.Threading.ThreadStart(pDelay));
            startupThread.Start();
           // DoStuff();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
           
    
        }
        void pDelay3()
        {
            int k = 20, j = 1, m = 0;
            Boolean flag2 = true;
            for (int i = 0; i < 50; i++)
            {
                System.Threading.Thread.Sleep(150);

                this.Dispatcher.BeginInvoke(() =>
                {
                    image1.Source = im5;

                    {
                        image3.Visibility = Visibility;
                        if (flag2)
                        {
                            if (image3.Height != 0 || image3.Width != 0)
                            {
                                image3.Height = image3.Height - 10;
                                image3.Width = image3.Width - 10;
                            }
                            else
                            {
                                button2.Visibility = Visibility;
                            }
                            
                        }

                    }
                });
            }
        //    doStuff3();
        }
        void pDelay2()
        {
            int k=20,j=1,m=0;
             Boolean flag2 = true;
            for (int i = 0; i < 50; i++)
            {
                System.Threading.Thread.Sleep(150);

                this.Dispatcher.BeginInvoke(() =>
                {
                    image1.Source = im5;
                    image2.Source = im3;
                   
                    {
                        image3.Visibility = Visibility;
                        if (flag2)
                        {
                            if (image3.Height < 110 || image3.Width < 130)
                            {
                                image3.Height = image3.Height + 10;
                                image3.Width = image3.Width + 10;
                            }
                            else
                            {
                                //NavigationService.Navigate(new Uri("/Page2a.xaml", UriKind.Relative));
                                if (j == 0)
                                {
                                    image3.Source = im8;
                                    j=1;
                                }
                                else
                                {
                                    image3.Source = im9;
                                    j = 0;
                                }
                            }
                        }
                           
                        }                     
                });
            }
            doStuff2();
        }

        void pDelay()
        {
            int j = 0, k = 6,m=550,n=550;
            Boolean flag = true;
           


            //  BitmapImage im2 = new BitmapImage(new Uri("/try_audio;component/QCACUCP08CAEBUQ2YCAILL857CAHZVVZLCAPHAO8GCACD7V9RCAMBR4T9CA4N6E49CATW1AQKCAE8VKAKCADCXHLKCAYDTVOPCA2IVZEFCASZSJ9FCA22SMNSCA4ZY05DCA5DLWSCCATJG9VXCAD374WZ.jpg", UriKind.Relative));
            for (int i = 0; i < 50; i++)
            {

                System.Threading.Thread.Sleep(150);

                this.Dispatcher.BeginInvoke(() =>
                {
                    if(flag)
                    {

                        if (j == 0)
                        {
                            image2.Source = im1;
                            image2.Margin = new Thickness(k, 26, 0, 0); k = k + 10;
                            j = 1; m=m-10;
                            if (m == 0)
                            {
                                flag = false;
                            }


                        }
                        else
                        {
                            image2.Source = im2;
                            image2.Margin = new Thickness(k, 26, 0, 0); k = k + 10;
                            j = 0; m=m-10;
                            if (m == 0)
                            {
                                flag = false;
                            }
                        }
                    }


                    else
                    {
                        if (j == 0)
                        {
                            image2.Source = im3;
                            image2.Margin = new Thickness(k, 26, 0, 0); k = k - 10;
                            j = 1; 
                            
                                m = m + 10;
                                if (m == 550)
                                {
                                    flag = true;
                                }
                        }
                        else
                        {
                            image2.Source = im4;
                            image2.Margin = new Thickness(k, 26, 0, 0); k = k - 10;
                            j = 0; m = m + 10;
                            if (m == 550)
                            {
                                flag = true;
                            }
                        }
                    }
                   



                });
            }
           doStuff();
        }
        
        void azzDelay1()
        {

            for (int i = 0; i < 400; i++)
            {
                Thread.Sleep(250);
                

                this.Dispatcher.BeginInvoke(() =>
                {
                                            

                });
            }
            
        }

        private void image2_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page3.xaml", UriKind.Relative));
        }

        
    }
}