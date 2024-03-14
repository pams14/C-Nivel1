using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
                //CICLO FOR-- CICLO EXACTO


            int n = 0, promedio, suma = 0;

           for (int x = 0; x < 5; x++)

            {
                Console.WriteLine("Ingrese  la nota: ");
                n = int.Parse(Console.ReadLine());
                suma += n; // suma = suma + n
            }
            
            promedio = suma / 5;
            Console.WriteLine("El promedio de notas es: " + promedio );



            // //aca codigo
            // //Ciclo For
           
            // for (int x = 0; x < 5; x++){
                
            // Console.WriteLine("Hola Mundo!" + x );
            //         //aca codigo
            // }
            // //mas codigo

        //     int n = 0;

        //    for (int x = 0; x < 5; x++)

        //     {
        //         Console.WriteLine("Ingrese un nro: ");
        //           n = int.Parse(Console.ReadLine());
        //     }
            
        //     Console.WriteLine("El valor de N es: " + n );

           




        }
    }
}
