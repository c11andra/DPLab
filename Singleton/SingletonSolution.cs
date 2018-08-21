using System;

namespace DPLab{
    public sealed class SCalculator{
        private static int i = 0;
        private SCalculator()
        {
            ++i;
        }

        private static SCalculator instance;
        public static SCalculator Instance()
        {
            if(instance == null)
            {
                instance = new SCalculator();
            }
            return instance;
        }

        public void Launch()
        {
           Console.WriteLine($"Instance : {i}");
        }
    }
}