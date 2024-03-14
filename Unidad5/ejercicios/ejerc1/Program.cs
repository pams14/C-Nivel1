using System;

namespace ejerc1
{
    class Program
    {
        static void Main(string[] args)
        {
           //1. Hacer un programa para mostrar los números del 1 al 10. 
           //No se debe realizar ningún pedido de datos.
           
            int con = 1;
            for(int x = 0; x < 10; x++){
                Console.WriteLine(con);
                con++;
            } 
            
            //Otra Forma
            /*for(int x = 0; x < 10; x++){
              Console.WriteLine(x+1);
            }*/

             //Otra Forma
           /*for(int x = 1; x < 10; x++){
               Console.WriteLine(x);
            }*/


        }
    }
}
