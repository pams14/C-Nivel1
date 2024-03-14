using System;

namespace ejerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2. Hacer una función llamada “par” que reciba un número entero
             y devuelva 1 (puede ser verdadero) si es par o cero( o falso) si no lo es.
              Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.*/
            int n, con = 0;
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un Nro :");
                n = int.Parse(Console.ReadLine());
                if(par(n))
                  con++;

            }
            Console.WriteLine("La cantidad de Nros pares es: " + con);

        }
            /*static int par(int a){
                    if(a % 2 == 0)
                        return 1;
                    else                    
                        return 0;
                    }*/
          static bool par(int a){
                    if(a % 2 == 0)
                        return true;
                    else                    
                        return false;
                    }

    }
}
