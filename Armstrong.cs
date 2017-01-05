using System;

namespace ConsoleApplication
{
    public class Armstrong
    {
        public static void PrintArmstrong(int input)
        {
            for (int i = 0; i < input; i++)
            {
                 int tempVal = i;
                int val = 0;
                do{
                    int rem = tempVal % 10;
                    val += rem * rem * rem;
                    tempVal = tempVal / 10;
                }
                while(tempVal > 0);

                if(i == val)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}