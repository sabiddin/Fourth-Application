using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetGreeting() + " " + PersonToBeGreeted());
            Console.Read();
        }
        public static string GetGreeting() => "Good Morning";
        public static string PersonToBeGreeted() => "Syed";

    }
}
