using AllameDehkhoda.Application.Common;
using AllameDehkhoda.Application.Extentions;
using AllameDehkhoda.Infrastructure.Extentions;
using Microsoft.Extensions.DependencyInjection;

namespace AllameDehkhoda.Presentation
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
            var service = new ServiceCollection();
            service.AddApplicationDependencyInjection();
            service.AddInfrastructureDependencyInjection();
            service.AddScoped<FrmMain>();
            service.AddScoped<FrmBook>();
            service.AddScoped<FrmMember>();
            service.AddScoped<FrmBorrow>();
            service.AddScoped<FrmReport>();

            var serviceprovider = service.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(serviceprovider.GetRequiredService<FrmMain>());
        }
    }
}