using System;

namespace index
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HittpCookie();
            cookie["name"] = "Por";
            Console.WriteLine(cookie["name"]);

        }
    }
}
