using System;

namespace ejerc1
{
    class Program
    {
        static void Main(string[] args)
        {
           /*1. Hacer una función llamada “producto” que reciba dos números enteros y
            que devuelva el producto de ambos.
            Luego hacer un programa que pida el precio de un artículo y la cantidad vendida
           y muestre por pantalla el monto total a pagar. Usar la función. */
            int n1, n2, prod;
            Console.WriteLine("Ingrese un nro: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro nro: ");
            n2 = int.Parse(Console.ReadLine());
           
           prod = producto (n1, n2);
           Console.WriteLine("El producto es : " + prod);

        }

            static int producto (int a, int b){
                int r = a * b;
                return r;


            }



    }
}
