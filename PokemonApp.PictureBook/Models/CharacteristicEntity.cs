using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.PictureBook.Models
{
    public class CharacteristicEntity : BindableBase
    {
        /// <summary>特性の名前 を取得、設定</summary>
        private string name_;
        /// <summary>特性の名前 を取得、設定</summary>
        public string Name
        {
            get { return this.name_; }
            set { this.SetProperty(ref name_, value); }
        }

        /// <summary>特性の説明 を取得、設定</summary>
        private string deteal_;
        /// <summary>特性の説明 を取得、設定</summary>
        public string Deteal
        {
            get { return this.deteal_; }
            set { this.SetProperty(ref deteal_, value); }
        }
    }
}
