using PokemonApp.Core.Interfaces;
using Prism.Mvvm;

namespace PokemonApp.Core.Bases
{
    /// <summary>
    /// Jsonの入れ物以外に使うやつ
    /// </summary>
    public class EntityBase : BindableBase, ISelectable, IDeletable, IAddable
    {
        /// <summary>選択フラグ を取得、設定</summary>
        private bool isSelected_;
        /// <summary>選択フラグ を取得、設定</summary>
        public bool IsSelected
        {
            get => this.isSelected_;

            set => this.SetProperty(ref this.isSelected_, value);
        }

        /// <summary>削除フラグ を取得、設定</summary>
        private bool isDeleted_;
        /// <summary>削除フラグ を取得、設定</summary>
        public bool IsDeleted
        {
            get => this.isDeleted_;

            set => this.SetProperty(ref this.isDeleted_, value);
        }

        /// <summary>追加フラグ を取得、設定</summary>
        private bool isAdded_;
        /// <summary>追加フラグ を取得、設定</summary>
        public bool IsAdded
        {
            get => this.isAdded_;

            set => this.SetProperty(ref this.isAdded_, value);
        }

        public EntityBase()
        {

        }
    }
}
