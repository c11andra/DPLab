using System;

namespace DPLabMain
{
    public class BridgeDemo
    {
        internal static void Show()
        {
            ShowBridgeProblem();
            ShowBridgeSolution();
        }

        private static void ShowBridgeProblem()
        {
            Console.WriteLine("=====Showing Bridge Problem======");
            Console.WriteLine("EmailSender class directly implements Web service interface to send email");

            var emailWS = new DPLab.Bridge.Problem.EmailSender();
            emailWS.Send("my message");   


            Console.WriteLine("Another TPEmailSender class directly implements third party interface to send email");
            var emailTp = new DPLab.Bridge.Problem.TPEmailSender();
            emailTp.Send("my message");   


        }

        private static void ShowBridgeSolution()
        {
             Console.WriteLine("=====Showing Bridge Pattern======");
            var webSP = new DPLab.Bridge.Solution.ServiceProviderWeb();
            var tpSP = new DPLab.Bridge.Solution.ServiceProviderThirdParty();

            var emailWS = new DPLab.Bridge.Solution.EmailSender(webSP);
            emailWS.Send("My New Message 1");


            var emailTp = new DPLab.Bridge.Solution.EmailSender(tpSP);
            emailTp.Send("My New Message 2");
        }
    }
}
