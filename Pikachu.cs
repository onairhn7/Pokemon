using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Pokemon
{
    internal class Pikachu: TipoElectricidad, I_Correr

    {
        public string Correr()
        {
            return "puedo correr";
        }

        public override string Evolucion()
        {
            return "Su evolucon es Raichu";
        }




        public override string ToString()
        {
            return $"Nombre: {Nombre}\nPuntos de Ataque: {PuntosAtaque}\nPuntos de Defensa: {PuntosDefensa}\nPorccentaje de Daño: {PorcentajeDanio()}\nAtaques: {string.Join(", ", Ataques)}\nEvolucion: {Evolucion()}\nDescarga: {Descarga()}\nCorrer: {Correr()}";
        }




    }
} 
