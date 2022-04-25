using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Vista
{
    public partial class FrmBacklog : Form
    {
        private List<Serie> backLog;
        private List<Serie> seriesParaVer;
        private Serializadora serializadora;
        private ManejadorBackLog manejador;


        public FrmBacklog()
        {
            seriesParaVer = new List<Serie>();
            serializadora = new Serializadora();
            manejador = new ManejadorBackLog();
            backLog = new List<Serie>();


            InitializeComponent();
        }


        private void FrmBacklog_Load(object sender, EventArgs e)
        {
            //Asignar como manejador del evento NuevaSerieParaVer de manejador al método del formulario CambiarEstadoSerie.
            lstbBacklog.DataSource = backLog;
            manejador.IniciarManejador(backLog);
        }


        private void CambiarEstadoSerie(Serie serie)
        {
            seriesParaVer.Add(serie);
            backLog.Remove(serie);
            Refrescar();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSerializar_Click(object sender, EventArgs e)
        {
            SerializarJSON();
            SerializarXML();
        }


        private void Refrescar()
        {
            lstbBacklog.DataSource = null;
            lstbParaVer.DataSource = null;

            lstbBacklog.DataSource = backLog;
            lstbParaVer.DataSource = seriesParaVer;
            lstbBacklog.Refresh();
            lstbBacklog.Update();
        }

        private void SerializarXML()
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = Path.Combine(rutaEscritorio, "log.xml");
            DialogResult = DialogResult.OK;
            

            serializadora.Guardar(backLog, rutaArchivo);
        }


        private void SerializarJSON()
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = Path.Combine(rutaEscritorio, "log.json");
            DialogResult = DialogResult.OK;

            serializadora.Guardar(seriesParaVer, rutaArchivo);
        }
    }
}

