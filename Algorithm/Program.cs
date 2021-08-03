using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Algorithm Problems");
            Console.WriteLine("Enter Option");
            Console.WriteLine("1.Permutations_String");
            Console.WriteLine("2.BinarySearchFile");
            Console.WriteLine("3.InsertionSort");
            Console.WriteLine("4.BubbleSort");

            int Option = int.Parse(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    Console.WriteLine("Please Enter Perm_string: ");
                    String str = Console.ReadLine();
                    int n = str.Length;
                    permutations_String.permute(str, 0, n - 1);
                    break;
                case 2:
                    BinarySearchFile.Binarysearch();
                    break;
                case 3:
                    InsertionSort insertionSort = new InsertionSort();
                    insertionSort.insertion();
                    break;
                case 4:
                    BubbleSort bubbleSort = new BubbleSort();
                    bubbleSort.bubblesort();
                    break;

                default:
                    Console.WriteLine("Please Enter valid option");
                    break;

            }
        }

    }


 }


