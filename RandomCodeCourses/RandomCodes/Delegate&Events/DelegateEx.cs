using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RandomCodes.Delegate_Events.DelegateEx;

namespace RandomCodes.Delegate_Events
{
    public class DelegateEx
    {
        public delegate void DelegateMessageSender(string message);

        public event DelegateMessageSender MessageSending;

        public void Send()
        {
            Console.WriteLine("sending");
            MessageSending.Invoke("calling methods");
        }
    }

    public static class MessageSender
    {
        public static void DoStuff()
        {
            DelegateEx delegateEx = new DelegateEx();
            delegateEx.MessageSending += SendMessage1; 
            delegateEx.MessageSending += SendMessage2;
            delegateEx.Send();
        }

        static void SendMessage1(string message = "first")
        {
            Console.WriteLine($"sending message {message}");
        }
        static void SendMessage2(string message = "second")
        {
            Console.WriteLine($"sending message {message}");
        }

    }
}
