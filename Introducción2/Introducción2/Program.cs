using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducción2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int valorCuentaTotal;
            string numeroPersonas;
            float resultado;
            string valorCuenta;
            float valornumeroPersonas;
            float igic;

            Console.Write(" Escribe el número de personas: ");
            numeroPersonas = Console.ReadLine();

            Console.Write("Entra valor de la cuenta: ");
            valorCuenta = Console.ReadLine();

            valorCuentaTotal = Convert.ToInt32(valorCuenta);
            valornumeroPersonas = Convert.ToSingle(numeroPersonas) * 1.0f;
            
            resultado = valorCuentaTotal / valornumeroPersonas;
            Console.WriteLine("A pagar: " + resultado);

            //Calcular el I.G.I.C
            //regla de 3
            igic = 7 * valorCuenta / 100
            Console.WriteLine("Presione enter para salir");
            Console.ReadLine();



           /*
            Console.Write("Entra el primer número: ");
            valor1 = Console.ReadLine();

 

            Console.Write("Entra el segundo número: "); 
            valor2 = Console.ReadLine();

            valorEntero1 = Convert.ToInt32(valor1);
            valorEntero2 = Convert.ToInt32(valor2);
            
    

            resultado = valorEntero1 + valorEntero2;
            Console.WriteLine(valor1 + " + " + valor2 + " = " + resultado);

            resultado = valorEntero1 - valorEntero2;
            Console.WriteLine(valor1 + " - " + valor2 + " = " + resultado);

            resultado = valorEntero1 * valorEntero2;
            Console.WriteLine(valor1 + " * " + valor2 + " = " + resultado);
            
            resultado = valorEntero1 / valorEntero2;
            Console.WriteLine(valor1 + " / " + valor2 + " = " + resultado);
            
            
            Console.WriteLine("Presione Enter para salir");
            Console.ReadLine();
            /*

            resultado = Convert.ToInt32(valor1) + Convert.ToInt32 (valor2);
            Console.WriteLine(resultado);
            Console.WriteLine("Presione Enter para salir");
            Console.ReadLine();
            */
            /*
            string entradaUsuario;
            string nombre;

            Console.WriteLine("Escribe tu nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Escribe tu edad: ");
            entradaUsuario = Console.ReadLine();

            Console.WriteLine("Tu nombre es: " + nombre);

            Console.WriteLine("Tu edad es: " + entradaUsuario);

            Console.WriteLine("presione Enter para salir");
            Console.ReadLine();
            */
        }
    }
}
