using System;

namespace Solid_ISP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    interface IMessage
    {
        void Send();
        string ToAddress { get; set; }
        string FromAddress { get; set; }
    }

    interface IVoiceMessage : IMessage
    {
        byte[] Voice { get; set; }
    }

    interface ITextMessage : IMessage
    {
        string Text { get; set; }
    }

    interface IEmailMessage : ITextMessage
    {
        string Subject { get; set; }
    }

    class VoiceMessage : IVoiceMessage
    {
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }

        public byte[] Voice { get; set; }
        public void Send()
        {
            Console.WriteLine("Send voice massage");
        }
    }

    class EmailMessage : IEmailMessage
    {
        public string Text { get; set; }
        public string Subject { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }

        public void Send()
        {
            Console.WriteLine("Send to Email : {0}", Text);
        }
    }

    class SmsMessage : ITextMessage
    {
        public string Text { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public void Send()
        {
            Console.WriteLine("Send to SMS massage: {0}", Text);
        }
    }
}
