/* 19-01073 
 * Torreverde, Leonard Bryan C.
 * 
 * 19-00735
 * Sioco, John Kyle D.
 * 
 * SD2A
 * March 2, 2021
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2_MyProfile
{   
    class Person
    {   
        //Fields
        private string name;
        private string bday;
        private string course;
        private string year;
        private string sect;


        //All the getter and setter methods
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Bday
        {
            get { return bday; }
            set { bday = value; }
        }

        public string Course
        {
            get { return course; }
            set { course = value; }
        }

        public string Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Sect
        {
            get { return sect; }
            set { sect = value; }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {   
            
            Person obj = new Person(); //Object creation for the Person class

            /*
             * Basically all the console interface including (in-order):
             *          --setter method for the fields
             *          --Reading user input for the fields' getters
             *          
             */

            Console.Write("Name: ");
            obj.Name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Date of Birth: ");
            obj.Bday = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Course: ");
            obj.Course = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Year: ");
            obj.Year = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Section: ");
            obj.Year = Console.ReadLine();
            Console.WriteLine();

            Console.ReadKey();


        }
    }
}
