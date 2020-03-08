using Prism.Mvvm;

namespace PokemonApp.AbilityValueConverter.Models
{
    public class IndividualEntity : BindableBase
    {
        /// <summary>項目名 を取得、設定</summary>
        private string name_;
        /// <summary>項目名 を取得、設定</summary>
        public string Name
        {
            get => this.name_;

            set => this.SetProperty(ref this.name_, value);
        }

        /// <summary>値 を取得、設定</summary>
        private int? value_;
        /// <summary>値 を取得、設定</summary>
        public int? Value
        {
            get => this.value_;

            set => this.SetProperty(ref this.value_, value);
        }

        public IndividualEntity(string name = "", int? value = null)
        {

        }
    }
}
