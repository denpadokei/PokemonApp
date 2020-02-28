using PokemonApp.Core.Interfaces;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.Composite.Services
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
            get { return this.isSelected_; }
            set { this.SetProperty(ref isSelected_, value); }
        }

        /// <summary>削除フラグ を取得、設定</summary>
        private bool isDeleted_;
        /// <summary>削除フラグ を取得、設定</summary>
        public bool IsDeleted
        {
            get { return this.isDeleted_; }
            set { this.SetProperty(ref isDeleted_, value); }
        }

        /// <summary>追加フラグ を取得、設定</summary>
        private bool isAdded_;
        /// <summary>追加フラグ を取得、設定</summary>
        public bool IsAdded
        {
            get { return this.isAdded_; }
            set { this.SetProperty(ref isAdded_, value); }
        }

        public EntityBase()
        {

        }
    }
}
