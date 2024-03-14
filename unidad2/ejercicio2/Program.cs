using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.
            //Pasos:
            

                int num, resultado2;
                //PEDIR NRO
                Console.WriteLine( "Ingrese un número: ");
                num = int.Parse (Console.ReadLine());

                //ELEVAR AL CUBO
                resultado2 = num * num * num;

                //MOSTRAR RESULTADO
                Console.WriteLine("El resultado al cubo es: " + resultado2);      
                
        }
    }
}
