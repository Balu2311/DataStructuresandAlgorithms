using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Algorithm Problems");
            String str = "ABC";
            int n = str.Length;
            permutations_String.permute(str, 0, n - 1);
        }


    }
}

