
namespace interfaz
{
    partial class Form_consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_consulta));
            this.text_consulta = new System.Windows.Forms.RichTextBox();
            this.panel_central_consulta = new System.Windows.Forms.Panel();
            this.image_salida_consulta = new System.Windows.Forms.PictureBox();
            this.image_inicio_consulta = new System.Windows.Forms.PictureBox();
            this.label2_signo = new System.Windows.Forms.Label();
            this.image_consulta = new System.Windows.Forms.PictureBox();
            this.label2_titulo = new System.Windows.Forms.Label();
            this.label1_titulo = new System.Windows.Forms.Label();
            this.label_signo = new System.Windows.Forms.Label();
            this.panel_central_consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_salida_consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_inicio_consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // text_consulta
            // 
            this.text_consulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_consulta.Font = new System.Drawing.Font("Source Sans Pro", 11.95F);
            this.text_consulta.ForeColor = System.Drawing.SystemColors.Info;
            this.text_consulta.Location = new System.Drawing.Point(58, 269);
            this.text_consulta.Name = "text_consulta";
            this.text_consulta.Size = new System.Drawing.Size(271, 232);
            this.text_consulta.TabIndex = 0;
            this.text_consulta.Text = resources.GetString("text_consulta.Text");
            this.text_consulta.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel_central_consulta
            // 
            this.panel_central_consulta.Controls.Add(this.image_salida_consulta);
            this.panel_central_consulta.Controls.Add(this.image_inicio_consulta);
            this.panel_central_consulta.Controls.Add(this.text_consulta);
            this.panel_central_consulta.Controls.Add(this.label2_signo);
            this.panel_central_consulta.Controls.Add(this.image_consulta);
            this.panel_central_consulta.Controls.Add(this.label2_titulo);
            this.panel_central_consulta.Controls.Add(this.label1_titulo);
            this.panel_central_consulta.Controls.Add(this.label_signo);
            this.panel_central_consulta.Location = new System.Drawing.Point(-2, 0);
            this.panel_central_consulta.Name = "panel_central_consulta";
            this.panel_central_consulta.Size = new System.Drawing.Size(386, 525);
            this.panel_central_consulta.TabIndex = 11;
            // 
            // image_salida_consulta
            // 
            this.image_salida_consulta.BackgroundImage = global::interfaz.Properties.Resources.salida;
            this.image_salida_consulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image_salida_consulta.Location = new System.Drawing.Point(347, 40);
            this.image_salida_consulta.Name = "image_salida_consulta";
            this.image_salida_consulta.Size = new System.Drawing.Size(20, 20);
            this.image_salida_consulta.TabIndex = 10;
            this.image_salida_consulta.TabStop = false;
            this.image_salida_consulta.Click += new System.EventHandler(this.image_salida_consulta_Click);
            // 
            // image_inicio_consulta
            // 
            this.image_inicio_consulta.BackgroundImage = global::interfaz.Properties.Resources.hogar;
            this.image_inicio_consulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image_inicio_consulta.Location = new System.Drawing.Point(347, 12);
            this.image_inicio_consulta.Name = "image_inicio_consulta";
            this.image_inicio_consulta.Size = new System.Drawing.Size(20, 20);
            this.image_inicio_consulta.TabIndex = 9;
            this.image_inicio_consulta.TabStop = false;
            this.image_inicio_consulta.Click += new System.EventHandler(this.image_inicio_consulta_Click);
            // 
            // label2_signo
            // 
            this.label2_signo.AutoSize = true;
            this.label2_signo.Font = new System.Drawing.Font("Violet Smile", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_signo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2_signo.Location = new System.Drawing.Point(277, 48);
            this.label2_signo.Name = "label2_signo";
            this.label2_signo.Size = new System.Drawing.Size(106, 138);
            this.label2_signo.TabIndex = 15;
            this.label2_signo.Text = "?";
            // 
            // image_consulta
            // 
            this.image_consulta.BackgroundImage = global::interfaz.Properties.Resources.algebra;
            this.image_consulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image_consulta.Location = new System.Drawing.Point(129, 136);
            this.image_consulta.Name = "image_consulta";
            this.image_consulta.Size = new System.Drawing.Size(123, 107);
            this.image_consulta.TabIndex = 11;
            this.image_consulta.TabStop = false;
            // 
            // label2_titulo
            // 
            this.label2_titulo.AutoSize = true;
            this.label2_titulo.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2_titulo.Location = new System.Drawing.Point(100, 73);
            this.label2_titulo.Name = "label2_titulo";
            this.label2_titulo.Size = new System.Drawing.Size(199, 40);
            this.label2_titulo.TabIndex = 14;
            this.label2_titulo.Text = "la aplicación ";
            // 
            // label1_titulo
            // 
            this.label1_titulo.AutoSize = true;
            this.label1_titulo.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1_titulo.Location = new System.Drawing.Point(86, 33);
            this.label1_titulo.Name = "label1_titulo";
            this.label1_titulo.Size = new System.Drawing.Size(213, 40);
            this.label1_titulo.TabIndex = 13;
            this.label1_titulo.Text = "De que trata ";
            // 
            // label_signo
            // 
            this.label_signo.AutoSize = true;
            this.label_signo.Font = new System.Drawing.Font("Violet Smile", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_signo.Location = new System.Drawing.Point(14, -24);
            this.label_signo.Name = "label_signo";
            this.label_signo.Size = new System.Drawing.Size(106, 138);
            this.label_signo.TabIndex = 12;
            this.label_signo.Text = "¿";
            // 
            // Form_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 513);
            this.Controls.Add(this.panel_central_consulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_consulta";
            this.Text = "Form_consulta";
            this.Load += new System.EventHandler(this.Form_consulta_Load);
            this.panel_central_consulta.ResumeLayout(false);
            this.panel_central_consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_salida_consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_inicio_consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_consulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox text_consulta;
        private System.Windows.Forms.PictureBox image_inicio_consulta;
        private System.Windows.Forms.PictureBox image_salida_consulta;
        private System.Windows.Forms.Panel panel_central_consulta;
        private System.Windows.Forms.PictureBox image_consulta;
        private System.Windows.Forms.Label label2_titulo;
        private System.Windows.Forms.Label label1_titulo;
        private System.Windows.Forms.Label label_signo;
        private System.Windows.Forms.Label label2_signo;
    }
}