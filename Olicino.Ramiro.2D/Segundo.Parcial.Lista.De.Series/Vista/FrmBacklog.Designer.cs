
namespace Vista
{
    partial class FrmBacklog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBacklog));
            this.lstbBacklog = new System.Windows.Forms.ListBox();
            this.lstbParaVer = new System.Windows.Forms.ListBox();
            this.lblBackLog = new System.Windows.Forms.Label();
            this.lblParaVer = new System.Windows.Forms.Label();
            this.btnSerializar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbBacklog
            // 
            this.lstbBacklog.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lstbBacklog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbBacklog.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstbBacklog.FormattingEnabled = true;
            this.lstbBacklog.ItemHeight = 20;
            this.lstbBacklog.Location = new System.Drawing.Point(12, 107);
            this.lstbBacklog.Name = "lstbBacklog";
            this.lstbBacklog.Size = new System.Drawing.Size(332, 280);
            this.lstbBacklog.TabIndex = 0;
            // 
            // lstbParaVer
            // 
            this.lstbParaVer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lstbParaVer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbParaVer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstbParaVer.FormattingEnabled = true;
            this.lstbParaVer.ItemHeight = 20;
            this.lstbParaVer.Location = new System.Drawing.Point(492, 107);
            this.lstbParaVer.Name = "lstbParaVer";
            this.lstbParaVer.Size = new System.Drawing.Size(332, 280);
            this.lstbParaVer.TabIndex = 1;
            // 
            // lblBackLog
            // 
            this.lblBackLog.AutoSize = true;
            this.lblBackLog.BackColor = System.Drawing.Color.Transparent;
            this.lblBackLog.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBackLog.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBackLog.Location = new System.Drawing.Point(12, 390);
            this.lblBackLog.Name = "lblBackLog";
            this.lblBackLog.Size = new System.Drawing.Size(78, 25);
            this.lblBackLog.TabIndex = 2;
            this.lblBackLog.Text = "Backlog";
            // 
            // lblParaVer
            // 
            this.lblParaVer.AutoSize = true;
            this.lblParaVer.BackColor = System.Drawing.Color.Transparent;
            this.lblParaVer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblParaVer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblParaVer.Location = new System.Drawing.Point(492, 390);
            this.lblParaVer.Name = "lblParaVer";
            this.lblParaVer.Size = new System.Drawing.Size(136, 25);
            this.lblParaVer.TabIndex = 3;
            this.lblParaVer.Text = "Series para ver";
            // 
            // btnSerializar
            // 
            this.btnSerializar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSerializar.BackgroundImage")));
            this.btnSerializar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerializar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSerializar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSerializar.Location = new System.Drawing.Point(12, 441);
            this.btnSerializar.Name = "btnSerializar";
            this.btnSerializar.Size = new System.Drawing.Size(93, 39);
            this.btnSerializar.TabIndex = 4;
            this.btnSerializar.Text = "Serializar";
            this.btnSerializar.UseVisualStyleBackColor = true;
            this.btnSerializar.Click += new System.EventHandler(this.btnSerializar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.Location = new System.Drawing.Point(809, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(37, 39);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmBacklog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(849, 492);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSerializar);
            this.Controls.Add(this.lblParaVer);
            this.Controls.Add(this.lblBackLog);
            this.Controls.Add(this.lstbParaVer);
            this.Controls.Add(this.lstbBacklog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBacklog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBacklog";
            this.Load += new System.EventHandler(this.FrmBacklog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbBacklog;
        private System.Windows.Forms.ListBox lstbParaVer;
        private System.Windows.Forms.Label lblBackLog;
        private System.Windows.Forms.Label lblParaVer;
        private System.Windows.Forms.Button btnSerializar;
        private System.Windows.Forms.Button btnSalir;
    }
}

