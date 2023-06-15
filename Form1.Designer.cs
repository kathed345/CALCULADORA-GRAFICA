
namespace interfaz
{
    partial class primer_form
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
            this.panel_form1 = new System.Windows.Forms.Panel();
            this.panel_relleno_form1 = new System.Windows.Forms.Panel();
            this.titulo_consulta = new System.Windows.Forms.Label();
            this.imagen_info = new System.Windows.Forms.PictureBox();
            this.titulo_salida = new System.Windows.Forms.Label();
            this.imagen_salida = new System.Windows.Forms.PictureBox();
            this.subtitulo_algebra = new System.Windows.Forms.Label();
            this.titulo_despejes = new System.Windows.Forms.Label();
            this.subtitulo_mate = new System.Windows.Forms.Label();
            this.boton_consulta = new interfaz.new_button();
            this.titulo_graficas = new System.Windows.Forms.Label();
            this.imagen_boton_algebra = new System.Windows.Forms.PictureBox();
            this.imagen_boton_mate = new System.Windows.Forms.PictureBox();
            this.boton_salida = new interfaz.new_button();
            this.boton_algebra = new interfaz.new_button();
            this.boton_mate = new interfaz.new_button();
            this.panel_form1.SuspendLayout();
            this.panel_relleno_form1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_salida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_boton_algebra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_boton_mate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_form1
            // 
            this.panel_form1.Controls.Add(this.panel_relleno_form1);
            this.panel_form1.Location = new System.Drawing.Point(0, 0);
            this.panel_form1.Name = "panel_form1";
            this.panel_form1.Size = new System.Drawing.Size(571, 314);
            this.panel_form1.TabIndex = 0;
            // 
            // panel_relleno_form1
            // 
            this.panel_relleno_form1.Controls.Add(this.titulo_consulta);
            this.panel_relleno_form1.Controls.Add(this.imagen_info);
            this.panel_relleno_form1.Controls.Add(this.titulo_salida);
            this.panel_relleno_form1.Controls.Add(this.imagen_salida);
            this.panel_relleno_form1.Controls.Add(this.subtitulo_algebra);
            this.panel_relleno_form1.Controls.Add(this.titulo_despejes);
            this.panel_relleno_form1.Controls.Add(this.subtitulo_mate);
            this.panel_relleno_form1.Controls.Add(this.boton_consulta);
            this.panel_relleno_form1.Controls.Add(this.titulo_graficas);
            this.panel_relleno_form1.Controls.Add(this.imagen_boton_algebra);
            this.panel_relleno_form1.Controls.Add(this.imagen_boton_mate);
            this.panel_relleno_form1.Controls.Add(this.boton_salida);
            this.panel_relleno_form1.Controls.Add(this.boton_algebra);
            this.panel_relleno_form1.Controls.Add(this.boton_mate);
            this.panel_relleno_form1.Location = new System.Drawing.Point(14, 15);
            this.panel_relleno_form1.Name = "panel_relleno_form1";
            this.panel_relleno_form1.Size = new System.Drawing.Size(540, 284);
            this.panel_relleno_form1.TabIndex = 0;
            // 
            // titulo_consulta
            // 
            this.titulo_consulta.AutoSize = true;
            this.titulo_consulta.BackColor = System.Drawing.Color.Gray;
            this.titulo_consulta.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_consulta.ForeColor = System.Drawing.SystemColors.Control;
            this.titulo_consulta.Location = new System.Drawing.Point(297, 192);
            this.titulo_consulta.Name = "titulo_consulta";
            this.titulo_consulta.Size = new System.Drawing.Size(88, 21);
            this.titulo_consulta.TabIndex = 13;
            this.titulo_consulta.Text = "Consulta";
            // 
            // imagen_info
            // 
            this.imagen_info.BackColor = System.Drawing.Color.Transparent;
            this.imagen_info.BackgroundImage = global::interfaz.Properties.Resources.informacion;
            this.imagen_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagen_info.Location = new System.Drawing.Point(300, 156);
            this.imagen_info.Name = "imagen_info";
            this.imagen_info.Size = new System.Drawing.Size(30, 30);
            this.imagen_info.TabIndex = 12;
            this.imagen_info.TabStop = false;
            // 
            // titulo_salida
            // 
            this.titulo_salida.AutoSize = true;
            this.titulo_salida.BackColor = System.Drawing.Color.Gray;
            this.titulo_salida.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_salida.ForeColor = System.Drawing.SystemColors.Control;
            this.titulo_salida.Location = new System.Drawing.Point(79, 194);
            this.titulo_salida.Name = "titulo_salida";
            this.titulo_salida.Size = new System.Drawing.Size(63, 21);
            this.titulo_salida.TabIndex = 11;
            this.titulo_salida.Text = "Salida";
            // 
            // imagen_salida
            // 
            this.imagen_salida.BackColor = System.Drawing.Color.Transparent;
            this.imagen_salida.BackgroundImage = global::interfaz.Properties.Resources.cerrar;
            this.imagen_salida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagen_salida.Location = new System.Drawing.Point(85, 162);
            this.imagen_salida.Name = "imagen_salida";
            this.imagen_salida.Size = new System.Drawing.Size(25, 25);
            this.imagen_salida.TabIndex = 10;
            this.imagen_salida.TabStop = false;
            // 
            // subtitulo_algebra
            // 
            this.subtitulo_algebra.AutoSize = true;
            this.subtitulo_algebra.BackColor = System.Drawing.Color.Gray;
            this.subtitulo_algebra.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitulo_algebra.ForeColor = System.Drawing.SystemColors.Control;
            this.subtitulo_algebra.Location = new System.Drawing.Point(297, 105);
            this.subtitulo_algebra.Name = "subtitulo_algebra";
            this.subtitulo_algebra.Size = new System.Drawing.Size(51, 22);
            this.subtitulo_algebra.TabIndex = 9;
            this.subtitulo_algebra.Text = "Algebra";
            // 
            // titulo_despejes
            // 
            this.titulo_despejes.AutoSize = true;
            this.titulo_despejes.BackColor = System.Drawing.Color.Gray;
            this.titulo_despejes.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_despejes.ForeColor = System.Drawing.SystemColors.Control;
            this.titulo_despejes.Location = new System.Drawing.Point(296, 85);
            this.titulo_despejes.Name = "titulo_despejes";
            this.titulo_despejes.Size = new System.Drawing.Size(87, 21);
            this.titulo_despejes.TabIndex = 8;
            this.titulo_despejes.Text = "Despejes";
            // 
            // subtitulo_mate
            // 
            this.subtitulo_mate.AutoSize = true;
            this.subtitulo_mate.BackColor = System.Drawing.Color.Gray;
            this.subtitulo_mate.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitulo_mate.ForeColor = System.Drawing.SystemColors.Control;
            this.subtitulo_mate.Location = new System.Drawing.Point(79, 105);
            this.subtitulo_mate.Name = "subtitulo_mate";
            this.subtitulo_mate.Size = new System.Drawing.Size(73, 22);
            this.subtitulo_mate.TabIndex = 7;
            this.subtitulo_mate.Text = "Matematica";
            // 
            // boton_consulta
            // 
            this.boton_consulta.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.boton_consulta.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.boton_consulta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.boton_consulta.BorderRadius = 23;
            this.boton_consulta.BorderSize = 0;
            this.boton_consulta.FlatAppearance.BorderSize = 0;
            this.boton_consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_consulta.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_consulta.ForeColor = System.Drawing.Color.White;
            this.boton_consulta.Location = new System.Drawing.Point(272, 143);
            this.boton_consulta.Name = "boton_consulta";
            this.boton_consulta.Size = new System.Drawing.Size(206, 97);
            this.boton_consulta.TabIndex = 3;
            this.boton_consulta.TextColor = System.Drawing.Color.White;
            this.boton_consulta.UseVisualStyleBackColor = false;
            this.boton_consulta.Click += new System.EventHandler(this.boton_consulta_Click);
            // 
            // titulo_graficas
            // 
            this.titulo_graficas.AutoSize = true;
            this.titulo_graficas.BackColor = System.Drawing.Color.Gray;
            this.titulo_graficas.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_graficas.ForeColor = System.Drawing.SystemColors.Control;
            this.titulo_graficas.Location = new System.Drawing.Point(78, 87);
            this.titulo_graficas.Name = "titulo_graficas";
            this.titulo_graficas.Size = new System.Drawing.Size(81, 21);
            this.titulo_graficas.TabIndex = 6;
            this.titulo_graficas.Text = "Graficas";
            // 
            // imagen_boton_algebra
            // 
            this.imagen_boton_algebra.BackColor = System.Drawing.Color.Transparent;
            this.imagen_boton_algebra.BackgroundImage = global::interfaz.Properties.Resources.al_cuadrado;
            this.imagen_boton_algebra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagen_boton_algebra.Location = new System.Drawing.Point(300, 51);
            this.imagen_boton_algebra.Name = "imagen_boton_algebra";
            this.imagen_boton_algebra.Size = new System.Drawing.Size(39, 33);
            this.imagen_boton_algebra.TabIndex = 5;
            this.imagen_boton_algebra.TabStop = false;
            this.imagen_boton_algebra.Click += new System.EventHandler(this.imagen_boton_algebra_Click);
            // 
            // imagen_boton_mate
            // 
            this.imagen_boton_mate.BackColor = System.Drawing.Color.Transparent;
            this.imagen_boton_mate.BackgroundImage = global::interfaz.Properties.Resources.grafico__1_;
            this.imagen_boton_mate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagen_boton_mate.Location = new System.Drawing.Point(82, 51);
            this.imagen_boton_mate.Name = "imagen_boton_mate";
            this.imagen_boton_mate.Size = new System.Drawing.Size(36, 33);
            this.imagen_boton_mate.TabIndex = 4;
            this.imagen_boton_mate.TabStop = false;
            // 
            // boton_salida
            // 
            this.boton_salida.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.boton_salida.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.boton_salida.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.boton_salida.BorderRadius = 23;
            this.boton_salida.BorderSize = 0;
            this.boton_salida.FlatAppearance.BorderSize = 0;
            this.boton_salida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_salida.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_salida.ForeColor = System.Drawing.Color.White;
            this.boton_salida.Location = new System.Drawing.Point(60, 143);
            this.boton_salida.Name = "boton_salida";
            this.boton_salida.Size = new System.Drawing.Size(206, 97);
            this.boton_salida.TabIndex = 2;
            this.boton_salida.TextColor = System.Drawing.Color.White;
            this.boton_salida.UseVisualStyleBackColor = false;
            this.boton_salida.Click += new System.EventHandler(this.boton_salida_Click);
            // 
            // boton_algebra
            // 
            this.boton_algebra.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.boton_algebra.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.boton_algebra.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.boton_algebra.BorderRadius = 23;
            this.boton_algebra.BorderSize = 0;
            this.boton_algebra.FlatAppearance.BorderSize = 0;
            this.boton_algebra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_algebra.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_algebra.ForeColor = System.Drawing.Color.White;
            this.boton_algebra.Location = new System.Drawing.Point(272, 40);
            this.boton_algebra.Name = "boton_algebra";
            this.boton_algebra.Size = new System.Drawing.Size(206, 97);
            this.boton_algebra.TabIndex = 1;
            this.boton_algebra.TextColor = System.Drawing.Color.White;
            this.boton_algebra.UseVisualStyleBackColor = false;
            this.boton_algebra.Click += new System.EventHandler(this.boton_algebra_Click);
            // 
            // boton_mate
            // 
            this.boton_mate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.boton_mate.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.boton_mate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.boton_mate.BorderRadius = 23;
            this.boton_mate.BorderSize = 0;
            this.boton_mate.FlatAppearance.BorderSize = 0;
            this.boton_mate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_mate.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_mate.ForeColor = System.Drawing.Color.White;
            this.boton_mate.Location = new System.Drawing.Point(60, 40);
            this.boton_mate.Name = "boton_mate";
            this.boton_mate.Size = new System.Drawing.Size(206, 97);
            this.boton_mate.TabIndex = 0;
            this.boton_mate.TextColor = System.Drawing.Color.White;
            this.boton_mate.UseVisualStyleBackColor = false;
            this.boton_mate.Click += new System.EventHandler(this.boton_mate_Click);
            // 
            // primer_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(571, 311);
            this.Controls.Add(this.panel_form1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "primer_form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_form1.ResumeLayout(false);
            this.panel_relleno_form1.ResumeLayout(false);
            this.panel_relleno_form1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_salida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_boton_algebra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_boton_mate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_form1;
        private System.Windows.Forms.Panel panel_relleno_form1;
        private new_button boton_consulta;
        private new_button boton_salida;
        private new_button boton_algebra;
        private new_button boton_mate;
        private System.Windows.Forms.PictureBox imagen_boton_mate;
        private System.Windows.Forms.PictureBox imagen_boton_algebra;
        private System.Windows.Forms.Label subtitulo_mate;
        private System.Windows.Forms.Label titulo_graficas;
        private System.Windows.Forms.Label subtitulo_algebra;
        private System.Windows.Forms.Label titulo_despejes;
        private System.Windows.Forms.PictureBox imagen_salida;
        private System.Windows.Forms.Label titulo_consulta;
        private System.Windows.Forms.PictureBox imagen_info;
        private System.Windows.Forms.Label titulo_salida;
    }
}

