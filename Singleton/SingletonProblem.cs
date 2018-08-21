using System;

namespace DPLab{
    public sealed class Calculator{
        private static int i = 0;
        public Calculator()
        {
            ++i;
        }

        public void Launch()
        {
           Console.WriteLine($"Instance : {i}");
        }
    }
}