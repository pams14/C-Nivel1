using System;

namespace acu_con
{
    class Program
    {
        static void Main(string[] args)
        {
            //Acumuladores y Contadores:
            
            // int contador = 0; Variables, el valor inicial casi siempre es 0 porq de ahí va agregando 1 (+1)
            //++ : operador de incremento - suma 1 al valor que tenga la variable
            //-- operador de disminucion
            //+=
            //-=

            int contador = 0, e1 = 10, e2 = 17, e3 = 28;
            int acumulador = 0, promedio; //acumulador , lo que le doy le suma a lo que tenga la variable

            if (e1 > 18)
                {contador++;
                acumulador += e1;
                }

            if (e2 > 18)
                {contador = contador + 1;
                acumulador = acumulador + e2;
                }
            
            if (e3 > 18)
                {contador = contador + 1;
                acumulador += e3;
                }
            promedio = acumulador / contador;
    
            Console.WriteLine ("El promedio es: " + promedio);


        }
    }
}
