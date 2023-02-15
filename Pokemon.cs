using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Pokemon
{
    internal class Pokemon
    {
        public string Nombre { get; set; }
        public int PuntosAtaque { get; set; }

        public int PuntosDefensa { get; set; }

        public List<string> Ataques { get; set; } = new List<string>();

        public double PorcentajeDanio (){

            

            return PuntosAtaque * 0.1;
        
        }


      
        public virtual string Evolucion ()
        {

            return "sobreescribir este metodo";
        }

      
        
        
    }
}
