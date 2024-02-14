namespace EmpresaTurismo
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnNombre = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTitulo.Location = new System.Drawing.Point(227, 238);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(351, 41);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "¡Bienvenido a Risas!";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitulo.UseMnemonic = false;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lbNombre.Location = new System.Drawing.Point(294, 343);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(225, 19);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Ingrese su nombre por favor";
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.ForeColor = System.Drawing.Color.Orange;
            this.tbNombre.Location = new System.Drawing.Point(314, 377);
            this.tbNombre.MaxLength = 20;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(154, 26);
            this.tbNombre.TabIndex = 3;
            this.tbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNombre.WordWrap = false;
            // 
            // btnNombre
            // 
            this.btnNombre.BackgroundImage = global::EmpresaTurismo.Properties.Resources.iconoAvion;
            this.btnNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNombre.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnNombre.Location = new System.Drawing.Point(474, 377);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(28, 26);
            this.btnNombre.TabIndex = 4;
            this.btnNombre.UseVisualStyleBackColor = true;
            this.btnNombre.Click += new System.EventHandler(this.btnNombre_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmpresaTurismo.Properties.Resources.risas;
            this.pictureBox1.Location = new System.Drawing.Point(234, -22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.btnNombre);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Risas Turismo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnNombre;
    }
}

