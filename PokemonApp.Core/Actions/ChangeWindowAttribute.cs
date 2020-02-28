using Microsoft.Xaml.Behaviors;
using System.Windows;
using System.Windows.Shell;

namespace PokemonApp.Core.Actions
{
    public class ChangeWindowAttribute : TriggerAction<DependencyObject>
    {
        public bool? IsRemoveOwner { get; set; } = false;
        public string Title { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public WindowChrome Chrome { get; set; }
        protected override void Invoke(object parameter)
        {
            try {
                var window = Window.GetWindow(this.AssociatedObject);
                if (this.IsRemoveOwner != null && this.IsRemoveOwner == true) {
                    window.Owner = null;
                }
                if (this.Title != null) {
                    window.Title = this.Title;
                }
                if (this.Width != null) {
                    window.Width = (double)this.Width;
                }
                if (this.Height != null) {
                    window.Height = (double)this.Height;
                }
                if (this.Chrome != null) {
                    WindowChrome.SetWindowChrome(window, this.Chrome);
                }
            }
            catch { }
        }
    }
}
