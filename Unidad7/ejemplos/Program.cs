using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
           /*-------------------------------------------
            //Vectores o Array o Arreglo.
           
           Ejemplo 1:

            int n;
            int[] numeros = new int [10];

            //  0 1 2 3 4 5 6 7 8 9 :indices
            // |7| | | | | |1| | |656| 

            //Escribo valor
           for (int x = 0; x < 10; x++)
           {
            Console.WriteLine("Ingrese la nota..");
            n = int.Parse(Console.ReadLine());
            numeros[x] = n;


           }

            //Leo lo acumulado 
            int acu = 0;
            for (int x = 0; x < 10; x++)
            { 
                acu += numeros[x];
                Console.WriteLine("El valor es: " + numeros[x]);
                
            }
            
            int prom = acu / 10;

            ----------------------------------------------------------------------------
            Ejemplo 2:
            
            //int, float, bool,char

            bool[] asistenciaQuincena1 = new bool [15];
            for (int x = 0; x < 15; x++)

            {
                //dia
                //asistencia
            }

                ----------------------------------------
            int[] legajos = new int[100];
            bool[] asistencia = new bool[100];

            for (int x = 0; x < 16; x++)
            {
                for (int y = 0; y < 100; y++)
                {
                    
                }

            }

            -----------------------------------------------------------------------------------------
            */ 

            //Ejemplo 3: SEGUIR DESARROLLANDO.. Registrar temperaturas del mes. 
             
            double[]muestraMatutina = new double [31];
            double[]muestraVespertina = new double [31];
            double[]muestranocturna = new double [31];

            int dia;
            double temperatura;

            Console.WriteLine("Cargue el registro matutino: ");
            for (int x = 0; x < 31; x++)
            {
                Console.WriteLine("Ingrese el día: ");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese temperatura registrada: ");
                temperatura = double.Parse(Console.ReadLine());

                muestraMatutina[dia - 1] = temperatura;

            }

           /* Console.WriteLine("Cargue el registro vespertino: ");
            for (int x = 0; x < 31; x++)
            {
                
            }

            Console.WriteLine("Cargue el registro Nocturno: ");
            for (int x = 0; x < 31; x++)
            {
                
            }*/

            //Leer vectores
            double acu = 0;
            for (int x = 0; x < 31; x++)
            {
                acu += muestraMatutina[x];
            }


        }
    }
}
