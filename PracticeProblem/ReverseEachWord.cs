using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class ReverseEachWord
    {
        public void Reverse_EachWord() {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string reversedString = ReverseWords(input);

            Console.WriteLine("Reversed String: " + reversedString);
        }

        static string ReverseWords(string input)
        {
            char[] charArray = input.ToCharArray();
            int start = 0;

            for (int end = 0; end < charArray.Length; end++)
            {
                if (charArray[end] == ' ' || end == charArray.Length - 1)
                {
                    int wordEnd = end;
                    if (end == charArray.Length - 1)
                    {
                        wordEnd = end; // If it's the end of the string, include the last character
                    }
                    else
                    {
                        wordEnd = end - 1; // If it's a space, exclude the space character
                    }

                    // Reverse the characters within the word
                    while (start < wordEnd)
                    {
                        char temp = charArray[start];
                        charArray[start] = charArray[wordEnd];
                        charArray[wordEnd] = temp;
                        start++;
                        wordEnd--;
                    }

                    start = end + 1;
                }
            }

            return new string(charArray);
        }
    }
}