using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Windows.Forms;
using Game.Services;

namespace Game.Views
{
    public static class Program
    {
        private const string ConnectionUrl = "http://localhost:5000/msihub";

        [STAThread]
        private static void Main()
        {
            var connection = new HubConnectionBuilder()
                .WithUrl(ConnectionUrl)
                .Build();

            var root = new CompositionRoot(
                new SignalRService(connection),
                new HeroFactory()
            );

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(root.MainForm);
        }
    }
}
