using System;

namespace ejerc5
{
    class Program
    {
        static void Main(string[] args)
        {
         //5. Hacer un programa para ingresar 4 números. 
         //Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .

         int n1, n2, n3, n4;
         
         Console.WriteLine("Ingrese 1er nro: ");
         n1 = int.Parse(Console.ReadLine());
         Console.WriteLine("Ingrese 2do nro: ");
         n2 = int.Parse(Console.ReadLine());
         Console.WriteLine("Ingrese 3er nro: ");
         n3 = int.Parse(Console.ReadLine());
         Console.WriteLine("Ingrese 4to nro: ");
         n4 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n2 > n3 && n3 > n4)
                Console.WriteLine("Se encuentran ordenanados de manera decreciente..");
            else
            
              Console.WriteLine("NO estan ordenados de manera decreciente..");
            

        

        }
    }
}
