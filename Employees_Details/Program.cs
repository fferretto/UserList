
using Service_API.Interface.Common;
using Service_API.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleInjector;
using Employees_Details.Pages;

namespace Employees_Details
{
    static class Program
    {
        private static Container container;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConfigureServices();

            Application.Run(container.GetInstance<MDIMain>());

        }
        public static void ConfigureServices()
        {
            container = new Container();

            container.Register<IApiClient, ApiClientBase>(Lifestyle.Singleton);
            container.Register<MDIMain>(Lifestyle.Singleton);

            // Optionally verify the container.
            container.Verify();
        }
    }
}
