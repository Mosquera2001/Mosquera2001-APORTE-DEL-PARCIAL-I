using System;
using System.Collections.Generic;
using System.Text;

namespace Aporte_3B_Jeancarlosmosquera
{
    class Asientos
    {
        public static int escoger;

        internal Salas Salas
        {
            get => default;
            set
            {
            }
        }

        public void AsientoSala1()
        {
            Console.WriteLine("---------SALA 1-----------");
            int[] vacios = new int[7] { 1, 2, 3, 9, 8, 21, 13 };
            Console.Write("Asientos disponibles en Sala 1:");
            int[] llenos = new int[7] { 6, 4, 23, 7, 10, 22, 14 };
            foreach (int i in vacios)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            Console.Write("Asientos ocupados en Sala 1:");
            foreach (int i in llenos)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            // escoger el asiento
            Console.Write("Ingrese el numero de asiento: ");
            escoger = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 7; i++)
            {
                if (escoger == vacios[i] | escoger == llenos[i])
                {
                    if (escoger == vacios[i])
                    {
                    }
                    if (escoger == llenos[i])
                    {
                    }
                }
            }

        }
        public void AsientoSala2()
        {
            Console.WriteLine("---------SALA 2-----------");
            int[] vacios = new int[7] { 10, 2, 3, 9, 10, 21, 17 };
            Console.Write("Asientos disponibles en Sala 2:");
            int[] llenos = new int[7] { 4, 7, 24, 7, 11, 22, 14 };
            foreach (int i in vacios)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            Console.Write("Asientos ocupados en Sala 2:");
            foreach (int i in llenos)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            // escoger el asiento
            Console.Write("Ingrese el numero de asiento: ");
            escoger = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 7; i++)
            {
                if (escoger == vacios[i] | escoger == llenos[i])
                {
                    if (escoger == vacios[i])
                    {
                    }
                    if (escoger == llenos[i])
                    {
                    }
                }
            }
        }
        public void AsientoSala3()
        {
            Console.WriteLine("---------SALA 3-----------");
            int[] vacios = new int[7] { 1, 2, 4, 9, 7, 11, 34 };
            Console.Write("Asientos disponibles en Sala 3:");
            int[] llenos = new int[7] { 6, 5, 23, 7, 10, 22, 14 };
            foreach (int i in vacios)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            Console.Write("Asientos ocupados en Sala 3:");
            foreach (int i in llenos)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            // escoger el asiento
            Console.WriteLine("Ingrese el numero de asiento");
            escoger = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 7; i++)
            {
                if (escoger == vacios[i] | escoger == llenos[i])
                {
                    if (escoger == vacios[i])
                    {
                    }
                    if (escoger == llenos[i])
                    {
                    }
                }
            }
        }
        public void Eleccion()
        {
            int eleccion = escoger;
            Console.WriteLine("Asiento escogido: " + eleccion);
        }
    }
}

