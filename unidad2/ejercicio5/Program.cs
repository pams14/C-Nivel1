﻿using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
           //5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno
           // y luego calcule y emita por pantalla el promedio final.

            int n1, n2, n3, promedio;

            Console.WriteLine("Ingrese la primera nota:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota:");
            n3 = int.Parse(Console.ReadLine());


            promedio = (n1 + n2 + n3) / 3;
            Console.WriteLine("El promedio de notas es: " + promedio);




        }
    }
}
