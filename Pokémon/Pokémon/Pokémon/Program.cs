using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokémon
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            Estadisticas puntos = new Estadisticas();
            puntos.estadisticas.Add("Vida",20);
            puntos.estadisticas.Add("Ataque",50);

            Pokemon Charizard = new Pokemon("Charizard", puntos);

            foreach (var item in Charizard.nombre.ToString())
            {
                Console.WriteLine(item);
                foreach (var esta in Charizard.estadisticas.ToString())
                {
                    Console.WriteLine(esta);
                }
            }

        }
    }
}
