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
            get { return this.no_; }
            set { this.SetProperty(ref no_, value); }
        }

        /// <summary>ポケモンの名前 を取得、設定</summary>
        private string name_;
        /// <summary>ポケモンの名前 を取得、設定</summary>
        [DataMember(Name = "no")]
        public string Name
        {
            get { return this.name_; }
            set { this.SetProperty(ref name_, value); }
        }

        /// <summary>フォーム名 を取得、設定</summary>
        private string formName_;
        /// <summary>フォーム名 を取得、設定</summary>
        public string FormName
        {
            get { return this.formName_; }
            set { this.SetProperty(ref formName_, value); }
        }

        /// <summary>タイプ１ を取得、設定</summary>
        private string type1_;
        /// <summary>タイプ１ を取得、設定</summary>
        public string Type1
        {
            get { return this.type1_; }
            set { this.SetProperty(ref type1_, value); }
        }

        /// <summary>タイプ2 を取得、設定</summary>
        private string type2_;
        /// <summary>タイプ2 を取得、設定</summary>
        public string Type2
        {
            get { return this.type2_; }
            set { this.SetProperty(ref type2_, value); }
        }

        /// <summary>特性1 を取得、設定</summary>
        private string characteristic1_;
        /// <summary>特性1 を取得、設定</summary>
        public string Characteristic1
        {
            get { return this.characteristic1_; }
            set { this.SetProperty(ref characteristic1_, value); }
        }

        /// <summary>特性2 を取得、設定</summary>
        private string characteristic2_;
        /// <summary>特性2 を取得、設定</summary>
        public string Characteristic2
        {
            get { return this.characteristic2_; }
            set { this.SetProperty(ref characteristic2_, value); }
        }

        /// <summary>夢特性 を取得、設定</summary>
        private string dreamCharacteristic_;
        /// <summary>夢特性 を取得、設定</summary>
        public string DreamCharacteristic1
        {
            get { return this.dreamCharacteristic_; }
            set { this.SetProperty(ref dreamCharacteristic_, value); }
        }

        /// <summary>HP を取得、設定</summary>
        private int hp_;
        /// <summary>HP を取得、設定</summary>
        public int Hp
        {
            get { return this.hp_; }
            set { this.SetProperty(ref hp_, value); }
        }

        /// <summary>攻撃 を取得、設定</summary>
        private int attack_;
        /// <summary>攻撃 を取得、設定</summary>
        public int Attack
        {
            get { return this.attack_; }
            set { this.SetProperty(ref attack_, value); }
        }

        /// <summary>防御 を取得、設定</summary>
        private int block_;
        /// <summary>防御 を取得、設定</summary>
        public int Block
        {
            get { return this.block_; }
            set { this.SetProperty(ref block_, value); }
        }

        /// <summary>特攻 を取得、設定</summary>
        private int contact_;
        /// <summary>特攻 を取得、設定</summary>
        public int Contact
        {
            get { return this.contact_; }
            set { this.SetProperty(ref contact_, value); }
        }

        /// <summary>特防 を取得、設定</summary>
        private int defence_;
        /// <summary>特防 を取得、設定</summary>
        public int Defence
        {
            get { return this.defence_; }
            set { this.SetProperty(ref defence_, value); }
        }

        /// <summary>素早さ を取得、設定</summary>
        private int speed_;
        /// <summary>素早さ を取得、設定</summary>
        public int Speed
        {
            get { return this.speed_; }
            set { this.SetProperty(ref speed_, value); }
        }
        /// <summary>種族値合計 を取得、設定</summary>
        public int SumAll
        {
            get { return this.hp_ + this.attack_ + this.block_ + this.contact_ + this.defence_ + this.speed_; }
        }

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
            RaisePropertyChanged(nameof(this.SumAll));
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
