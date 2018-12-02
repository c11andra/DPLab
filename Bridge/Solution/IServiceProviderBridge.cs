using System;

namespace DPLab.Bridge.Solution
{
    public interface IServiceProviderBridge
    {
        string Name{get;}
        void Send(string type, string message);
    }
}
