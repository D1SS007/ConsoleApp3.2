using System;

namespace ConsoleApp3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int rows = 10;
            int columns = 10;
            int minNumber = 1;
            int maxNumber = 10;
            int[,] array = new int [rows,columns];
            int maxElement = int.MinValue;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array [i,j] = random.Next(minNumber, maxNumber);
                    Console.Write(array [i,j] + " ");
                    
                    if(maxElement < array[i, j])
                    {
                        maxElement = array [i,j];
                    }
                }
                
                Console.WriteLine ();
            }

            Console.WriteLine(maxElement); 

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(array [i,j] == maxElement)
                    {
                        array[i, j] = 0;
                    }

                    Console.Write(array[i,j]+ " ");
                }

                Console.WriteLine();
            }
        }
    }
}
