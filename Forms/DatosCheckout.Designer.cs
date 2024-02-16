namespace EmpresaTurismo.Forms
{
    partial class DatosCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosCheckout));
            this.button1 = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatosTarjeta = new System.Windows.Forms.GroupBox();
            this.tbCad2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCvc = new System.Windows.Forms.TextBox();
            this.tbCad1 = new System.Windows.Forms.TextBox();
            this.tbTarjeta = new System.Windows.Forms.TextBox();
            this.gbDatosExtra = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbGuardar = new System.Windows.Forms.CheckBox();
            this.tbCp = new System.Windows.Forms.TextBox();
            this.tbPiso = new System.Windows.Forms.TextBox();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.tbDir = new System.Windows.Forms.TextBox();
            this.tbCiudad = new System.Windows.Forms.TextBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.labAgradecimiento = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.labError = new System.Windows.Forms.Label();
            this.gbDatosPersonales.SuspendLayout();
            this.gbDatosTarjeta.SuspendLayout();
            this.gbDatosExtra.SuspendLayout();
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
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.tbNombre.ForeColor = System.Drawing.Color.Orange;
            this.tbNombre.Location = new System.Drawing.Point(7, 40);
            this.tbNombre.MaxLength = 20;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 21);
            this.tbNombre.TabIndex = 2;
            this.tbNombre.WordWrap = false;
            // 
            // tbApellido
            // 
            this.tbApellido.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.tbApellido.ForeColor = System.Drawing.Color.Orange;
            this.tbApellido.Location = new System.Drawing.Point(123, 40);
            this.tbApellido.MaxLength = 20;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(100, 21);
            this.tbApellido.TabIndex = 3;
            this.tbApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbApellido.WordWrap = false;
            // 
            // tbDni
            // 
            this.tbDni.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.tbDni.ForeColor = System.Drawing.Color.Orange;
            this.tbDni.Location = new System.Drawing.Point(123, 77);
            this.tbDni.MaxLength = 9;
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(100, 21);
            this.tbDni.TabIndex = 4;
            this.tbDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDni.WordWrap = false;
            this.tbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.tbTelefono.ForeColor = System.Drawing.Color.Orange;
            this.tbTelefono.Location = new System.Drawing.Point(7, 77);
            this.tbTelefono.MaxLength = 15;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(100, 21);
            this.tbTelefono.TabIndex = 5;
            this.tbTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTelefono.WordWrap = false;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Controls.Add(this.label4);
            this.gbDatosPersonales.Controls.Add(this.label3);
            this.gbDatosPersonales.Controls.Add(this.label2);
            this.gbDatosPersonales.Controls.Add(this.label1);
            this.gbDatosPersonales.Controls.Add(this.tbNombre);
            this.gbDatosPersonales.Controls.Add(this.tbDni);
            this.gbDatosPersonales.Controls.Add(this.tbTelefono);
            this.gbDatosPersonales.Controls.Add(this.tbApellido);
            this.gbDatosPersonales.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosPersonales.ForeColor = System.Drawing.Color.White;
            this.gbDatosPersonales.Location = new System.Drawing.Point(78, 50);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(230, 119);
            this.gbDatosPersonales.TabIndex = 6;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = "Datos personales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(121, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "DNI*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefono*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(120, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre*";
            // 
            // gbDatosTarjeta
            // 
            this.gbDatosTarjeta.Controls.Add(this.tbCad2);
            this.gbDatosTarjeta.Controls.Add(this.label7);
            this.gbDatosTarjeta.Controls.Add(this.label6);
            this.gbDatosTarjeta.Controls.Add(this.label5);
            this.gbDatosTarjeta.Controls.Add(this.tbCvc);
            this.gbDatosTarjeta.Controls.Add(this.tbCad1);
            this.gbDatosTarjeta.Controls.Add(this.tbTarjeta);
            this.gbDatosTarjeta.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbDatosTarjeta.ForeColor = System.Drawing.Color.White;
            this.gbDatosTarjeta.Location = new System.Drawing.Point(78, 176);
            this.gbDatosTarjeta.Name = "gbDatosTarjeta";
            this.gbDatosTarjeta.Size = new System.Drawing.Size(230, 109);
            this.gbDatosTarjeta.TabIndex = 7;
            this.gbDatosTarjeta.TabStop = false;
            this.gbDatosTarjeta.Text = "Datos Tarjeta";
            // 
            // tbCad2
            // 
            this.tbCad2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.tbCad2.ForeColor = System.Drawing.Color.Orange;
            this.tbCad2.Location = new System.Drawing.Point(45, 82);
            this.tbCad2.MaxLength = 2;
            this.tbCad2.Name = "tbCad2";
            this.tbCad2.Size = new System.Drawing.Size(30, 21);
            this.tbCad2.TabIndex = 10;
            this.tbCad2.Text = "24";
            this.tbCad2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCad2.WordWrap = false;
            this.tbCad2.TextChanged += new System.EventHandler(this.tbCad2_TextChanged);
            this.tbCad2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCad2_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(121, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "CVC*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Caducidad*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nro de Tarjeta*";
            // 
            // tbCvc
            // 
            this.tbCvc.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.tbCvc.ForeColor = System.Drawing.Color.Orange;
            this.tbCvc.Location = new System.Drawing.Point(123, 82);
            this.tbCvc.MaxLength = 3;
            this.tbCvc.Name = "tbCvc";
            this.tbCvc.Size = new System.Drawing.Size(34, 21);
            this.tbCvc.TabIndex = 2;
            this.tbCvc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCvc.WordWrap = false;
            this.tbCvc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCvc_KeyPress);
            // 
            // tbCad1
            // 
            this.tbCad1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.tbCad1.ForeColor = System.Drawing.Color.Orange;
            this.tbCad1.Location = new System.Drawing.Point(7, 82);
            this.tbCad1.MaxLength = 2;
            this.tbCad1.Name = "tbCad1";
            this.tbCad1.Size = new System.Drawing.Size(30, 21);
            this.tbCad1.TabIndex = 1;
            this.tbCad1.Text = "02";
            this.tbCad1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCad1.WordWrap = false;
            this.tbCad1.TextChanged += new System.EventHandler(this.tbCad1_TextChanged);
            this.tbCad1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCad1_KeyPress);
            // 
            // tbTarjeta
            // 
            this.tbTarjeta.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.tbTarjeta.ForeColor = System.Drawing.Color.Orange;
            this.tbTarjeta.Location = new System.Drawing.Point(6, 36);
            this.tbTarjeta.MaxLength = 16;
            this.tbTarjeta.Name = "tbTarjeta";
            this.tbTarjeta.Size = new System.Drawing.Size(217, 21);
            this.tbTarjeta.TabIndex = 0;
            this.tbTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTarjeta.WordWrap = false;
            this.tbTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // gbDatosExtra
            // 
            this.gbDatosExtra.Controls.Add(this.label13);
            this.gbDatosExtra.Controls.Add(this.label12);
            this.gbDatosExtra.Controls.Add(this.label11);
            this.gbDatosExtra.Controls.Add(this.label10);
            this.gbDatosExtra.Controls.Add(this.label9);
            this.gbDatosExtra.Controls.Add(this.label8);
            this.gbDatosExtra.Controls.Add(this.cbGuardar);
            this.gbDatosExtra.Controls.Add(this.tbCp);
            this.gbDatosExtra.Controls.Add(this.tbPiso);
            this.gbDatosExtra.Controls.Add(this.tbNum);
            this.gbDatosExtra.Controls.Add(this.tbDir);
            this.gbDatosExtra.Controls.Add(this.tbCiudad);
            this.gbDatosExtra.Controls.Add(this.tbPais);
            this.gbDatosExtra.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbDatosExtra.ForeColor = System.Drawing.Color.White;
            this.gbDatosExtra.Location = new System.Drawing.Point(78, 291);
            this.gbDatosExtra.Name = "gbDatosExtra";
            this.gbDatosExtra.Size = new System.Drawing.Size(230, 133);
            this.gbDatosExtra.TabIndex = 8;
            this.gbDatosExtra.TabStop = false;
            this.gbDatosExtra.Text = "Datos Extra";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(160, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Piso";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(121, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "NRO*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(5, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Direccion*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(191, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "CP*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(120, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ciudad*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(5, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Pais*";
            // 
            // cbGuardar
            // 
            this.cbGuardar.AutoSize = true;
            this.cbGuardar.Font = new System.Drawing.Font("Arial", 8.2F);
            this.cbGuardar.ForeColor = System.Drawing.Color.White;
            this.cbGuardar.Location = new System.Drawing.Point(6, 105);
            this.cbGuardar.Name = "cbGuardar";
            this.cbGuardar.Size = new System.Drawing.Size(204, 18);
            this.cbGuardar.TabIndex = 6;
            this.cbGuardar.Text = "Guardar datos para futuras compras\r\n";
            this.cbGuardar.UseVisualStyleBackColor = true;
            // 
            // tbCp
            // 
            this.tbCp.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.tbCp.ForeColor = System.Drawing.Color.Orange;
            this.tbCp.Location = new System.Drawing.Point(186, 39);
            this.tbCp.MaxLength = 8;
            this.tbCp.Name = "tbCp";
            this.tbCp.Size = new System.Drawing.Size(40, 21);
            this.tbCp.TabIndex = 5;
            this.tbCp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCp.WordWrap = false;
            this.tbCp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCp_KeyPress);
            // 
            // tbPiso
            // 
            this.tbPiso.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.tbPiso.ForeColor = System.Drawing.Color.Orange;
            this.tbPiso.Location = new System.Drawing.Point(161, 77);
            this.tbPiso.MaxLength = 3;
            this.tbPiso.Name = "tbPiso";
            this.tbPiso.Size = new System.Drawing.Size(34, 21);
            this.tbPiso.TabIndex = 4;
            this.tbPiso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPiso.WordWrap = false;
            this.tbPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPiso_KeyPress);
            // 
            // tbNum
            // 
            this.tbNum.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.tbNum.ForeColor = System.Drawing.Color.Orange;
            this.tbNum.Location = new System.Drawing.Point(122, 77);
            this.tbNum.MaxLength = 8;
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(34, 21);
            this.tbNum.TabIndex = 3;
            this.tbNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNum.WordWrap = false;
            this.tbNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNum_KeyPress);
            // 
            // tbDir
            // 
            this.tbDir.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.tbDir.ForeColor = System.Drawing.Color.Orange;
            this.tbDir.Location = new System.Drawing.Point(6, 77);
            this.tbDir.MaxLength = 200;
            this.tbDir.Name = "tbDir";
            this.tbDir.Size = new System.Drawing.Size(100, 21);
            this.tbDir.TabIndex = 2;
            this.tbDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDir.WordWrap = false;
            // 
            // tbCiudad
            // 
            this.tbCiudad.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.tbCiudad.ForeColor = System.Drawing.Color.Orange;
            this.tbCiudad.Location = new System.Drawing.Point(122, 39);
            this.tbCiudad.MaxLength = 25;
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(60, 21);
            this.tbCiudad.TabIndex = 1;
            this.tbCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCiudad.WordWrap = false;
            // 
            // tbPais
            // 
            this.tbPais.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.tbPais.ForeColor = System.Drawing.Color.Orange;
            this.tbPais.Location = new System.Drawing.Point(6, 39);
            this.tbPais.MaxLength = 30;
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(100, 21);
            this.tbPais.TabIndex = 0;
            this.tbPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPais.WordWrap = false;
            // 
            // labAgradecimiento
            // 
            this.labAgradecimiento.AutoSize = true;
            this.labAgradecimiento.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.labAgradecimiento.ForeColor = System.Drawing.Color.White;
            this.labAgradecimiento.Location = new System.Drawing.Point(387, 85);
            this.labAgradecimiento.MaximumSize = new System.Drawing.Size(430, 0);
            this.labAgradecimiento.Name = "labAgradecimiento";
            this.labAgradecimiento.Size = new System.Drawing.Size(364, 62);
            this.labAgradecimiento.TabIndex = 9;
            this.labAgradecimiento.Text = "Completa con tus datos para finalizar tu compra";
            this.labAgradecimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(393, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(516, 337);
            this.label14.MaximumSize = new System.Drawing.Size(430, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(235, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Los campos que poseen * son obligatorios";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Ivory;
            this.btnContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.Orange;
            this.btnContinuar.Location = new System.Drawing.Point(605, 426);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(106, 33);
            this.btnContinuar.TabIndex = 12;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // labError
            // 
            this.labError.AutoSize = true;
            this.labError.ForeColor = System.Drawing.Color.Red;
            this.labError.Location = new System.Drawing.Point(78, 431);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(236, 13);
            this.labError.TabIndex = 13;
            this.labError.Text = "*Se encontró un error, por favor revisa tus datos.";
            this.labError.Visible = false;
            // 
            // DatosCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.labError);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labAgradecimiento);
            this.Controls.Add(this.gbDatosExtra);
            this.Controls.Add(this.gbDatosTarjeta);
            this.Controls.Add(this.gbDatosPersonales);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DatosCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Risas Turismo";
            this.gbDatosPersonales.ResumeLayout(false);
            this.gbDatosPersonales.PerformLayout();
            this.gbDatosTarjeta.ResumeLayout(false);
            this.gbDatosTarjeta.PerformLayout();
            this.gbDatosExtra.ResumeLayout(false);
            this.gbDatosExtra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.GroupBox gbDatosTarjeta;
        private System.Windows.Forms.TextBox tbCvc;
        private System.Windows.Forms.TextBox tbCad1;
        private System.Windows.Forms.TextBox tbTarjeta;
        private System.Windows.Forms.GroupBox gbDatosExtra;
        private System.Windows.Forms.CheckBox cbGuardar;
        private System.Windows.Forms.TextBox tbCp;
        private System.Windows.Forms.TextBox tbPiso;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.TextBox tbDir;
        private System.Windows.Forms.TextBox tbCiudad;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCad2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labAgradecimiento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Label labError;
    }
}