using BibliotecaDeClases;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmEventos : Form
    {
        Universidad unaUniversidad;  // no modificar

        public FrmEventos()
        {
            InitializeComponent();
            unaUniversidad = new Universidad(GeneradorDeDatos.Rnd.Next(5, 16));
            unaUniversidad.cupoLleno += MostrarMensajeAgradecimiento;
            unaUniversidad.cupoLleno += DesactivarComponentesFormularios;
        }

        // no modificar metodo
        private void btn_AgregarCarreras_Click(object sender, EventArgs e)
        {
            lbox_listado.DataSource = null;
            lbox_listado.DataSource = unaUniversidad.AgregarNuevaCarrera();
        }


        // no modificar metodo
        private void MostrarMensajeAgradecimiento(bool universidadCompleta)
        {
            if (universidadCompleta)
            {
                MessageBox.Show("La carrera se encuentra completa. Agradecemos su participacion.\n Los esperamos la proxima");
                this.lbox_listado.Enabled = !universidadCompleta;
            }
        }

        // no modificar metodo
        private void DesactivarComponentesFormularios(bool estado)
        {
            this.btn_AgregarCursos.Enabled = !estado;
        }

        private void FrmEventos_Load(object sender, EventArgs e)
        {

        }
    }
}
