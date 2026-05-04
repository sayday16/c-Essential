// See https://aka.ms/new-console-template for more information
using System;

namespace task1
{
    class Task1
    {
        static void Main1(string[] args)
        {
            Console.Write("enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("enter y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("enter num: A-1, S-2, M-3, D-4: ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Func<int, int, int> Add = (x, y) => x + y;
                    Console.WriteLine(Add(x,y));
                    break;
                case 2:
                    Func<int, int, int> Sub = (x, y) => x - y;
                    Console.WriteLine(Sub(x, y));
                    break;
                case 3:
                    Func<int, int, int> Mul = (x, y) => x * y;
                    Console.WriteLine(Mul(x, y));
                    break;
                case 4:
                    Func<double, double, double> Div = (x, y) => { if (y == 0) { return 0; } return x / y; };
                    Console.WriteLine(Div(x, y));
                    break;
            }
        }
    }
}
