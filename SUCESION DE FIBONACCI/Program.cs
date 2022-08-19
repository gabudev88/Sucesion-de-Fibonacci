using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUCESION_DE_FIBONACCI
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // SE DECLARAN DOS VARIABLES DEL TIPO LONG
            long n1 = 0;
            long n2 = 1;

            // RESOLVEMOS MEDIANTE EL LOOP FOR
            for (int i = 0; i <= 50; i++)
            {
                long sucesionDeFibonacci = n1 + n2;
                // "N1" VALDRIA 1 DESDE ESTE PUNTO
                n1 = n2;
                // "N2" ES EL RESULTADO DE SUMAR "1"(N1) + EL RESULTADO
                // DEL LOOP ANTERIOR 
                n2 = sucesionDeFibonacci;
                Console.WriteLine(sucesionDeFibonacci);    
            }               
                          
            
            Console.Read();

        }
        
        
    }
}
