using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Pokemon
{
    internal class Squirtle : TipoAgua, I_Nadar
    {

        public string Nadar()
        {
            return "Este pokemon puede nadar";
        }

        public override string Evolucion()
        {
            return "Su siguinete evolucion es Wartortle";
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}\nPuntos de Ataque: {PuntosAtaque}\nPuntos de Defensa: {PuntosDefensa}\nPorccentaje de Daño: {PorcentajeDanio()}\nAtaques: {string.Join(", ", Ataques)}\nEvolucion: {Evolucion()}\nEvasion: {Evasion()}\nCorrer: {Nadar()}";
        }

    }
}
