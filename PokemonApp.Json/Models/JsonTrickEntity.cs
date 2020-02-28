using System.Runtime.Serialization;

namespace PokemonApp.Json.Models
{
    [DataContract]
    public class JsonTrickEntity
    {
        /// <summary>ID
        /// を取得、設定</summary>
        [DataMember(Name = "id")]
        public int? Id { get; set; }


        /// <summary>名前 を取得、設定</summary>
        [DataMember(Name = "ename")]
        public string Name { get; set; }


        /// <summary>カテゴリー を取得、設定</summary>
        [DataMember(Name = "category")]
        public string Category { get; set; }


        /// <summary>名前 を取得、設定</summary>
        [DataMember(Name = "jname")]
        public string JName { get; set; }


        /// <summary>威力 を取得、設定</summary>
        [DataMember(Name = "power")]
        public int? Power { get; set; }

        /// <summary>命中率 を取得、設定</summary>
        [DataMember(Name = "accuracy")]
        public int? Accuracy { get; set; }

        /// <summary>タイプ を取得、設定</summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }

        /// <summary>PP を取得、設定</summary>
        [DataMember(Name = "pp")]
        public int? Pp { get; set; }
    }
}
