using MahApps.Metro.Controls;
using Prism.Services.Dialogs;

namespace PokemonApp.Core.Dialogs
{
    /// <summary>
    /// Interaction logic for TabWindow.xaml
    /// </summary>
    public partial class TabWindow : MetroWindow, IDialogWindow
    {

        public TabWindow()
        {
            InitializeComponent();
        }

        public IDialogResult Result { get; set; }
    }
}
