using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitUzduotis
{
    public partial class Form1 : Form
    {
        double[] skaiciai = new double[10];
        int ivestaSkaiciu = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void skaiciuoti_Click(object sender, EventArgs e)
        {
            double ivestasSkaicius = 1;

            if(ivestaSkaiciu > 9)
            {
                double suma = 0;

                foreach (double skaicius in skaiciai)
                {
                    suma += skaicius;
                }

                isvestis.Text = String.Format("Visu ivestu skaiciu suma yra lygi {0}", suma);
            }
            else if (String.IsNullOrEmpty(ivestis.Text) || String.IsNullOrWhiteSpace(ivestis.Text) || !Double.TryParse(ivestis.Text, out ivestasSkaicius))
            {
                isvestis.Text = "Ivestas tekstas turi buti skaicius!";
            }
            else
            {
                skaiciai[ivestaSkaiciu++] = ivestasSkaicius;
                isvestis.Text = String.Format("Liko ivesti {0} skaiciu(-s)", 10 - ivestaSkaiciu);
            }


        }

        private void piesti_Click(object sender, EventArgs e)
        {
            int ivestasSkaicius;
            string tekstas = "";

            if(String.IsNullOrEmpty(eglutesDydis.Text) || String.IsNullOrWhiteSpace(eglutesDydis.Text) || !Int32.TryParse(eglutesDydis.Text, out ivestasSkaicius))
            {
                eglute.Text = "Ivestas tekstas turi buti sveikasis skaicius!";
            }
            else
            {
                for (int i = 0; i <= ivestasSkaicius; i++)
                {
                    for (int j = 0; j < i * 2 - 1; j++)
                    {
                        if(j % 2 == 1)
                        {
                            tekstas += " ";
                        }
                        else
                        {
                            tekstas += "*";
                        }
                    }

                    tekstas += "\n";
                }

                eglute.Text = tekstas;
                eglute.SelectAll();
                eglute.SelectionAlignment = HorizontalAlignment.Center;
            }
        }
    }
}
