using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace FormCentralita
{
    public partial class FormPrincipal : Form
    {

        public Centralita centralita = new Centralita("EMPRESA");

        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_generarLLamada_Click(object sender, EventArgs e)
        {
            FrmLlamador frmLlamador = new FrmLlamador(centralita);
            frmLlamador.ShowDialog();
        }


        private void bt_fcTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralita);
            frmMostrar.TipoLlamada = Llamada.TipoLLamadas.Todas;
            frmMostrar.ShowDialog();
        }

        private void bt_fcLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralita);
            frmMostrar.TipoLlamada = Llamada.TipoLLamadas.Local;
            frmMostrar.ShowDialog();
        }

        private void bt_fcProv_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralita);
            frmMostrar.TipoLlamada = Llamada.TipoLLamadas.Provincial;
            frmMostrar.ShowDialog();
        }
    }
}
