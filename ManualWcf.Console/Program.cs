namespace ManualWcf.Console
{
    using System;
    using System.ServiceModel;
    using ManualWcf.Service;

    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceHost = new ServiceHost(typeof (UserManagingService));
            serviceHost.Open();
            Console.WriteLine("UserManagingService listening... Press any key to stop.");
            Console.ReadLine();
        }
    }
}
