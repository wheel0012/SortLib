using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastSort
{
    public class QuickSort
    {
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
            if (right.Count > 1) right = Sort(right, right[right.Count / 2]);
            arr.AddRange(left);
            arr.AddRange(middle);
            arr.AddRange(right);
            return arr;
        }
    }
}
