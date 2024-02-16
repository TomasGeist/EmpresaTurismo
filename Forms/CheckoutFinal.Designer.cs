using EmpresaTurismo.Properties;

namespace EmpresaTurismo.Forms
{
    partial class CheckoutFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutFinal));
            this.button1 = new System.Windows.Forms.Button();
            this.gbResumen = new System.Windows.Forms.GroupBox();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPagar = new System.Windows.Forms.Button();
            this.gbResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
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
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbResumen
            // 
            this.gbResumen.Controls.Add(this.dgvResumen);
            this.gbResumen.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbResumen.Location = new System.Drawing.Point(66, 56);
            this.gbResumen.Name = "gbResumen";
            this.gbResumen.Size = new System.Drawing.Size(677, 249);
            this.gbResumen.TabIndex = 2;
            this.gbResumen.TabStop = false;
            this.gbResumen.Text = "Resumen de Pago";
            // 
            // dgvResumen
            // 
            this.dgvResumen.BackgroundColor = System.Drawing.Color.White;
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResumen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Destino,
            this.Fecha,
            this.Precio,
            this.Impuesto,
            this.Total});
            this.dgvResumen.Location = new System.Drawing.Point(7, 20);
            this.dgvResumen.MinimumSize = new System.Drawing.Size(650, 0);
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.RowHeadersWidth = 162;
            this.dgvResumen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResumen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvResumen.Size = new System.Drawing.Size(664, 226);
            this.dgvResumen.TabIndex = 0;
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            this.Destino.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Impuesto
            // 
            this.Impuesto.HeaderText = "Impuesto";
            this.Impuesto.Name = "Impuesto";
            this.Impuesto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.Ivory;
            this.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.Orange;
            this.btnPagar.Location = new System.Drawing.Point(372, 311);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 33);
            this.btnPagar.TabIndex = 3;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // CheckoutFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.gbResumen);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CheckoutFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Risas Turismo";
            this.gbResumen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbResumen;
        private System.Windows.Forms.DataGridView dgvResumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnPagar;
    }
}