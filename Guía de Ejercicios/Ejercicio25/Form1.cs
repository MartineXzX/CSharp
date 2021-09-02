using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio22;
using Ejercicio13;

namespace Ejercicio25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            NumeroBinario bin = txtBinario.Text;
            txtResultadoDec.Text = Conversor.BinarioDecimal(bin.numero).ToString();
        }
        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            NumeroDecimal dec = double.Parse(txtDecimal.Text);
            txtResultadoBin.Text = Conversor.DecimalBinario((int)dec.numero);
        }

    }
}
