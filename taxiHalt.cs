using System;
using System.Text;
using System.Collections.Generic;

namespace TaxiStop
{
    class Person
    {
        public int TimeEnter { get; set; }
        public int TimeLeave { get; set; }

        public Person(int timeEnter)
        {
            TimeEnter = timeEnter;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random random = new Random();

            Queue<Person> peopleOnHalt = new Queue<Person>();
            List<Person> passengers = new List<Person>();
            int numberOfFreeSits;

            Console.WriteLine("Enter the middle hour (in seconds) show passengers : "); 
            int timeArrivalPassengers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the middle hour (in seconds), show buses : "); 
            int timeArrivalBuses = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < 17 * 60 * 60; i++)
            {
                    if (i % timeArrivalPassengers == 0)
                    {
                        peopleOnHalt.Enqueue(new Person(i));
                    }

                    if (i % timeArrivalBuses == 0)
                    {
                        numberOfFreeSits = random.Next(0, 28);
                        Console.WriteLine("Bus with sits: " + numberOfFreeSits);

                        while (numberOfFreeSits != 0 && peopleOnHalt.Count != 0)
                        {
                            Person person = peopleOnHalt.Dequeue();
                            person.TimeLeave = i;
                            passengers.Add(person);
                            numberOfFreeSits--;
                        }

                    }
                

                Console.WriteLine("Count of people on stop: " + peopleOnHalt.Count);
            }

            int timeOnHalt = 0;

            foreach (Person passenger in passengers)
            {
                timeOnHalt += passenger.TimeLeave - passenger.TimeEnter;
            }

            Console.WriteLine("Average hour spent on the bus: " + timeOnHalt / passengers.Count);
        }
    }
}