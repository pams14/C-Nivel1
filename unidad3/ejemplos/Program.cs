﻿using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
          //BLOQUE IF: Condicionales.
          // > < >= <= == !=  operadores logicos
          // valor OP(operacion) valor

          int edad = 35;

          if (edad > 20){
             if (edad > 30)
               Console.WriteLine("30 OFF");
             else 
            Console.WriteLine("21 OFF ");
            
     
          }else  
           Console.WriteLine("10 OFF ");
          

           Console.WriteLine("Fin del programa");



        }
    }
}
