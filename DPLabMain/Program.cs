using System;
using DPLab;
namespace DPLabMain
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc1 = Calculator.Instance();
            calc1.Launch();


            var calc2 = Calculator.Instance();
            calc2.Launch();

            if(calc1 == calc2)
            {
                Console.WriteLine("Same Instance");
            }
        }
    }
}
