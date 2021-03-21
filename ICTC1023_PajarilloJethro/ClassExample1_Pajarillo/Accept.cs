using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExample1_Pajarillo
{
    class Accept
    {
        public string firstName, lastName;
        
        public void AcceptDetails()
        {
            Console.WriteLine("Enter your First Name and Last Name:   ");
            firstName = Console.ReadLine();
            lastName = Console.ReadLine();

        }
    }
}
