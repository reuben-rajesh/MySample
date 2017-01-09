using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class ArraySample
    {
        public static void PrintArraySample(int inputCnt, string inputArrStr)
        {
            /*
            int[] inputArr = new int[inputCnt];
            
            inputArr = inputArrStr.Split(' ').Select(s => int.Parse(s)).ToArray();

            int largest = 0;
            int secondLargest = 0;


            for(int i = 0; i < inputCnt; i++)
            {
                if(inputArr[i] > largest)
                {
                    if(largest > secondLargest)                         
                        secondLargest = largest;

                    largest = inputArr[i];               
                }
                else if(inputArr[i] > secondLargest)
                {
                    secondLargest = inputArr[i];
                }
            }

            Console.WriteLine("Largest: " + largest + " SecondLargest: " + secondLargest);
            */

            List<int> inputArr = inputArrStr.Split(' ').Select(int.Parse).ToList();
            int secondLargest = inputArr.OrderByDescending(i => i).Skip(1).First();
            Console.WriteLine(" SecondLargest: " + secondLargest);
        }
    }
}