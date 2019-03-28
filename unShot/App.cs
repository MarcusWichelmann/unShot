using System;
using GLib;
using UnShot.Frontend.Windows;

namespace UnShot
{
    public class App : Gtk.Application
    {
        public const string AppId = "de.marcusw.unshot";

        public App() : base(AppId, ApplicationFlags.None)
        {
        }

        protected override void OnStartup()
        {
            base.OnStartup();
        }

        protected override void OnActivated()
        {
            base.OnActivated();

            var settingsWindow = new SettingsWindow();
            AddWindow(settingsWindow);

            settingsWindow.Show();
        }

        [STAThread]
        public static void Main(string[] args)
        {
            // Initialisation
            Init();

            // Create application
            var app = new App();

            // Try to register the application on DBus and detect, if this is a primary instance
            app.Register(Cancellable.Current);

            // Run the application
            ((Application) app).Run();
        }
    }
}