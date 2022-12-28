using Microsoft.Extensions.Configuration;
using System.Runtime.InteropServices;

namespace DenonSpeakerSelect
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static int Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", true, false);
            builder.AddEnvironmentVariables();
            if (args != null)
                builder.AddCommandLine(args);
            Configuration = builder.Build();
            Configuration.Bind(Settings);
            if (Settings.DenonIPAddress == null)
            {
                MessageBox.Show("Please specify the IP address of your Denon receiver in appsettings.json ('DenonIPAddress')");
                return 1;
            }
            Application.Run(new Form1());
            return 0;
        }

        public static IConfiguration Configuration { get; set; } = null!;

        public static Settings Settings { get; set; } = new();
    }
}