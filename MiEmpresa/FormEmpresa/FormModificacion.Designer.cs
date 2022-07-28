namespace FormEmpresa
{
    partial class FormModificacion
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
            this.gb_sexo = new System.Windows.Forms.GroupBox();
            this.rbt_bin = new System.Windows.Forms.RadioButton();
            this.rbt_fem = new System.Windows.Forms.RadioButton();
            this.rbt_mas = new System.Windows.Forms.RadioButton();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.gb_puesto = new System.Windows.Forms.GroupBox();
            this.rb_mozo = new System.Windows.Forms.RadioButton();
            this.rb_cocina = new System.Windows.Forms.RadioButton();
            this.rb_limpieza = new System.Windows.Forms.RadioButton();
            this.rb_recepcionista = new System.Windows.Forms.RadioButton();
            this.rb_administrcion = new System.Windows.Forms.RadioButton();
            this.bt_cerrar = new System.Windows.Forms.Button();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.gb_sexo.SuspendLayout();
            this.gb_puesto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_sexo
            // 
            this.gb_sexo.Controls.Add(this.rbt_bin);
            this.gb_sexo.Controls.Add(this.rbt_fem);
            this.gb_sexo.Controls.Add(this.rbt_mas);
            this.gb_sexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_sexo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_sexo.Location = new System.Drawing.Point(36, 162);
            this.gb_sexo.Name = "gb_sexo";
            this.gb_sexo.Size = new System.Drawing.Size(200, 126);
            this.gb_sexo.TabIndex = 15;
            this.gb_sexo.TabStop = false;
            this.gb_sexo.Text = "SEXO";
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
            // txt_apellido
            // 
            this.txt_apellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_apellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_apellido.Location = new System.Drawing.Point(36, 91);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.PlaceholderText = "       INGRESE APELLIDO";
            this.txt_apellido.Size = new System.Drawing.Size(200, 29);
            this.txt_apellido.TabIndex = 14;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nombre.Location = new System.Drawing.Point(36, 29);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PlaceholderText = "       INGRESE NOMBRE";
            this.txt_nombre.Size = new System.Drawing.Size(200, 29);
            this.txt_nombre.TabIndex = 13;
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
            this.gb_puesto.Location = new System.Drawing.Point(12, 314);
            this.gb_puesto.Name = "gb_puesto";
            this.gb_puesto.Size = new System.Drawing.Size(253, 126);
            this.gb_puesto.TabIndex = 17;
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
            // bt_cerrar
            // 
            this.bt_cerrar.BackColor = System.Drawing.Color.SlateGray;
            this.bt_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_cerrar.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_cerrar.Location = new System.Drawing.Point(12, 534);
            this.bt_cerrar.Name = "bt_cerrar";
            this.bt_cerrar.Size = new System.Drawing.Size(253, 34);
            this.bt_cerrar.TabIndex = 19;
            this.bt_cerrar.Text = "CERRAR";
            this.bt_cerrar.UseVisualStyleBackColor = false;
            this.bt_cerrar.Click += new System.EventHandler(this.bt_cerrar_Click);
            // 
            // bt_modificar
            // 
            this.bt_modificar.BackColor = System.Drawing.Color.SlateGray;
            this.bt_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_modificar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_modificar.Location = new System.Drawing.Point(36, 456);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(200, 56);
            this.bt_modificar.TabIndex = 18;
            this.bt_modificar.Text = "MODIFICAR";
            this.bt_modificar.UseVisualStyleBackColor = false;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // FormModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(278, 570);
            this.Controls.Add(this.bt_cerrar);
            this.Controls.Add(this.bt_modificar);
            this.Controls.Add(this.gb_puesto);
            this.Controls.Add(this.gb_sexo);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormModificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODIFICAR";
            this.Load += new System.EventHandler(this.FormModificacion_Load);
            this.gb_sexo.ResumeLayout(false);
            this.gb_sexo.PerformLayout();
            this.gb_puesto.ResumeLayout(false);
            this.gb_puesto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_sexo;
        private System.Windows.Forms.RadioButton rbt_bin;
        private System.Windows.Forms.RadioButton rbt_fem;
        private System.Windows.Forms.RadioButton rbt_mas;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.GroupBox gb_puesto;
        private System.Windows.Forms.RadioButton rb_mozo;
        private System.Windows.Forms.RadioButton rb_cocina;
        private System.Windows.Forms.RadioButton rb_limpieza;
        private System.Windows.Forms.RadioButton rb_recepcionista;
        private System.Windows.Forms.RadioButton rb_administrcion;
        private System.Windows.Forms.Button bt_cerrar;
        private System.Windows.Forms.Button bt_modificar;
    }
}