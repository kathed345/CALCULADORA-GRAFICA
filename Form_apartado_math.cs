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
    public partial class Form_apartado_math : Form
    {
        public Form_apartado_math()
        {
            InitializeComponent();
        }

        private void Form_apartado_math_Load(object sender, EventArgs e)
        {
            color_class.colors("segundo_set_color");
            panel_form_mate.BackColor = color_class.blanco;
            panel_grafica.BackColor = color_class.amarillo;
            text_grafica.BackColor = color_class.grispalido;
            panel_barra_desplazamineto_mat.BackColor = color_class.negro;
            mate_label_titulo.BackColor = color_class.negro;
            image_inicio.BackColor = color_class.negro;
            image_salida.BackColor = color_class.negro;
            image_recarga.BackColor = color_class.negro;
            text_ecuaciones.BackColor = color_class.grispalido;
            label_resultados.BackColor = color_class.blanco;
            text_resutados.BackColor = color_class.grispalido;




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void image_salida_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void image_inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            primer_form inicio = new primer_form ();
            inicio.Show();
        }

        private void panel_barra_desplazamineto_mat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_form_mate_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
