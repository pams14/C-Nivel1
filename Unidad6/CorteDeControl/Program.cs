using System;

namespace CorteDeControl
{
    class Program
    {
        static void Main(string[] args)
        {
           //Corte de Control--
           //Es para lotes de datos agrupados
           //legajo, edad, sueldo, codigo de equipo

           int legajo, edad, codigoEquipo;
           float sueldo;
           int equipoActual;

           Console.WriteLine("Ingrese el legajo: ");
           legajo = int.Parse(Console.ReadLine());
           Console.WriteLine("Ingrese la edad: ");
           edad = int.Parse(Console.ReadLine());
           Console.WriteLine("Ingrese el sueldo: ");
           sueldo = float.Parse(Console.ReadLine());
           Console.WriteLine("Ingrese el código de equipo: ");
           codigoEquipo = int.Parse(Console.ReadLine());

            while (sueldo > 0)
            {
                equipoActual = codigoEquipo; //Asignacion con corete de control
                while (codigoEquipo == equipoActual)
                {
                 //Acá procesamos....

                 Console.WriteLine("Ingrese el legajo: ");
                 legajo = int.Parse(Console.ReadLine());
                 Console.WriteLine("Ingrese la edad: ");
                 edad = int.Parse(Console.ReadLine());
                 Console.WriteLine("Ingrese el sueldo: ");
                 sueldo = float.Parse(Console.ReadLine());
                 Console.WriteLine("Ingrese el código de equipo: ");
                 codigoEquipo = int.Parse(Console.ReadLine());

                    //Acá tmb se puede mostrar resultado...

                }  
                 //mostrar lo que necesite mostrar...
            }
           //Acá tmb se puede mostrar resultado...

        }
        
    }
}
