using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class BoxPattern
    {
        public void Box_Pattern() {
            int rows = 6;
            int columns = 6;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i == 0 || i == rows - 1 || j == 0 || j == columns - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  "); // Two spaces to maintain spacing
                    }
                }
                Console.WriteLine(); // Move to the next line after each row
            }

            Console.ReadLine(); // Pause the program to see the pattern
        }
    }
}
