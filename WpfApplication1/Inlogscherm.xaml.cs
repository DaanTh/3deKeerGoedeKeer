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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

//Author : Daan Theunis
//Date : 03.04.2015 18:56

//Author : Axel Bollen
//Date : 07.04.2015 16:19
namespace ProjectChallenge
{

    public partial class Window1 : Window
    {
        private string[] gegevens = new string[2];
        private char[] seperator = { ',' };
        private string naam;
        private string wachtwoord;
        private string naamFile;
        private string wachtwoordFile;

        public Window1()
        {
            InitializeComponent();
            naam = "";
            wachtwoord = "";
            naamFile = "";
            wachtwoordFile = "";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            wachtwoord = tbWachtwoord.Password;
            naam = tbInlog.Text;
            controleerGegevens();
        }

        private void controleerGegevens()
        {
            StreamReader lezer = File.OpenText("Aanmeldgegevens.txt");
            string line = lezer.ReadLine();
            gegevens = line.Split(seperator);
            naamFile = gegevens[0].Trim();
            wachtwoordFile = gegevens[1].Trim();

            if (naam != naamFile)
            {
                errormessage.Text = "Foutieve gebruikersnaam";
                lezer.Close();
            }
            else if (wachtwoord == wachtwoordFile)
            {
                HowToPlay selectie = new HowToPlay(); // HowToPlay window ipv direct naar leerstofselectie
                selectie.Show();
                this.Close();
            }
            else
            {
                errormessage.Text = "Foutief wachtwoord";
                lezer.Close();
            }



        }
    }
}