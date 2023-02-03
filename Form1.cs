using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2CastingNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertirEntero_Click(object sender, EventArgs e)
        { 
            int result = (Int32.Parse(txtBDameEntero.Text)) * 2;
            txtBResultadoDoble.Text = result.ToString();
            int result2 = (Int32.Parse(txtBDameEntero.Text)) / 2;
            txtBResultadoMitad.Text = result2.ToString();
        }

        private void btnConvertirReal_Click(object sender, EventArgs e)
        {
            float result = (float.Parse(txtBDameReal.Text)) * 2;
            txtBResultadoDoble.Text = result.ToString();
            float result2 = (float.Parse(txtBDameReal.Text)) / 2;
            txtBResultadoMitad.Text = result2.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
