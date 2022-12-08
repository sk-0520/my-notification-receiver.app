using System;
using System.Windows.Forms;

namespace ContentTypeTextNet.MyNotificationReceiver.Main
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var notifyIcon = new System.Windows.Forms.NotifyIcon() {
                Visible = true,
            };
            Application.Run();
        }
    }
}
