namespace FormEmpresa
{
    partial class FormEmpleadoss
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_cerrar = new System.Windows.Forms.Button();
            this.bt_alta = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.rbt_mas = new System.Windows.Forms.RadioButton();
            this.rbt_fem = new System.Windows.Forms.RadioButton();
            this.rbt_bin = new System.Windows.Forms.RadioButton();
            this.gb_sexo = new System.Windows.Forms.GroupBox();
            this.bt_empInac = new System.Windows.Forms.Button();
            this.bt_empAct = new System.Windows.Forms.Button();
            this.bt_limpiar = new System.Windows.Forms.Button();
            this.gb_puesto = new System.Windows.Forms.GroupBox();
            this.rb_mozo = new System.Windows.Forms.RadioButton();
            this.rb_cocina = new System.Windows.Forms.RadioButton();
            this.rb_limpieza = new System.Windows.Forms.RadioButton();
            this.rb_recepcionista = new System.Windows.Forms.RadioButton();
            this.rb_administrcion = new System.Windows.Forms.RadioButton();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_empleados = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Activar = new System.Windows.Forms.DataGridViewImageColumn();
            this.menuStrip1.SuspendLayout();
            this.gb_sexo.SuspendLayout();
            this.gb_puesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1103, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.cargarToolStripMenuItem.Text = "Cargar";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // bt_cerrar
            // 
            this.bt_cerrar.BackColor = System.Drawing.Color.SlateGray;
            this.bt_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_cerrar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_cerrar.Location = new System.Drawing.Point(12, 492);
            this.bt_cerrar.Name = "bt_cerrar";
            this.bt_cerrar.Size = new System.Drawing.Size(805, 44);
            this.bt_cerrar.TabIndex = 6;
            this.bt_cerrar.Text = "CERRAR";
            this.bt_cerrar.UseVisualStyleBackColor = false;
            this.bt_cerrar.Click += new System.EventHandler(this.bt_cerrar_Click);
            // 
            // bt_alta
            // 
            this.bt_alta.BackColor = System.Drawing.Color.SlateGray;
            this.bt_alta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_alta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_alta.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_alta.Location = new System.Drawing.Point(859, 480);
            this.bt_alta.Name = "bt_alta";
            this.bt_alta.Size = new System.Drawing.Size(200, 56);
            this.bt_alta.TabIndex = 5;
            this.bt_alta.Text = "ALTA";
            this.bt_alta.UseVisualStyleBackColor = false;
            this.bt_alta.Click += new System.EventHandler(this.bt_alta_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nombre.Location = new System.Drawing.Point(859, 79);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PlaceholderText = "       INGRESE NOMBRE";
            this.txt_nombre.Size = new System.Drawing.Size(200, 29);
            this.txt_nombre.TabIndex = 7;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_apellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_apellido.Location = new System.Drawing.Point(859, 127);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.PlaceholderText = "       INGRESE APELLIDO";
            this.txt_apellido.Size = new System.Drawing.Size(200, 29);
            this.txt_apellido.TabIndex = 8;
            // 
            // rbt_mas
            // 
            this.rbt_mas.AutoSize = true;
            this.rbt_mas.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rbt_mas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbt_mas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbt_mas.Location = new System.Drawing.Point(21, 22);
            this.rbt_mas.Name = "rbt_mas";
            this.rbt_mas.Size = new System.Drawing.Size(98, 25);
            this.rbt_mas.TabIndex = 0;
            this.rbt_mas.TabStop = true;
            this.rbt_mas.Text = "Masculino";
            this.rbt_mas.UseVisualStyleBackColor = false;
            // 
            // rbt_fem
            // 
            this.rbt_fem.AutoSize = true;
            this.rbt_fem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rbt_fem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbt_fem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbt_fem.Location = new System.Drawing.Point(21, 57);
            this.rbt_fem.Name = "rbt_fem";
            this.rbt_fem.Size = new System.Drawing.Size(96, 25);
            this.rbt_fem.TabIndex = 1;
            this.rbt_fem.TabStop = true;
            this.rbt_fem.Text = "Femenino";
            this.rbt_fem.UseVisualStyleBackColor = false;
            // 
            // rbt_bin
            // 
            this.rbt_bin.AutoSize = true;
            this.rbt_bin.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rbt_bin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbt_bin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbt_bin.Location = new System.Drawing.Point(21, 92);
            this.rbt_bin.Name = "rbt_bin";
            this.rbt_bin.Size = new System.Drawing.Size(101, 25);
            this.rbt_bin.TabIndex = 2;
            this.rbt_bin.TabStop = true;
            this.rbt_bin.Text = "No Binario";
            this.rbt_bin.UseVisualStyleBackColor = false;
            // 
            // gb_sexo
            // 
            this.gb_sexo.Controls.Add(this.rbt_bin);
            this.gb_sexo.Controls.Add(this.rbt_fem);
            this.gb_sexo.Controls.Add(this.rbt_mas);
            this.gb_sexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_sexo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_sexo.Location = new System.Drawing.Point(859, 175);
            this.gb_sexo.Name = "gb_sexo";
            this.gb_sexo.Size = new System.Drawing.Size(200, 126);
            this.gb_sexo.TabIndex = 9;
            this.gb_sexo.TabStop = false;
            this.gb_sexo.Text = "SEXO";
            // 
            // bt_empInac
            // 
            this.bt_empInac.BackColor = System.Drawing.Color.SlateGray;
            this.bt_empInac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_empInac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_empInac.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_empInac.Location = new System.Drawing.Point(237, 52);
            this.bt_empInac.Name = "bt_empInac";
            this.bt_empInac.Size = new System.Drawing.Size(206, 21);
            this.bt_empInac.TabIndex = 11;
            this.bt_empInac.Text = "EMPLEADOS INACTIVOS";
            this.bt_empInac.UseVisualStyleBackColor = false;
            this.bt_empInac.Click += new System.EventHandler(this.bt_empInac_Click);
            // 
            // bt_empAct
            // 
            this.bt_empAct.BackColor = System.Drawing.Color.SlateGray;
            this.bt_empAct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_empAct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_empAct.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_empAct.Location = new System.Drawing.Point(12, 51);
            this.bt_empAct.Name = "bt_empAct";
            this.bt_empAct.Size = new System.Drawing.Size(206, 22);
            this.bt_empAct.TabIndex = 12;
            this.bt_empAct.Text = "EMPLEADOS ACTIVOS";
            this.bt_empAct.UseVisualStyleBackColor = false;
            this.bt_empAct.Click += new System.EventHandler(this.bt_empAct_Click);
            // 
            // bt_limpiar
            // 
            this.bt_limpiar.BackColor = System.Drawing.Color.SlateGray;
            this.bt_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_limpiar.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_limpiar.Location = new System.Drawing.Point(859, 453);
            this.bt_limpiar.Name = "bt_limpiar";
            this.bt_limpiar.Size = new System.Drawing.Size(200, 21);
            this.bt_limpiar.TabIndex = 13;
            this.bt_limpiar.Text = "REFRESCAR";
            this.bt_limpiar.UseVisualStyleBackColor = false;
            this.bt_limpiar.Click += new System.EventHandler(this.bt_limpiar_Click_1);
            // 
            // gb_puesto
            // 
            this.gb_puesto.Controls.Add(this.rb_mozo);
            this.gb_puesto.Controls.Add(this.rb_cocina);
            this.gb_puesto.Controls.Add(this.rb_limpieza);
            this.gb_puesto.Controls.Add(this.rb_recepcionista);
            this.gb_puesto.Controls.Add(this.rb_administrcion);
            this.gb_puesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_puesto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_puesto.Location = new System.Drawing.Point(836, 322);
            this.gb_puesto.Name = "gb_puesto";
            this.gb_puesto.Size = new System.Drawing.Size(253, 126);
            this.gb_puesto.TabIndex = 18;
            this.gb_puesto.TabStop = false;
            this.gb_puesto.Text = "PUESTO";
            // 
            // rb_mozo
            // 
            this.rb_mozo.AutoSize = true;
            this.rb_mozo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rb_mozo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_mozo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_mozo.Location = new System.Drawing.Point(160, 22);
            this.rb_mozo.Name = "rb_mozo";
            this.rb_mozo.Size = new System.Drawing.Size(80, 25);
            this.rb_mozo.TabIndex = 4;
            this.rb_mozo.TabStop = true;
            this.rb_mozo.Text = "Mozo/a";
            this.rb_mozo.UseVisualStyleBackColor = false;
            // 
            // rb_cocina
            // 
            this.rb_cocina.AutoSize = true;
            this.rb_cocina.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rb_cocina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_cocina.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_cocina.Location = new System.Drawing.Point(160, 84);
            this.rb_cocina.Name = "rb_cocina";
            this.rb_cocina.Size = new System.Drawing.Size(74, 25);
            this.rb_cocina.TabIndex = 3;
            this.rb_cocina.TabStop = true;
            this.rb_cocina.Text = "Cocina";
            this.rb_cocina.UseVisualStyleBackColor = false;
            // 
            // rb_limpieza
            // 
            this.rb_limpieza.AutoSize = true;
            this.rb_limpieza.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rb_limpieza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_limpieza.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_limpieza.Location = new System.Drawing.Point(21, 84);
            this.rb_limpieza.Name = "rb_limpieza";
            this.rb_limpieza.Size = new System.Drawing.Size(89, 25);
            this.rb_limpieza.TabIndex = 2;
            this.rb_limpieza.TabStop = true;
            this.rb_limpieza.Text = "Limpieza";
            this.rb_limpieza.UseVisualStyleBackColor = false;
            // 
            // rb_recepcionista
            // 
            this.rb_recepcionista.AutoSize = true;
            this.rb_recepcionista.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rb_recepcionista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_recepcionista.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_recepcionista.Location = new System.Drawing.Point(21, 53);
            this.rb_recepcionista.Name = "rb_recepcionista";
            this.rb_recepcionista.Size = new System.Drawing.Size(122, 25);
            this.rb_recepcionista.TabIndex = 1;
            this.rb_recepcionista.TabStop = true;
            this.rb_recepcionista.Text = "Recepcionista";
            this.rb_recepcionista.UseVisualStyleBackColor = false;
            // 
            // rb_administrcion
            // 
            this.rb_administrcion.AutoSize = true;
            this.rb_administrcion.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rb_administrcion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_administrcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_administrcion.Location = new System.Drawing.Point(21, 22);
            this.rb_administrcion.Name = "rb_administrcion";
            this.rb_administrcion.Size = new System.Drawing.Size(132, 25);
            this.rb_administrcion.TabIndex = 0;
            this.rb_administrcion.TabStop = true;
            this.rb_administrcion.Text = "Administracion";
            this.rb_administrcion.UseVisualStyleBackColor = false;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(Biblioteca.Empleado);
            // 
            // empleadoBindingSource1
            // 
            this.empleadoBindingSource1.DataSource = typeof(Biblioteca.Empleado);
            // 
            // empleadoBindingSource2
            // 
            this.empleadoBindingSource2.DataSource = typeof(Biblioteca.Empleado);
            // 
            // empleadoBindingSource3
            // 
            this.empleadoBindingSource3.DataSource = typeof(Biblioteca.Empleado);
            // 
            // dgv_empleados
            // 
            this.dgv_empleados.AllowUserToResizeColumns = false;
            this.dgv_empleados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgv_empleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_empleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_empleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_empleados.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv_empleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_empleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_empleados.ColumnHeadersHeight = 25;
            this.dgv_empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar,
            this.Eliminar,
            this.Activar});
            this.dgv_empleados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_empleados.EnableHeadersVisualStyles = false;
            this.dgv_empleados.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_empleados.Location = new System.Drawing.Point(12, 79);
            this.dgv_empleados.MultiSelect = false;
            this.dgv_empleados.Name = "dgv_empleados";
            this.dgv_empleados.ReadOnly = true;
            this.dgv_empleados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_empleados.RowHeadersVisible = false;
            this.dgv_empleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_empleados.RowTemplate.Height = 25;
            this.dgv_empleados.Size = new System.Drawing.Size(805, 407);
            this.dgv_empleados.TabIndex = 19;
            this.dgv_empleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_empleados_CellClick);
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Image = global::FormEmpresa.Properties.Resources.modify;
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Width = 63;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::FormEmpresa.Properties.Resources.delete;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 55;
            // 
            // Activar
            // 
            this.Activar.HeaderText = "Activar";
            this.Activar.Image = global::FormEmpresa.Properties.Resources.up;
            this.Activar.Name = "Activar";
            this.Activar.ReadOnly = true;
            this.Activar.Width = 49;
            // 
            // FormEmpleadoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1103, 548);
            this.Controls.Add(this.dgv_empleados);
            this.Controls.Add(this.gb_puesto);
            this.Controls.Add(this.bt_limpiar);
            this.Controls.Add(this.bt_empAct);
            this.Controls.Add(this.bt_empInac);
            this.Controls.Add(this.gb_sexo);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.bt_cerrar);
            this.Controls.Add(this.bt_alta);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormEmpleadoss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmpleadoss";
            this.Load += new System.EventHandler(this.FormEmpleadoss_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_sexo.ResumeLayout(false);
            this.gb_sexo.PerformLayout();
            this.gb_puesto.ResumeLayout(false);
            this.gb_puesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.Button bt_cerrar;
        private System.Windows.Forms.Button bt_alta;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.RadioButton rbt_mas;
        private System.Windows.Forms.RadioButton rbt_fem;
        private System.Windows.Forms.RadioButton rbt_bin;
        private System.Windows.Forms.GroupBox gb_sexo;
        private System.Windows.Forms.Button bt_empInac;
        private System.Windows.Forms.Button bt_empAct;
        private System.Windows.Forms.Button bt_limpiar;
        private System.Windows.Forms.GroupBox gb_puesto;
        private System.Windows.Forms.RadioButton rb_mozo;
        private System.Windows.Forms.RadioButton rb_cocina;
        private System.Windows.Forms.RadioButton rb_limpieza;
        private System.Windows.Forms.RadioButton rb_recepcionista;
        private System.Windows.Forms.RadioButton rb_administrcion;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private System.Windows.Forms.BindingSource empleadoBindingSource1;
        private System.Windows.Forms.BindingSource empleadoBindingSource2;
        private System.Windows.Forms.BindingSource empleadoBindingSource3;
        private System.Windows.Forms.DataGridView dgv_empleados;
        private System.Windows.Forms.DataGridViewImageColumn Modificar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Activar;
    }
}