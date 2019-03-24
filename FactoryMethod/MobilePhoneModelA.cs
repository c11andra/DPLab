using System;

namespace DPLab.FactoryMethod
{
    public class MobilePhoneModelA : MobilePhone
    {
        protected override void CreateFeature()
        {
            this.Features.Add(new Gyroscope());
        }
    }
}
