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
            double ivestasSkaicius;

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
    }
}
