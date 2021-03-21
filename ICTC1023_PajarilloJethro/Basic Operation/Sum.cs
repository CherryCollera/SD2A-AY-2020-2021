using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOperation
{
    class Sum
    {


        public void Compute()
        {

            Input input = new Input();
            input.InputValue();
            Console.WriteLine("Sum is {0}", DeclareVar.num1 + DeclareVar.num2);
        }
    }
}

