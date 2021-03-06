﻿using PokemonApp.AbilityValueConverter.Models;
using PokemonApp.Core.Bases;
using PokemonApp.Core.Collections;
using Prism.Commands;
using System;
using System.ComponentModel;

namespace PokemonApp.AbilityValueConverter.ViewModels
{
    public class AbilityValueConverterViewModel : BaseWindowViewModel
    {
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // プロパティ
        /// <summary>ポケモン名前一覧 を取得、設定</summary>
        private MTObservableCollection<string> pokemonNames_;
        /// <summary>ポケモン名前一覧 を取得、設定</summary>
        public MTObservableCollection<string> PokemonNames
        {
            get => this.pokemonNames_;

            set => this.SetProperty(ref this.pokemonNames_, value);
        }

        /// <summary>選択中のポケモン を取得、設定</summary>
        private string currentPokemon_;
        /// <summary>選択中のポケモン を取得、設定</summary>
        public string CurrentPokemon
        {
            get => this.currentPokemon_;

            set => this.SetProperty(ref this.currentPokemon_, value);
        }
        /// <summary>能力値コントローラーリスト を取得、設定</summary>
        private MTObservableCollection<NumberInputControler> controlers_;
        /// <summary>能力値コントローラーリスト を取得、設定</summary>
        public MTObservableCollection<NumberInputControler> Controlers
        {
            get => this.controlers_;

            set => this.SetProperty(ref this.controlers_, value);
        }

        /// <summary>推定固定値 を取得、設定</summary>
        private MTObservableCollection<IndividualEntity> individuals_;
        /// <summary>推定固定値 を取得、設定</summary>
        public MTObservableCollection<IndividualEntity> Individuals
        {
            get => this.individuals_;

            set => this.SetProperty(ref this.individuals_, value);
        }

        /// <summary>個体値一覧表 を取得、設定</summary>
        private MTObservableCollection<AbilityEntity> abilityes_;
        /// <summary>個体値一覧表 を取得、設定</summary>
        public MTObservableCollection<AbilityEntity> Abilityes
        {
            get => this.abilityes_;

            set => this.SetProperty(ref this.abilityes_, value);
        }

        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // コマンド
        /// <summary>絞り込みコマンド を取得、設定</summary>
        private DelegateCommand filteringCommand_;
        /// <summary>絞り込みコマンド を取得、設定</summary>
        public DelegateCommand FilteringCommand => this.filteringCommand_ ?? (this.filteringCommand_ = new DelegateCommand(this.Filtering));
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // コマンド用メソッド
        private void Filtering()
        {
            // 仮置き
            this.Serch();
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
            this.Serch();
        }

        protected override void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnPropertyChanged(args);
            if (args.PropertyName == nameof(this.CurrentPokemon)) {
                this.domain_.CurrentPokemon = this.CurrentPokemon;
            }
        }
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // プライベートメソッド
        private void Serch()
        {
            this.DataBaseService.Load(this.domain_.Serch);
        }

        /// <summary>
        /// 計算機の値が変化した時に呼び出されるあれ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnValuePropertyChanged(Object sender, PropertyChangedEventArgs e)
        {
            if (sender is NumberInputControler controler && (e.PropertyName == nameof(controler.EffortValue) || e.PropertyName == nameof(controler.Individualvalue))) {
                this.Calculation();
            }
        }

        /// <summary>
        /// 計算
        /// </summary>
        private void Calculation()
        {

        }
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // パブリックメソッド
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // メンバ変数
        private readonly AbilityValueConverterDomain domain_;
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // 構築・破棄
        public AbilityValueConverterViewModel()
        {
            this.domain_ = new AbilityValueConverterDomain();
            this.Controlers = new MTObservableCollection<NumberInputControler>() {
                new NumberInputControler("HP"),
                new NumberInputControler("こうげき"),
                new NumberInputControler("ぼうぎょ"),
                new NumberInputControler("とくこう"),
                new NumberInputControler("とくぼう"),
                new NumberInputControler("すばやさ"),
            };
            this.PokemonNames = this.domain_.PokemonNames;
            this.Individuals = this.domain_.Individuals;
            this.Abilityes = this.domain_.Abilityes;
        }
        #endregion
    }
}
