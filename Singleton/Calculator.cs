using System;

namespace DPLab{
    public sealed class Calculator{
        private static int i = 0;
        private Calculator()
        {
            ++i;
        }

        private static Calculator instance;
        public static Calculator Instance()
        {
            if(instance == null)
            {
                instance = new Calculator();
            }
            return instance;
        }

        public void Launch()
        {
           Console.WriteLine($"Instance : {i}");
        }
    }
}