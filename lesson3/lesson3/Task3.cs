// See https://aka.ms/new-console-template for more information
using System;

namespace task3
{
    class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine($"{value}");
        }
    }

    class RedPrinter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Print(value);
            Console.ResetColor();
        }
    }

    class GreenPrinter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            base.Print(value);
            Console.ResetColor();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Printer[] printers = new Printer[3];

            printers[0] = new Printer();
            printers[1] = new RedPrinter();
            printers[2] = (Printer)new GreenPrinter();

            foreach (Printer p in printers)
            {
                p.Print("Work of printer");
            }

            Console.WriteLine();

            Printer somePrinter = new RedPrinter();

            if (somePrinter is RedPrinter)
            {
                RedPrinter myRedPrinter = (RedPrinter)somePrinter;
                myRedPrinter.Print("Downcasting");
            }
        }
    }
}
