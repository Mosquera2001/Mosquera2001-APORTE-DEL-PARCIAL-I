using System;
using System.Collections.Generic;
using System.Text;

namespace Aporte_3B_Jeancarlosmosquera
{
    class Aperitivos
    {
        public static string respuesta;
        public static string respuesta2;

        internal Salas Salas
        {
            get => default;
            set
            {
            }
        }

        public void EleccionAperitivo()
        {
            List<string> listacomida = new List<string>();
            Console.WriteLine("----------Lista de aperitivos---------");
            listacomida.Add("1.Canquil");
            listacomida.Add("2.Hot-Dog");
            listacomida.Add("3.Nachos");
            foreach (string i in listacomida)
            {
                Console.WriteLine(i);
            }
            int aperitivo;
            Console.Write("De acuerdo a los numero de aperitivos ingrese lo deseado: ");
            do
            {
                aperitivo = Convert.ToInt32(Console.ReadLine());
                if (aperitivo < 1 || aperitivo > 3)
                {
                    Console.Write("Ingrese un numero de aperitivo valido: ");
                }
                if (aperitivo <= 3)
                {
                    if (aperitivo == 1)
                    {
                        respuesta = "Canguil";
                    }
                    if (aperitivo == 2)
                    {
                        respuesta = "Hot-Dog";
                    }
                    if (aperitivo == 3)
                    {
                        respuesta = "Nachos";
                    }
                }
            } while (aperitivo <= 0 || aperitivo > 3);

        }
        public void EleccionBebida()
        {
            List<string> bebida = new List<string>();
            Console.WriteLine("----------Lista de bebidas---------");
            bebida.Add("1.Coca Cola");
            bebida.Add("2.Pepsi");
            bebida.Add("3.Inca Kola");
            foreach (string i in bebida)
            {
                Console.WriteLine(i);
            }
            int aperitivo;
            Console.Write("De acuerdo a los numero de Bebidas ingrese lo deseado: ");
            do
            {
                aperitivo = Convert.ToInt32(Console.ReadLine());
                if (aperitivo < 1 || aperitivo > 3)
                {
                    Console.Write("Ingrese un numero de Bebida valido: ");
                }
                if (aperitivo <= 3)
                {
                    if (aperitivo == 1)
                    {
                        respuesta2 = "Coca Cola";
                    }
                    if (aperitivo == 2)
                    {
                        respuesta2 = "Pepsi";
                    }
                    if (aperitivo == 3)
                    {
                        respuesta2 = "Inca Kola";
                    }
                }
            } while (aperitivo <= 0 || aperitivo > 3);
        }
        public void MostrarAperitivos()
        {
            Console.WriteLine("Aperitivos escogidos: " + respuesta + " y " + respuesta2);
        }
    }
}