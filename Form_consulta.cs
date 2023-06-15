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
    public partial class Form_consulta : Form
    {
        public Form_consulta()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void image_inicio_consulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            primer_form inicio = new primer_form();
            inicio.Show();
        }

        private void Form_consulta_Load(object sender, EventArgs e)
        {
            color_class.colors("segundo_set_color");
            panel_central_consulta.BackColor = color_class.negro;
            label1_titulo.BackColor = color_class.negro;
            label2_signo.BackColor = color_class.negro;
            label1_titulo.BackColor = color_class.negro;
            label2_titulo.BackColor = color_class.negro;
            text_consulta.BackColor = color_class.negro;
            image_consulta.BackColor = color_class.negro;
            image_inicio_consulta.BackColor = color_class.negro;
            image_salida_consulta.BackColor = color_class.negro;

        }

        private void image_salida_consulta_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
