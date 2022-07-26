﻿using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            //TODO: Completar con sus datos
            this.Text = "Olicino.Ramiro";
        }


        #region Botones - No cambiar nada   
        private void btn_SerializacionDeserializacion_Click(object sender, EventArgs e)
        {
            try
            {
                new FrmSerializacionDeserializacion().ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        private void btn_BaseDeDatos_Click(object sender, EventArgs e)
        {
            try
            {
                new FrmBaseDeDatos().ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        private void btn_eventos_Click(object sender, EventArgs e)
        {
            try
            {
                new FrmEventos().ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        private void btn_multiHilo_Click(object sender, EventArgs e)
        {
            try
            {
                new FrmProgramacionMultiHilo().ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        #endregion


    }
}
