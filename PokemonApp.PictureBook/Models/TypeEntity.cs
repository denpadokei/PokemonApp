using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonApp.PictureBook.Models
{
    public class TypeEntity : BindableBase
    {
        /// <summary>タイプ名 を取得、設定</summary>
        private string name_;
        /// <summary>タイプ名 を取得、設定</summary>
        public string Name
        {
            get { return this.name_; }
            set { this.SetProperty(ref name_, value); }
        }

        public TypeEntity()
        {

        }
    }
}
