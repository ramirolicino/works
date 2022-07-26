using BibliotecaDeClases;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmBaseDeDatos : Form
    {
        SqlManejador manejador; // no modificar
        public FrmBaseDeDatos()
        {
            InitializeComponent(); // no modificar linea
            manejador = new SqlManejador(); // no modificar linea
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno unAlumno = new Alumno(int.Parse(tb_dni.Text), tb_nombre.Text, int.Parse(tb_nota1.Text), int.Parse(tb_nota2.Text));
                //Completar
                if (manejador.Insertar(unAlumno) is 1)
                {
                    MessageBox.Show("Alumno creado correctamente");
                }
                else
                {
                    MessageBox.Show("No se ha podido insertar Alumno");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FrmBaseDeDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
