using MahApps.Metro.Controls;
using Prism.Services.Dialogs;
using System;

namespace PokemonApp.Core.Dialogs
{
    /// <summary>
    /// Interaction logic for TabWindow.xaml
    /// </summary>
    public partial class TabWindow : MetroWindow, IDialogWindow
    {

        public TabWindow()
        {
            this.InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (this.DataContext is IDisposable context) {
                context.Dispose();
            }
        }

        public IDialogResult Result { get; set; }
    }
}
