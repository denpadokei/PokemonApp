﻿using PokemonApp.Core.Collections;
using PokemonApp.DataBase.Models;
using PokemonApp.PictureBook.DataBase;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PokemonApp.PictureBook.Models
{
    public class TrickDomain : BindableBase
    {
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // プロパティ
        /// <summary>コレクション を取得、設定</summary>
        private MTObservableCollection<TrickEntity> collection_;
        /// <summary>コレクション を取得、設定</summary>
        public MTObservableCollection<TrickEntity> Collection
        {
            get => this.collection_;

            set => this.SetProperty(ref this.collection_, value);
        }

        /// <summary>選択中の技 を取得、設定</summary>
        private TrickEntity currentMove_;
        /// <summary>選択中の技 を取得、設定</summary>
        public TrickEntity CurrentMove
        {
            get => this.currentMove_;

            set => this.SetProperty(ref this.currentMove_, value);
        }

        /// <summary>ポケモンのコレクション を取得、設定</summary>
        private MTObservableCollection<PokemonEntity> pokemonCollection_;
        /// <summary>ポケモンのコレクション を取得、設定</summary>
        public MTObservableCollection<PokemonEntity> PokemonCollection
        {
            get => this.pokemonCollection_;

            set => this.SetProperty(ref this.pokemonCollection_, value);
        }

        /// <summary>初期リスト を取得、設定</summary>
        private IReadOnlyList<TrickEntity> trickList_;
        /// <summary>初期リスト を取得、設定</summary>
        public IReadOnlyList<TrickEntity> TrickList
        {
            get => this.trickList_;

            set => this.SetProperty(ref this.trickList_, value);
        }

        /// <summary>検索条件 を取得、設定</summary>
        private PictureBookFilter filter_;
        /// <summary>検索条件 を取得、設定</summary>
        public PictureBookFilter Filter
        {
            get => this.filter_;

            set => this.SetProperty(ref this.filter_, value);
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
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // プライベートメソッド
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // パブリックメソッド
        public void Serch()
        {
            this.Collection.Clear();
            using (var repository = new Repository()) {
                var tricks = PictureBookDataBase.FindTrickList(repository.Context);
                this.Collection.AddRange(tricks);
            }
        }

        public void Filtering()
        {
            var list = new List<TrickEntity>(this.TrickList);
            this.Collection.Clear();
            this.Collection.AddRange(list.Where(x => x.Name.Contains(this.Filter.PokemonName)));
        }

        public void SetPokemon()
        {
            this.PokemonCollection.Clear();
            if (this.CurrentMove.TrickId == 0) {
                return;
            }
            using (var repository = new Repository()) {
                this.PokemonCollection.AddRange(PictureBookDataBase.FindLinkPokemon(repository.Context, this.CurrentMove.TrickId));
            }
        }

        public bool Regist()
        {
            //var logger = LogManager.GetCurrentClassLogger();
            //using (var repository = new Repository()) {

            //    var table = repository.Context.GetTable<trick>();
            //    var i = 1;
            //    foreach (var trick in this.Collection) {
            //        table.InsertOnSubmit(new trick()
            //        {
            //            trick_id = i,
            //            trick_name = trick.Name
            //        });
            //        ++i;
            //        logger.Info($"{i}行目が終わりました。");

            //    }
            //    try {
            //        repository.Context.SubmitChanges();
            //    }
            //    catch (Exception e) {
            //        logger.Error(e);
            //        //throw e;
            //    }
            //    finally {
            //    }

            //};
            return true;
        }
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // メンバ変数
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // 構築・破棄
        public TrickDomain()
        {
            this.Collection = new MTObservableCollection<TrickEntity>();
            this.PokemonCollection = new MTObservableCollection<PokemonEntity>();
            this.CurrentMove = new TrickEntity();
            this.TrickList = new List<TrickEntity>();
            this.Filter = new PictureBookFilter();
        }
        #endregion
    }
}
