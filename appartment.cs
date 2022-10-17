using System;
using System.Collections.Generic;
using System.Text;

namespace Appartment
{
    class Appartment
    {
        public readonly uint Floors;

        public Flat[] flats;

        public Appartment(uint countOfFloors, uint countOfFlats)
        {
            Floors = countOfFloors;
            flats = new Flat[countOfFlats];

            for (int i = 0; i < flats.Length; i++)
            {
                flats[i] = new Flat(2);
            }
        }
    }

    class Flat
    {
        public List<Human> humans;
        public Room[] rooms;

        public Flat(uint countOfRoom)
        {
            humans = new List<Human>();
            rooms = new Room[countOfRoom];

            for (int i = 0; i < rooms.Length; i++)
            {
                rooms[i] = new Room(2, 3, 3);
            }
        }

        public void AddHuman(Human human)
        {
            humans.Add(human);
            Console.WriteLine($"{human.Name} moved into the apartment");
        }

        public void Banish(string name)
        {
            for (int i = 0; i < humans.Count; i++)
            {
                if (humans[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    humans.RemoveAt(i);
                    Console.WriteLine($"{humans[i].Name} leaving the apartment");
                }
                else
                {
                    Console.WriteLine("In the apartment of a non-resident with such a name");
                }
            }
        }

        public void Habitant()
        {
            for (int i = 0; i < humans.Count; i++)
            {
                Console.WriteLine($"{humans[i].Name}\n");
            }
        }
    }

    class Room
    {
        public readonly uint Length;
        public readonly uint Height;
        public readonly uint Width;

        public Room(uint length, uint height, uint width)
        {
            Length = length;
            Height = height;
            Width = width;
        }

        public uint GetArea()
        {
            return Length * Height * Width;
        }
    }

    class Human
    {
        public string Name { get; set; }
        public uint Age { get; set; }
        public string Gender { get; set; }

        public Human(string name, uint age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}\nGender: {Gender}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Appartment building = new Appartment(9, 27);
            Console.WriteLine(building.flats[0].rooms[0].Height);

        }
    }
}