using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Pokemon
{
    internal class Charizard: TipoFuego, I_Volar
    {

        public string Volar()
        {

            return "Puedo volar";
        }

        public override string Evolucion()
        {
            return "Esta en su ultima evolucion";
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}\nPuntos de Ataque: {PuntosAtaque}\nPuntos de Defensa: {PuntosDefensa}\nPorccentaje de Daño: {PorcentajeDanio()}\nAtaques: {string.Join(", ", Ataques)}\nEvolucion: {Evolucion()}\nEnojarse: {enojarse()}\nCorrer: {Volar()}";
        }
    }
}
