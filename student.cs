using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace oop_3
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Number { get; set; }

        public Student() {
            }

        public Student(string name, int age, string sex, string number)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Number = number;
        }

        List<Student> students = new List<Student>();

        public void Info() {
            

            Console.WriteLine("Enter your name :");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your age :");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your sex :");
            string sex = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your number :");
            string number = Convert.ToString(Console.ReadLine());

            students.Add(new Student(name, age, sex, number));

            foreach(var i in students)
            {
                Console.WriteLine("\n" + "Your name : " + i.Name);
                Console.WriteLine("\n" + "Your age : " + i.Age);
                Console.WriteLine("\n" + "Your sex : " + i.Sex);
                Console.WriteLine("\n" + "Your number : " + i.Number);
                Console.ReadKey();

            }

        }
    }

}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3
{
    class Program
    {
        static void Main(string[] args)

        {
            Student student = new Student();
            student.Info();
        }
    }
}
