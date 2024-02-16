using EmpresaTurismo.Properties;

namespace EmpresaTurismo
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.lbSaludo = new System.Windows.Forms.Label();
            this.btnVuelos = new System.Windows.Forms.Button();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.lbUltimaSesion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(717, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSaludo
            // 
            this.lbSaludo.AutoSize = true;
            this.lbSaludo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaludo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbSaludo.Location = new System.Drawing.Point(18, 82);
            this.lbSaludo.MaximumSize = new System.Drawing.Size(98, 0);
            this.lbSaludo.Name = "lbSaludo";
            this.lbSaludo.Size = new System.Drawing.Size(0, 16);
            this.lbSaludo.TabIndex = 2;
            this.lbSaludo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVuelos
            // 
            this.btnVuelos.BackColor = System.Drawing.Color.FloralWhite;
            this.btnVuelos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVuelos.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVuelos.Location = new System.Drawing.Point(276, 152);
            this.btnVuelos.Name = "btnVuelos";
            this.btnVuelos.Size = new System.Drawing.Size(251, 63);
            this.btnVuelos.TabIndex = 3;
            this.btnVuelos.Text = "Buscar Vuelos";
            this.btnVuelos.UseVisualStyleBackColor = false;
            this.btnVuelos.Click += new System.EventHandler(this.btnVuelos_Click);
            // 
            // btnCuenta
            // 
            this.btnCuenta.BackColor = System.Drawing.Color.FloralWhite;
            this.btnCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuenta.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnCuenta.ForeColor = System.Drawing.Color.Black;
            this.btnCuenta.Location = new System.Drawing.Point(276, 243);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(251, 63);
            this.btnCuenta.TabIndex = 4;
            this.btnCuenta.Text = "Mi Cuenta";
            this.btnCuenta.UseVisualStyleBackColor = false;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // lbUltimaSesion
            // 
            this.lbUltimaSesion.AutoSize = true;
            this.lbUltimaSesion.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.lbUltimaSesion.ForeColor = System.Drawing.Color.White;
            this.lbUltimaSesion.Location = new System.Drawing.Point(601, 12);
            this.lbUltimaSesion.Name = "lbUltimaSesion";
            this.lbUltimaSesion.Size = new System.Drawing.Size(0, 15);
            this.lbUltimaSesion.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmpresaTurismo.Properties.Resources.risas;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox2.Image = global::EmpresaTurismo.Properties.Resources.fondoAvion;
            this.pictureBox2.Location = new System.Drawing.Point(12, 221);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(499, 307);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.lbUltimaSesion);
            this.Controls.Add(this.btnCuenta);
            this.Controls.Add(this.btnVuelos);
            this.Controls.Add(this.lbSaludo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Risas Turismo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();




        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbSaludo;
        private System.Windows.Forms.Button btnVuelos;
        private System.Windows.Forms.Button btnCuenta;
        private System.Windows.Forms.Label lbUltimaSesion;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}