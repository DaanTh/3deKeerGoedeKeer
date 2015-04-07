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
using System.IO;

// author: Daan Theunis
// Date: 7/04/2015  15:20
namespace ProjectChallenge
{
    /// <summary>
    /// Interaction logic for Optellen.xaml
    /// </summary>
    public partial class Optellen : Window
    {
        public Boolean volgendeklik = false;
        private char[] seperator = { '=' };
        private string[] gegevens = new string[2];
        private string[,] oefeningen1 = new string[8327, 2];
        private string[,] oefeningen2 = new string[9010, 2];
        //oefeningen3 nog niet af
        private string[,] oefeningen3 = new string[100, 2];
        int i = 0;
        int teller = 1;
        int gtl;
        int score = 0;
        int totaal = 0;

        public Optellen()
        {
            InitializeComponent();

            // oefeningen moeten nog geoptimaliseerd worden om compatibel te zijn met de lengte van de file
            if (Window3.eersteclick == true)
            {
                StreamReader lezer = File.OpenText("optellingen.txt");
                string line = lezer.ReadLine();
                while (line != null)
                {
                    gegevens = line.Split(seperator);
                    oefeningen1[i, 0] = gegevens[0];
                    oefeningen1[i, 1] = gegevens[1];
                    line = lezer.ReadLine();
                    i++;
                }
                genereerVraag();
            }
            else if (Window3.tweedeclick == true)
            {
                StreamReader lezer = File.OpenText("optellingen2.txt");
                string line = lezer.ReadLine();

                while (line != null)
                {
                    gegevens = line.Split(seperator);
                    oefeningen2[i, 0] = gegevens[0];
                    oefeningen2[i, 1] = gegevens[1];
                    line = lezer.ReadLine();
                    i++;
                }
                genereerVraag();
            }
            else if (Window3.derdeclick == true)
            {
                StreamReader lezer = File.OpenText("tafelsvmaal3.txt");
                string line = lezer.ReadLine();

                while (line != null)
                {
                    gegevens = line.Split(seperator);
                    oefeningen3[i, 0] = gegevens[0].Trim();
                    oefeningen3[i, 1] = gegevens[1];
                    line = lezer.ReadLine();
                    i++;
                }
                genereerVraag(); 
            }
        }

        private void volgende_Click(object sender, RoutedEventArgs e)
        {
            if (Window3.eersteclick == true)
            {
                if (oefeningen1[gtl, 1] == uitkomst.Text)
                {
                    score++;
                }
                genereerVraag();
                teller++;
                controleerScore();
                punten.Text = score.ToString();
                totaal++;
                op10.Text = totaal.ToString();

            }
            if (Window3.tweedeclick == true)
            {
                if (oefeningen2[gtl, 1] == oefeningen2[gtl, 1])
                {
                    score++;
                }
                genereerVraag();
                teller++;
                controleerScore();
                punten.Text = score.ToString();
                totaal++;
                op10.Text = totaal.ToString();
            }
            if (Window3.derdeclick == true)
            {
                if (oefeningen3[gtl, 1] == oefeningen3[gtl, 1])
                {
                    score++;
                }
                genereerVraag();
                teller++;
                controleerScore();
                punten.Text = score.ToString();
                totaal++;
                op10.Text = totaal.ToString();
            }
        }

        private void controleerScore()
        {
            if (teller > 10)
            {
                volgende.Visibility = System.Windows.Visibility.Hidden;
                eindig.Visibility = System.Windows.Visibility.Visible;
            }
        }

        public void genereerVraag()
        {
            if (Window3.eersteclick == true)
            {
                Random g = new Random();
                gtl = g.Next(oefeningen1.Length - 8327);
                oefening.Text = oefeningen1[gtl, 0];
            }
            else if (Window3.tweedeclick == true)
            {
                Random g = new Random();
                int gtl = g.Next(oefeningen2.Length - 9010);
                oefening.Text = oefeningen2[gtl, 0];
            }
            else if (Window3.derdeclick == true)
            {
                Random g = new Random();
                int gtl = g.Next(oefeningen3.Length - 100);
                oefening.Text = oefeningen3[gtl, 0];
            }
        }

        private void op10_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
