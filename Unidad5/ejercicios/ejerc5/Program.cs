﻿using System;

namespace ejerc5
{
    class Program
    {
        static void Main(string[] args)
        {
           //5. Hacer un programa que solicite 20 números y luego emitir por pantalla
           //el máximo de los números pares y el mínimo de los números impares.

            int n, max = 0, min = 0;
            int conPar = 0, conImpar = 0;

            for (int x = 0; x < 20; x++)
               {
                Console.WriteLine("Ingrese un nro: ");
                n = int.Parse(Console.ReadLine());
                if(n % 2 == 0){
                   conPar++;
                //trabajo con los pares
                    if(conPar == 1)
                        max = n;
                    else if(n > max)
                        max = n;
                }else{
                    conImpar++;
                //trabajo con impares
                    if(conImpar == 1)
                        min = n;
                    else if (n < min)
                        min = n;
                }
                
            }

            Console.WriteLine("El máximo par es: " + max);
            Console.WriteLine("El mínimo impar es: " + min);

        }
    }
}
