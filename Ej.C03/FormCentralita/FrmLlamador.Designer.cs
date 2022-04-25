using System;

namespace FormCentralita
{
    partial class FrmLlamador
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
            this.txt_nroDestino = new System.Windows.Forms.TextBox();
            this.gb_panel = new System.Windows.Forms.GroupBox();
            this.bt_pin = new System.Windows.Forms.Button();
            this.bt_0 = new System.Windows.Forms.Button();
            this.bt_hash = new System.Windows.Forms.Button();
            this.bt_9 = new System.Windows.Forms.Button();
            this.bt_8 = new System.Windows.Forms.Button();
            this.bt_6 = new System.Windows.Forms.Button();
            this.bt_7 = new System.Windows.Forms.Button();
            this.bt_5 = new System.Windows.Forms.Button();
            this.bt_4 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.bt_1 = new System.Windows.Forms.Button();
            this.txt_nroOrigen = new System.Windows.Forms.TextBox();
            this.bt_salir = new System.Windows.Forms.Button();
            this.bt_limpiar = new System.Windows.Forms.Button();
            this.bt_llamar = new System.Windows.Forms.Button();
            this.cmb_franja = new System.Windows.Forms.ComboBox();
            this.gb_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nroDestino
            // 
            this.txt_nroDestino.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_nroDestino.Location = new System.Drawing.Point(12, 12);
            this.txt_nroDestino.Name = "txt_nroDestino";
            this.txt_nroDestino.PlaceholderText = "Nro Destino";
            this.txt_nroDestino.Size = new System.Drawing.Size(354, 36);
            this.txt_nroDestino.TabIndex = 1;
            // 
            // gb_panel
            // 
            this.gb_panel.Controls.Add(this.bt_pin);
            this.gb_panel.Controls.Add(this.bt_0);
            this.gb_panel.Controls.Add(this.bt_hash);
            this.gb_panel.Controls.Add(this.bt_9);
            this.gb_panel.Controls.Add(this.bt_8);
            this.gb_panel.Controls.Add(this.bt_6);
            this.gb_panel.Controls.Add(this.bt_7);
            this.gb_panel.Controls.Add(this.bt_5);
            this.gb_panel.Controls.Add(this.bt_4);
            this.gb_panel.Controls.Add(this.bt_2);
            this.gb_panel.Controls.Add(this.bt_3);
            this.gb_panel.Controls.Add(this.bt_1);
            this.gb_panel.Location = new System.Drawing.Point(12, 70);
            this.gb_panel.Name = "gb_panel";
            this.gb_panel.Size = new System.Drawing.Size(191, 201);
            this.gb_panel.TabIndex = 2;
            this.gb_panel.TabStop = false;
            this.gb_panel.Text = "Panel";
            // 
            // bt_pin
            // 
            this.bt_pin.Location = new System.Drawing.Point(21, 150);
            this.bt_pin.Name = "bt_pin";
            this.bt_pin.Size = new System.Drawing.Size(45, 35);
            this.bt_pin.TabIndex = 23;
            this.bt_pin.Text = "*";
            this.bt_pin.UseVisualStyleBackColor = true;
            this.bt_pin.Click += new System.EventHandler(this.Teclado_Click);
            // 
            // bt_0
            // 
            this.bt_0.Location = new System.Drawing.Point(72, 150);
            this.bt_0.Name = "bt_0";
            this.bt_0.Size = new System.Drawing.Size(45, 35);
            this.bt_0.TabIndex = 22;
            this.bt_0.Text = "0";
            this.bt_0.UseVisualStyleBackColor = true;
            this.bt_0.Click += new System.EventHandler(this.Teclado_Click);
            // 
            // bt_hash
            // 
            this.bt_hash.Location = new System.Drawing.Point(123, 150);
            this.bt_hash.Name = "bt_hash";
            this.bt_hash.Size = new System.Drawing.Size(45, 35);
            this.bt_hash.TabIndex = 21;
            this.bt_hash.Text = "#";
            this.bt_hash.UseVisualStyleBackColor = true;
            this.bt_hash.Click += new System.EventHandler(this.Teclado_Click);
            // 
            // bt_9
            // 
            this.bt_9.Location = new System.Drawing.Point(123, 106);
            this.bt_9.Name = "bt_9";
            this.bt_9.Size = new System.Drawing.Size(45, 35);
            this.bt_9.TabIndex = 20;
            this.bt_9.Text = "9";
            this.bt_9.UseVisualStyleBackColor = true;
            this.bt_9.Click += new System.EventHandler(this.Teclado_Click);
            // 
            // bt_8
            // 
            this.bt_8.Location = new System.Drawing.Point(72, 106);
            this.bt_8.Name = "bt_8";
            this.bt_8.Size = new System.Drawing.Size(45, 35);
            this.bt_8.TabIndex = 19;
            this.bt_8.Text = "8";
            this.bt_8.UseVisualStyleBackColor = true;
            this.bt_8.Click += new System.EventHandler(this.Teclado_Click);
            // 
            // bt_6
            // 
            this.bt_6.Location = new System.Drawing.Point(123, 65);
            this.bt_6.Name = "bt_6";
            this.bt_6.Size = new System.Drawing.Size(45, 35);
            this.bt_6.TabIndex = 18;
            this.bt_6.Text = "6";
            this.bt_6.UseVisualStyleBackColor = true;
            this.bt_6.Click += new System.EventHandler(this.Teclado_Click);
            // 
            // bt_7
            // 
            this.bt_7.Location = new System.Drawing.Point(21, 106);
            this.bt_7.Name = "bt_7";
            this.bt_7.Size = new System.Drawing.Size(45, 35);
            this.bt_7.TabIndex = 17;
            this.bt_7.Text = "7";
            this.bt_7.UseVisualStyleBackColor = true;
            this.bt_7.Click += new System.EventHandler(this.Teclado_Click);
            // 
            // bt_5
            // 
            this.bt_5.Location = new System.Drawing.Point(72, 65);
            this.bt_5.Name = "bt_5";
            this.bt_5.Size = new System.Drawing.Size(45, 35);
            this.bt_5.TabIndex = 16;
            this.bt_5.Text = "5";
            this.bt_5.UseVisualStyleBackColor = true;
            this.bt_5.Click += new System.EventHandler(this.Teclado_Click);
            // 
            // bt_4
            // 
            this.bt_4.Location = new System.Drawing.Point(21, 65);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(45, 35);
            this.bt_4.TabIndex = 15;
            this.bt_4.Text = "4";
            this.bt_4.UseVisualStyleBackColor = true;
            this.bt_4.Click += new System.EventHandler(this.Teclado_Click);
            // 
            // bt_2
            // 
            this.bt_2.Location = new System.Drawing.Point(72, 24);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(45, 35);
            this.bt_2.TabIndex = 14;
            this.bt_2.Text = "2";
            this.bt_2.UseVisualStyleBackColor = true;
            this.bt_2.Click += new System.EventHandler(this.Teclado_Click);
            // 
            // bt_3
            // 
            this.bt_3.Location = new System.Drawing.Point(123, 24);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(45, 35);
            this.bt_3.TabIndex = 13;
            this.bt_3.Text = "3";
            this.bt_3.UseVisualStyleBackColor = true;
            this.bt_3.Click += new System.EventHandler(this.Teclado_Click);
            // 
            // bt_1
            // 
            this.bt_1.Location = new System.Drawing.Point(21, 24);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(45, 35);
            this.bt_1.TabIndex = 12;
            this.bt_1.Text = "1";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.Teclado_Click);
            // 
            // txt_nroOrigen
            // 
            this.txt_nroOrigen.Location = new System.Drawing.Point(209, 188);
            this.txt_nroOrigen.Name = "txt_nroOrigen";
            this.txt_nroOrigen.PlaceholderText = "Nro Origen";
            this.txt_nroOrigen.Size = new System.Drawing.Size(157, 23);
            this.txt_nroOrigen.TabIndex = 26;
            // 
            // bt_salir
            // 
            this.bt_salir.Location = new System.Drawing.Point(209, 228);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(157, 43);
            this.bt_salir.TabIndex = 27;
            this.bt_salir.Text = "SALIR";
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // bt_limpiar
            // 
            this.bt_limpiar.Location = new System.Drawing.Point(209, 135);
            this.bt_limpiar.Name = "bt_limpiar";
            this.bt_limpiar.Size = new System.Drawing.Size(157, 43);
            this.bt_limpiar.TabIndex = 28;
            this.bt_limpiar.Text = "LIMPIAR";
            this.bt_limpiar.UseVisualStyleBackColor = true;
            this.bt_limpiar.Click += new System.EventHandler(this.bt_limpiar_Click);
            // 
            // bt_llamar
            // 
            this.bt_llamar.Location = new System.Drawing.Point(209, 86);
            this.bt_llamar.Name = "bt_llamar";
            this.bt_llamar.Size = new System.Drawing.Size(157, 43);
            this.bt_llamar.TabIndex = 29;
            this.bt_llamar.Text = "LLAMAR";
            this.bt_llamar.UseVisualStyleBackColor = true;
            this.bt_llamar.Click += new System.EventHandler(this.bt_llamar_Click);
            // 
            // cmb_franja
            // 
            this.cmb_franja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_franja.FormattingEnabled = true;
            this.cmb_franja.Location = new System.Drawing.Point(13, 287);
            this.cmb_franja.Name = "cmb_franja";
            this.cmb_franja.Size = new System.Drawing.Size(191, 23);
            this.cmb_franja.TabIndex = 30;
            // 
            // FrmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(398, 329);
            this.Controls.Add(this.cmb_franja);
            this.Controls.Add(this.bt_llamar);
            this.Controls.Add(this.bt_limpiar);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.txt_nroOrigen);
            this.Controls.Add(this.gb_panel);
            this.Controls.Add(this.txt_nroDestino);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLlamador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LLAMADOR";
            this.Load += new System.EventHandler(this.FrmLlamador_Load);
            this.gb_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_nroDestino;
        private System.Windows.Forms.GroupBox gb_panel;
        private System.Windows.Forms.Button bt_pin;
        private System.Windows.Forms.Button bt_0;
        private System.Windows.Forms.Button bt_hash;
        private System.Windows.Forms.Button bt_9;
        private System.Windows.Forms.Button bt_8;
        private System.Windows.Forms.Button bt_6;
        private System.Windows.Forms.Button bt_7;
        private System.Windows.Forms.Button bt_5;
        private System.Windows.Forms.Button bt_4;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.TextBox txt_nroOrigen;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.Button bt_limpiar;
        private System.Windows.Forms.Button bt_llamar;
        private System.Windows.Forms.ComboBox cmb_franja;
    }
}