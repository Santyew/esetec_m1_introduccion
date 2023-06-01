using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducción_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables e inicializacion
            int numero1, numero2, resultado, multiplicacion;

            numero1 = 10;
            numero2 = 20;

            //Logica
            resultado = numero1 + numero2;
            multiplicacion = numero1 * numero2;

            if (numero1 < numero2)
            {
                Console.WriteLine("numero1 es mayor que numero2");
            }

            else
            {
                Console.WriteLine("numero1 no es mayor que numero2");
            }

            //Visualización
            Console.WriteLine(numero1 + " + " + numero2 + " = " + resultado);
            Console.WriteLine(numero1 + " * " + numero2 + " = " + multiplicacion);
            Console.ReadLine();
        }
            /*
            Console.WriteLine("Hola mundo");

            Console.WriteLine("Presione ENTER para salir");
            Console.ReadLine();
        }*/
    }
}
