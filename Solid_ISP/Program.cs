using System;

namespace Solid_ISP
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
        string Text { get; set; }
        string Subject { get; set; }
        string ToAddress { get; set; }
        string FromAddress { get; set; }
    }

    //interface IMessage
    //{
    //    void Send();
    //    string Text { get; set; }
    //    string ToAddress { get; set; }
    //    string Subject { get; set; }
    //    string FromAddress { get; set; }

    //    byte[] Voice { get; set; }
    //}

    class EmailMessage : IMessage
    {
        public string Subject { get; set; }
        public string Text { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }

        public void Send()
        {
            Console.WriteLine("Send to Email massage: {0}", Text);
        }
    }

    class SmsMessage : IMessage
    {
        public string Text { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }

        public string Subject
        {
            get { throw new NotImplementedException(); }

            set { throw new NotImplementedException(); }
        }

        public void Send()
        {
            Console.WriteLine("Send to SMS massage: {0}", Text);
        }
    }

    class VoiceMessage : IMessage
    {
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }
        public byte[] Voice { get; set; }

        public string Text
        {
            get { throw new NotImplementedException(); }

            set { throw new NotImplementedException(); }
        }

        public string Subject
        {
            get { throw new NotImplementedException(); }

            set { throw new NotImplementedException(); }
        }

        public void Send()
        {
            Console.WriteLine("Send voice massage");
        }
    }
}
