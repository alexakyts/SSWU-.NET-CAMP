using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 12, 123, 775, 56, 1, 90, 8, 8, 11, 9, 27, 43, 11, 45 };
            Vector vector = new Vector(arr);
            Console.WriteLine(vector);
            //vector.QuickSort(0, arr.Length - 1);
            vector.SplitMergeSort(0, arr.Length);
            Console.WriteLine(vector);
        }
    }
}
