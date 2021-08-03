using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Utility
    {
        public static string usersinput()
        {
            return Console.ReadLine();
        }
        public static int binarysearch(string[] arr, string key)
        {
            int l = 0;
            int h = arr.Length;
            while (l <= h)
            {
                int m = l + (h - l) / 2;
                int res = key.CompareTo(arr[m]);
                if (res == 0)
                    return m;
                if (res > 0)
                {
                    l = m + 1;

                }
                else
                {
                    h = m - 1;
                }
            }
            return -1;
        }
        public static int IntegerInput()
        {
            return int.Parse(Console.ReadLine());
        }
        public static void arraysorting(string[] str, int n)
        {
            string temp = " ";
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (str[i].CompareTo(str[j]) > 0)
                    {

                        temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;
                    }

                }
            }
        }
        public static void arraysorting(int[] a, int n)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }

                }
            }
        }
    }
}
