using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[10,10];

            for(int row = 0; row < 10; row++)
            {
                int rowPlace = row*10;
                Console.Write("[");
                for(int col = 0; col < 10; col++)
                {
                    matrix[row,col] = rowPlace+(col+1);
                    Console.Write(string.Format("{0} ", matrix[row, col]));
                }
                Console.WriteLine("]");
            }
        }
    }
}
