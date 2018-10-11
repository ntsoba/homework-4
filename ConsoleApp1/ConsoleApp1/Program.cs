using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
          
            for (int i = 0; i < number.Length/2; i++)
            {
                int temp = number[i];
                number[i] = number[number.Length - i - 1];
                number[number.Length - i - 1] = temp;
            }
            foreach (int i in number)
            {
                Console.Write(i);
            }

            Console.ReadLine();




        }
    }
}
