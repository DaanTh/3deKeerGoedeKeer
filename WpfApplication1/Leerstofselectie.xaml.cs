﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

//Author : Daan Theunis
//Date : 04.04.2015 17:20

//Author : Axel Bollen
//Date : 07.04.2015

namespace ProjectChallenge
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void wiskunde_Click(object sender, RoutedEventArgs e)
        {
            Window3 wiskunde = new Window3();
            wiskunde.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Startscherm_Click_1(object sender, RoutedEventArgs e)
        {
            HowToPlay startscherm = new HowToPlay(); //Knop toegevoegd om naar startscherm te gaan
            startscherm.Show();
            this.Close();
        }
    }
}
