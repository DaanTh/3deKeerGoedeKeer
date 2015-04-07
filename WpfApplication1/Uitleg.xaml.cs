using System;
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

// Author : Axel Bollen
// Date : 07.04.2015

namespace ProjectChallenge
{
    /// <summary>
    /// Interaction logic for Uitleg.xaml
    /// </summary>
    public partial class Uitleg : Window
    {
        public Uitleg()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HowToPlay startscherm = new HowToPlay(); //Knop toegevoegd om naar startscherm te gaan
            startscherm.Show();
            this.Close();
        }
    }
}
