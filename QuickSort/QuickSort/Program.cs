using System;
using System.Collections.Generic;

namespace QuickSort
{
    class Program
    {
        static Program instance;
        static void Main(string[] args)
        {
            instance = new Program();
            //Console.WriteLine("Hello World!");
            List<int> arr = new List<int>() { 1, 5, 2, 9, 0, 6, 2, 61, 4, 0, 2};
            arr = instance.Sort(arr, arr[arr.Count / 2]);
            foreach(int i in arr)
            Console.WriteLine(i);
        }
        List<int> Sort(List<int> arr, int pivot)
        {
            Console.WriteLine(pivot);
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            List<int> middle = new List<int>();
            foreach (int i in arr)
            {
                if (i > pivot) right.Add(i);
                else if (i < pivot) left.Add(i);
                else middle.Add(i);
            }
            arr.Clear();
            foreach (int j in left) Console.Write(j);
            Console.WriteLine();
            foreach (int j in right) Console.Write(j);
            Console.WriteLine();
            if (left.Count > 1) left = Sort(left, left[left.Count / 2]);
            if(right.Count >1) right  = Sort(right, right[right.Count / 2]);
            arr.AddRange(left);
            arr.AddRange(middle);
            arr.AddRange(right);
            return arr;
        }
    }
}
