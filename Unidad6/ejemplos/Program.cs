using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
           // Ciclos combinados:

           //1-For con for: Calcular el promedio de edades de 10 equipos(cargar las edades de 20 personas
           //de 10 equipos distintos)
            /*
            int n, acu, prom;

            for (int y = 0; y < 10: y++)  
            {
              acu = 0;
              for (int x = 0; x < 10: x++)
                {
                    Console.WriteLine("Ingrese la edad: ");
                    n  = int.Parse(Console.ReadLine());
                    acu += n;
                }
                prom = acu / 20;
                Console.WriteLine("El promedio es de: " + prom);
            }
          */
          //----------------------------------------------------------------

         /* //2-For con While
          int n, acu, prom, con;

          for( int x = 0; x < 10; x++){
            Console.WriteLine("Ingrese la edad: ");
            n = int.Parse(Console.ReadLine());
            acu = 0;
            con = 0;
            while(n != 0){

                acu += n;
                con++;
                Console.WriteLine("Ingrese la edad: ");
                n = int.Parse(Console.ReadLine());
            }

            prom = acu / con;
            Console.WriteLine("El promedio es de: " + prom);
            }*/
          
          //----------------------------------------------------------

          /* //3- While con For

           int n, acu, prom;

           Console.WriteLine("Ingrese 1 para comenzar o 0 para terminar.");
           n = int.Parse(Console.ReadLine());
           while(n != 0){
            acu = 0;
            for( int x = 0; x < 5; x++)
            {
                Console.WriteLine("ingrese la edad: ");
                n = int.Parse(Console.ReadLine());
                acu += n;
            }
            prom = acu / 5;
            Console.WriteLine("El promedio es de: " + prom);

            Console.WriteLine("Ingrese 1 para comenzar o 0 para terminar.");
            n = int.Parse(Console.ReadLine());

           }

            */

         //--------------------------------------------------------------------------------   

         //4- While con While - combinacion comun en corte de control
            int n, acu, prom, con;

           
            Console.WriteLine("Ingrese la edad: ");
            n = int.Parse(Console.ReadLine());
            while( n > 0){

            acu = 0;
            con = 0;
            while(n != 0){
                acu += n;
                con++;
                Console.WriteLine("Ingrese la edad: ");
                n = int.Parse(Console.ReadLine());
            }

            prom = acu / con;
            Console.WriteLine("El promedio es de: " + prom);

            Console.WriteLine("Ingrese la edad para continuar o un negativo para terminar.");
            n = int.Parse(Console.ReadLine());


            }
            
        }
    }
}
