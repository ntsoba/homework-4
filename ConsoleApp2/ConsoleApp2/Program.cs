using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = {-4,-3,-2,-1,0,1,2,3,4,5,-8,7};
            for (int i = 0; i < number.Length; i++) {
                if (number[i] > 0) {
                    Console.WriteLine(number[i]);
                    Console.ReadKey();
                }
                

            }
            
        }
    }
}
