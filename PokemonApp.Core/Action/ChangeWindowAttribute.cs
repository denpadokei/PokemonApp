using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;
using System.Windows.Shell;

namespace PokemonApp.Core.Action
{
    public class ChangeWindowAttribute : TriggerAction<UserControl>
    {
        public bool IsRemoveOwner { get; set; }
        public string Title { get; set; }
        public double? With { get; set; }
        public double? Height { get; set; }
        //public WindowChrome Chrome { get; set; }
        protected override void Invoke(object parameter)
        {
            var window = Application.Current.Windows.OfType<Window>().FirstOrDefault(x => x.IsActive);
            window.Title = this.Title;
            if (this.With != null) {
                window.Width = (double)this.With;
            }
            if (this.Height != null) {
                window.Height = (double)this.Height;
            }
            if (this.IsRemoveOwner) {
                window.Owner = null;
            }
            //if (this.Chrome != null) {
            //    WindowChrome.SetWindowChrome(window, this.Chrome);
            //}
        }
    }
}
