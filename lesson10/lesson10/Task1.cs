// See https://aka.ms/new-console-template for more information
using System;

namespace task1
{
    class MyList<T>
    {
        T[] li = new T[4];

        public int count { get; private set; }

        public void Add(T item)
        {
            if(count == li.Length)
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
    class Program
    {
        static void Main1()
        {
            MyList<int> numbers = new MyList<int>();
            for(int i = 1; i < 11; i++)
            {
                numbers.Add(i);
            }

            int first = numbers[0];
            Console.WriteLine(first); 
            Console.WriteLine(numbers.count); 
        }
    }
}
