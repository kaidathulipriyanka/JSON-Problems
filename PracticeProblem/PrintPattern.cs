using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class PrintPattern
    {
        public void  Prin_tPattern() {
            int n = 8; // Number of lines

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine(); // Pause to see the pattern
        }
    }
}
   
