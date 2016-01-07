using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desviacion_media
{
    class Program
    {
        static void Main(string[] args)
        {

          
            
            double desv=0;
            double media=0;
            double rango=0, varianza=0;

            if (args.Length == 0)
            {
                Console.WriteLine("No se han recibido valores");
                Console.Read();
            }
            else
            {


                for (int i = 0; i < args.Length; i++)
                {
                    media +=  Int32.Parse(args[i]); 
                }
                media = media /  args.Length;





                   for (int i = 0; i < args.Length; i++)
                {
                    
                    rango = Math.Pow( Int32.Parse(args[i]) - media, 2);
                    varianza += rango;
                }

                   desv = Math.Sqrt(varianza / (args.Length-1));

                 //  Console.WriteLine("desviacionymedia: " + desv);
                   Console.WriteLine("La desviacion tipica es: " + desv);

                    Console.WriteLine("La media aritmética es: " + media);

                    Console.Read();

            }

        }
    }
}
