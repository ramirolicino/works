namespace FormCentralita
{
    partial class FormPrincipal
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
            this.bt_generarLLamada = new System.Windows.Forms.Button();
            this.bt_fcTotal = new System.Windows.Forms.Button();
            this.bt_fcLocal = new System.Windows.Forms.Button();
            this.bt_fcProv = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_generarLLamada
            // 
            this.bt_generarLLamada.Location = new System.Drawing.Point(74, 12);
            this.bt_generarLLamada.Name = "bt_generarLLamada";
            this.bt_generarLLamada.Size = new System.Drawing.Size(171, 43);
            this.bt_generarLLamada.TabIndex = 0;
            this.bt_generarLLamada.Text = "GENERAR LLAMADA";
            this.bt_generarLLamada.UseVisualStyleBackColor = true;
            this.bt_generarLLamada.Click += new System.EventHandler(this.bt_generarLLamada_Click);
            // 
            // bt_fcTotal
            // 
            this.bt_fcTotal.Location = new System.Drawing.Point(74, 81);
            this.bt_fcTotal.Name = "bt_fcTotal";
            this.bt_fcTotal.Size = new System.Drawing.Size(171, 43);
            this.bt_fcTotal.TabIndex = 1;
            this.bt_fcTotal.Text = "FACTURACION TOTAL";
            this.bt_fcTotal.UseVisualStyleBackColor = true;
            this.bt_fcTotal.Click += new System.EventHandler(this.bt_fcTotal_Click);
            // 
            // bt_fcLocal
            // 
            this.bt_fcLocal.Location = new System.Drawing.Point(74, 150);
            this.bt_fcLocal.Name = "bt_fcLocal";
            this.bt_fcLocal.Size = new System.Drawing.Size(171, 43);
            this.bt_fcLocal.TabIndex = 2;
            this.bt_fcLocal.Text = "FACTURACION LOCAL";
            this.bt_fcLocal.UseVisualStyleBackColor = true;
            this.bt_fcLocal.Click += new System.EventHandler(this.bt_fcLocal_Click);
            // 
            // bt_fcProv
            // 
            this.bt_fcProv.Location = new System.Drawing.Point(74, 221);
            this.bt_fcProv.Name = "bt_fcProv";
            this.bt_fcProv.Size = new System.Drawing.Size(171, 43);
            this.bt_fcProv.TabIndex = 3;
            this.bt_fcProv.Text = "FACTURACION PROVINCIA";
            this.bt_fcProv.UseVisualStyleBackColor = true;
            this.bt_fcProv.Click += new System.EventHandler(this.bt_fcProv_Click);
            // 
            // bt_salir
            // 
            this.bt_salir.Location = new System.Drawing.Point(74, 291);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(171, 43);
            this.bt_salir.TabIndex = 4;
            this.bt_salir.Text = "SALIR";
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(315, 343);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_fcProv);
            this.Controls.Add(this.bt_fcLocal);
            this.Controls.Add(this.bt_fcTotal);
            this.Controls.Add(this.bt_generarLLamada);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_generarLLamada;
        private System.Windows.Forms.Button bt_fcTotal;
        private System.Windows.Forms.Button bt_fcLocal;
        private System.Windows.Forms.Button bt_fcProv;
        private System.Windows.Forms.Button bt_salir;
    }
}
