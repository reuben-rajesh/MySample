using System;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Print prime number
            //Prime.PrintPrime(3, 21);

            //Print Armstrong number
            //Armstrong.PrintArmstrong(1000);

            //Print Narcissistic number
            //Narcissistic.PrintNarcissistic(372);

            //Sample Array Example
            //int count = Convert.ToInt32(Console.ReadLine());
            //string input = Console.ReadLine();
            // int count = 5;
            // string input = "66 13 56 42 22 33 44 88";
            // ArraySample.PrintArraySample(count, input);

            //Sample Count Letter
            //CountLetters.PrintLetterCount("Techgig Is The Best Coding Platform.");

            //Matrix Addition
            // int row = 3;
            // int col = 3;

            // int[,] arr1 = new int[,]
            // {
            //     {1,2,3},
            //     {4,5,6},
            //     {7,8,9}
            // };

            // int[,] arr2 = new int[,]
            // {
            //     {2,3,4},
            //     {5,6,7},
            //     {7,8,9}
            // };

            
            int row, col;

            int[,] arr1 = MatrixAddition.GetInput(out row, out col);
            int[,] arr2 = MatrixAddition.GetInput(out row, out col);

            MatrixAddition.PrintMatrixAddition(row, col, arr1, arr2);

            //Console.ReadLine();            
        }
    }
}
