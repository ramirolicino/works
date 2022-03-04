using System;
using System.Windows.Forms;
using Entidades;


namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOperar_Click(object sender, EventArgs e)
        {
            string num1 = txtNumero1.Text;
            string num2 = txtNumero2.Text;
            string operador = cmbOperador.Text;
            double resultado = Operar(num1, num2, operador);
            lblResultado.Text = resultado.ToString();

            if (num1 == string.Empty)
            {
                num1 = "0";
            }
            if (num2 == string.Empty)
            {
                num2 = "0";
            }
            if (operador == " ")
            {
                operador = "+";
            }

            lstResultados.Items.Add($"{num1}{operador}{num2} = {resultado}");
        }

        private void btBinario_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblResultado.Text, out double aux))
            {
                Operando resultado = new Operando(lblResultado.Text);
                string numeroBinario = resultado.DecimalBinario(lblResultado.Text);
                if (aux >= 0)
                {
                    lstResultados.Items.Add($"{lblResultado.Text}D = {numeroBinario}B");
                }

                lblResultado.Text = numeroBinario;
            }
            else
            {
                MessageBox.Show("Debe ingresar un valor válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btDecimal_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblResultado.Text, out _))
            {
                Operando resultado = new Operando(lblResultado.Text);
                string numeroDecimal = resultado.BinarioDecimal(lblResultado.Text);
                if (int.TryParse(numeroDecimal, out _))
                {
                    lstResultados.Items.Add($"{lblResultado.Text}B = {numeroDecimal}D");
                }

                lblResultado.Text = numeroDecimal;
            }
            else
            {
                MessageBox.Show("Debe ingresar un valor válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        //METODOS

        /// <summary>
        /// Limpia la consola 
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = string.Empty;
            cmbOperador.SelectedIndex = 0;
        }


        private double Operar(string num1, string num2, string operador)
        {
            Operando operando1 = new Operando(num1);
            Operando operando2 = new Operando(num2);
            char operadorChar = char.Parse(operador);
            return Calculadora.Operar(operando1, operando2, operadorChar);
        }

    }
}
