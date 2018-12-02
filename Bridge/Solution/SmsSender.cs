using System;

namespace DPLab.Bridge.Solution
{
    public class SmsSender : Sender
    {
        public SmsSender(IServiceProviderBridge serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            type = "Email";
        }
    }
}
