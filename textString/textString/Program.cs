using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"Learn C# by stepping through the basics with Bob: get the tools, see how to write code,
debug features, explore customizations, and much more ! Search for and focus on the information you need, 
in this C# for beginners course, which has topics separated out into individual videos. Get to know the grammar,
create and use methods, manipulate strings, and see how to handle events. Plus, get a look at next steps as you 
learn to develop Windows and web applications.";

            int counter = 0;
            for (int i = 1; i < text.Length-1; i++)
            {
                string et = text.Substring(i, 2);
                if (et == "et")
                {
                    counter++;
                }
            }
            Console.WriteLine("Number of " + counter);
            Console.ReadKey();
        }
    } 
}
