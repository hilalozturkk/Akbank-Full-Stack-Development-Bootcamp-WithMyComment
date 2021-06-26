using System;

namespace DependencyInversionPrinciple
{
    //Large systems should not depend on small systems, small systems should depend on large ones.
    public class Program
    {
        static void Main(string[] args)
        {
            Report report = new Report(new MailSender());
            report.Send();
            Report wsReport = new Report(new WhatsappSender());
            wsReport.Send();
        }
    }

    public class Report
    {
        // private MailSender sender;
        private ISender sender;
        public Report(ISender sender)
        {
            this.sender = sender;
        }

        public void Send()
        {

            //MailSender mailSender = new MailSender();
            //mailSender.Send();
            sender.Send();
        }
    }

    public interface ISender
    {
        void Send();
    }

    public class MailSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Email gone");
        }
    }

    public class WhatsappSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Whatsapp gone");
        }
    }

}
