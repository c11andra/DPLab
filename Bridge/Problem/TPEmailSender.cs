using System;

namespace DPLab.Bridge.Problem
{
    public class TPEmailSender : IThirdPartySender
    {
        public void Send(string message)
        {
            Console.WriteLine($"From Third Party implementation, sending email: {message}");
        }
    }
}
