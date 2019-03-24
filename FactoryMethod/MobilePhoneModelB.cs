using System;

namespace DPLab.FactoryMethod
{
    public class MobilePhoneModelB : MobilePhone
    {
        protected override void CreateFeature()
        {
            this.Features.Add(new FrontCameraFlash());
            this.Features.Add(new ProximitySensor());
        }
    }
}
