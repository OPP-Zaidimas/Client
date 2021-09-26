using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Windows.Forms;

namespace Game.Views
{
    public static class Program
    {
        [STAThread]
        private static void Main()
        {
            HubConnection connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/msihub")
                .Build();


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameWindow(new Services.SignalRService(connection)));
        }
    }
}
