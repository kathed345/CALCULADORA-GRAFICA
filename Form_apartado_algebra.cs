using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaz
{
    public partial class Form_apartado_algebra : Form
    {
        public Form_apartado_algebra()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_apartado_algebra_Load(object sender, EventArgs e)
        {
            color_class.colors("segundo_set_color");
            panel_central_algebra.BackColor = color_class.blanco;
            label_bienvenida_algebra.BackColor = color_class.blanco;
            imagen_usuario.BackColor = color_class.blanco;
            panel_barra_desplazamineto_algebra.BackColor = color_class.negro;
            image_inicio.BackColor = color_class.negro;
            image_salida.BackColor = color_class.negro;
            image_recarga.BackColor = color_class.negro;
            algebra_label_titulo.BackColor = color_class.negro;
            text_grafica_algebra.BackColor = color_class.grispalido;
            panel_grafica_algebra.BackColor = color_class.verde;
            text_ecuacion1.BackColor = color_class.grispalido;
            text_ecuacion2.BackColor = color_class.grispalido;
            metodos_algebra_cmb.BackColor = color_class.grispalido;
            label_resultados_algebra.BackColor = color_class.blanco;

        }

        private void new_button1_Click(object sender, EventArgs e)
        {

        }

        private void panel_barra_desplazamineto_mat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mate_label_titulo_Click(object sender, EventArgs e)
        {

        }

        private void imagen_usuario_Click(object sender, EventArgs e)
        {

        }

        private void panel_central_algebra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void image_inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            primer_form inicio = new primer_form();
            inicio.Show();
        }

        private void image_salida_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
