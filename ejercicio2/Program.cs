using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           // 1. Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.
                /*int num1, num2, resultado;

                Console.WriteLine(" Ingrese un número: ");
                num1 = int.Parse (Console.ReadLine());

                Console.WriteLine (" Ingrese otro número: ");
                num2 = int.Parse (Console.ReadLine());

                resultado = num1 + num2;
                Console.WriteLine( "El resultado es: " + resultado);*/

            //------------------------------------------------------------------------------------------
       


            //3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y 
            //la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado
            // que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

                float km, velocidad, tiempo;           

                Console.WriteLine ("Ingrese distancia en kms: ");
                km = float.Parse (Console.ReadLine());

                Console.WriteLine ("Ingrese la velocidad promedio: ");
                velocidad = float.Parse (Console.ReadLine());

                tiempo = km / velocidad;
                Console.WriteLine ("EL tiempo aprox es de: " + tiempo + "horas"); 


            
           
        }
    }
}
