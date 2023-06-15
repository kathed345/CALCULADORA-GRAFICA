using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace interfaz
{
    class color_class
    {
        public static Color negro;
        public static Color negro_palido;
        public static Color amarillo;
        public static Color celeste;
        public static Color rojo;
        public static Color verde;
        public static Color aqua;
        public static Color grism;
        public static Color grispalido;
        public static Color blanco;
        public static Color palidez;
        public static readonly Color negro_dar = Color.FromArgb(13, 13, 13);
        public static readonly Color negro_palido_dar = Color.FromArgb(16, 16, 16);
        public static readonly Color amarillo_dar = Color.FromArgb(242, 190, 34);
        public static readonly Color celeste_dar = Color.FromArgb(51, 60, 131);
        public static readonly Color rojo_dar = Color.FromArgb(242, 74, 114);
        public static readonly Color verde_dar = Color.FromArgb(242, 151, 39);
        public static readonly Color aqua_dar = Color.FromArgb(34, 166, 153);
        public static readonly Color grism_dar = Color.FromArgb(157, 178, 191);
        public static readonly Color grispalido_dar = Color.FromArgb(221, 230, 237);
        public static readonly Color blanco_dar = Color.FromArgb(246, 251, 244); 
        public static readonly Color palidez_dar = Color.FromArgb(210, 233, 233);


        public static void colors (string colores)
        {
            if (colores == "primer_set_color")
            {
                negro = negro_dar;
                negro_palido = negro_palido_dar;
                amarillo = amarillo_dar;
                celeste = celeste_dar;
                rojo = rojo_dar;
                verde = verde_dar;
            }

            if (colores == "segundo_set_color")
            {
                negro = negro_dar;
                negro_palido = negro_palido_dar;
                aqua = aqua_dar;
                grism = grism_dar;
                grispalido = grispalido_dar;
                blanco = blanco_dar;
                palidez = palidez_dar;

            }

            }

    }
}
