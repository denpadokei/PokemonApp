﻿using PokemonApp.Core.Enums;
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
            get { return this.trickId_; }
            set { this.SetProperty(ref trickId_, value); }
        }

        /// <summary>技の名前 を取得、設定</summary>
        private string name_;
        /// <summary>技の名前 を取得、設定</summary>
        public string Name
        {
            get { return this.name_; }
            set { this.SetProperty(ref name_, value); }
        }

        /// <summary>威力 を取得、設定</summary>
        private int? power_;
        /// <summary>威力 を取得、設定</summary>
        public int? Power
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
        private CategoryAttribute categoryAttribute_;
        /// <summary>属性 を取得、設定</summary>
        public CategoryAttribute CategoryAttribute
        {
            get { return this.categoryAttribute_; }
            set { this.SetProperty(ref categoryAttribute_, value); }
        }

        public string CategoryAttributeDescription => this.CategoryAttribute.GetDescription();

        /// <summary>更新フラグ を取得、設定</summary>
        private bool isUpdated_;
        /// <summary>更新フラグ を取得、設定</summary>
        public bool IsUpdated
        {
            get { return this.isUpdated_; }
            set { this.SetProperty(ref isUpdated_, value); }
        }

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
