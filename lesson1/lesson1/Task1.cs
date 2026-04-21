// See https://aka.ms/new-console-template for more information
using System;

namespace task1
{

    class Address
    {
        public int index { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string house { get; set; }
        public string apartment { get; set; }

        public Address(int index, string country, string city, string street, string house, string apartment)
        {
            this.index = index;
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apartment = apartment;
        }

        public void Show()
        {
            Console.WriteLine($"{index}, {country}, {city}, {street}, {house}, {apartment}");
        }
    }

    class Task1
    {


        static void Main()
        {
            Address ad = new Address(12, "country", "city", "street", "house", "apartment");
            ad.Show();

        }
    }
}

