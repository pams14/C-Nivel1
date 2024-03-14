using System;

namespace ejemplo_switch
{
    class Program
    {
        static void Main(string[] args)
        {
        
            char letra = 'H';

            switch (letra)
            {
                case 'M':
                    Console.WriteLine("Tu nombre comienza con M....");    
                    break;
                case 'H':
                    Console.WriteLine("Tu nombre comienza con H....");    
                    break;
                case 'R':
                    Console.WriteLine("Tu nombre comienza con R...");    
                    break;
                                
                default:
                
                    Console.WriteLine("No coincide ninguna....");    
                    break;
            }

        }
    }
}
