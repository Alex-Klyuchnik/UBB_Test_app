using System;
using System.ServiceProcess;

namespace ServerServiceApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static void Main()
        {
            if (!Environment.UserInteractive)
            {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                                    {
                                        new ServerService()
                                    };
                ServiceBase.Run(ServicesToRun);
            }
            else
            {
                Starter starter = new Starter();
                starter.Start();
            }
        }
    }
}
