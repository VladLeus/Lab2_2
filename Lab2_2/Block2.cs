using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
     public class Block2
    {
        static int GetSumOfDigits(int i)
        {
            int sum = 0;
            int temp;
            while (i > 0)
            {
                temp = i % 10;
                sum = sum + temp;
                i = i / 10;
            }
            return sum;
        }
        static int[][] Part2B(int m)
        {
            int[][] jaggedArray = new int[m][];
            int maxsum = int.MinValue;
            for (int i = 0; i <= m; i++)
            {
                if (GetSumOfDigits(i) > maxsum)
                {
                    maxsum = GetSumOfDigits(i);
                }
            }
            maxsum++;
            int[][] JaggedArray = new int[maxsum][];
            for (int i = 1; i < JaggedArray.Length; i++)
            {
                int sum = GetSumOfDigits(i);
                JaggedArray[i] = new int[m / sum];
                int temp = 0;
                for (int j = sum; j <= m; j += sum)
                {
                    JaggedArray[i][temp] = j;
                    temp++;
                }
            }
            for (int i = 0; i < m; i++)
            {
                int sum = GetSumOfDigits(i);
                jaggedArray[i] = JaggedArray[sum];
            }
            FillAndPrintArray.PrintJagArrayForBlock2(jaggedArray);
            return jaggedArray;
        }
        static int[][] Part2A(int n)
        {
            int[][] juggedArray = new int[n][];
            for (int i = 1; i < juggedArray.Length; i++)
            {
                int sum = GetSumOfDigits(i);
                juggedArray[i] = new int[n / sum];
                int temp = 0;
                for (int j = sum; j <= n; j += sum)
                {
                    juggedArray[i][temp] = j;
                    temp++;
                }
            }
            FillAndPrintArray.PrintJagArrayForBlock2(juggedArray);
            return juggedArray;
        }
        public static void DoBlock2()
        {
            Console.Clear();
            int choice;
            Console.WriteLine("Enter 1 to start 2a");
            Console.WriteLine("Enter 2 to start 2b");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter your number");
                    int n = int.Parse(Console.ReadLine());
                    Part2A(n);
                    break;
                case 2:
                    Console.WriteLine("Enter your number");
                    int m = int.Parse(Console.ReadLine());
                    Part2B(m);
                    break;
            }
        }
    }
}
