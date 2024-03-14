using System;

namespace ejerc5
{
    class Program
    {
        static void Main(string[] args)
        {
           //Hacer un programa para ingresar cuatro números y luego
           // mostrar por pantalla cuáles son mayores a 100

            int a, b, c, d, con = 0;
     

            Console.WriteLine("Ingrese valor a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valor b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valor c: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese uvalor d: ");
            d = int.Parse(Console.ReadLine());         
            Console.WriteLine();

            // if  (a > 100)
            //   Console.WriteLine("El valor de a: " + a + " es mayor a 100.");   
              
            // if (b > 100)
            //   Console.WriteLine("El valor de b: " + b + " es mayor a 100.");        
            
            // if (c > 100)
            //   Console.WriteLine("El valor de c: " + c + " es mayor a 100.");
            
            // if (d > 100) 
            //   Console.WriteLine("El valor de d: " + d + " es mayor a 100.");
             
             //-----------OTRA FORMA------------

             if ( a > 100){
                Console.WriteLine(a);
                con++;
             }
            

            if ( b > 100){
                Console.WriteLine(b);
                con++;
             }

             if ( c > 100){
                Console.WriteLine(c);
                con++;
             }

             if ( d > 100){
                Console.WriteLine(d);
                con++;
             }

            if (con != 0)
                Console.WriteLine("Son mayores a 100...." );
                Console.WriteLine("Fin del programa!");


        }
    }
}
