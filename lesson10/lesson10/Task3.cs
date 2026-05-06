using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class MyList<T>
    {
        T[] li = new T[4];

        public int count { get; private set; }

        public void Add(T item)
        {
            if (count == li.Length)
            {
                T[] newLi = new T[count * 2];
                Array.Copy(li, newLi, count);
                li = newLi;
            }
            li[count] = item;
            count++;
        }

        public T this[int index]
        {
            get { return li[index]; }
        }
    }

    public static class MyListExtensions
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] newList = new T[list.count];
            for (int i = 0; i < list.count; i++)
            {
                newList[i] = list[i];
            }
            return newList;
        }
    }
    class Program
    {
        static void Main()
        {
            MyList<int> numbers = new MyList<int>();
            for (int i = 1; i < 11; i++)
            {
                numbers.Add(i);
            }

            int first = numbers[0];
            Console.WriteLine(first);
            Console.WriteLine(numbers.count);

            int[] result = numbers.GetArray();
            foreach(int number in result)
            {
                Console.WriteLine(number);
            }
        }
    }
}
