using System;
using GLib;
using UnShot.Frontend.Windows;

namespace UnShot
{
    public class App : Gtk.Application
    {
        public const string AppId = "de.marcusw.unshot";

        public const string ScreenshotAllActionName = "screenshot-all";
        public const string ScreenshotWindowActionName = "screenshot-window";
        public const string ScreenshotSelectionActionName = "screenshot-selection";

        public App() : base(AppId, ApplicationFlags.None) { }

        protected override void OnStartup()
        {
            base.OnStartup();

            AddActions();

            // commandline...
        }

        protected override void OnActivated()
        {
            base.OnActivated();

            var settingsWindow = new SettingsWindow();
            AddWindow(settingsWindow);

            settingsWindow.Show();
        }

        private void AddActions()
        {
            var screenshotAllAction = new SimpleAction(ScreenshotAllActionName, null);
            screenshotAllAction.Activated += OnScreenshotAllActionActivated;
            AddAction(screenshotAllAction);

            var screenshotWindowAction = new SimpleAction(ScreenshotWindowActionName, null);
            screenshotWindowAction.Activated += OnScreenshotWindowActionActivated;
            AddAction(screenshotWindowAction);

            var screenshotSelectionAction = new SimpleAction(ScreenshotSelectionActionName, null);
            screenshotSelectionAction.Activated += OnScreenshotSelectionActionActivated;
            AddAction(screenshotSelectionAction);
        }

        private void OnScreenshotAllActionActivated(object o, ActivatedArgs args)
        {
            throw new NotImplementedException();
        }

        private void OnScreenshotWindowActionActivated(object o, ActivatedArgs args)
        {
            throw new NotImplementedException();
        }

        private void OnScreenshotSelectionActionActivated(object o, ActivatedArgs args)
        {
            throw new NotImplementedException();
        }

        [STAThread]
        public static int Main(string[] args)
        {
            // Initialisation
            Init();

            // Create application
            var app = new App();

            // Try to register the application on DBus and detect, if this is a primary instance
            app.Register(Cancellable.Current);

            // Run the application
            return app.Run(AppId, args);
        }
    }
}
