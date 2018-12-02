using System;

namespace DPLab.Singleton.Solution
{
    public sealed class Calculator{
        private static int instanceCount = 0;
        private Calculator()
        {
            ++instanceCount;
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
           Console.WriteLine($"Instance : {instanceCount}");
        }
    }
}