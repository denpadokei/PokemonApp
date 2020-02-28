using Prism.Services.Dialogs;
using System.Windows;

namespace PokemonApp.Views
{
    /// <summary>
    /// CustomDialogWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class CustomDialogWindow : Window, IDialogWindow
    {
        public CustomDialogWindow()
        {
            InitializeComponent();
        }

        public IDialogResult Result { get; set; }
    }
}
