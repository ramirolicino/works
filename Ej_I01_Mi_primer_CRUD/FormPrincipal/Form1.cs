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

namespace FormPrincipal
{
    public partial class Form1 : Form
    {
        private PersonaDAO personaDAO;

        public Form1()
        {
            InitializeComponent();
            personaDAO = new PersonaDAO();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_cargar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
       
        private void bt_modificar_Click(object sender, EventArgs e)
        {
            if (data_personas.SelectedRows.Count > 0)
            {
                Persona nuevaPersona = new Persona(tx_nombre.Text, tx_apellido.Text);

                personaDAO.Modificar(nuevaPersona);
                Actualizar();
            }
            else
            {
                MessageBox.Show("Seleccione persona", "Error", MessageBoxButtons.OK);
            }
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (data_personas.SelectedRows.Count > 0)
            {
                Persona persona = (Persona)data_personas.CurrentRow.DataBoundItem;
                personaDAO.Borrar(persona.Id);
                Actualizar();
            }
            else
            {
                MessageBox.Show("Seleccione persona","Error", MessageBoxButtons.OK);
            }
        }


        private void Actualizar()
        {
            data_personas.DataSource = personaDAO.Leer();
            data_personas.Update();
            data_personas.Refresh();
        }

    }
}
