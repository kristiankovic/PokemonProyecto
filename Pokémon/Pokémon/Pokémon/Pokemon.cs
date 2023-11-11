using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokémon
{
    internal class Pokemon
    {
        public string nombre;
        //public Tipos tipo;
        public Estadisticas estadisticas;
        //public Map ataques;
        //public Debilidades debilidades;

        public Pokemon(string nombre,  Estadisticas estadisticas)
        {
            this.nombre = nombre;
            //this.tipo = tipo;
            this.estadisticas = estadisticas;
            //this.ataques = ataques;
            //this.debilidades = debilidades;
        }
        public void atacar()
        {

        }

    }
}
