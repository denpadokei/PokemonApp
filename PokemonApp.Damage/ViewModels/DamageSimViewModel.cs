using PokemonApp.Core.ViewModels;
using PokemonApp.Damage.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace PokemonApp.Damage.ViewModels
{ 
    public class DamageSimViewModel : BaseWindowViewModel
    {
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // プロパティ
        /// <summary>レベル を取得、設定</summary>
        private int level_;
        /// <summary>レベル を取得、設定</summary>
        public int Level
        {
            get { return this.level_; }
            set { this.SetProperty(ref level_, value); }
        }

        /// <summary>技の威力 を取得、設定</summary>
        private int power_;
        /// <summary>技の威力 を取得、設定</summary>
        public int Power
        {
            get { return this.power_; }
            set { this.SetProperty(ref power_, value); }
        }

        /// <summary>攻撃値 を取得、設定</summary>
        private int powerValue_;
        /// <summary>攻撃値 を取得、設定</summary>
        public int PowerValue
        {
            get { return this.powerValue_; }
            set { this.SetProperty(ref powerValue_, value); }
        }

        /// <summary>防御値 を取得、設定</summary>
        private int blockValue_;
        /// <summary>防御値 を取得、設定</summary>
        public int BlockValue
        {
            get { return this.blockValue_; }
            set { this.SetProperty(ref blockValue_, value); }
        }

        /// <summary>倍率 を取得、設定</summary>
        private double magnification_;
        /// <summary>倍率 を取得、設定</summary>
        public double Magnification
        {
            get { return this.magnification_; }
            set { this.SetProperty(ref magnification_, value); }
        }

        /// <summary>最低値 取得、設定</summary>
        private int min_;
        /// <summary>最低値 を取得、設定</summary>
        public int Min
        {
            get { return this.min_; }
            set { this.SetProperty(ref min_, value); }
        }

        /// <summary>最大値 を取得、設定</summary>
        private int Max_;
        /// <summary>最大値 を取得、設定</summary>
        public int Max
        {
            get { return this.Max_; }
            set { this.SetProperty(ref Max_, value); }
        }

        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // コマンド

        /// <summary>攻撃コマンド を取得、設定</summary>
        private DelegateCommand attackCommand_;
        /// <summary>攻撃コマンド を取得、設定</summary>
        public DelegateCommand AttackCommand { get { return this.attackCommand_ ?? (this.attackCommand_ = new DelegateCommand(this.Attack)); } }

        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // コマンド用メソッド
        private void Attack()
        {
            this.domain_.Level = this.Level;
            this.domain_.Power = this.Power;
            this.domain_.PowerValue = this.PowerValue;
            this.domain_.BlockValue = this.BlockValue;
            this.domain_.Magnification = this.Magnification;
            this.domain_.Min = this.Min;
            this.domain_.Max = this.Max;
            this.domain_?.Attack();
            this.Level = this.domain_.Level;
            this.Power = this.domain_.Power;
            this.PowerValue = this.domain_.PowerValue;
            this.BlockValue = this.domain_.BlockValue;
            this.Magnification = this.domain_.Magnification;
            this.Min = this.domain_.Min;
            this.Max = this.domain_.Max;
        }

        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // リクエスト
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // オーバーライドメソッド
        public override void OnInitialize()
        {
            base.OnInitialize();
            this.Level = this.domain_.Level;
            this.Power = this.domain_.Power;
            this.PowerValue = this.domain_.PowerValue;
            this.BlockValue = this.domain_.BlockValue;
            this.Magnification = this.domain_.Magnification;
            this.Min = this.domain_.Min;
            this.Max = this.domain_.Max;
        }
        protected override void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnPropertyChanged(args);
            //this.Attack();
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
        private readonly DamageSimDomain domain_ = new DamageSimDomain();
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // 構築・破棄
        public DamageSimViewModel()
        {

        }
        #endregion
    }
}
