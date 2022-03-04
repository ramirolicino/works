using Entidades;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Cuartel : Form
    {
        private List<Bombero> bomberos;
        private List<PictureBox> fuegos;
        private CancellationTokenSource cancellationTokenSource;

        public Cuartel()
        {
            InitializeComponent();

            cancellationTokenSource = new CancellationTokenSource();
            fuegos = new List<PictureBox>();
            fuegos.Add(fuego1);
            fuegos.Add(fuego2);
            fuegos.Add(fuego3);
            fuegos.Add(fuego4);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            bomberos = new List<Bombero>();
            Bombero b1 = new Bombero("M. Palermo");
            b1.MarcarFin += OcultarBombero;
            bomberos.Add(b1);
            Bombero b2 = new Bombero("G. Schelotto");
            b2.MarcarFin += OcultarBombero;
            bomberos.Add(b2);
            Bombero b3 = new Bombero("C. Tevez");
            b3.MarcarFin += OcultarBombero;
            bomberos.Add(b3);
            Bombero b4 = new Bombero("F. Gago");
            b4.MarcarFin += OcultarBombero;
            bomberos.Add(b4);
        }

        private void btnEnviar1_Click(object sender, EventArgs e)
        {
            EnviarBombero(0);
        }

        private void btnEnviar2_Click(object sender, EventArgs e)
        {
            EnviarBombero(1);
        }

        private void btnEnviar3_Click(object sender, EventArgs e)
        {
            EnviarBombero(2);
        }

        private void btnEnviar4_Click(object sender, EventArgs e)
        {
            EnviarBombero(3);
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {
            ReportesXML(0);
        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {
            ReportesXML(1);
        }

        private void btnReporte3_Click(object sender, EventArgs e)
        {
            ReportesXML(2);
        }

        private void btnReporte4_Click(object sender, EventArgs e)
        {
            ReportesXML(3);
        }

        private void Cuartel_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource.Cancel();
        }


        private void DespacharServicio(int index)
        {
            Bombero bombero = bomberos[index];
            VerificarBomberoOcupado(bombero);
            fuegos[index].Visible = true;
            Task.Run(() => bombero.AtenderSalida(index), cancellationTokenSource.Token);
        }

        private void OcultarBombero(int bomberoIndex)
        {
            if (InvokeRequired)
            {
                Action<int> ocultarBombero = OcultarBombero;
                Invoke(ocultarBombero, bomberoIndex);
            }
            else
            {
                fuegos[bomberoIndex].Visible = false;
            }
        }


        private void ReportesXML(int index)
        {
            Bombero bombero = bomberos[index];
            bombero.Guardar(bombero);
        }

        private void VerificarBomberoOcupado(Bombero bombero)
        {
            foreach (Salida item in bombero.Salidas)
            {
                if (item.FechaFin == default)
                {
                    throw new BomberoOcupadoException();
                }
            }
        }

        private void EnviarBombero(int index)
        {
            try
            {
                DespacharServicio(index);
            }
            catch (BomberoOcupadoException)
            {
                MostrarMensajeError(index);
            }
        }

        private void MostrarMensajeError(int index)
        {
            MessageBox.Show($"Bombero {index} ocupado. Espere...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
