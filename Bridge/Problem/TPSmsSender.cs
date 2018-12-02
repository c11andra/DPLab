using System;

namespace DPLab.Bridge.Problem
{
    public class TPSmsSender:IThirdPartySender
    {
        public void Send(string message)
        {
            Console.WriteLine($"From Third Party Service Implemenation, sending Sms : {message}");
        }
    }
}
