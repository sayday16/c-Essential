// See https://aka.ms/new-console-template for more information
using System;

namespace task4
{
    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }

    class XMLHandler : AbstractHandler
    {
        public override void Open() { Console.WriteLine("Відкрито XML документ"); }
        public override void Create() { Console.WriteLine("Створено XML документ"); }
        public override void Change() { Console.WriteLine("Відредаговано XML документ"); }
        public override void Save() { Console.WriteLine("Збережено XML документ"); }
    }

    class TXTHandler : AbstractHandler
    {
        public override void Open() { Console.WriteLine("Відкрито TXT документ"); }
        public override void Create() { Console.WriteLine("Створено TXT документ"); }
        public override void Change() { Console.WriteLine("Відредаговано TXT документ"); }
        public override void Save() { Console.WriteLine("Збережено TXT документ"); }
    }

    class DOCHandler : AbstractHandler
    {
        public override void Open() { Console.WriteLine("Відкрито DOC документ"); }
        public override void Create() { Console.WriteLine("Створено DOC документ"); }
        public override void Change() { Console.WriteLine("Відредаговано DOC документ"); }
        public override void Save() { Console.WriteLine("Збережено DOC документ"); }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("XML");
            AbstractHandler xml = new XMLHandler();
            xml.Create();
            xml.Open();
            xml.Change();
            xml.Save();

            Console.WriteLine("\nTXT");
            AbstractHandler txt = new TXTHandler();
            txt.Create();
            txt.Open();
            txt.Change();
            txt.Save();

            Console.WriteLine("\nDOC ");
            AbstractHandler doc = new DOCHandler();
            doc.Create();
            doc.Open();
            doc.Change();
            doc.Save();

            Console.ReadLine();
        }
    }
}