using PokemonApp.Core.Enums;
using Prism.Mvvm;

namespace PokemonApp.WildArea.Models
{
    class WildAreaEntity : BindableBase
    {
        private string name_;
        public string Name
        {
            get => this.name_;

            set => this.SetProperty(ref this.name_, value);
        }

        private int? probability_;
        public int? Probability
        {
            get => this.probability_;

            set => this.SetProperty(ref this.probability_, value);
        }

        private WildAreaEnum area_;
        public WildAreaEnum Area
        {
            get => this.area_;

            set => this.SetProperty(ref this.area_, value);
        }

        private Wether wether_;
        public Wether Wether
        {
            get => this.wether_;

            set => this.SetProperty(ref this.wether_, value);
        }

        public WildAreaEntity()
        {

        }
    }
}
