using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lessons.M2.L1
{
    public class L1Array
    {
        public static void Run()
        {
            int[] intArray = { 0, 1, 2, 3, 4 };
            int[] intArray1 = new int[5];
            ShowArray(intArray);

            intArray1[2] = 2;
            ShowArray(intArray1);

            int[] intArray2 = new int[3] { 1, 2, 3 };
            ShowArray(intArray2);

            int[,] intMatrix = new int[3, 2];
            int[,] intMatrix1 = { { 1, 2 }, { 3,4} };

            int[][] intMultiArray = new int[3][];
            intMultiArray[0] = new int[7];
            intMultiArray[1] = new int[70];
            intMultiArray[2] = new int[12];
        }

        public static void Run1()
        {
            string[] shoppingArray = new string[6];
            shoppingArray[0] = "milk";
            ShowArray(shoppingArray);
            shoppingArray[1] = "butter";
            ShowArray(shoppingArray);
            shoppingArray[5] = "apple juice";
            ShowArray(shoppingArray);
        }

        public static void Run3()
        {
            int[,] intMatrix = new int[3, 2];
            int[,] intMatrix1 = { { 1, 2 }, { 3, 4 } };
            int[,] intMatrix2 = { { 1, 2, 3 }, { 3, 4, 7 },{ 1,1,1},{ 5,7,8} };   

            Show2DArray(intMatrix2);
        }

        public static void ShowArray(string[] array)
        {
            Console.WriteLine($"Number of elements: {array.Length}");
            foreach(string  item in array)
            {
                Console.WriteLine(item);
            }
        }
        public static void ShowArray(int[] array)
        {
            foreach(int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        public static void Show2DArray(int[,] matrix)
        {
            for (int iterator=0; iterator<matrix.GetLength(0);iterator++)
            {
                for(int iterator1=0; iterator1<matrix.GetLength(1);iterator1++)
                {
                    Console.Write($"{matrix[iterator,iterator1]} ");
                }
                Console.WriteLine();
            }
        }
    }
    
}
