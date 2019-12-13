using Dragablz;
using MahApps.Metro.Controls;
using PokemonApp.Core.ViewModels;
using Prism.Events;
using Prism.Services.Dialogs;
using System.Windows;
using Unity;

namespace PokemonApp.Core.Views
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
