using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
          // AND y OR.. NOT
          //AND[y] Operador: &&
          //OR [o] Operador: ||
          // v OP v OR v OP v


            //----------------------------------------------------
            int edad = 30;
            char inicial = 'J';


            //Not
            if (!(inicial == 'H' || inicial == 'J') && edad > 20){
                Console.WriteLine("21 OFF....");
            }

            Console.WriteLine("Fin del programa!");

            //-----------------------------------------------------
            //Combinaciones:
            
             /* if (inicial == 'H' || inicial == 'J' && edad > 20){
                Console.WriteLine("21 OFF....");
             }

              if (inicial == 'J' || inicial == 'H' && edad > 20){
                 Console.WriteLine("21 OFF....");
             }

              if ((inicial == 'J' || inicial == 'H') && edad > 20){
                Console.WriteLine("21 OFF....");
              }*/

             //--------------------------------------------------------------------------

             // true && true

             /* if (edad > 20 && inicial == 'H'){
                Console.WriteLine("21 OFF...");
             }*/

                //AND Todas las expresiones concatenadas tiene que cumplirse
                //true && true = true
                //false && true = false
                //true && false = false
                //false && false = false


                //-------------------------------------------------------------
                // true || true
                /*if (edad > 20 || inicial == 'H'){
                 Console.WriteLine("21 OFF...");
                }*/

                //OR Con una expresion que se cumpla 
                //true && true = true
                //false && true = true
                //true && false = true
                //false && false = false

              
          



        }
    }
}
