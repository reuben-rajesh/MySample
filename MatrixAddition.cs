using System;
using System.Linq;

namespace ConsoleApplication
{
    public class MatrixAddition
    {
        public static void PrintMatrixAddition(int row, int col, int[,] array1, int[,] array2 )
        {
            for (int rowIndex = 0; rowIndex < row; rowIndex++)
            {
                for (int colIndex = 0; colIndex < col; colIndex++)
                {
                    Console.Write(array1[rowIndex, colIndex] + array2[rowIndex, colIndex]);

                    if(colIndex + 1 < col)
                        Console.Write(" ");
                }

                if(rowIndex + 1 < row)
                    Console.Write(Environment.NewLine);
            }
        }

        public static int[,] GetInput(out int row, out int col)
        {
            string rowCol = Console.ReadLine();
            int[] rowColArr = rowCol.Split(' ').Select(int.Parse).ToArray();
            row = rowColArr[0];
            col = rowColArr[0];

            int[,] tempArr = new int[row,col];

            for (int rowCnt = 0; rowCnt < row; rowCnt++)
            {
                int[] val = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int colCnt = 0; colCnt < col; colCnt++)
                {
                    tempArr[rowCnt, colCnt] = val[colCnt];
                }            
            }

            return tempArr;
        }
    }
}