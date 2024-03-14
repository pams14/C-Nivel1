using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0: Declarar variables, pedir espacio en memoria
            // Tipo de dato: int, float, char, bool

            int n1, n2, resultado;

            //Paso 1: Pedir valores
            Console.WriteLine("ingrese número1: ");
            n1= int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese número2: ");
            n2 = int.Parse(Console.ReadLine());

            //Paso 2: Realizar calculo
            resultado = (n1 + n2) * 10;

            //Paso 3: Emitir Resultado
            Console.WriteLine("El resultado es: " + resultado);

        }
    }

}
