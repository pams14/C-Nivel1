using System;

namespace ejemploDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //DoWhile ejecuta aunque sea una vuelta

            int n, con = 0;

            do{
                Console.WriteLine("Ingrese un nro: ");
                n = int.Parse(Console.ReadLine());
                con++;
              }while (n != 0);
            
            Console.WriteLine("Ingresaste " + con + "nros. ");
        
        }
    }
}
