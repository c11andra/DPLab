using System;

namespace DPLabMain
{
    public class SingletonDemo{
        public static void Show()
        {

            TestSingletonProblem();
            TestSingletonSolution();
        }

        private static void TestSingletonProblem()
        {
            Console.WriteLine("=====Showing Singleton Problem=====");
            ///Problem : New instances of calculator are generated for every new call
            var calc1 = new DPLab.Singleton.Problem.Calculator();
            Console.WriteLine("1st instance creation");
            calc1.Launch();

            Console.WriteLine("2nd instance creation");
            var calc2 = new DPLab.Singleton.Problem.Calculator();
            calc2.Launch();


            if (ReferenceEquals(calc1, calc2))
            {
                Console.WriteLine("Same Instance");
            }
            else
            {
                Console.WriteLine("Different Instances");
            }
        }

        private static void TestSingletonSolution()
        {
            Console.WriteLine("=====Showing Singleton Solution=====");
            Console.WriteLine("2nd instance creation");
            var calc1 = DPLab.Singleton.Solution.Calculator.Instance();
            calc1.Launch();

            Console.WriteLine("2nd instance creation");
            var calc2 = DPLab.Singleton.Solution.Calculator.Instance();
            calc2.Launch();

            if (calc1 == calc2)
            {
                Console.WriteLine("Same Instance");
            }
             else
            {
                Console.WriteLine("Different Instances");
            }
        }
    }
}
