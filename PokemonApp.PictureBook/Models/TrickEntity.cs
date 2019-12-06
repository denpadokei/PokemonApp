using PokemonApp.Core.Enums;
using PokemonApp.Core.Extentions;
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

        /// <summary>威力 を取得、設定</summary>
        private int power_;
        /// <summary>威力 を取得、設定</summary>
        public int Power
        {
            get { return this.power_; }
            set { this.SetProperty(ref power_, value); }
        }

        /// <summary>命中率 を取得、設定</summary>
        private int? rate_;
        /// <summary>命中率 を取得、設定</summary>
        public int? Rate
        {
            get { return this.rate_; }
            set { this.SetProperty(ref rate_, value); }
        }

        /// <summary>タイプ を取得、設定</summary>
        private string type_;
        /// <summary>タイプ を取得、設定</summary>
        public string Type
        {
            get { return this.type_; }
            set { this.SetProperty(ref type_, value); }
        }

        /// <summary>属性 を取得、設定</summary>
        private TypeAttribute typeAttribute_;
        /// <summary>属性 を取得、設定</summary>
        public TypeAttribute TypeAttribute
        {
            get { return this.typeAttribute_; }
            set { this.SetProperty(ref typeAttribute_, value); }
        }

        public string TypeAttributeString => EnumExtention.GetDescription(this.TypeAttribute);

        /// <summary>説明 を取得、設定</summary>
        private string detial_;
        /// <summary>説明 を取得、設定</summary>
        public string Detial
        {
            get { return this.detial_; }
            set { this.SetProperty(ref detial_, value); }
        }

    }
}
