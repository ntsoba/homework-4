using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    enum Days
    {
        Monday =1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[,] input =
            {
{"John and Mary have a discussion","1"},

{"John and Mary interview","3"},

{"F2F","4"},

{"General meeting","7"}
            };

            int rows = input.GetUpperBound(0) + 1;
            int columns = input.Length / rows;

            for (int i=0; i<rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 0) { 
                    
                    if (input[i, j].Length > 10)
                    {
                        
                        string st = input[i, j].Substring(0,10);
                        Console.WriteLine($"{st.ToLower()} ");
                        
                    }
                    else
                    {
                       
                        Console.WriteLine($"{input[i,j].ToLower()} ");
                       
                       
                    }
                    }
                    else {int days = Convert.ToInt32(input[i, 1]);
                    Console.WriteLine((Days)days);}
                   
                    

                }
            }

            Console.ReadLine();
        }
    }
}
