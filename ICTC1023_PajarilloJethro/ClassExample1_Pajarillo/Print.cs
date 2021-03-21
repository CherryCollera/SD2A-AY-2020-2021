using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExample1_Pajarillo
{
    class Print
    {
        public void PrintDetails()
        {
            Accept acpt = new Accept();
            acpt.AcceptDetails();
            Console.Write("Hello " + acpt.firstName + " " + acpt.lastName + "!!!\nYou have created classes in OOP");
            MyProfile1 mp = new MyProfile1();
            mp.DisplayProfile();
        }
      
    }
}
