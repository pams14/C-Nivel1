﻿using System;

namespace ejerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

            // Si vende menos de 100 litros, no hay descuento.
            // Si vende entre 101 y 300 litros, el descuento es del 10%.
            // Si vende entre 301 y 500 litros, el descuento es del 15%.
            // Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            // Hacer un programa que solicite el ingreso del importe total de la venta y
            // la cantidad de litros vendidos y calcule y emita el importe con el descuento aplicado..

            float importeTotal, litros;

            Console.WriteLine("Ingrese el importe de la venta: ");
            importeTotal = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de litros vendidos: ");
            litros = float.Parse(Console.ReadLine());


            if (litros > 500)
              importeTotal = importeTotal * 0.75F;
            else if( litros > 101 && litros < 300)        
               importeTotal = importeTotal * 0.9F;              
            else  if( litros > 301 && litros < 500)                
               importeTotal = importeTotal * 0.85F;              
            else
                Console.WriteLine("No hay descuento..");                  
                   
           
              
             Console.WriteLine("El importe a pagar es: " + importeTotal);








        }
    }
}
