using System;
using System.Windows.Forms;
using Game.Services;
using Game.Services.SignalR;
using Microsoft.AspNetCore.SignalR.Client;

namespace Game
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
