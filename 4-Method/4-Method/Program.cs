using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace _4_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = int.Parse("abc");
            }
            catch (Exception)
            {
                Console.WriteLine("Conversation fall");
            }
            int num = 0;
            var re = int.TryParse("abc", out num);
            if (re)
                Console.WriteLine(num);

            else
                Console.WriteLine("Conversation fall");
        }
        static void UseParams()
        {
            var calaulator = new Calculator();
            Console.WriteLine(calaulator.Add(1, 2));
            Console.WriteLine(calaulator.Add(1, 2, 3));
            Console.WriteLine(new int[] { 1, 2, 3, 4 });

        }
        static void UsePoint()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is ({0},{1})", point.x, point.y);

                point.Move(100, 200);
                Console.WriteLine("Point is ({0},{1})", point.x, point.y);
            }
            catch (Exception)
            {
                Console.WriteLine("error");

            }
        }
    }
}
