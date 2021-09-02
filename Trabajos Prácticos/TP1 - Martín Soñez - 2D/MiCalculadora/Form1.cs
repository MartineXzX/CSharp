using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
            lblResultado.Text = "0";
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        /// <summary>
        /// Cierra el formulario llamando al método Close().
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
           
            if(MessageBox.Show("Cerrar calculadora?","SALIR", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Convierte el numero en el label a Binario 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
               string numero = lblResultado.Text;
            Numero num = new Numero();
            lblResultado.Text= num.DecimalBinario(numero);
            
        }

        /// <summary>
        /// Convierte el numero en el label a Decimal 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string numero = lblResultado.Text;
            Numero num = new Numero();
            lblResultado.Text = num.BinarioDecimal(numero);
        }

        /// <summary>
        /// Limpia la pantalla del formulario.
        /// </summary>
        void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = "0";
            cmbOperator.Text = "";
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        /// <summary>
        /// Limpia el formulario llamando al método Limpiar() 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Crea 2 instancias de la clase "Numero" y llama al metodo estatico "Operar" de la clase "Calculadora".
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>El resultado de la operacion recibida por parámetros.</returns>
        private static double Operar(string num1, string num2, string operador)
        {
            double resultado;
            Numero n1 = new Numero(num1);
            Numero n2 = new Numero(num2);

            return resultado = Calculadora.Operar(n1, n2, operador);
        }

        /// <summary>
        /// Muestra en el label el resultado de la operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Convert.ToString(Operar(txtNumero1.Text, txtNumero2.Text, cmbOperator.Text));
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = true;
            btnLimpiar.Enabled = true;
        }
    }
}
