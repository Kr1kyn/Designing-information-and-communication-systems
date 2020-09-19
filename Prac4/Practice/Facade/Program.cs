using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var drive = new Drive();
            var power = new Power();
            var notification = new Notification();
            var microwave = new Microwave(drive, power, notification);

            power.powerevent += power_powerevent;
            drive.driveevent += drive_driveevent;
            notification.notificationevent += notification_notificationevent;

            Console.WriteLine("Разморозка");
            microwave.Defrost();

            Console.WriteLine("Приготовление блюда");
            microwave.CookDish();

        }

        static void notification_notificationevent(object sender, EventArgs e) 
        { 
            Notification n = (Notification)sender;
            Console.WriteLine(n.ToString());
        }
        static void drive_driveevent(object sender, EventArgs e) 
        { 
            Drive d = (Drive)sender;
            Console.WriteLine(d.ToString());
        }
        private static void power_powerevent(object sender, EventArgs e)
        { 
            Power p = (Power)sender;
            Console.WriteLine(p.ToString()); 
        }
    }
}
