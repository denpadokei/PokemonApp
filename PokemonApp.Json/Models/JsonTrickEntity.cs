using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.Json.Models
{
    [DataContract]
    public class JsonTrickEntity
    {
        /// <summary>ID を取得、設定</summary>
        private int id_;
        /// <summary>ID
        /// を取得、設定</summary>
        [DataMember(Name = "id")]
        public int? Id { get; set; }
        
        /// <summary>名前 を取得、設定</summary>
        private string name_;
        /// <summary>名前 を取得、設定</summary>
        [DataMember(Name = "ename")]
        public string Name { get; set; }

        /// <summary>カテゴリー を取得、設定</summary>
        private string category_;
        /// <summary>カテゴリー を取得、設定</summary>
        [DataMember(Name = "category")]
        public string Category { get; set; }

        /// <summary>名前 を取得、設定</summary>
        private string jname_;
        /// <summary>名前 を取得、設定</summary>
        [DataMember(Name = "jname")]
        public string JName { get; set; }

        /// <summary>威力 を取得、設定</summary>
        private int power_;
        /// <summary>威力 を取得、設定</summary>
        [DataMember(Name = "power")]
        public int? Power { get; set; }

        /// <summary>命中率 を取得、設定</summary>
        private int accuracy_;
        /// <summary>命中率 を取得、設定</summary>
        [DataMember(Name = "accuracy")]
        public int? Accuracy { get; set; }

        /// <summary>タイプ を取得、設定</summary>
        private string type_;
        /// <summary>タイプ を取得、設定</summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }

        /// <summary>PP を取得、設定</summary>
        private int pp_;
        /// <summary>PP を取得、設定</summary>
        [DataMember(Name = "pp")]
        public int? Pp { get; set; }
    }
}
