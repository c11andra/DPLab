using System;

namespace DPLab.Bridge.Problem
{
    public class SmsSender:IWebServiceSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"From WebService implemenation, sending Sms : {message}");
        }
    }
}
