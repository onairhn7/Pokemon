using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Pokemon
{
    internal class Cubone: TipoTierra, I_Correr
    {
        public string Correr ()
        {

            return "Este pokemon puede correr";
        }

        public override string Evolucion()
        {
            return" Su evolucion es Marowak";
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}\nPuntos de Ataque: {PuntosAtaque}\nPuntos de Defensa: {PuntosDefensa}\nPorccentaje de Daño: {PorcentajeDanio()}\nAtaques: {string.Join(", ", Ataques)}\nEvolucion: {Evolucion()}\nEvasion: {AumentarDureza()}\nCorrer: {Correr()}";
        }
    }
}
