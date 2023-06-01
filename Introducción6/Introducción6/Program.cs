using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducción6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imprimir los 10 primeros números

            int tabla = 5, resultado;

            //for(int indice = 0; i < 10; indice++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int indice = 9; i >= 0; indice--)
            //{
            //    Console.WriteLine(indice);
            //}

            ////Tabla de multilplicar del 5
            //Console.WriteLine("0 * 1 " + " = " + (0 * 5));
            //Console.WriteLine("1 * 5 " + " = " + (1 * 5));
            //Console.WriteLine("2 * 5 " + " = " + (2 * 5));
            //Console.WriteLine("3 * 5 " + " = " + (3 * 5));
            //Console.WriteLine("4 * 1 " + " = " + (4 * 5));
            //Console.WriteLine("5 * 1 " + " = " + (5 * 5));
            //Console.WriteLine("6 * 1 " + " = " + (6 * 5));
            //Console.WriteLine("7 * 1 " + " = " + (7 * 5));
            //Console.WriteLine("8 * 1 " + " = " + (8 * 5));
            //Console.WriteLine("9 * 1 " + " = " + (9 * 5));
            //Console.WriteLine("10 * 5 " + = " + (10 * 5));

            for (int indice = 0; indice < 10; indice++)
            {
                resultado = indice * tabla;
                Console.WriteLine(resultado);
                //Console.WriteLine(indice + " * 5" + " = " + (indice * 5));
            }



            Console.ReadLine();
        }
    }
}
