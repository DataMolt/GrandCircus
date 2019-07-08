using System;
using System.Collections.Generic;

namespace GrandCircus_Day26
{
    class Program
    {
        static void Main(string[] args)
        {
            var intArray = new int[5] {10,42,1,74,420};
            var intList = new List<int> { 11, 980, 50, 23, 69, };
            Console.WriteLine(string.Join(", ", Sort(intArray)));
            Console.WriteLine("\n");
            Console.WriteLine(string.Join(", ", MergeSort(intList)));
            var sortedList = MergeSort(intList);
            var sortedArray = sortedList.ToArray();
            Console.WriteLine("\n");
            Console.WriteLine(BinarySearch(sortedArray, 16));
            Console.WriteLine(BinarySearch(sortedArray, 980));
            Console.WriteLine(LinearSearch(sortedArray, 16));
            Console.WriteLine(LinearSearch(sortedArray, 980));
            Console.WriteLine("\n");
            Console.WriteLine(CalculateSumRecursively(1,3));
        }

        private static int[] Sort(int[] unsorted)
        {
            for (int i = 0; i < unsorted.Length; i++)
            {
                for (int j = i + 1; j < unsorted.Length; j++)
                {
                    if (unsorted[i] > unsorted[j]) 
                    {
                        var temp = unsorted[j];
                        unsorted[j] = unsorted[i];
                        unsorted[i] = temp;
                    }
                }
            }
            return unsorted;
        }

        private static T[] SortGeneric<T>(T[] unsorted) where T:IComparable
        {
            for (int i = 0; i < unsorted.Length; i++)
            {
                for (int j = i + 1; j < unsorted.Length; j++)
                {
                    if (unsorted[i].CompareTo(unsorted[j]) >= 0 )
                    {
                        var temp = unsorted[j];
                        unsorted[j] = unsorted[i];
                        unsorted[i] = temp;
                    }
                }
            }
            return unsorted;
        }

        private static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
            {
                return unsorted;
            }

            var middle = unsorted.Count / 2;
            var left = new List<int>();
            var right = new List<int>();

            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }

            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);


            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            var merged = new List<int>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left[0] <= right[0])
                    {
                        merged.Add(left[0]);
                        left.RemoveAt(0);
                    }
                    else
                    {
                        merged.Add(right[0]);
                        right.RemoveAt(0);
                    }
                }
                else if (left.Count > 0)
                {
                    merged.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    merged.Add(right[0]);
                    right.RemoveAt(0);
                }
            }
            return merged;
        }

        private static bool BinarySearch(int[] inputArray, int key)
        {
            var min = 0;
            var max = inputArray.Length;
            while (min <= max)
            {
                var middle = (min + max) / 2;
                if (inputArray[middle] == key)
                {
                    return true;
                }
                else if (inputArray[middle] < key)
                {
                    min = middle + 1;
                }
                else
                {
                    max = middle - 1;
                }
            }
            return false;
        }

        private static bool LinearSearch(int[] inputArray, int key)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (key == inputArray[i])
                {
                    return true;
                }

                if (key < inputArray[i])
                {
                    return false;
                }
            }
            return false;
        }

        public static int CalculateSumRecursively(int n, int m)
        {
            int sum = n;

            if (n < m)
            {
                n++;
                return sum += CalculateSumRecursively(n, m);
            }

            return sum;
        }
    }
}
