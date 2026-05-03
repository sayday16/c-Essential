// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Http.Headers;



namespace Task1
{
    enum MyColors
    {
        Red,
        Green,
        Blue
    }

    static class Pr
    {
        public static void Print(string stroka, int color)
        {
           switch (color)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;                
            }
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }

    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("enter text: ");
            string text = Console.ReadLine();

            Console.WriteLine("0 Red: ");
            Console.WriteLine("1 Green: ");
            Console.WriteLine("2 Blue: ");

            int input = int.Parse(Console.ReadLine());
            Pr.Print(text, input);

        }
    }
}
