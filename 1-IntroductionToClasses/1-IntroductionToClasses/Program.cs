using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_IntroductionToClasses
{
    public class Person
    {
        public string Name;
        public void Introduction(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
        public static Person Parse(string str)
        {
            var preson = new Person();
            preson.Name = str;

            return preson;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var person = Person.Parse("Por");

            
            person.Introduction("Tida");
            Console.ReadKey();
        }
    }
}
