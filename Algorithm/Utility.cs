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
    }
}
