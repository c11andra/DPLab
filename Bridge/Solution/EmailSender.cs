using System;

namespace DPLab.Bridge.Solution
{
    public class EmailSender : Sender
    {
        public EmailSender(IServiceProviderBridge serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            type = "Email";
        }
    }
}
