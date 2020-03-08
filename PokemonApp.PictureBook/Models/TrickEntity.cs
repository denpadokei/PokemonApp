using PokemonApp.Core.Enums;
using PokemonApp.Core.Extentions;
using PokemonApp.Core.Interfaces;
using Prism.Mvvm;

namespace PokemonApp.PictureBook.Models
{
    public class TrickEntity : BindableBase, IUpdatable
    {
        /// <summary>技ID を取得、設定</summary>
        private int trickId_;
        /// <summary>技ID を取得、設定</summary>
        public int TrickId
        {
            get => this.trickId_;

            set => this.SetProperty(ref this.trickId_, value);
        }

        /// <summary>技の名前 を取得、設定</summary>
        private string name_;
        /// <summary>技の名前 を取得、設定</summary>
        public string Name
        {
            get => this.name_;

            set => this.SetProperty(ref this.name_, value);
        }

        /// <summary>威力 を取得、設定</summary>
        private int? power_;
        /// <summary>威力 を取得、設定</summary>
        public int? Power
        {
            get => this.power_;

            set => this.SetProperty(ref this.power_, value);
        }

        /// <summary>命中率 を取得、設定</summary>
        private int? rate_;
        /// <summary>命中率 を取得、設定</summary>
        public int? Rate
        {
            get => this.rate_;

            set => this.SetProperty(ref this.rate_, value);
        }

        /// <summary>タイプ を取得、設定</summary>
        private string type_;
        /// <summary>タイプ を取得、設定</summary>
        public string Type
        {
            get => this.type_;

            set => this.SetProperty(ref this.type_, value);
        }

        /// <summary>属性 を取得、設定</summary>
        private CategoryAttribute categoryAttribute_;
        /// <summary>属性 を取得、設定</summary>
        public CategoryAttribute CategoryAttribute
        {
            get => this.categoryAttribute_;

            set => this.SetProperty(ref this.categoryAttribute_, value);
        }

        public string CategoryAttributeDescription => this.CategoryAttribute.GetDescription();

        /// <summary>更新フラグ を取得、設定</summary>
        private bool isUpdated_;
        /// <summary>更新フラグ を取得、設定</summary>
        public bool IsUpdated
        {
            get => this.isUpdated_;

            set => this.SetProperty(ref this.isUpdated_, value);
        }

        /// <summary>説明 を取得、設定</summary>
        private string detial_;
        /// <summary>説明 を取得、設定</summary>
        public string Detial
        {
            get => this.detial_;

            set => this.SetProperty(ref this.detial_, value);
        }

    }
}
