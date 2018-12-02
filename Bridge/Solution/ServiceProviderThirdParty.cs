using System;

namespace DPLab.Bridge.Solution
{
    public class ServiceProviderThirdParty: IServiceProviderBridge
    {
        public void Send(string type, string message)
        {
            Console.WriteLine($"Sending {type} with message {message} via. {Name}");
        }
        public string Name => "Third Party";
    }
}
