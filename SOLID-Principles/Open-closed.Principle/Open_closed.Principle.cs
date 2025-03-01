using System;

namespace SOLID_Principles.Open_closed.Principle
{
    //public class Open_closed { }

    //public class NotificationService
    //{
    //    public void SendNotification(string type, string message)
    //    {
    //        if (type == "Email")
    //        {
    //            Console.WriteLine("Email gönderildi: " + message);
    //        }
    //        else if (type == "SMS")
    //        {
    //            Console.WriteLine("SMS gönderildi: " + message);
    //        }
    //    }
    //}



    ////////////////////////////
    public interface INotification
    {
        void Send(string message);
    }

    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }
    }

    public class SMSNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("SMS sent: " + message);
        }
    }

    public class NotificationService
    {
        public void SendNotification(INotification notification, string message)
        {
            notification.Send(message);
        }
    }

    class Program
    {
        static void Main()
        {
            NotificationService service = new NotificationService();

            INotification email = new EmailNotification();
            INotification sms = new SMSNotification();

            service.SendNotification(email, "Welcome");
            service.SendNotification(sms, "1234");
        }
    }


}
