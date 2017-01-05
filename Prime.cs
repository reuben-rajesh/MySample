using System;
namespace ConsoleApplication
{
public class Prime
{
    public static void PrintPrime(int start, int end)
    {
        try
        {
            for (int i = start; i < end; i++)
            {
                int count = 0;
                for (int j = 2; j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        count++;
                    }
                }

                if(count == 1) // all the number should be divisible by 1, So leaving that behind the number should be divisible only by itself
                {
                    Console.WriteLine(i);
                }
            }
        }
        catch (System.Exception ex)
        {
            Console.WriteLine("Error: "+ ex.Message);
        }
    }
}
}