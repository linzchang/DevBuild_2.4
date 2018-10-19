using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSecondDimension
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a 2d array using numbers from assessment
            int[,] arrayOfArrays = new int[4, 4] {
                {5, -4, 3, 0},
                {5, 1, -2, -1},
                {8, 6, -7, 4},
                {-2, 1, -5, 2}};

            //Display 2d array to console
            Console.Write("Here is our two-dimensional array:");
            for (int rows = 0; rows < arrayOfArrays.GetLength(0); rows++)
            {
                Console.WriteLine(" ");
                for (int columns = 0; columns < arrayOfArrays.GetLength(1); columns++)
                {
                    Console.Write(arrayOfArrays[rows, columns] + " ");
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //Calculate sum of diagonal
            int sum = SumDiagonal(arrayOfArrays);

            //Print sum to console
            Console.WriteLine($"The sum of the diagonal numbers in this two-dimensional array is {sum}.");
            Console.ReadLine();
        }

        //Write a method that finds the sum of the diagonal of a 2d array
        public static int SumDiagonal(int[,] matrix)
        {
            int sum = 0;

            //use nested loops to iterate through array to get index of each number in diagonal position
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int result = 0;

                //grab the number at the given index of the inner array
                for (int column = 0; column < 1; column++)
                {
                    result = matrix[row,row];
                }

                //add up the numbers in diagonal
                sum = result + sum;
            }

            return sum;
        }
    }
}
