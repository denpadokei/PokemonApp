using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.PictureBook.Models
{
    public class TrickEntity : BindableBase
    {
        /// <summary>技の名前 を取得、設定</summary>
        private string name_;
        /// <summary>技の名前 を取得、設定</summary>
        public string Name
        {
            get { return this.name_; }
            set { this.SetProperty(ref name_, value); }
        }
    }
}
