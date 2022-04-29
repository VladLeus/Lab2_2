using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
     public class Block3
    {
        static int[][] DeleteRows(ref int[][] array)
        {
            int[][] newArr = new int[((array.Length + 1) / 2)][];

            for (int i = 0, j = 0; i < array.Length; i += 2, j++)
            {
                newArr[j] = array[i];
            }
            FillAndPrintArray.PrintJagArray(newArr);
            return newArr;
        }
        static void Solve(int lines, int colunms)
        {
            int[][] arr = new int[lines][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[colunms];
                arr[i] = FillAndPrintArray.RandomForBlock3(arr[i], -10, 11);
            }
            FillAndPrintArray.PrintJagArray(arr);
            Console.WriteLine("Here is ur new array:");
            DeleteRows(ref arr);
        }
        public static void DoBlock3()
        {
            Console.Clear();
            Console.WriteLine("Enter the number of lines");
            int lines = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of colunms");
            int colunms = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Here is ur array:");
            Solve(lines, colunms);
        }
    }
}
