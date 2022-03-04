namespace FormPrincipal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tx_nombre = new System.Windows.Forms.TextBox();
            this.tx_apellido = new System.Windows.Forms.TextBox();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_cargar = new System.Windows.Forms.Button();
            this.data_personas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_personas)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_nombre
            // 
            this.tx_nombre.Location = new System.Drawing.Point(224, 27);
            this.tx_nombre.Name = "tx_nombre";
            this.tx_nombre.PlaceholderText = "        Nombre";
            this.tx_nombre.Size = new System.Drawing.Size(100, 23);
            this.tx_nombre.TabIndex = 0;
            // 
            // tx_apellido
            // 
            this.tx_apellido.Location = new System.Drawing.Point(224, 65);
            this.tx_apellido.Name = "tx_apellido";
            this.tx_apellido.PlaceholderText = "        Apellido";
            this.tx_apellido.Size = new System.Drawing.Size(100, 23);
            this.tx_apellido.TabIndex = 1;
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(236, 105);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 23);
            this.bt_guardar.TabIndex = 3;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.UseVisualStyleBackColor = true;
            // 
            // bt_modificar
            // 
            this.bt_modificar.Location = new System.Drawing.Point(236, 150);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(75, 23);
            this.bt_modificar.TabIndex = 4;
            this.bt_modificar.Text = "Modificar";
            this.bt_modificar.UseVisualStyleBackColor = true;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Location = new System.Drawing.Point(236, 192);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(75, 23);
            this.bt_eliminar.TabIndex = 5;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_cargar
            // 
            this.bt_cargar.Location = new System.Drawing.Point(236, 232);
            this.bt_cargar.Name = "bt_cargar";
            this.bt_cargar.Size = new System.Drawing.Size(75, 23);
            this.bt_cargar.TabIndex = 6;
            this.bt_cargar.Text = "Cargar";
            this.bt_cargar.UseVisualStyleBackColor = true;
            this.bt_cargar.Click += new System.EventHandler(this.bt_cargar_Click);
            // 
            // data_personas
            // 
            this.data_personas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_personas.Location = new System.Drawing.Point(22, 27);
            this.data_personas.Name = "data_personas";
            this.data_personas.RowTemplate.Height = 25;
            this.data_personas.Size = new System.Drawing.Size(174, 228);
            this.data_personas.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(341, 280);
            this.Controls.Add(this.data_personas);
            this.Controls.Add(this.bt_cargar);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_modificar);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.tx_apellido);
            this.Controls.Add(this.tx_nombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_personas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_nombre;
        private System.Windows.Forms.TextBox tx_apellido;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Button bt_modificar;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_cargar;
        private System.Windows.Forms.DataGridView data_personas;
    }
}
