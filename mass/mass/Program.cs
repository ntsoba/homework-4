using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -4,-3,-2,-1,0,1,2,3,4 };

            for(int i=0; i<=numbers.Length/2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Length - i - 1];
                numbers[numbers.Length - i - 1] = temp;
            }
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
