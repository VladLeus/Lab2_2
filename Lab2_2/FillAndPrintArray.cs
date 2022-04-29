using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    public class FillAndPrintArray
    {
        public static int[] InOneRaw()
        {
            string[] data = Console.ReadLine().Trim().Split();
            int[] oneRawArray = new int[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                oneRawArray[i] = Convert.ToInt32(data[i]);
            }
            return oneRawArray;
        }
        public static int[] RandomForBlock3(int[] arr, int x, int y)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(x, y);
            }
            return arr;
        }
         public static void PrintRecArr(int[,] array)
        {
            int n = array.GetLength(0);
            int m = array.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void PrintJagArray(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
         public static void PrintJagArrayForBlock2(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} : ", i);
                if (arr[i] != null)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        Console.Write("{0} ", arr[i][j]);
                    }
                }
                Console.WriteLine();
            }
        }
        public static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }
        public static int[] RandomArray(int n)
        {
            int[] randArray = new int[n];
            Random rand = new Random();
            for (int i = 0; i < randArray.Length; i++)
            {
                randArray[i] = rand.Next(-15, 16);
            }
            return randArray;
        }
    }
}
