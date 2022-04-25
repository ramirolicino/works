using System;
using System.Windows.Forms;
using Biblioteca;

namespace FormCentralita
{
    public partial class FrmLlamador : Form
    {
        private Centralita centralita;


        public FrmLlamador(Centralita centralita)
        {
            this.centralita = centralita;
            InitializeComponent();
        }

        public Centralita Centralita
        {
            get
            {
                return centralita;
            }
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            cmb_franja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            cmb_franja.Enabled = false;

        }

        private void Teclado_Click(object sender, EventArgs e)
        {
            txt_nroDestino.Text += ((Button)sender).Text;

            if (txt_nroDestino.Text[0] == '#')
            {
                cmb_franja.Enabled = true;
            }
        }

        private void bt_llamar_Click(object sender, EventArgs e)
        {
            if (txt_nroDestino.Text == "" || txt_nroOrigen.Text == "")
            {
                MessageBox.Show("Debe ingresar un número de orígen y un número de destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Provincial.Franja franjas;
                Enum.TryParse<Provincial.Franja>(cmb_franja.SelectedValue.ToString(), out franjas);

                float duracion = GenerarNumeroRandom(1, 51);

                if (txt_nroDestino.Text[0] == '#')
                {
                    Provincial auxiliar = new Provincial(txt_nroOrigen.Text, franjas, duracion, txt_nroDestino.Text);
                    centralita.Llamadas.Add(auxiliar);
                }
                else
                {
                    float costo = (GenerarNumeroRandom(5, 57) / 10);
                    Local auxiliar = new Local(txt_nroOrigen.Text, duracion, txt_nroDestino.Text, costo);
                    centralita.Llamadas.Add(auxiliar);
                }

                this.Close();
            }
        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            txt_nroDestino.Text = "";
            txt_nroOrigen.Text = "";
            cmb_franja.Enabled = false;
        }


        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private float GenerarNumeroRandom(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }
}
