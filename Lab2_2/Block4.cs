using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
     public class Block4
    {
        static int[,] SwapRows(int[,] reversed)
        {

            int[,] swaped = reversed;
            int n = swaped.GetLength(0);
            int m = swaped.GetLength(1);
            int[] temp = new int[m];
            for (int i = 0; i < m; i++)
            {
                temp[i] = reversed[0, i];
                swaped[0, i] = reversed[n - 1, i];
                swaped[n - 1, i] = temp[i];
            }
            Console.WriteLine("Here is ur swaped matrix:");
            FillAndPrintArray.PrintRecArr(swaped);
            return swaped;
        }
        static int[,] ReverseMatrix(int[,] result)
        {
            int n = result.GetLength(0);
            int m = result.GetLength(1);
            int[,] reversed = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    reversed[i, j] = result[i, m - 1 - j];
                }
            }
            Console.WriteLine("Here is ur reverse matrix:");
            FillAndPrintArray.PrintRecArr(reversed);
            SwapRows(reversed);
            return reversed;
        }
        static int[,] GetTronsposeMatrix(int[,] array)
        {
            int n = array.GetLength(0);
            int m = array.GetLength(1);
            int[,] result = new int[m, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    result[j, i] = array[i, j];
                }
            }
            Console.WriteLine("Here is ur transpose matrix:");
            FillAndPrintArray.PrintRecArr(result);
            ReverseMatrix(result);
            return result;
        }
        public static void DoBlock4()
        {
            Console.Clear();
            Console.WriteLine("Enter the number of elements in R and S arrays");
            int n = int.Parse(Console.ReadLine());
            int[] R = FillAndPrintArray.RandomArray(n);
            int[] S = FillAndPrintArray.RandomArray(n);
            Console.WriteLine("Here is ur array R:");
            FillAndPrintArray.Print(R);
            Console.WriteLine();
            Console.WriteLine("Here is ur array S:");
            FillAndPrintArray.Print(S);
            Console.WriteLine();
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[j, i] = R[i] + S[j];
                }
            }
            Console.WriteLine("Here is ur array:");
            FillAndPrintArray.PrintRecArr(array);
            GetTronsposeMatrix(array);
            Console.WriteLine();
        }
    }
}
