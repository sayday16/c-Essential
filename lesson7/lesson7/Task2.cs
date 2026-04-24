using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    class MyClass
    {
        public string change {  get; set; }
    }

    struct MyStruct
    {
        public string change { get; set; }
    }

    class Program2
    {
        static void Main()
        {

            static void ClassTaker(MyClass myClass)
            {
                myClass.change = "changed";
            }

            static void StructTaker(MyStruct myStruct)
            {
                myStruct.change = "changed";
            }

            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            myClass.change = "not changed";
            myStruct.change = "not changed";

            ClassTaker(myClass);
            StructTaker(myStruct);

            Console.WriteLine($"Клас: {myClass.change}");
            Console.WriteLine($"Структура: {myStruct.change}");

        }
    }
}
