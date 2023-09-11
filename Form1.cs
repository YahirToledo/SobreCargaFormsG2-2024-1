using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SobreCargaFormsG2_2024_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            lbSuma.Text = Suma(float.Parse(txtbOperando1.Text), float.Parse(txtbOperando2.Text)).ToString();
        }
        private void btnSuma2_Click(object sender, EventArgs e)
        {
            lbSuma2.Text = Suma(float.Parse(txtbOperando21.Text), float.Parse(txtbOperando22.Text), float.Parse(txtbOperando23.Text)).ToString();
        }
        private void btnMultiplicacion3_Click(object sender, EventArgs e)
        {
            lbMultiplicacion3.Text = Multiplicacion(float.Parse(txtbOperando31.Text), float.Parse(txtbOperando32.Text)).ToString();
        }
        private void btnMultiplicacion4_Click(object sender, EventArgs e)
        {
            lbMultiplicacion4.Text = Multiplicacion(float.Parse(txtbOperando41.Text), float.Parse(txtbOperando42.Text), float.Parse(txtbOperando43.Text)).ToString();
        }
        #region Metodos Sobrecargados
        private float Suma(float sumando1, float sumando2)
        {
            return sumando1 + sumando2;
        }
        private float Suma(float sumando1, float sumando2, float sumando3)
        {
            return sumando1 + sumando2 + sumando3;
        }
        private float Multiplicacion(float factor1, float factor2)
        {
            return factor1 * factor2;
        }
        private float Multiplicacion(float factor1, float factor2, float factor3)
        {
            return factor1 * factor2 * factor3;
        }
        #endregion
    }
}
