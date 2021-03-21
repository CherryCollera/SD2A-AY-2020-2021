using System;

namespace BasicOperation
{
    class Program
    {

        static void Main(string[] args)
        {
          
            Sum theSum = new Sum();
            theSum.Compute();
            Difference theDiff = new Difference();
            theDiff.Compute();
            Product theProd = new Product();
            theProd.Compute();
            Quotient theQuo = new Quotient();
            theQuo.Compute();
            Remainder theMod = new Remainder();
            theMod.Compute();

        }

    }
}
