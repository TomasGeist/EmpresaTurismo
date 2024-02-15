namespace EmpresaTurismo
{
    partial class FormMiCuenta
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbTituloCuenta = new System.Windows.Forms.Label();
            this.lbVuelosComprados = new System.Windows.Forms.ListBox();
            this.labVuelosComprados = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // lbTituloCuenta
            // 
            this.lbTituloCuenta.AutoSize = true;
            this.lbTituloCuenta.Location = new System.Drawing.Point(92, 51);
            this.lbTituloCuenta.Name = "lbTituloCuenta";
            this.lbTituloCuenta.Size = new System.Drawing.Size(0, 13);
            this.lbTituloCuenta.TabIndex = 1;
            // 
            // lbVuelosComprados
            // 
            this.lbVuelosComprados.FormattingEnabled = true;
            this.lbVuelosComprados.Location = new System.Drawing.Point(95, 137);
            this.lbVuelosComprados.Name = "lbVuelosComprados";
            this.lbVuelosComprados.Size = new System.Drawing.Size(640, 95);
            this.lbVuelosComprados.TabIndex = 2;
            // 
            // labVuelosComprados
            // 
            this.labVuelosComprados.AutoSize = true;
            this.labVuelosComprados.Location = new System.Drawing.Point(95, 118);
            this.labVuelosComprados.Name = "labVuelosComprados";
            this.labVuelosComprados.Size = new System.Drawing.Size(0, 13);
            this.labVuelosComprados.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmpresaTurismo.Properties.Resources.fondoAvion;
            this.pictureBox1.Location = new System.Drawing.Point(273, -28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormMiCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.labVuelosComprados);
            this.Controls.Add(this.lbVuelosComprados);
            this.Controls.Add(this.lbTituloCuenta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMiCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMiCuenta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTituloCuenta;
        private System.Windows.Forms.ListBox lbVuelosComprados;
        private System.Windows.Forms.Label labVuelosComprados;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}