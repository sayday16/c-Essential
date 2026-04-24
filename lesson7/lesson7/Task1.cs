// See https://aka.ms/new-console-template for more information
using System;

namespace lesson7
{
    struct Train
    {
       public string Destination {  get; set; }
       public int NumberOfTrain {  get; set; }
       public DateTime Time { get; set; }

       public  Train(string destination, int numberOfTrain, DateTime time)
        {
            Destination = destination;
            NumberOfTrain = numberOfTrain;
            Time = time;
        }
    }

    class Program
    {
        static void Main1(string[] args)
        {          
            int N = 8;
            Train[] t = new Train[N];
            
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("enter destination: ");
                string tempDest = Console.ReadLine();
                Console.WriteLine("enter number of train: ");
                int tempNum = int.Parse(Console.ReadLine());
                Console.WriteLine("enter date: ");
                DateTime tempDate = DateTime.Parse(Console.ReadLine());
                t[i] = new Train(tempDest, tempNum, tempDate);
            }
            
            for(int i =0; i < N; i++)
            {
                for(int j = 0; j < N - 1 - i; j++)
                {
                    if (t[j].NumberOfTrain > t[j + 1].NumberOfTrain)
                    {
                        Train temp = t[j];
                        t[j] = t[j + 1];
                        t[j + 1] = temp;
                    }
                }
            }
            

            Console.WriteLine("enter number of train or 0 to stop: ");
            int searchNum = int.Parse(Console.ReadLine());
            while (searchNum != 0) 
            {
                bool isFound = false;
                for (int i = 0; i < N; i++) {
                    if (t[i].NumberOfTrain == searchNum)
                    {
                        Console.WriteLine($"dest: {t[i].Destination}, time: {t[i].Time}");
                        isFound = true;
                    }                   
                }
                if (!isFound)
                {
                    Console.WriteLine("dont found");
                }
                Console.WriteLine("enter number of train or 0 to stop: ");
                searchNum = int.Parse(Console.ReadLine());
            }
        }
    }
    
}
