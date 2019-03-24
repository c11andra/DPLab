using System;
using DPLab.FactoryMethod;

namespace DPLabMain
{
    public class FactoryMethodDemo
    {
        internal static void Show()
        {
            var modelA = new MobilePhoneModelA();
            var modelB = new MobilePhoneModelB();
            Console.WriteLine("Model A Features");
            foreach (var feature in modelA.Features)
            {
                feature.Name();
            }

            Console.WriteLine("Model B Features");
             foreach (var feature in modelB.Features)
            {
                feature.Name();
            }
            
        }
    }
}
