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
    public partial class Page23 : PhoneApplicationPage
    {
        public Page23()
        {
            InitializeComponent();
            System.Threading.Thread startupThread =
                            new System.Threading.Thread(new System.Threading.ThreadStart(timeDec));
            startupThread.Start();
        }
        Boolean flag1 = true;
        Boolean flag4 = true;
        void timeDec()
        {
            int k = 20, j = 1, m = 0;

            for (int i4 = 0; i4 < 101; i4++)
            {
                System.Threading.Thread.Sleep(1000);

                this.Dispatcher.BeginInvoke(() =>
                {
                    if (flag1)
                    {

                        if (flag4)
                        {
                            string s1;
                            s1 = textBlock8.Text;
                            int num = int.Parse(s1);
                            num--;
                            s1 = num.ToString();
                            textBlock8.Text = s1;
                            //int q = int.Parse(s1);
                            if (i4 == 100)
                            {
                                flag1 = false;
                            }
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                       // NavigationService.Navigate(new Uri("/Page36.xaml", UriKind.Relative));
                    }
                });
            }
        }
        int m = 2, i = 3;
        Boolean flag = true;
        Boolean flag2 = true;
        Boolean flag3 = true;
        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (flag)
            {
                string s1;
                s1 = textBox1.Text;
                if (s1 == "top")
                {
                    textBlock4.Visibility = Visibility.Collapsed;
                    textBlock5.Visibility = Visibility.Collapsed;
                    button3.Content = "continue"; flag = false; flag4 = false;
                    textBlock6.Text = "You got it Right. 4 of 7 letters are unlocked...Press Continue";
                    textBlock11.Text = "T";
                    textBlock14.Text = "J";
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
                        if (flag2)
                        {
                            if (flag3)
                            {
                                image2.Visibility = Visibility.Collapsed;
                                textBlock6.Text = "You lost a life !!! ";
                                textBlock5.Text = "3";
                                m = 2;
                                flag3 = false;
                            }
                            else
                            {
                                image7.Visibility = Visibility.Collapsed;
                                textBlock6.Text = "You lost a second life !!! ";
                                textBlock5.Text = "3";
                                m = 2;

                                flag2 = false;
                            }
                        }
                        else
                        {
                            NavigationService.Navigate(new Uri("/Page35.xaml", UriKind.Relative));
                        }
                    }
                }
            }

            else
            {
                NavigationService.Navigate(new Uri("/Page24.xaml", UriKind.Relative));
            }
        }
    }
}