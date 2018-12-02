using System;

namespace DPLab.Bridge.Solution
{
    public class ServiceProviderWeb: IServiceProviderBridge
    {
        public void Send(string type, string message)
        {
            Console.WriteLine($"Sending {type} with message {message} via. {Name}");
        }
        public string Name => "Web Service";
    }
}
