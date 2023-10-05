using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class UniqueElements
    {
        public void Unique_Elements() {

            int[] arr = { 1, 2, 3, 4, 5, 1, 2, 6, 7, 8, 8, 9 };

            Console.WriteLine("Unique elements in the array:");

            for (int i = 0; i < arr.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
