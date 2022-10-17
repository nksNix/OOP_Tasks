using System;

namespace Overcoat
{
    enum Size
    {
        XS, M, L, XL, XXL
    }

    class Overcoat
    {
        public uint cost { get; set; }
        public string color { get; set; }
        public Size size { get; set; }

        public Overcoat(uint price, string color, Size size)
        {
            this.cost = price;
            this.color = color;
            this.size = size;
        }

        public override bool Equals(object obj)
        {
            bool eq = false;
            if (obj is Overcoat overcoat)
            {
                if (color.Equals(overcoat.color) && cost.Equals(overcoat.cost) && size.Equals(overcoat.size))
                {
                    eq = true;
                }
            }
            return eq;
        }


        public static bool operator >(Overcoat overcoat1, Overcoat overcoat2)
        {
            bool eq = false;
            if (overcoat1.cost > overcoat2.cost)
            {
                eq = true;
            }
            return eq;
        }

        public static bool operator <(Overcoat overcoat1, Overcoat overcoat2)
        {
            bool eq = false;
            if (overcoat1.cost < overcoat2.cost)
            {
                eq = true;
            }
            return eq;
        }

        public static bool operator <=(Overcoat overcoat1, Overcoat overcoat2)
        {
            bool eq = false;
            if (overcoat1.cost <= overcoat2.cost)
            {
                eq = true;
            }
            return eq;
        }

        public static bool operator >=(Overcoat overcoat1, Overcoat overcoat2)
        {
            bool eq = false;
            if (overcoat1.cost >= overcoat2.cost)
            {
                eq = true;
            }
            return eq;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Overcoat overcoat = new Overcoat(12, "Purple", Size.XS);
            Overcoat overcoat1 = new Overcoat(12, "Brown", Size.L);
            Console.WriteLine(overcoat > overcoat1);
        }
    }
}