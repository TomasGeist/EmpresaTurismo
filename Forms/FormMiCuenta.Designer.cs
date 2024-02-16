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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMiCuenta));
            this.button1 = new System.Windows.Forms.Button();
            this.lbTituloCuenta = new System.Windows.Forms.Label();
            this.lbVuelosComprados = new System.Windows.Forms.ListBox();
            this.labVuelosComprados = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labSaldoRestante = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPagarTodo = new System.Windows.Forms.Button();
            this.btnPagarSelec = new System.Windows.Forms.Button();
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
            // lbTituloCuenta
            // 
            this.lbTituloCuenta.AutoSize = true;
            this.lbTituloCuenta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbTituloCuenta.ForeColor = System.Drawing.Color.White;
            this.lbTituloCuenta.Location = new System.Drawing.Point(12, 67);
            this.lbTituloCuenta.Name = "lbTituloCuenta";
            this.lbTituloCuenta.Size = new System.Drawing.Size(0, 16);
            this.lbTituloCuenta.TabIndex = 1;
            // 
            // lbVuelosComprados
            // 
            this.lbVuelosComprados.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbVuelosComprados.ForeColor = System.Drawing.Color.Black;
            this.lbVuelosComprados.FormattingEnabled = true;
            this.lbVuelosComprados.ItemHeight = 16;
            this.lbVuelosComprados.Location = new System.Drawing.Point(95, 137);
            this.lbVuelosComprados.Name = "lbVuelosComprados";
            this.lbVuelosComprados.Size = new System.Drawing.Size(640, 84);
            this.lbVuelosComprados.TabIndex = 2;
            // 
            // labVuelosComprados
            // 
            this.labVuelosComprados.AutoSize = true;
            this.labVuelosComprados.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.labVuelosComprados.ForeColor = System.Drawing.Color.White;
            this.labVuelosComprados.Location = new System.Drawing.Point(95, 118);
            this.labVuelosComprados.Name = "labVuelosComprados";
            this.labVuelosComprados.Size = new System.Drawing.Size(0, 16);
            this.labVuelosComprados.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(273, -28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labSaldoRestante
            // 
            this.labSaldoRestante.AutoSize = true;
            this.labSaldoRestante.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.labSaldoRestante.ForeColor = System.Drawing.Color.White;
            this.labSaldoRestante.Location = new System.Drawing.Point(12, 84);
            this.labSaldoRestante.Name = "labSaldoRestante";
            this.labSaldoRestante.Size = new System.Drawing.Size(0, 16);
            this.labSaldoRestante.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EmpresaTurismo.Properties.Resources.risas;
            this.pictureBox2.Location = new System.Drawing.Point(7, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnPagarTodo
            // 
            this.btnPagarTodo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnPagarTodo.ForeColor = System.Drawing.Color.Orange;
            this.btnPagarTodo.Location = new System.Drawing.Point(607, 227);
            this.btnPagarTodo.Name = "btnPagarTodo";
            this.btnPagarTodo.Size = new System.Drawing.Size(128, 33);
            this.btnPagarTodo.TabIndex = 7;
            this.btnPagarTodo.Text = "Pagar Todo";
            this.btnPagarTodo.UseVisualStyleBackColor = true;
            this.btnPagarTodo.Click += new System.EventHandler(this.btnPagarTodo_Click);
            // 
            // btnPagarSelec
            // 
            this.btnPagarSelec.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnPagarSelec.ForeColor = System.Drawing.Color.Orange;
            this.btnPagarSelec.Location = new System.Drawing.Point(526, 227);
            this.btnPagarSelec.Name = "btnPagarSelec";
            this.btnPagarSelec.Size = new System.Drawing.Size(75, 33);
            this.btnPagarSelec.TabIndex = 8;
            this.btnPagarSelec.Text = "Pagar";
            this.btnPagarSelec.UseVisualStyleBackColor = true;
            // 
            // FormMiCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.btnPagarSelec);
            this.Controls.Add(this.btnPagarTodo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labSaldoRestante);
            this.Controls.Add(this.labVuelosComprados);
            this.Controls.Add(this.lbVuelosComprados);
            this.Controls.Add(this.lbTituloCuenta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMiCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Risas Turismo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTituloCuenta;
        private System.Windows.Forms.ListBox lbVuelosComprados;
        private System.Windows.Forms.Label labVuelosComprados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labSaldoRestante;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPagarTodo;
        private System.Windows.Forms.Button btnPagarSelec;
    }
}