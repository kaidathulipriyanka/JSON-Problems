using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class CountDuplicateElements
    {
        public void Count_Duplicate_Elements()
        {
            int[] arr = { 1, 2, 3, 4, 2, 5, 6, 3, 7, 8, 9, 1, 1, 4, 5 };

            int count = CountDuplicates(arr);

            Console.WriteLine("Total number of duplicate elements in the array: " + count);
        }

        static int CountDuplicates(int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;  
                    }
                }
            }

            return count;
        }
    }
}

