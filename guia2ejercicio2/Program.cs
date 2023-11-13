using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia2ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombrearticulo;
            int cantidad;
            double precio;
            double resultado;

            Console.WriteLine("Ingrese el nombre del articulo: ");
            nombrearticulo = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese su precio: ");
            precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad que lleva el cliente: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            resultado = precio * cantidad;

            Console.WriteLine("El precio total a pagar del cliente es de: " + resultado + " dolares ");
            Console.ReadLine();

        }
    }
}
