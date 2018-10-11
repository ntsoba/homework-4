using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twonumbers
{
    class Program
    {
        static void Main(string[] args)
        {

      
            int mnog;
            int i=0;

            while(true){

                int x = Convert.ToInt32(Console.ReadLine()); 
                int y = Convert.ToInt32(Console.ReadLine()); 

                if ((y>10) || (x> 10) || (x < 0) || (y < 0))
                {
                    Console.WriteLine("Недопустимі символи");
                   
                    continue;
                }
                else
                {
                    mnog = x * y;
                    Console.WriteLine($"Множення {mnog}");
                    Console.ReadKey();
                    break;

                }
            }
        }
    }
}
