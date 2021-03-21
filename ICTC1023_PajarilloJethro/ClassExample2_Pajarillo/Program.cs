using System;

namespace ClassExample2_Pajarillo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car;
            car = new Car("Red");
            Console.WriteLine(car.Describe());
            car = new Car("Green");
            Console.WriteLine(car.Describe());
        }
    }
}
