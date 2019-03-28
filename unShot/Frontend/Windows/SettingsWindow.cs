using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace UnShot.Frontend.Windows
{
    class SettingsWindow : Window
    {
//        [UI] private Label _label1 = null;
//        [UI] private Button _button1 = null;

        public SettingsWindow() : this(new Builder("SettingsWindow.glade"))
        {
        }

        private SettingsWindow(Builder builder) : base(builder.GetObject("settingsWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }
    }
}