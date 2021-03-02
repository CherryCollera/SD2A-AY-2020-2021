using System;


namespace Sample3_InputMyName
{
    class Person
    {
        private string Fullname;

        //Method for getter and setter
        public string FullName
        {
            get { return Fullname; }
            set { Fullname = value; }
        }

        //Welcome message
        public void Welcome()
        {
            Console.WriteLine("\n Hello " + FullName + "!!!\n Welcome to OOP environment");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //object creation for the Person class
            Person obj = new Person();

            Console.Write("Enter your name (firstname lastname)");

            //Reading user input as value for the setter method
            obj.FullName = Console.ReadLine();

            obj.Welcome();

            Console.ReadKey();



        }
    }
}
