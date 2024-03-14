using System;

namespace ejerc4
{
    class Program
    {
        static void Main(string[] args)
        {
          // 4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio 
          // si la suma de los dos primeros es mayor al producto del segundo con el tercero.

            int n1, n2, n3;

            Console.WriteLine("Ingrese un número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el último número: ");
            n3 = int.Parse(Console.ReadLine());

      
            if( n1 + n2 > n2 * n3)
               Console.WriteLine("La suma es mayor al producto de los valores 2 y 3");
            else
               Console.WriteLine("El producto es superior a la suma de los valores 1 y 2");

            ////// otra Forma-------------------------------------------------------------------------

            // int n1, n2, n3, suma, producto;
            //         suma = n1 + n2;
            // producto = n2 * n3;

            // if( suna > producto)
            //    Console.WriteLine("La suma es mayor que producto ....");
            
            
            // Console.WriteLine("Programa terminado....");
        }
    }
}
