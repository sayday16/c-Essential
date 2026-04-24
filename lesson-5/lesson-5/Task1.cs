// See https://aka.ms/new-console-template for more information
using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size of array: ");
            int N = int.Parse(Console.ReadLine());

            int[] myArray = new int[N];
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(1, 101);
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"element [{i}] = {myArray[i]}");
            }

        }
    }
}
