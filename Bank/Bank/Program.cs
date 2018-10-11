using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            int mis = Convert.ToInt32(Console.ReadLine());
             for(int i=1; i<mis; i++)
            {
               
                 sum=sum+(sum*0.07M);
                
            }
            Console.WriteLine($"Після {mis} місяців сума вкладу нараховує {sum}");
            Console.ReadKey();

        }
    }
}
