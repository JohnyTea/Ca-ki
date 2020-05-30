using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Całki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MetodaProstokatow_Button_Click(object sender, EventArgs e)
        {
            string[] wspolczynikiSTR = wspolczynniki_TB.Text.Split(' ');
            double[] wspolczynniki = new double[wspolczynikiSTR.Length];
            for (int i = 0; i < wspolczynikiSTR.Length; i++)
            {
                wspolczynniki[i] = double.Parse(wspolczynikiSTR[i]);
            }
            double lewaGranica = double.Parse(lewyKraniec_TB.Text);
            double prawaGranica = double.Parse(prawyKraniec_TB.Text);
            int n = int.Parse(wartoscN_TB.Text);

            LiczProstokaty(wspolczynniki, lewaGranica, prawaGranica, n);
            

        }

        private void LiczProstokaty(double[] wspolczynniki, double lewaGranica, double prawaGranica, int n)
        {
            
            wyniki_TB.Clear();
            double skok = (prawaGranica - lewaGranica) / n;
            double x = lewaGranica;
            double wynik = 0;
            double wysokosc;

            for (int i = 0; i < n; i++)
            {
                wysokosc = 0;
                for (int j = 0; j < wspolczynniki.Length; j++)
                {
                    wysokosc += wspolczynniki[j]*Math.Pow(x, wspolczynniki.Length-j-1);
                }
                wynik += wysokosc * skok;
                x += skok;
            }

            wyniki_TB.Text += $"Wartosc z niedomiarem: {wynik}\n";
            wynik = 0;
            x = lewaGranica;

            for (int i = 0; i < n; i++)
            {
                wysokosc = 0;
                x += skok;
                for (int j = 0; j < wspolczynniki.Length; j++)
                {
                    wysokosc += wspolczynniki[j] * Math.Pow(x, wspolczynniki.Length - j - 1);
                }
                wynik += wysokosc * skok;
                
            }

            wyniki_TB.Text += $"Wartosc z nadmiarem: {wynik}\n";
        }

        private void MetodaTrapezow_Button_Click(object sender, EventArgs e)
        {
            string[] wspolczynikiSTR = wspolczynniki_TB.Text.Split(' ');
            double[] wspolczynniki = new double[wspolczynikiSTR.Length];
            for (int i = 0; i < wspolczynikiSTR.Length; i++)
            {
                wspolczynniki[i] = double.Parse(wspolczynikiSTR[i]);
            }
            double lewaGranica = double.Parse(lewyKraniec_TB.Text);
            double prawaGranica = double.Parse(prawyKraniec_TB.Text);
            int n = int.Parse(wartoscN_TB.Text);

            LiczTrapezy(wspolczynniki, lewaGranica, prawaGranica, n);
        }

        private void LiczTrapezy(double[] wspolczynniki, double lewaGranica, double prawaGranica, int n)
        {
            wyniki_TB.Clear();
            double skok = (prawaGranica - lewaGranica) / n;
            double x = lewaGranica;
            double wynik = 0;
            double[] wysokosci = new double[n+1];
            for (int i = 0; i < n+1; i++)
            {
                for (int j = 0; j < wspolczynniki.Length; j++)
                {
                    wysokosci[i] += wspolczynniki[j] * Math.Pow(x, wspolczynniki.Length - j - 1);
                }
                x += skok;
            }
            for (int i = 1; i < wysokosci.Length-1; i++)
            {
                wynik += wysokosci[i];
            }
            wynik += (wysokosci[0] + wysokosci[wysokosci.Length - 1]) / 2;
            wynik *= skok;
            wyniki_TB.Text += $"Wartosc całki liczona trapezami: {wynik}\n";
        }

        private void DetodaSimpsona_Button_Click(object sender, EventArgs e)
        {
            string[] wspolczynikiSTR = wspolczynniki_TB.Text.Split(' ');
            double[] wspolczynniki = new double[wspolczynikiSTR.Length];
            for (int i = 0; i < wspolczynikiSTR.Length; i++)
            {
                wspolczynniki[i] = double.Parse(wspolczynikiSTR[i]);
            }
            double lewaGranica = double.Parse(lewyKraniec_TB.Text);
            double prawaGranica = double.Parse(prawyKraniec_TB.Text);
            int n = int.Parse(wartoscN_TB.Text);

            LiczSimpson(wspolczynniki, lewaGranica, prawaGranica, n);
        }

        private void LiczSimpson(double[] wspolczynniki, double lewaGranica, double prawaGranica, int n)
        {
            if (n % 2 != 0)
            {
                return;
            }
            wyniki_TB.Clear();
            double skok = (prawaGranica - lewaGranica) / n;
            double x = lewaGranica;
            double wynik = 0;
            double[] wysokosci = new double[n + 1];
            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < wspolczynniki.Length; j++)
                {
                    wysokosci[i] += wspolczynniki[j] * Math.Pow(x, wspolczynniki.Length - j - 1);
                }
                x += skok;
            }
            for (int i = 1; i < wysokosci.Length - 1; i += 2)
            {
                wynik += 4 * wysokosci[i];
            }
            for (int i = 2; i < wysokosci.Length - 1; i += 2)
            {
                wynik += 2 * wysokosci[i];
            }
            wynik += wysokosci[0] + wysokosci[wysokosci.Length - 1];
            wynik *= skok/3;
            wyniki_TB.Text += $"Wartosc całki liczona Simpsonem: {wynik}\n";
        }
    }
}
