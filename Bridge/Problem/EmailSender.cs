using System;

namespace DPLab.Bridge.Problem
{
    public class EmailSender : IWebServiceSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"From WebService implementation, sending email : {message}");
        }
    }
}
