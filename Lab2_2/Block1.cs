using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
     public class  Block1
    {
        static void InsertA(ref int[] a, int idx, int v)
        {
            if (a == null || idx < 0 || idx > a.Length)
            {
                Console.WriteLine("Impossible to do");
            }
            else
            {
                Array.Resize(ref a, a.Length + 1);
                for (int i = a.Length - 2; i >= idx; i--)
                {
                    a[i + 1] = a[i];
                }
                a[idx] = v;
            }
        }
        static void Check(ref int[] a)
        {
            int idx;
            int v;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    idx = i + 1;
                    v = Math.Abs(a[i]);
                    InsertA(ref a, idx, v);
                }
            }
        }
        public static void DoBlock1()
        {
            Console.Clear();
            int[] a;
            int ch;
            Console.WriteLine("Enter 1 to fill array by random");
            Console.WriteLine("Enter 2 to fill array by one raw");
            Console.WriteLine("Enter 0  to finish the Block1");
            ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter the number of elements");
                    int n = int.Parse(Console.ReadLine());
                    a = FillAndPrintArray.RandomArray(n);
                    Console.WriteLine("Here is ur array");
                    FillAndPrintArray.Print(a);
                    Check(ref a);
                    Console.WriteLine();
                    Console.WriteLine("Here is ur new array");
                    FillAndPrintArray.Print(a);
                    break;
                case 2:
                    a = FillAndPrintArray.InOneRaw();
                    Check(ref a);
                    Console.WriteLine();
                    Console.WriteLine("Here is ur new array");
                    FillAndPrintArray.Print(a);
                    break;
                case 0:
                    Console.WriteLine("Ok, got it");
                    break;
                default:
                    Console.WriteLine("An incorrect choice, try again");
                    break;
            }
            Console.WriteLine();
        }
    }
}
