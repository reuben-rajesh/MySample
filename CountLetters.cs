using System;
using System.Linq;

namespace ConsoleApplication
{
    public class CountLetters
    {
        public static void PrintLetterCount(string input)
        {
            int lower = 0;
            int upper = 0;

            input.Replace(" ", string.Empty).ToList<char>().ForEach(c => 
            {
                if(char.IsLetter(c))
                {
                    if(char.IsUpper(c))
                        upper++;
                    else
                        lower++;
                }                
            });

            Console.WriteLine(upper);
            Console.WriteLine(lower);
        }
    }
}