namespace EmpresaTurismo
{
    partial class FormVuelos
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.lbListaVuelos = new System.Windows.Forms.Label();
            this.lbVuelosDisponibles = new System.Windows.Forms.ListBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbDestinos = new System.Windows.Forms.ComboBox();
            this.labDestinos = new System.Windows.Forms.Label();
            this.cbFecha = new System.Windows.Forms.ComboBox();
            this.labMeses = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Ivory;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Orange;
            this.btnVolver.Location = new System.Drawing.Point(717, 426);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 33);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lbListaVuelos
            // 
            this.lbListaVuelos.AutoSize = true;
            this.lbListaVuelos.Location = new System.Drawing.Point(273, 37);
            this.lbListaVuelos.MaximumSize = new System.Drawing.Size(273, 0);
            this.lbListaVuelos.Name = "lbListaVuelos";
            this.lbListaVuelos.Size = new System.Drawing.Size(0, 13);
            this.lbListaVuelos.TabIndex = 1;
            this.lbListaVuelos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbVuelosDisponibles
            // 
            this.lbVuelosDisponibles.BackColor = System.Drawing.Color.DarkOrange;
            this.lbVuelosDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbVuelosDisponibles.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVuelosDisponibles.ForeColor = System.Drawing.SystemColors.Window;
            this.lbVuelosDisponibles.FormattingEnabled = true;
            this.lbVuelosDisponibles.ItemHeight = 16;
            this.lbVuelosDisponibles.Location = new System.Drawing.Point(136, 37);
            this.lbVuelosDisponibles.Name = "lbVuelosDisponibles";
            this.lbVuelosDisponibles.Size = new System.Drawing.Size(547, 290);
            this.lbVuelosDisponibles.TabIndex = 2;
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnComprar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnComprar.ForeColor = System.Drawing.Color.Orange;
            this.btnComprar.Location = new System.Drawing.Point(515, 343);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(168, 33);
            this.btnComprar.TabIndex = 3;
            this.btnComprar.Text = "Reservar Vuelo";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FloralWhite;
            this.button1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(414, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbDestinos
            // 
            this.cbDestinos.DropDownHeight = 80;
            this.cbDestinos.FormattingEnabled = true;
            this.cbDestinos.IntegralHeight = false;
            this.cbDestinos.Items.AddRange(new object[] {
            "",
            "Buenos Aires",
            "Bariloche",
            "Mendoza",
            "Mar del Plata",
            "Córdoba",
            "Ushuaia",
            "Salta",
            "Puerto Madryn",
            "San Carlos de Bariloche",
            "Villa Gesell",
            "San Martín de los Andes",
            "La Plata",
            "Rosario",
            "El Calafate",
            "San Juan",
            "Neuquén",
            "Tandil",
            "Trelew",
            "Jujuy",
            "Villa La Angostura",
            "Santa Rosa",
            "Bahía Blanca",
            "Puerto Iguazú",
            "Resistencia",
            "San Rafael",
            "Comodoro Rivadavia",
            "Santa Fe",
            "San Luis",
            "Tucumán",
            "La Rioja"});
            this.cbDestinos.Location = new System.Drawing.Point(136, 352);
            this.cbDestinos.Name = "cbDestinos";
            this.cbDestinos.Size = new System.Drawing.Size(103, 21);
            this.cbDestinos.TabIndex = 5;
            // 
            // labDestinos
            // 
            this.labDestinos.AutoSize = true;
            this.labDestinos.BackColor = System.Drawing.Color.Transparent;
            this.labDestinos.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labDestinos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labDestinos.Location = new System.Drawing.Point(133, 334);
            this.labDestinos.Name = "labDestinos";
            this.labDestinos.Size = new System.Drawing.Size(61, 16);
            this.labDestinos.TabIndex = 6;
            this.labDestinos.Text = "Destino";
            // 
            // cbFecha
            // 
            this.cbFecha.DropDownHeight = 80;
            this.cbFecha.FormattingEnabled = true;
            this.cbFecha.IntegralHeight = false;
            this.cbFecha.Items.AddRange(new object[] {
            "",
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbFecha.Location = new System.Drawing.Point(245, 352);
            this.cbFecha.Name = "cbFecha";
            this.cbFecha.Size = new System.Drawing.Size(102, 21);
            this.cbFecha.TabIndex = 7;
            // 
            // labMeses
            // 
            this.labMeses.AutoSize = true;
            this.labMeses.BackColor = System.Drawing.Color.Transparent;
            this.labMeses.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labMeses.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labMeses.Location = new System.Drawing.Point(245, 334);
            this.labMeses.Name = "labMeses";
            this.labMeses.Size = new System.Drawing.Size(37, 16);
            this.labMeses.TabIndex = 8;
            this.labMeses.Text = "Mes";
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Image = global::EmpresaTurismo.Properties.Resources.trash;
            this.btnReset.Location = new System.Drawing.Point(353, 349);
            this.btnReset.Margin = new System.Windows.Forms.Padding(0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(28, 27);
            this.btnReset.TabIndex = 9;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmpresaTurismo.Properties.Resources.risas;
            this.pictureBox1.Location = new System.Drawing.Point(-8, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(821, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.labMeses);
            this.Controls.Add(this.cbFecha);
            this.Controls.Add(this.labDestinos);
            this.Controls.Add(this.cbDestinos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lbVuelosDisponibles);
            this.Controls.Add(this.lbListaVuelos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormVuelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVuelos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lbListaVuelos;
        private System.Windows.Forms.ListBox lbVuelosDisponibles;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbDestinos;
        private System.Windows.Forms.Label labDestinos;
        private System.Windows.Forms.ComboBox cbFecha;
        private System.Windows.Forms.Label labMeses;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}