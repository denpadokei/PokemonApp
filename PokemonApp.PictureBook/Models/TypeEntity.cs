using Prism.Mvvm;

namespace PokemonApp.PictureBook.Models
{
    public class TypeEntity : BindableBase
    {
        /// <summary>タイプ名 を取得、設定</summary>
        private string name_;
        /// <summary>タイプ名 を取得、設定</summary>
        public string Name
        {
            get => this.name_;

            set => this.SetProperty(ref this.name_, value);
        }

        public TypeEntity()
        {

        }
    }
}
