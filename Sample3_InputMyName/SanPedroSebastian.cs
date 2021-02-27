using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample3_InputMyName
{
    class SanPedroSebastian
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name (firstname lastname): ");
            string Name = Console.ReadLine();

            Console.WriteLine("\n Hello " + Name + "!!!");
            Console.WriteLine(" Welcome to OOP environment.");
        }
    }
}
