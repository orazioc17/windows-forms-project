
namespace asignacion_2_orazio_cappadonna
{
    partial class form_bienvenida
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
            this.btn_notas = new System.Windows.Forms.Button();
            this.btn_comprar_pc = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_notas
            // 
            this.btn_notas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_notas.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_notas.ForeColor = System.Drawing.Color.Navy;
            this.btn_notas.Location = new System.Drawing.Point(12, 12);
            this.btn_notas.Name = "btn_notas";
            this.btn_notas.Size = new System.Drawing.Size(456, 69);
            this.btn_notas.TabIndex = 2;
            this.btn_notas.Text = "Formulario de notas";
            this.btn_notas.UseVisualStyleBackColor = true;
            this.btn_notas.Click += new System.EventHandler(this.btn_notas_Click);
            // 
            // btn_comprar_pc
            // 
            this.btn_comprar_pc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comprar_pc.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprar_pc.ForeColor = System.Drawing.Color.Navy;
            this.btn_comprar_pc.Location = new System.Drawing.Point(12, 87);
            this.btn_comprar_pc.Name = "btn_comprar_pc";
            this.btn_comprar_pc.Size = new System.Drawing.Size(456, 69);
            this.btn_comprar_pc.TabIndex = 3;
            this.btn_comprar_pc.Text = "Formulario de compras";
            this.btn_comprar_pc.UseVisualStyleBackColor = true;
            this.btn_comprar_pc.Click += new System.EventHandler(this.btn_comprar_pc_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.Navy;
            this.btn_salir.Location = new System.Drawing.Point(12, 162);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(456, 69);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // form_bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(480, 244);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_comprar_pc);
            this.Controls.Add(this.btn_notas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "form_bienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenida";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_notas;
        private System.Windows.Forms.Button btn_comprar_pc;
        private System.Windows.Forms.Button btn_salir;
    }
}

