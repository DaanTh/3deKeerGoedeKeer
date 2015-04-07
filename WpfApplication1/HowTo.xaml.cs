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

//Author : Axel Bollen
//Date : 07.04.2015

namespace ProjectChallenge
{
    /// <summary>
    /// Interaction logic for HowToPlay.xaml
    /// </summary>
    public partial class HowToPlay : Window
    {
        public HowToPlay()
        {
            InitializeComponent();
        }

        private void Speel_Click(object sender, RoutedEventArgs e)
        {
            Window2 leerstofselectie = new Window2();
            leerstofselectie.Show();
            this.Close();
        }

        private void Credits_Click(object sender, RoutedEventArgs e)
        {
            Credits credits = new Credits();
            credits.Show();
            this.Close();
        }

        private void Uitleg_Click(object sender, RoutedEventArgs e)
        {
            Uitleg2 uitleg = new Uitleg2();
            uitleg.Show();
            this.Close();
        }
    }
}
