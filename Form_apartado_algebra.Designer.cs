
namespace interfaz
{
    partial class Form_apartado_algebra
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
            this.label_bienvenida_algebra = new System.Windows.Forms.Label();
            this.metodos_algebra_cmb = new System.Windows.Forms.ComboBox();
            this.text_ecuacion1 = new System.Windows.Forms.TextBox();
            this.panel_grafica_texto = new System.Windows.Forms.Panel();
            this.label_resultados_algebra = new System.Windows.Forms.Label();
            this.panel_grafica_algebra = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imagen_grafica = new System.Windows.Forms.PictureBox();
            this.text_grafica_algebra = new System.Windows.Forms.RichTextBox();
            this.text_ecuacion2 = new System.Windows.Forms.TextBox();
            this.panel_central_algebra = new System.Windows.Forms.Panel();
            this.imagen_usuario = new System.Windows.Forms.PictureBox();
            this.panel_barra_desplazamineto_algebra = new System.Windows.Forms.Panel();
            this.image_inicio = new System.Windows.Forms.PictureBox();
            this.image_salida = new System.Windows.Forms.PictureBox();
            this.image_recarga = new System.Windows.Forms.PictureBox();
            this.algebra_label_titulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.new_button1 = new interfaz.new_button();
            this.panel_grafica_texto.SuspendLayout();
            this.panel_grafica_algebra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_grafica)).BeginInit();
            this.panel_central_algebra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_usuario)).BeginInit();
            this.panel_barra_desplazamineto_algebra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_inicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_salida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_recarga)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label_bienvenida_algebra
            // 
            this.label_bienvenida_algebra.AutoSize = true;
            this.label_bienvenida_algebra.Font = new System.Drawing.Font("Quicksand Medium", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bienvenida_algebra.Location = new System.Drawing.Point(183, 22);
            this.label_bienvenida_algebra.Name = "label_bienvenida_algebra";
            this.label_bienvenida_algebra.Size = new System.Drawing.Size(215, 52);
            this.label_bienvenida_algebra.TabIndex = 15;
            this.label_bienvenida_algebra.Text = "Bienvenido";
            // 
            // metodos_algebra_cmb
            // 
            this.metodos_algebra_cmb.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metodos_algebra_cmb.FormattingEnabled = true;
            this.metodos_algebra_cmb.Items.AddRange(new object[] {
            "Susititucion",
            "Eliminación",
            "Igualación",
            "Forma Gráfica",
            "Por determinante",
            "Por Matrices",
            "Por Vectores"});
            this.metodos_algebra_cmb.Location = new System.Drawing.Point(189, 86);
            this.metodos_algebra_cmb.Name = "metodos_algebra_cmb";
            this.metodos_algebra_cmb.Size = new System.Drawing.Size(125, 26);
            this.metodos_algebra_cmb.TabIndex = 18;
            this.metodos_algebra_cmb.Text = "Método";
            // 
            // text_ecuacion1
            // 
            this.text_ecuacion1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_ecuacion1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ecuacion1.Location = new System.Drawing.Point(322, 89);
            this.text_ecuacion1.Name = "text_ecuacion1";
            this.text_ecuacion1.Size = new System.Drawing.Size(203, 20);
            this.text_ecuacion1.TabIndex = 21;
            this.text_ecuacion1.Text = "INGRESE  ECUACION UNO";
            this.text_ecuacion1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel_grafica_texto
            // 
            this.panel_grafica_texto.Controls.Add(this.label_resultados_algebra);
            this.panel_grafica_texto.Controls.Add(this.panel_grafica_algebra);
            this.panel_grafica_texto.Controls.Add(this.text_grafica_algebra);
            this.panel_grafica_texto.Location = new System.Drawing.Point(189, 187);
            this.panel_grafica_texto.Name = "panel_grafica_texto";
            this.panel_grafica_texto.Size = new System.Drawing.Size(564, 266);
            this.panel_grafica_texto.TabIndex = 22;
            // 
            // label_resultados_algebra
            // 
            this.label_resultados_algebra.AutoSize = true;
            this.label_resultados_algebra.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultados_algebra.Location = new System.Drawing.Point(16, 13);
            this.label_resultados_algebra.Name = "label_resultados_algebra";
            this.label_resultados_algebra.Size = new System.Drawing.Size(124, 24);
            this.label_resultados_algebra.TabIndex = 15;
            this.label_resultados_algebra.Text = "RESULTADOS:";
            // 
            // panel_grafica_algebra
            // 
            this.panel_grafica_algebra.Controls.Add(this.panel1);
            this.panel_grafica_algebra.Controls.Add(this.imagen_grafica);
            this.panel_grafica_algebra.Location = new System.Drawing.Point(301, 23);
            this.panel_grafica_algebra.Name = "panel_grafica_algebra";
            this.panel_grafica_algebra.Size = new System.Drawing.Size(246, 214);
            this.panel_grafica_algebra.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(30, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 161);
            this.panel1.TabIndex = 8;
            // 
            // imagen_grafica
            // 
            this.imagen_grafica.BackgroundImage = global::interfaz.Properties.Resources.plano_cartesiano_1024x976;
            this.imagen_grafica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagen_grafica.Location = new System.Drawing.Point(14, 13);
            this.imagen_grafica.Name = "imagen_grafica";
            this.imagen_grafica.Size = new System.Drawing.Size(220, 187);
            this.imagen_grafica.TabIndex = 7;
            this.imagen_grafica.TabStop = false;
            // 
            // text_grafica_algebra
            // 
            this.text_grafica_algebra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_grafica_algebra.Location = new System.Drawing.Point(20, 48);
            this.text_grafica_algebra.Name = "text_grafica_algebra";
            this.text_grafica_algebra.Size = new System.Drawing.Size(236, 189);
            this.text_grafica_algebra.TabIndex = 6;
            this.text_grafica_algebra.Text = "";
            // 
            // text_ecuacion2
            // 
            this.text_ecuacion2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_ecuacion2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ecuacion2.Location = new System.Drawing.Point(545, 89);
            this.text_ecuacion2.Name = "text_ecuacion2";
            this.text_ecuacion2.Size = new System.Drawing.Size(203, 20);
            this.text_ecuacion2.TabIndex = 23;
            this.text_ecuacion2.Text = "INGRESE ECUACION DOS";
            // 
            // panel_central_algebra
            // 
            this.panel_central_algebra.Controls.Add(this.imagen_usuario);
            this.panel_central_algebra.Controls.Add(this.metodos_algebra_cmb);
            this.panel_central_algebra.Controls.Add(this.text_ecuacion2);
            this.panel_central_algebra.Controls.Add(this.panel_barra_desplazamineto_algebra);
            this.panel_central_algebra.Controls.Add(this.text_ecuacion1);
            this.panel_central_algebra.Controls.Add(this.panel_grafica_texto);
            this.panel_central_algebra.Controls.Add(this.panel3);
            this.panel_central_algebra.Controls.Add(this.new_button1);
            this.panel_central_algebra.Location = new System.Drawing.Point(-2, -1);
            this.panel_central_algebra.Name = "panel_central_algebra";
            this.panel_central_algebra.Size = new System.Drawing.Size(793, 511);
            this.panel_central_algebra.TabIndex = 23;
            this.panel_central_algebra.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_central_algebra_Paint);
            // 
            // imagen_usuario
            // 
            this.imagen_usuario.BackgroundImage = global::interfaz.Properties.Resources.usuario__1_;
            this.imagen_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagen_usuario.Location = new System.Drawing.Point(397, 35);
            this.imagen_usuario.Name = "imagen_usuario";
            this.imagen_usuario.Size = new System.Drawing.Size(30, 30);
            this.imagen_usuario.TabIndex = 24;
            this.imagen_usuario.TabStop = false;
            // 
            // panel_barra_desplazamineto_algebra
            // 
            this.panel_barra_desplazamineto_algebra.Controls.Add(this.image_inicio);
            this.panel_barra_desplazamineto_algebra.Controls.Add(this.image_salida);
            this.panel_barra_desplazamineto_algebra.Controls.Add(this.image_recarga);
            this.panel_barra_desplazamineto_algebra.Controls.Add(this.algebra_label_titulo);
            this.panel_barra_desplazamineto_algebra.Location = new System.Drawing.Point(0, 0);
            this.panel_barra_desplazamineto_algebra.Name = "panel_barra_desplazamineto_algebra";
            this.panel_barra_desplazamineto_algebra.Size = new System.Drawing.Size(162, 515);
            this.panel_barra_desplazamineto_algebra.TabIndex = 23;
            this.panel_barra_desplazamineto_algebra.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_barra_desplazamineto_mat_Paint);
            // 
            // image_inicio
            // 
            this.image_inicio.BackgroundImage = global::interfaz.Properties.Resources.hogar;
            this.image_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image_inicio.Location = new System.Drawing.Point(67, 155);
            this.image_inicio.Name = "image_inicio";
            this.image_inicio.Size = new System.Drawing.Size(30, 30);
            this.image_inicio.TabIndex = 7;
            this.image_inicio.TabStop = false;
            this.image_inicio.Click += new System.EventHandler(this.image_inicio_Click);
            // 
            // image_salida
            // 
            this.image_salida.BackgroundImage = global::interfaz.Properties.Resources.salida;
            this.image_salida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image_salida.Location = new System.Drawing.Point(67, 200);
            this.image_salida.Name = "image_salida";
            this.image_salida.Size = new System.Drawing.Size(30, 30);
            this.image_salida.TabIndex = 8;
            this.image_salida.TabStop = false;
            this.image_salida.Click += new System.EventHandler(this.image_salida_Click);
            // 
            // image_recarga
            // 
            this.image_recarga.BackgroundImage = global::interfaz.Properties.Resources.actualizar;
            this.image_recarga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image_recarga.Location = new System.Drawing.Point(67, 246);
            this.image_recarga.Name = "image_recarga";
            this.image_recarga.Size = new System.Drawing.Size(30, 30);
            this.image_recarga.TabIndex = 9;
            this.image_recarga.TabStop = false;
            // 
            // algebra_label_titulo
            // 
            this.algebra_label_titulo.AutoSize = true;
            this.algebra_label_titulo.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algebra_label_titulo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.algebra_label_titulo.Location = new System.Drawing.Point(39, 473);
            this.algebra_label_titulo.Name = "algebra_label_titulo";
            this.algebra_label_titulo.Size = new System.Drawing.Size(77, 24);
            this.algebra_label_titulo.TabIndex = 8;
            this.algebra_label_titulo.Text = "Algebra";
            this.algebra_label_titulo.Click += new System.EventHandler(this.mate_label_titulo_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel3.BackgroundImage = global::interfaz.Properties.Resources.lapiz__1_;
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Location = new System.Drawing.Point(425, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(34, 32);
            this.panel3.TabIndex = 20;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pictureBox6.BackgroundImage = global::interfaz.Properties.Resources.lapiz__3_;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(6, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 28);
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // new_button1
            // 
            this.new_button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.new_button1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.new_button1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.new_button1.BorderRadius = 0;
            this.new_button1.BorderSize = 0;
            this.new_button1.FlatAppearance.BorderSize = 0;
            this.new_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_button1.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_button1.ForeColor = System.Drawing.Color.White;
            this.new_button1.Location = new System.Drawing.Point(454, 125);
            this.new_button1.Name = "new_button1";
            this.new_button1.Size = new System.Drawing.Size(83, 32);
            this.new_button1.TabIndex = 19;
            this.new_button1.Text = "RESOLVER";
            this.new_button1.TextColor = System.Drawing.Color.White;
            this.new_button1.UseVisualStyleBackColor = false;
            this.new_button1.Click += new System.EventHandler(this.new_button1_Click);
            // 
            // Form_apartado_algebra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 505);
            this.Controls.Add(this.label_bienvenida_algebra);
            this.Controls.Add(this.panel_central_algebra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_apartado_algebra";
            this.Text = "Form_apartado_algebra";
            this.Load += new System.EventHandler(this.Form_apartado_algebra_Load);
            this.panel_grafica_texto.ResumeLayout(false);
            this.panel_grafica_texto.PerformLayout();
            this.panel_grafica_algebra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagen_grafica)).EndInit();
            this.panel_central_algebra.ResumeLayout(false);
            this.panel_central_algebra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_usuario)).EndInit();
            this.panel_barra_desplazamineto_algebra.ResumeLayout(false);
            this.panel_barra_desplazamineto_algebra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_inicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_salida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_recarga)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_bienvenida_algebra;
        private System.Windows.Forms.ComboBox metodos_algebra_cmb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private new_button new_button1;
        private System.Windows.Forms.TextBox text_ecuacion1;
        private System.Windows.Forms.Panel panel_grafica_texto;
        private System.Windows.Forms.RichTextBox text_grafica_algebra;
        private System.Windows.Forms.TextBox text_ecuacion2;
        private System.Windows.Forms.Panel panel_central_algebra;
        private System.Windows.Forms.Panel panel_barra_desplazamineto_algebra;
        private System.Windows.Forms.PictureBox image_inicio;
        private System.Windows.Forms.PictureBox image_salida;
        private System.Windows.Forms.PictureBox image_recarga;
        private System.Windows.Forms.Label algebra_label_titulo;
        private System.Windows.Forms.PictureBox imagen_usuario;
        private System.Windows.Forms.Panel panel_grafica_algebra;
        private System.Windows.Forms.PictureBox imagen_grafica;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_resultados_algebra;
    }
}