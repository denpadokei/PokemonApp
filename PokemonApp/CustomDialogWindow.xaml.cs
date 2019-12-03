using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
        }
        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            this.Owner = null;
        }

        public IDialogResult Result { get; set; }
    }
}
