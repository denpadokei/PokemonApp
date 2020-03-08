using Prism.Mvvm;

namespace PokemonApp.PictureBook.Models
{
    public class CharacteristicEntity : BindableBase
    {
        /// <summary>特性の名前 を取得、設定</summary>
        private string name_;
        /// <summary>特性の名前 を取得、設定</summary>
        public string Name
        {
            get => this.name_;

            set => this.SetProperty(ref this.name_, value);
        }

        /// <summary>特性の説明 を取得、設定</summary>
        private string deteal_;
        /// <summary>特性の説明 を取得、設定</summary>
        public string Deteal
        {
            get => this.deteal_;

            set => this.SetProperty(ref this.deteal_, value);
        }
    }
}
