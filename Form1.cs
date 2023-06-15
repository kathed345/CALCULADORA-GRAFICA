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
    public partial class primer_form : Form
    {
        public primer_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            color_class.colors("primer_set_color");
            panel_form1.BackColor = color_class.negro;
            panel_relleno_form1.BackColor = color_class.negro_palido;
            boton_mate.BackColor = color_class.amarillo;
            imagen_boton_mate.BackColor = color_class.amarillo;
            titulo_graficas.BackColor = color_class.amarillo;
            subtitulo_mate.BackColor = color_class.amarillo;
            boton_algebra.BackColor = color_class.celeste;
            imagen_boton_algebra.BackColor = color_class.celeste;
            titulo_despejes.BackColor = color_class.celeste;
            subtitulo_algebra.BackColor = color_class.celeste;
            boton_salida.BackColor = color_class.rojo;
            imagen_salida.BackColor = color_class.rojo;
            titulo_salida.BackColor = color_class.rojo;
            boton_consulta.BackColor = color_class.verde;
            imagen_info.BackColor = color_class.verde;
            titulo_consulta.BackColor = color_class.verde;
        }

        private void boton_salida_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imagen_boton_algebra_Click(object sender, EventArgs e)
        {

        }

        private void boton_mate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_apartado_math iniciar = new Form_apartado_math();
            iniciar.Show ();
        }

        private void boton_algebra_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_apartado_algebra abrir = new Form_apartado_algebra ();
            abrir.Show ();

        }

        private void boton_consulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_consulta inicio = new Form_consulta();
            inicio.Show();
        }
    }
}
