// See https://aka.ms/new-console-template for more information
using System;

namespace task2
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public readonly DateTime DateOfFilling;

        public User(string login, string name, string surname, int age)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
            DateOfFilling = DateTime.Now;

        }

        public void Show()
        {
            Console.WriteLine($"Login: {Login}, Name: {Name}, Surname: {Surname}, Age: {Age}, Date: {DateOfFilling}");
        }
    }


    class Task2
    {
        static void Main()
        {
            User u = new User("Login", "Name", "Surname", 16);
            u.Show();

        }
    }
}
