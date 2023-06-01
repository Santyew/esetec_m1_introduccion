using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion4
{
    internal class Program
    {
        //Dado la edad de una persona decir si es mayor de edad
        static void Main(string[] args)
        {
            int edad, mayoría;

            edad = 20;
            mayoría = 18;

            if (edad >= mayoría)
            {
                Console.WriteLine("Eres mayor de 18 años");
            }
            else
            {
                Console.WriteLine("Eres menor de 18 años");
            }


            Console.WriteLine("Presione ENTER para continuar");
            Console.ReadLine();
        }
    }
}
