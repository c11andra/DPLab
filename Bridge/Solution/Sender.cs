using System;

namespace DPLab.Bridge.Solution
{
    public abstract class Sender
    {
        protected string type;
        protected IServiceProviderBridge serviceProvider;
        public virtual void Send(string message)
        {
            Console.WriteLine($"I'm sender abstract class, I'm sending via. serviceProvider abstract to me ");
            serviceProvider.Send(type, message);
        }
    }
}
