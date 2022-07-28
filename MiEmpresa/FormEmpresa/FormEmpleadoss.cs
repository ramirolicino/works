using Biblioteca;
using System;
using System.Windows.Forms;

namespace FormEmpresa
{
    public partial class FormEmpleadoss : Form
    {
        public FormEmpleadoss()
        {
            InitializeComponent();
        }

        private void FormEmpleadoss_Load(object sender, EventArgs e)
        {
            Actualizar(1);
        }

        private void bt_alta_Click(object sender, EventArgs e)
        {
            AltaEmpleado();
        }

        private void dgv_empleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EstablecerOpcion(e);
        }
        private void bt_empInac_Click(object sender, EventArgs e)
        {
            Actualizar(0);
        }

        private void bt_empAct_Click(object sender, EventArgs e)
        {
            Actualizar(1);
        }

        private void bt_limpiar_Click_1(object sender, EventArgs e)
        {
            Actualizar(1);
        }


        private void bt_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }







        //METODOS

        private void Actualizar(int indicar)
        {
            if (indicar == 1)
            {

                dgv_empleados.DataSource = null;
                dgv_empleados.DataSource = ManejadorEmpresa.EmpleadosActivo;
                dgv_empleados.Update();
                dgv_empleados.Refresh();
                if (dgv_empleados.Rows.Count > 0)
                {
                    dgv_empleados.Rows[0].Selected = false;
                }
                txt_nombre.Text = string.Empty;
                txt_apellido.Text = string.Empty;
                gb_sexo.Text = string.Empty;
                rbt_mas.Checked = false;
                rbt_fem.Checked = false;
                rbt_bin.Checked = false;


                //Editar datagrid
                dgv_empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_empleados.Columns["Eliminar"].Visible = true;
                dgv_empleados.Columns["Modificar"].Visible = true;
                dgv_empleados.Columns["Modificar"].DisplayIndex = 9;
                dgv_empleados.Columns["Eliminar"].DisplayIndex = 9;
                dgv_empleados.Columns["Activar"].Visible = false;
            }
            else
            {
                dgv_empleados.DataSource = null;
                dgv_empleados.DataSource = ManejadorEmpresa.EmpleadosInactivos;
                dgv_empleados.Update();
                dgv_empleados.Refresh();
                if (dgv_empleados.Rows.Count > 0)
                {
                    dgv_empleados.Rows[0].Selected = false;
                }
                txt_nombre.Text = string.Empty;
                txt_apellido.Text = string.Empty;
                gb_sexo.Text = string.Empty;
                rbt_mas.Checked = false;
                rbt_fem.Checked = false;
                rbt_bin.Checked = false;


                //Editar datagrid
                dgv_empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_empleados.Columns["Eliminar"].Visible = false;
                dgv_empleados.Columns["Modificar"].Visible = false;
                dgv_empleados.Columns["Activar"].Visible = true;
                dgv_empleados.Columns["Activar"].DisplayIndex = 8;
            }

        }


        private void EstablecerOpcion(DataGridViewCellEventArgs e)
        {
            if (dgv_empleados.Columns[e.ColumnIndex].Name == "Modificar")
            {
                ModificarEmpleado();
            }
            else if (dgv_empleados.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                EliminarEmpleado();
            }
            else if (dgv_empleados.Columns[e.ColumnIndex].Name == "Activar")
            {
                DarAltaEmpleado();
            }
        }



        private Empleado EmpleadoSeleccionado(int indicar)
        {
            Empleado emp = null;
            int indice;

            if (indicar == 1)
            {

                try
                {
                    foreach (DataGridViewRow item in dgv_empleados.Rows)
                    {
                        indice = dgv_empleados.CurrentRow.Cells["Id"].RowIndex;
                        emp = ManejadorEmpresa.EmpleadosActivo[indice];
                    }

                    return emp;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                try
                {
                    foreach (DataGridViewRow item in dgv_empleados.Rows)
                    {
                        indice = dgv_empleados.CurrentRow.Cells["Id"].RowIndex;
                        emp = ManejadorEmpresa.EmpleadosInactivos[indice];
                    }

                    return emp;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        private void DarAltaEmpleado()
        {
            Empleado empAlta = EmpleadoSeleccionado(0);

            DialogResult dialogResult = MessageBox.Show($"Empelado: {empAlta.Apellido}", "DAR DE ALTA", MessageBoxButtons.YesNo);
            if (dialogResult is DialogResult.Yes)
            {
                try
                {
                    if (ManejadorEmpresa.AltaEmpleado(empAlta))
                    {
                        MessageBox.Show($"{empAlta.ToString()}  \nFue dado de ALTA exitosamente");
                        Actualizar(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void EliminarEmpleado()
        {
            Empleado empEliminar = EmpleadoSeleccionado(1);

            DialogResult dialogResult = MessageBox.Show($"Empelado: {empEliminar.Apellido}", "DAR DE BAJA", MessageBoxButtons.YesNo);
            if (dialogResult is DialogResult.Yes)
            {
                try
                {
                    if (ManejadorEmpresa.BajaEmpleado(empEliminar))
                    {
                        MessageBox.Show($"{empEliminar.ToString()}  \nFue dado de BAJA exitosamente");
                        Actualizar(1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void ModificarEmpleado()
        {
            Empleado empModificar = EmpleadoSeleccionado(1);

            FormModificacion formModificacion = new(empModificar);
            formModificacion.ShowDialog();
            Actualizar(1);
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


        private void AltaEmpleado()
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
            else if (rbt_fem.Checked == true)
            {
                sexo = rbt_fem.Text;
            }
            else if (rbt_bin.Checked == true)
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

                    Empleado empleado = new Empleado(nombre.UpperFirstChar(), apellido.UpperFirstChar(), sexo, DateTime.Today, descPuesto, estado);

                    if (ManejadorEmpresa.AgregarEmpleado(empleado))
                    {
                        MessageBox.Show("Datos guardados correctamente", "Confirmar", MessageBoxButtons.OK);
                        Actualizar(1);
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
