using System;

namespace ejerc2
{
    class Program
    {
        static void Main(string[] args)
        {
        /*2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
        Se pide determinar e informar:

        1-El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
        2-Informar cuántos grupos están formados por todos números ordenados de mayor a menor.*/

        int n, conNumeros, conImpares, grupoImparesMax = 0, min, conOrdenados = 0;
        double porcentajeImpares, porcentajeMaximo=-1;
        bool banderaOrdenados;


                for (int x = 0; x < 5; x++)
                {
                    conNumeros = 0;
                    conImpares = 0;
                    banderaOrdenados = true;

                    Console.WriteLine("Ingrese un nro: " );
                    n = int.Parse(Console.ReadLine());     
                    min = n;
                    while (n != 0)
                    {
                        //punto1
                        conNumeros++;
                        if(n % 2 != 0)
                         conImpares++;

                        //punto2
                        if (n <= min)
                         min = n;
                        else
                         banderaOrdenados = false;

                        n = int.Parse(Console.ReadLine());
                    }//fin while

                       //punto1 
                    
                    porcentajeImpares = conImpares * 100 / conNumeros;
                    if (porcentajeImpares > porcentajeMaximo){
                        porcentajeMaximo = porcentajeImpares;
                        grupoImparesMax = x + 1;
                       
                    }

                    //punto2
                   if(banderaOrdenados == true)     
                    conOrdenados++;             
                    

            }//fin For
                
             //1er punto   
            Console.WriteLine("El grupo con mayor porcentaje de impares es: " + grupoImparesMax); 
             //2do punto
            Console.WriteLine("La cantidad de grupo con nros ordenados es: " + conOrdenados);

        }
    }
}
