using System;
using System.Text;
using System.Windows.Forms;
using Biblioteca;

namespace FormCentralita
{
    public partial class FrmMostrar : Form
    {
        protected Centralita centralita;
        protected Llamada.TipoLLamadas tipoLlamada;

        public Llamada.TipoLLamadas TipoLlamada
        {
            set
            {
                tipoLlamada = value;
            }
        }

        public FrmMostrar(Centralita centralita)
        {
            this.centralita = centralita;
            InitializeComponent();
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            rtb_facturacion.Text = GenerarFacturacion(tipoLlamada);
        }

        private string GenerarFacturacion(Llamada.TipoLLamadas tipoLlamada)
        {
            StringBuilder sb = new();

            switch (tipoLlamada)
            {
                case Llamada.TipoLLamadas.Local:
                    sb.AppendLine($"Facturacion Local: {centralita.GananciasLocal:N2}");
                    break;

                case Llamada.TipoLLamadas.Provincial:
                    sb.AppendLine($"Facturacion Provicial: {centralita.GananciasProvincial:N2}");
                    break;

                case Llamada.TipoLLamadas.Todas:
                    sb.AppendLine($"Facturacion Total: {centralita.GananciasTodas:N2}");
                    break;

                default:
                    sb.AppendLine("VACIO");
                    break;
            }

            return sb.ToString();
        }
    }
}
