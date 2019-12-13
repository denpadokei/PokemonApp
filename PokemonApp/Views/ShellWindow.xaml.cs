using MahApps.Metro.Controls;
using System;
using System.Linq;
using System.Windows;

namespace PokemonApp.Views
{
    /// <summary>
    /// Interaction logic for ShellWindow.xaml
    /// </summary>
    public partial class ShellWindow : MetroWindow
    {
        public ShellWindow()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            var windows = Application.Current.Windows.OfType<Window>().Where(x => x != Application.Current.MainWindow);
            foreach (var window in windows) {
                window.Close();
            }
            base.OnClosed(e);
        }
    }
}
