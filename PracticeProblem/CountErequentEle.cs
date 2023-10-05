using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class CountFrequentEle
    {
        public void Count_Frequency()
        {
            int[] arr = { 10, 20, 30, 10, 20, 10 };

            // Initialize two arrays to store unique elements and their frequencies
            int[] uniqueElements = new int[arr.Length];
            int[] frequencies = new int[arr.Length];

            // Initialize the count variable
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isUnique = true;

                // Check if the current element is already counted
                for (int j = 0; j < count; j++)
                {
                    if (arr[i] == uniqueElements[j])
                    {
                        frequencies[j]++;
                        isUnique = false;
                        break;
                    }
                }

                // If the element is unique, add it to the uniqueElements array
                if (isUnique)
                {
                    uniqueElements[count] = arr[i];
                    frequencies[count] = 1;
                    count++;
                }
            }

            Console.WriteLine("Element\tFrequency");

            // Display the frequency of each unique element
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{uniqueElements[i]}\t{frequencies[i]}");
            }
        }
    }
}
   