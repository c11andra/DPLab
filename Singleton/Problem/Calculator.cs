using System;

namespace DPLab.Singleton.Problem
{
    public class Calculator
    {
        public Calculator()
        {
            ++instanceCount;
        }
        private static int instanceCount ;
        public void Launch()
        {
           Console.WriteLine($"Instance : {instanceCount}");
        }
    }
}
