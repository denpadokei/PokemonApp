using System.Windows;
using System.Windows.Controls;

namespace PokemonApp.Style.Controls
{
    public class LoadingPanel : UserControl
    {
        public LoadingPanel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LoadingPanel), new FrameworkPropertyMetadata(typeof(LoadingPanel)));
        }
    }
}
