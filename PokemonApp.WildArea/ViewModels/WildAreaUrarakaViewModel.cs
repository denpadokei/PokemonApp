using PokemonApp.Core.Bases;
using PokemonApp.WildArea.Models;

namespace PokemonApp.WildArea.ViewModels
{
    public class WildAreaUrarakaViewModel : BaseWindowViewModel
    {
        private string text_;
        public string Text
        {
            get => this.text_;

            set => this.SetProperty(ref this.text_, value);
        }

        private readonly WildAreaDomain domain_;

        public WildAreaUrarakaViewModel()
        {
            this.domain_ = new WildAreaDomain();
            this.Text = nameof(WildAreaUrarakaViewModel);
        }
    }
}
