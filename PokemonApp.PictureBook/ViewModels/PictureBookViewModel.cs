﻿using PokemonApp.Core.Bases;
using PokemonApp.Core.Collections;
using PokemonApp.Core.Models;
using PokemonApp.PictureBook.Models;
using PokemonApp.PictureBook.Views;
using Prism.Commands;
using Prism.Services.Dialogs;
using System.Collections.Generic;
using System.ComponentModel;

namespace PokemonApp.PictureBook.ViewModels
{
    public class PictureBookViewModel : BaseWindowViewModel
    {
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // プロパティ
        /// <summary>説明 を取得、設定</summary>
        private MTObservableCollection<PokemonEntity> pokemons_;
        /// <summary>説明 を取得、設定</summary>
        public MTObservableCollection<PokemonEntity> Pokemons
        {
            get => this.pokemons_;

            set => this.SetProperty(ref this.pokemons_, value);
        }

        /// <summary>覚える技コレクション を取得、設定</summary>
        private MTObservableCollection<TrickEntity> trickCollection_;
        /// <summary>覚える技コレクション を取得、設定</summary>
        public MTObservableCollection<TrickEntity> TrickCollection
        {
            get => this.trickCollection_;

            set => this.SetProperty(ref this.trickCollection_, value);
        }

        /// <summary>選択中 を取得、設定</summary>
        private PokemonEntity currentPokemon_;
        /// <summary>選択中 を取得、設定</summary>
        public PokemonEntity CurrentPokemon
        {
            get => this.currentPokemon_ ?? (this.currentPokemon_ = new PokemonEntity());

            set => this.SetProperty(ref this.currentPokemon_, value);
        }

        /// <summary>検索条件 を取得、設定</summary>
        private PictureBookFilter filter_;
        /// <summary>検索条件 を取得、設定</summary>
        public PictureBookFilter Filter
        {
            get => this.filter_;

            set => this.SetProperty(ref this.filter_, value);
        }

        /// <summary>登録コマンド を取得、設定</summary>
        private DelegateCommand registCommand_;
        /// <summary>登録コマンド を取得、設定</summary>
        public DelegateCommand RegistCommand => this.registCommand_ ?? (this.registCommand_ = new DelegateCommand(this.Regist));

        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // コマンド
        /// <summary>コマンド を取得、設定</summary>
        private DelegateCommand serchCommand_;
        /// <summary>コマンド を取得、設定</summary>
        public DelegateCommand SerchCommand

        {
            get => this.serchCommand_ ?? new DelegateCommand(this.Serch);

            set => this.SetProperty(ref this.serchCommand_, value);
        }

        /// <summary>絞り込みコマンド を取得、設定</summary>
        private DelegateCommand filteringCommand_;
        /// <summary>絞り込みコマンド を取得、設定</summary>
        public DelegateCommand FilteringCommand

        {
            get => this.filteringCommand_ ?? new DelegateCommand(this.Filtering);

            set => this.SetProperty(ref this.filteringCommand_, value);
        }

        /// <summary>特性を紐づけるコマンド を取得、設定</summary>
        private DelegateCommand comittCommand_;
        /// <summary>特性を紐づけるコマンド を取得、設定</summary>
        public DelegateCommand ComittCommand => this.comittCommand_ ?? (this.comittCommand_ = new DelegateCommand(this.CharComit));

        /// <summary>タイプを紐づけるコマンド を取得、設定</summary>
        private DelegateCommand typeComitCommand_;
        /// <summary>タイプを紐づけるコマンド を取得、設定</summary>
        public DelegateCommand TypeComitCommand => this.typeComitCommand_ ?? (this.typeComitCommand_ = new DelegateCommand(this.TypeComit));

        /// <summary>覚える技紐づけウインドウコマンド を取得、設定</summary>
        private DelegateCommand trickWindowcommand_;
        /// <summary>覚える技紐づけウインドウコマンド を取得、設定</summary>
        public DelegateCommand TrickWindowCommand => this.trickWindowcommand_ ?? (this.trickWindowcommand_ = new DelegateCommand(this.TrickComit));
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // コマンド用メソッド
        /// <summary>
        /// CSVから引っ張ってくる。
        /// </summary>
        private void Serch()
        {
            this.Pokemons.Clear();
            this.DataBaseService?.Load(this.domain_.Serch);
            //this.Pokemons.AddRange(PictureBookDataSet.FindPokemon());
            //this.DataBaseService?.Load(this, this.domain_.Serch);
        }

        private void SerchLeanTrick()
        {
            if (this.CurrentPokemon.Id != 0) {
                this.domain_.CurrentPokemon = this.CurrentPokemon;
                this.DataBaseService?.Load(this.domain_.SerchLearnTrick);
            }
        }

        private void Filtering()
        {
            this.domain_.Filtering();
        }

        private void Regist()
        {
            this.DataBaseService?.Regist(this.domain_.Regist);
        }

        private void TrickComit()
        {
            if (this.CurrentPokemon.Id != 0) {
                this.WindowManager.ShowDialog(nameof(LearnTrickLink), new DialogParameters() { { "PokemonId", this.CurrentPokemon.Id }, { "PokemonName", this.CurrentPokemon.Name } }, _ => { });
            }
        }

        private void CharComit()
        {
            //this.DataBaseService?.Regist(this.domain_.CharComit);
        }

        private void TypeComit()
        {
            //this.DataBaseService?.Regist(this.domain_.TypeComit);
        }
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // リクエスト
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // オーバーライドメソッド
        protected override void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnPropertyChanged(args);
            if (args.PropertyName == nameof(this.CurrentPokemon)) {
                this.SerchLeanTrick();
            }
        }

        protected override void OnMasterPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnMasterPropertyChanged(sender, e);
            if (sender is Master && e.PropertyName == nameof(this.Master.Generate)) {
                this.Serch();
            }
        }

        public override void OnInitialize()
        {
            base.OnInitialize();
            this.Serch();
            this.TrickCollection.Clear();
            this.domain_.PokemonList = new List<PokemonEntity>(this.Pokemons);
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
        private readonly PictureBookDomain domain_;
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // 構築・破棄
        public PictureBookViewModel()
        {
            this.domain_ = new PictureBookDomain();
            this.Pokemons = this.domain_.Collection;
            this.TrickCollection = this.domain_.TrickCollection;
            this.domain_.Filter = this.Filter;
        }
        #endregion
    }
}
