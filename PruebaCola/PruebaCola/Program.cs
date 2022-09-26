using System;
using System.Collections.Generic;

namespace PruebaCola
{
    internal class Program
    {
        static void Main(string[] _1)

        {
            #region Cola

            //string cadena;

            //Queue<string> colaStr = new Queue<string>();

            //Console.WriteLine("Ingrese una cadena en la cola");
            //cadena = Console.ReadLine();

            //while (cadena != "")
            //{
            //    colaStr.Enqueue(cadena);
            //    Console.WriteLine("Ingrese próxima cadena en la cola");
            //    cadena = Console.ReadLine();
            //}

            //while (colaStr.Count > 0)
            //{
            //    Console.WriteLine((string)colaStr.Dequeue());
            //}

            //Console.ReadKey();

            #endregion  

            #region Pila

            //string cadena;

            //Stack<string> pila = new Stack<string>();

            //Console.WriteLine("ingrese una cadena en la pila");
            //cadena = Console.ReadLine();

            //while (cadena != "")
            //{
            //    pila.Push(cadena);
            //    Console.WriteLine("ingrese próxima cadena en la pila");
            //    cadena = Console.ReadLine();
            //}

            //while (pila.Count > 0)
            //{
            //    Console.WriteLine((string)pila.Pop());
            //}

            //Console.ReadKey();

            #endregion  

            #region ArrayList

            string sumarALista;

            List<string> lista = new List<string>();

            Console.WriteLine("\n Ingrese un texto a almacenar en la lista\n");
            sumarALista = Console.ReadLine();
            lista.Add("");


            while (sumarALista != "")
            {
                lista.Add(sumarALista);
                Console.WriteLine("\n---------------------------------------\n\nIngrese otro texto a almacenar en la lista, o presione ENTER para terminar\n");
                sumarALista = Console.ReadLine();

            }
            Console.Clear();
            for (int i = 1; ; i++)
            {
                int posicion;
                Console.WriteLine("\nIndique la posición que quiere leer\n");
                posicion = int.Parse(Console.ReadLine());

                if (posicion != 0)
                {
                    if (posicion < lista.Count)
                    {
                        string frase = lista[posicion];
                        Console.WriteLine("\n");
                        Console.WriteLine(frase);
                    }
                    else
                    {
                        Console.WriteLine("\n\nNo es una opción válida");
                    }
                    
                }
                else
                {
                    Console.WriteLine("\n\nPULSE UNA TECLA PARA TERMINAR DE EJECUTAR");
                    break; 
                }
            }
            Console.ReadKey();
            #endregion

        }
    }
}
