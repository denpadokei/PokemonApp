using Prism.Mvvm;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace PokemonApp.Json.Models
{
    [DataContract]
    public class JsonConvertEntity : BindableBase
    {
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // プロパティ
        /// <summary>図鑑番号 を取得、設定</summary>
        private int no_;
        /// <summary>図鑑番号 を取得、設定</summary>
        [DataMember(Name = "name")]
        public int No
        {
            get => this.no_;

            set => this.SetProperty(ref this.no_, value);
        }

        /// <summary>ポケモンの名前 を取得、設定</summary>
        private string name_;
        /// <summary>ポケモンの名前 を取得、設定</summary>
        [DataMember(Name = "no")]
        public string Name
        {
            get => this.name_;

            set => this.SetProperty(ref this.name_, value);
        }

        /// <summary>フォーム名 を取得、設定</summary>
        private string formName_;
        /// <summary>フォーム名 を取得、設定</summary>
        public string FormName
        {
            get => this.formName_;

            set => this.SetProperty(ref this.formName_, value);
        }

        /// <summary>タイプ１ を取得、設定</summary>
        private string type1_;
        /// <summary>タイプ１ を取得、設定</summary>
        public string Type1
        {
            get => this.type1_;

            set => this.SetProperty(ref this.type1_, value);
        }

        /// <summary>タイプ2 を取得、設定</summary>
        private string type2_;
        /// <summary>タイプ2 を取得、設定</summary>
        public string Type2
        {
            get => this.type2_;

            set => this.SetProperty(ref this.type2_, value);
        }

        /// <summary>特性1 を取得、設定</summary>
        private string characteristic1_;
        /// <summary>特性1 を取得、設定</summary>
        public string Characteristic1
        {
            get => this.characteristic1_;

            set => this.SetProperty(ref this.characteristic1_, value);
        }

        /// <summary>特性2 を取得、設定</summary>
        private string characteristic2_;
        /// <summary>特性2 を取得、設定</summary>
        public string Characteristic2
        {
            get => this.characteristic2_;

            set => this.SetProperty(ref this.characteristic2_, value);
        }

        /// <summary>夢特性 を取得、設定</summary>
        private string dreamCharacteristic_;
        /// <summary>夢特性 を取得、設定</summary>
        public string DreamCharacteristic1
        {
            get => this.dreamCharacteristic_;

            set => this.SetProperty(ref this.dreamCharacteristic_, value);
        }

        /// <summary>HP を取得、設定</summary>
        private int hp_;
        /// <summary>HP を取得、設定</summary>
        public int Hp
        {
            get => this.hp_;

            set => this.SetProperty(ref this.hp_, value);
        }

        /// <summary>攻撃 を取得、設定</summary>
        private int attack_;
        /// <summary>攻撃 を取得、設定</summary>
        public int Attack
        {
            get => this.attack_;

            set => this.SetProperty(ref this.attack_, value);
        }

        /// <summary>防御 を取得、設定</summary>
        private int block_;
        /// <summary>防御 を取得、設定</summary>
        public int Block
        {
            get => this.block_;

            set => this.SetProperty(ref this.block_, value);
        }

        /// <summary>特攻 を取得、設定</summary>
        private int contact_;
        /// <summary>特攻 を取得、設定</summary>
        public int Contact
        {
            get => this.contact_;

            set => this.SetProperty(ref this.contact_, value);
        }

        /// <summary>特防 を取得、設定</summary>
        private int defence_;
        /// <summary>特防 を取得、設定</summary>
        public int Defence
        {
            get => this.defence_;

            set => this.SetProperty(ref this.defence_, value);
        }

        /// <summary>素早さ を取得、設定</summary>
        private int speed_;
        /// <summary>素早さ を取得、設定</summary>
        public int Speed
        {
            get => this.speed_;

            set => this.SetProperty(ref this.speed_, value);
        }
        /// <summary>種族値合計 を取得、設定</summary>
        public int SumAll => this.hp_ + this.attack_ + this.block_ + this.contact_ + this.defence_ + this.speed_;

        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // コマンド
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // コマンド用メソッド
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // リクエスト
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // オーバーライドメソッド
        protected override void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnPropertyChanged(args);
            this.RaisePropertyChanged(nameof(this.SumAll));
        }
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // プライベートメソッド
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // パブリックメソッド
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // メンバ変数
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // 構築・破棄
        #endregion
    }
}
