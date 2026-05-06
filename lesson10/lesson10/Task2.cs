using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{

    class MyDictionary<TKey, TValue>
    {
        private struct Field
        {
            public TKey Key;
            public TValue Value;
        }

        private Field[] fields = new Field[4];

        public int Count { get; private set; }

        public void Add(TKey key, TValue value)
        {
            if (Count == fields.Length)
            {
                Field[] newFields = new Field[Count * 2];
                Array.Copy(fields, newFields, Count);
                fields = newFields;
            }


            Field newField = new Field();
            newField.Key = key;
            newField.Value = value;
            fields[Count] = newField;
            Count++;
        }

        public TValue this[TKey key] {
            get {
                for (int i = 0; i < Count; i++) {
                    if (fields[i].Key.Equals(key))
                    {
                        return fields[i].Value;
                    }                   
                }
                return default;
            }
        }
    }

    class Program
    {
        static void Main1(string[] args)
        {
            MyDictionary<string, int> d = new MyDictionary<string, int>();
            d.Add("a", 1);
            d.Add("b", 2);
            d.Add("c", 3);

            Console.WriteLine(d["b"]);
        }
    }
}
