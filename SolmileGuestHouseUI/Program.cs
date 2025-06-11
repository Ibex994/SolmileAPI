using Solmile.Forms;
using Solmile.Interface;
using Solmile.Service;
using Solmile;

namespace SharedModel
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            IUserService userService = new UserService();
            Application.Run(new SplashScreen());
            Application.Run(new Login(userService));
            //Application.Run(new ReceptionForm());
        }
    }
}