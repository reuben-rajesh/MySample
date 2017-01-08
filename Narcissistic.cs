using System;

namespace ConsoleApplication
{
    public class Narcissistic
    {
        public static void PrintNarcissistic(int input)
        {
            int len = input.ToString().Length;
            
            int tempVal = input;
            int val = 0;
            do{
                int rem = tempVal % 10;
                val += getValue(rem, len);
                tempVal = tempVal / 10;
            }
            while(tempVal > 0);

            Console.WriteLine(val);
            if(input == val)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        public static int getValue(int val, int pow)
        {
            return (int)Math.Pow(val, pow);
        }
    }
}