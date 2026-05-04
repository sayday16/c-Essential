using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    class Task2
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Func<int>[] myDelegates = new Func<int>[] {
                () => rnd.Next(1, 100),
                () => rnd.Next(1, 100),
                () => rnd.Next(1, 100)
            };

            Func<Func<int>[], double> avg = array =>
            {
                double sum = 0;

                foreach(var item in array)
                {
                    sum += item();
                }
                return sum / array.Length;
            };

            double res = avg(myDelegates);
            Console.WriteLine(res);
        }
    }
}
