using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    enum Post
    {
        Teacher = 100,
        Сashier = 90,
        Driver = 115
    }

    class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if(hours >= (int)worker)
            {
                return true;
            }
            return false;

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Accauntant a = new Accauntant();
            Console.WriteLine(a.AskForBonus(Post.Сashier, 100));
            
        }
    }
}
