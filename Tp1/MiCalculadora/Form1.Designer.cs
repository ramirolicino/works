namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.btOperar = new System.Windows.Forms.Button();
            this.btDecimal = new System.Windows.Forms.Button();
            this.btBinario = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbOperador
            // 
            this.cmbOperador.AllowDrop = true;
            this.cmbOperador.BackColor = System.Drawing.SystemColors.Window;
            this.cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperador.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Items.AddRange(new object[] {
            " ",
            "+",
            "-",
            "/",
            "*"});
            this.cmbOperador.Location = new System.Drawing.Point(157, 69);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(78, 48);
            this.cmbOperador.TabIndex = 2;
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.ItemHeight = 15;
            this.lstResultados.Location = new System.Drawing.Point(383, 12);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(173, 229);
            this.lstResultados.TabIndex = 7;
            // 
            // btOperar
            // 
            this.btOperar.Location = new System.Drawing.Point(41, 142);
            this.btOperar.Name = "btOperar";
            this.btOperar.Size = new System.Drawing.Size(78, 38);
            this.btOperar.TabIndex = 4;
            this.btOperar.Text = "Operar";
            this.btOperar.UseVisualStyleBackColor = true;
            this.btOperar.Click += new System.EventHandler(this.btOperar_Click);
            // 
            // btDecimal
            // 
            this.btDecimal.Location = new System.Drawing.Point(200, 203);
            this.btDecimal.Name = "btDecimal";
            this.btDecimal.Size = new System.Drawing.Size(159, 38);
            this.btDecimal.TabIndex = 9;
            this.btDecimal.Text = "Convertir a Decimal";
            this.btDecimal.UseVisualStyleBackColor = true;
            this.btDecimal.Click += new System.EventHandler(this.btDecimal_Click);
            // 
            // btBinario
            // 
            this.btBinario.Location = new System.Drawing.Point(32, 203);
            this.btBinario.Name = "btBinario";
            this.btBinario.Size = new System.Drawing.Size(159, 38);
            this.btBinario.TabIndex = 8;
            this.btBinario.Text = "Convertir a Binario";
            this.btBinario.UseVisualStyleBackColor = true;
            this.btBinario.Click += new System.EventHandler(this.btBinario_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(269, 142);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(78, 38);
            this.btCerrar.TabIndex = 6;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(155, 142);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(78, 38);
            this.btLimpiar.TabIndex = 5;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // txtNumero1
            // 
            this.txtNumero1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNumero1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero1.Location = new System.Drawing.Point(32, 70);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 47);
            this.txtNumero1.TabIndex = 1;
            // 
            // txtNumero2
            // 
            this.txtNumero2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNumero2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero2.Location = new System.Drawing.Point(259, 70);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 47);
            this.txtNumero2.TabIndex = 3;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.ForeColor = System.Drawing.SystemColors.Window;
            this.lblResultado.Location = new System.Drawing.Point(232, 12);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(53, 32);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "RTA";
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(568, 253);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btBinario);
            this.Controls.Add(this.btDecimal);
            this.Controls.Add(this.btOperar);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.cmbOperador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora - Ramiro Olicino - 2D";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Button btOperar;
        private System.Windows.Forms.Button btDecimal;
        private System.Windows.Forms.Button btBinario;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.Button btLimpiar;
        protected System.Windows.Forms.ComboBox cmbOperador;
        protected System.Windows.Forms.TextBox txtNumero1;
        protected System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label lblResultado;
    }
}
