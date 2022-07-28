using Biblioteca;
using System;
using System.Windows.Forms;

namespace FormEmpresa
{
    public partial class FormModificacion : Form
    {
        private Empleado auxEmpleado;
        private Puesto descrPuesto;
        private bool estadoPestaña;

        public bool EstadoPestaña { get => estadoPestaña; set => estadoPestaña = value; }

        public FormModificacion(Empleado emp)
        {
            InitializeComponent();
            auxEmpleado = emp;
            estadoPestaña = false;
            descrPuesto = null;
        }

        private void FormModificacion_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            ModificarEmpleado();
        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = string.Empty;
            txt_apellido.Text = string.Empty;
        }


        private void Actualizar()
        {
            if (bt_modificar.Text is "MODIFICAR")
            {
                txt_nombre.Text = auxEmpleado.Nombre;
                txt_apellido.Text = auxEmpleado.Apellido;
                descrPuesto = Extencion.ConvertirPuesto(auxEmpleado.Puesto.Id);


                //Sexo
                if (auxEmpleado.Sexo == rbt_mas.Text)
                {
                    rbt_mas.Checked = true;
                }

                else if (auxEmpleado.Sexo == rbt_fem.Text)
                {
                    rbt_fem.Checked = true;
                }

                else if (auxEmpleado.Sexo == rbt_bin.Text)
                {
                    rbt_bin.Checked = true;
                }


                //Puesto
                if (descrPuesto.Descripcion == rb_administrcion.Text)
                {
                    rb_administrcion.Checked = true;
                }
                else if (descrPuesto.Descripcion == rb_cocina.Text)
                {
                    rb_cocina.Checked = true;
                }
                else if (descrPuesto.Descripcion == rb_mozo.Text)
                {
                    rb_mozo.Checked = true;
                }
                else if (descrPuesto.Descripcion == rb_limpieza.Text)
                {
                    rb_limpieza.Checked = true;
                }
                else if (descrPuesto.Descripcion == rb_recepcionista.Text)
                {
                    rb_recepcionista.Checked = true;
                }

            }
        }


        private int ExtraerIDPuesto(string descripcion)
        {
            foreach (Puesto item in ManejadorEmpresa.ListaPuestos)
            {
                if (item.Descripcion == descripcion)
                {
                    return item.Id;
                }
            }

            return 0;
        }


        private void ModificarEmpleado()
        {
            string nombre = txt_nombre.Text.ToLower();
            string apellido = txt_apellido.Text.ToLower();
            string sexo = string.Empty;
            int puesto = 0;
            bool estado = true;


            //Sexo
            if (rbt_mas.Checked == true)
            {
                sexo = rbt_mas.Text;
            }
            if (rbt_fem.Checked == true)
            {
                sexo = rbt_fem.Text;
            }
            if (rbt_bin.Checked == true)
            {
                sexo = rbt_bin.Text;
            }

            //Puesto
            if (rb_administrcion.Checked == true)
            {
                puesto = ExtraerIDPuesto(rb_administrcion.Text);
            }
            else if (rb_cocina.Checked == true)
            {
                puesto = ExtraerIDPuesto(rb_cocina.Text);
            }
            else if (rb_mozo.Checked == true)
            {
                puesto = ExtraerIDPuesto(rb_mozo.Text);
            }
            else if (rb_limpieza.Checked == true)
            {
                puesto = ExtraerIDPuesto(rb_limpieza.Text);
            }
            else if (rb_recepcionista.Checked == true)
            {
                puesto = ExtraerIDPuesto(rb_recepcionista.Text);
            }



            try
            {
                if (!string.IsNullOrWhiteSpace(nombre) &&
                   !string.IsNullOrWhiteSpace(apellido) &&
                   !string.IsNullOrWhiteSpace(sexo) &&
                   puesto > 0)
                {
                    Puesto descPuesto = Extencion.ConvertirPuesto(puesto);

                    auxEmpleado = new Empleado(auxEmpleado.Id, nombre.UpperFirstChar(), apellido.UpperFirstChar(), sexo, DateTime.Today, descPuesto, estado);

                    if (ManejadorEmpresa.ModificarEmpleado(auxEmpleado))
                    {
                        MessageBox.Show("Datos guardados correctamente", "Confirmar", MessageBoxButtons.OK);
                        estadoPestaña = true;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show($"Debe completar el/los campo/s", "ERROR", MessageBoxButtons.OK);
                }
            }
            catch (EmpleadoExcepcion ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }


    }
}
