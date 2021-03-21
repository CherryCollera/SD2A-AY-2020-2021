using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExample2_Pajarillo
{
    class Car
    {
        public string color;
        public Car(string color)
        {
            this.color = color;
        }
        public string Describe()
        {
            return "This car is " + color;
        }
    }
}
