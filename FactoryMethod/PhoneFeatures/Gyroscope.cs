using System;

namespace DPLab.FactoryMethod
{
    public class Gyroscope : Feature
    {
        public override void Name()
        {
            Console.WriteLine("Gyroscope");
        }
    }
}
