
namespace asignacion_2_orazio_cappadonna
{
    partial class form_computadoras
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.list_procesador = new System.Windows.Forms.ListBox();
            this.btn_amd = new System.Windows.Forms.RadioButton();
            this.btn_intel = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_monitor = new System.Windows.Forms.ListBox();
            this.btn_crt = new System.Windows.Forms.RadioButton();
            this.btn_lcd = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_generar_factura = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_num_fac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.list_precio = new System.Windows.Forms.ListBox();
            this.list_descripcion = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nueva_factura = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn__atras = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.list_procesador);
            this.groupBox1.Controls.Add(this.btn_amd);
            this.groupBox1.Controls.Add(this.btn_intel);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procesador";
            // 
            // list_procesador
            // 
            this.list_procesador.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_procesador.FormattingEnabled = true;
            this.list_procesador.ItemHeight = 19;
            this.list_procesador.Location = new System.Drawing.Point(6, 86);
            this.list_procesador.Name = "list_procesador";
            this.list_procesador.Size = new System.Drawing.Size(191, 80);
            this.list_procesador.TabIndex = 2;
            this.list_procesador.SelectedIndexChanged += new System.EventHandler(this.list_procesador_SelectedIndexChanged);
            // 
            // btn_amd
            // 
            this.btn_amd.AutoSize = true;
            this.btn_amd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_amd.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_amd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_amd.Location = new System.Drawing.Point(6, 51);
            this.btn_amd.Name = "btn_amd";
            this.btn_amd.Size = new System.Drawing.Size(72, 25);
            this.btn_amd.TabIndex = 1;
            this.btn_amd.TabStop = true;
            this.btn_amd.Text = "AMD";
            this.btn_amd.UseVisualStyleBackColor = true;
            this.btn_amd.CheckedChanged += new System.EventHandler(this.btn_amd_CheckedChanged);
            // 
            // btn_intel
            // 
            this.btn_intel.AutoSize = true;
            this.btn_intel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_intel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_intel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_intel.Location = new System.Drawing.Point(6, 28);
            this.btn_intel.Name = "btn_intel";
            this.btn_intel.Size = new System.Drawing.Size(68, 25);
            this.btn_intel.TabIndex = 0;
            this.btn_intel.TabStop = true;
            this.btn_intel.Text = "Intel";
            this.btn_intel.UseVisualStyleBackColor = true;
            this.btn_intel.CheckedChanged += new System.EventHandler(this.btn_intel_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.list_monitor);
            this.groupBox2.Controls.Add(this.btn_crt);
            this.groupBox2.Controls.Add(this.btn_lcd);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(221, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 177);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monitor";
            // 
            // list_monitor
            // 
            this.list_monitor.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_monitor.FormattingEnabled = true;
            this.list_monitor.ItemHeight = 19;
            this.list_monitor.Location = new System.Drawing.Point(6, 86);
            this.list_monitor.Name = "list_monitor";
            this.list_monitor.Size = new System.Drawing.Size(185, 80);
            this.list_monitor.TabIndex = 3;
            this.list_monitor.SelectedIndexChanged += new System.EventHandler(this.list_monitor_SelectedIndexChanged);
            // 
            // btn_crt
            // 
            this.btn_crt.AutoSize = true;
            this.btn_crt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crt.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_crt.Location = new System.Drawing.Point(6, 51);
            this.btn_crt.Name = "btn_crt";
            this.btn_crt.Size = new System.Drawing.Size(64, 25);
            this.btn_crt.TabIndex = 2;
            this.btn_crt.TabStop = true;
            this.btn_crt.Text = "CRT";
            this.btn_crt.UseVisualStyleBackColor = true;
            this.btn_crt.CheckedChanged += new System.EventHandler(this.btn_crt_CheckedChanged);
            // 
            // btn_lcd
            // 
            this.btn_lcd.AutoSize = true;
            this.btn_lcd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_lcd.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lcd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_lcd.Location = new System.Drawing.Point(6, 28);
            this.btn_lcd.Name = "btn_lcd";
            this.btn_lcd.Size = new System.Drawing.Size(66, 25);
            this.btn_lcd.TabIndex = 1;
            this.btn_lcd.TabStop = true;
            this.btn_lcd.Text = "LCD";
            this.btn_lcd.UseVisualStyleBackColor = true;
            this.btn_lcd.CheckedChanged += new System.EventHandler(this.btn_lcd_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_eliminar);
            this.groupBox3.Controls.Add(this.txt_direccion);
            this.groupBox3.Controls.Add(this.txt_cedula);
            this.groupBox3.Controls.Add(this.txt_nombre);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_num_fac);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_total);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.list_precio);
            this.groupBox3.Controls.Add(this.list_descripcion);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(756, 249);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Facturacion";
            // 
            // btn_generar_factura
            // 
            this.btn_generar_factura.BackColor = System.Drawing.Color.Silver;
            this.btn_generar_factura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_generar_factura.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar_factura.ForeColor = System.Drawing.Color.Navy;
            this.btn_generar_factura.Location = new System.Drawing.Point(495, 298);
            this.btn_generar_factura.Name = "btn_generar_factura";
            this.btn_generar_factura.Size = new System.Drawing.Size(105, 64);
            this.btn_generar_factura.TabIndex = 16;
            this.btn_generar_factura.Text = "Generar factura";
            this.btn_generar_factura.UseVisualStyleBackColor = false;
            this.btn_generar_factura.Click += new System.EventHandler(this.btn_generar_factura_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Silver;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.Navy;
            this.btn_eliminar.Location = new System.Drawing.Point(372, 196);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(180, 35);
            this.btn_eliminar.TabIndex = 15;
            this.btn_eliminar.Text = "Eliminar item";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txt_direccion
            // 
            this.txt_direccion.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.Location = new System.Drawing.Point(10, 200);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(318, 30);
            this.txt_direccion.TabIndex = 14;
            this.txt_direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_direccion_KeyPress);
            // 
            // txt_cedula
            // 
            this.txt_cedula.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cedula.Location = new System.Drawing.Point(10, 143);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(318, 30);
            this.txt_cedula.TabIndex = 13;
            this.txt_cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cedula_KeyPress);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(10, 86);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(318, 30);
            this.txt_nombre.TabIndex = 12;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(6, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Direccion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(6, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cedula de identidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombres y apellidos:";
            // 
            // txt_num_fac
            // 
            this.txt_num_fac.Enabled = false;
            this.txt_num_fac.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_fac.Location = new System.Drawing.Point(137, 25);
            this.txt_num_fac.Name = "txt_num_fac";
            this.txt_num_fac.Size = new System.Drawing.Size(105, 30);
            this.txt_num_fac.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nro. Factura:";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(624, 200);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(123, 30);
            this.txt_total.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(558, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total:";
            // 
            // list_precio
            // 
            this.list_precio.Enabled = false;
            this.list_precio.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_precio.FormattingEnabled = true;
            this.list_precio.ItemHeight = 19;
            this.list_precio.Location = new System.Drawing.Point(594, 52);
            this.list_precio.Name = "list_precio";
            this.list_precio.Size = new System.Drawing.Size(153, 137);
            this.list_precio.TabIndex = 4;
            // 
            // list_descripcion
            // 
            this.list_descripcion.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_descripcion.FormattingEnabled = true;
            this.list_descripcion.ItemHeight = 19;
            this.list_descripcion.Location = new System.Drawing.Point(372, 52);
            this.list_descripcion.Name = "list_descripcion";
            this.list_descripcion.Size = new System.Drawing.Size(216, 137);
            this.list_descripcion.TabIndex = 3;
            this.list_descripcion.SelectedIndexChanged += new System.EventHandler(this.list_descripcion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(590, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(368, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // btn_nueva_factura
            // 
            this.btn_nueva_factura.BackColor = System.Drawing.Color.Silver;
            this.btn_nueva_factura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nueva_factura.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nueva_factura.ForeColor = System.Drawing.Color.Navy;
            this.btn_nueva_factura.Location = new System.Drawing.Point(619, 298);
            this.btn_nueva_factura.Name = "btn_nueva_factura";
            this.btn_nueva_factura.Size = new System.Drawing.Size(105, 64);
            this.btn_nueva_factura.TabIndex = 17;
            this.btn_nueva_factura.Text = "Nueva factura";
            this.btn_nueva_factura.UseVisualStyleBackColor = false;
            this.btn_nueva_factura.Click += new System.EventHandler(this.btn_nueva_factura_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Silver;
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.Navy;
            this.btn_salir.Location = new System.Drawing.Point(666, 381);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(102, 64);
            this.btn_salir.TabIndex = 18;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Silver;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Navy;
            this.btn_cancelar.Location = new System.Drawing.Point(447, 380);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(105, 64);
            this.btn_cancelar.TabIndex = 19;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn__atras
            // 
            this.btn__atras.BackColor = System.Drawing.Color.Silver;
            this.btn__atras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn__atras.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__atras.ForeColor = System.Drawing.Color.Navy;
            this.btn__atras.Location = new System.Drawing.Point(558, 381);
            this.btn__atras.Name = "btn__atras";
            this.btn__atras.Size = new System.Drawing.Size(102, 64);
            this.btn__atras.TabIndex = 20;
            this.btn__atras.Text = "Atras";
            this.btn__atras.UseVisualStyleBackColor = false;
            this.btn__atras.Click += new System.EventHandler(this.btn__atras_Click);
            // 
            // form_computadoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.Controls.Add(this.btn__atras);
            this.Controls.Add(this.btn_generar_factura);
            this.Controls.Add(this.btn_nueva_factura);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "form_computadoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta de Hardware";
            this.Load += new System.EventHandler(this.form_computadoras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox list_procesador;
        private System.Windows.Forms.RadioButton btn_amd;
        private System.Windows.Forms.RadioButton btn_intel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox list_monitor;
        private System.Windows.Forms.RadioButton btn_crt;
        private System.Windows.Forms.RadioButton btn_lcd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_generar_factura;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_num_fac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox list_precio;
        private System.Windows.Forms.ListBox list_descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_nueva_factura;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn__atras;
    }
}