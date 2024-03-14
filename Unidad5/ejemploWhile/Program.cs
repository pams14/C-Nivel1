using System;

namespace ejemploWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //CICLO WHILE -- CICLO INEXACTO. 
            //Solamente condición lógica. Mientras esa condición lógica se cumpla va a seguir iterando

            //Se toma como ejemplo: Ingresar nros que sean distintos de cero, cuando es cero se termina mi programa


                  int n, con = 0;          

            Console.WriteLine("Ingrese un nro: ");
            n= int.Parse(Console.ReadLine());
            while (n!= 0){      
            con++;          
            Console.WriteLine("Ingrese un nro: ");
            n= int.Parse(Console.ReadLine());


            }

             Console.WriteLine("Ingresaste: " + con + "nros.");


               //    while(con < 20){

        //      con++;
        //      Console.WriteLine(con);
        //     }   

        }
    }

}
