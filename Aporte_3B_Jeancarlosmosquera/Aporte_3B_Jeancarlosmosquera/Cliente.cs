using System;
using System.Collections.Generic;
using System.Text;

namespace Aporte_3B_Jeancarlosmosquera
{
    class Cliente : Persona
    {
        Persona persona = new Persona();

        internal Asientos Asientos
        {
            get => default;
            set
            {
            }
        }

        public void Nombre()
        {
            persona.Nombres = "Jean Carlos Mosquera";

            Console.WriteLine("Cliente: " + persona.Nombres);
        }
    }
}
