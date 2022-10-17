using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    public enum Priority
    {
        High = 2,
        Middle = 1,
        Low = 0
    }

    class Client
    {
        public string Name { get; set; }
        public Priority priority { get; set; }

        public static int Counter { get; private set; }

        public Client()
        {
            Counter++;
        }


        public Client(string name)
        {
            Name = name;
            AddPriority();
        }

        private void AddPriority()
        {
            Random random = new Random();
            priority = (Priority)random.Next(1, 4);
        }
    }

    class Program
    {
        static Queue<Client>[] queue = new Queue<Client>[]
        {
            new Queue<Client>(),
            new Queue<Client>(),
            new Queue<Client>(),
        };

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int choice = 0;

            do
            {
                try
                {
                    Console.WriteLine("Choose an operation: \n1.Add user \n2.Show statistics");
                    choice = Convert.ToInt32(Console.ReadLine());
                    choice--;
                    Action[] actions = new Action[] {AddClient, ShowStatistic };

                    actions[choice]?.Invoke();
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("\n------Incorrect operation selected. Please try again------\n");
                }


            }
            while (choice != 2);
        }

        public static void AddClient()
        {
            Console.WriteLine("Enter username: ");
            string name = Console.ReadLine();

            Client client = new Client(name);

            queue[(int)client.priority].Enqueue(client);
        }

        public static void ShowStatistic()
        {
            Client client;

            for(int i = 0; i<queue.Length; i++)
            {
                while(queue[i].Count != 0)
                {
                    client = queue[i].Dequeue();
                    Console.WriteLine("The printer is busy for " + client.Name + " " + DateTime.Now);
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
    }
}