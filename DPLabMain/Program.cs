using System;
using DPLab;
namespace DPLabMain
{
    class Program
    {
        static void Main(string[] args)
        {

            TestSingleton();
            
        }

        private static void TestSingleton()
        {
            Console.WriteLine($"Problem - Everytime a new instance is launched when I need only 1 instance");
            SingletonProblem();

            Console.WriteLine($"Singleton - Everytime a single instance is launched");
            SingletonSolution();
        }

        private static void SingletonProblem()
        {
            var calc1 = new Calculator();
            calc1.Launch(); 

            var calc2 = new Calculator();
            calc2.Launch(); 
        }

        private static void SingletonSolution()
        {
            var calc1 = SCalculator.Instance();
            calc1.Launch();


            var calc2 = SCalculator.Instance();
            calc2.Launch();

            if (calc1 == calc2)
            {
                Console.WriteLine("Same Instance");
            }
        }
    }
}
