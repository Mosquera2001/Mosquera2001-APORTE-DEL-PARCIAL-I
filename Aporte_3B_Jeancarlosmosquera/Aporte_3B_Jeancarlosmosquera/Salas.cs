using System;
using System.Collections.Generic;
using System.Text;

namespace Aporte_3B_Jeancarlosmosquera
{
    class Salas
    {
        public string sala;
        public void Disponibles()
        {
            //--------------------
            //Sirve para elegir que salas estan llenas
            // Salas llenas=1
            // Salas vacias=0
            int sala1 = 0;
            int sala2 = 1;
            int sala3 = 1;
            // ---------------
            if (sala1 == 0 || sala2 == 0 || sala3 == 0)
            {
                if (sala1 == 0 & sala2 == 1 & sala3 == 1)
                {
                    Asientos asiento = new Asientos();
                    asiento.AsientoSala1();
                    sala = "Sala 1";
                }
                if (sala2 == 0 & sala1 == 1 & sala3 == 1)
                {
                    Asientos asiento = new Asientos();
                    asiento.AsientoSala2();
                    sala = "Sala 2";
                }
                if (sala3 == 0 & sala2 == 1 & sala1 == 1)
                {
                    Asientos asiento = new Asientos();
                    asiento.AsientoSala3();
                    sala = "Sala 3";
                }
                if (sala2 == 0 & sala3 == 0)
                {
                    Asientos asiento = new Asientos();
                    asiento.AsientoSala2();
                    sala = "Sala 3";
                }
            }
        }
        public void SalaEscogida()
        {
            Console.WriteLine("Se encuentra en: " + sala);
        }

    }
    }

