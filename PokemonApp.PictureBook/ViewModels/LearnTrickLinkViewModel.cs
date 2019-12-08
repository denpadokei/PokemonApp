using PokemonApp.Core.ViewModels;
using PokemonApp.DataBase.Models;
using PokemonApp.PictureBook.DataBase;
using PokemonApp.PictureBook.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PokemonApp.PictureBook.ViewModels
{
    public class LearnTrickLinkViewModel : BaseWindowViewModel
    {
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // プロパティ
        /// <summary>ポケモンID を取得、設定</summary>
        private int pokemonId_;
        /// <summary>ポケモンID を取得、設定</summary>
        public int PokemonId
        {
            get { return this.pokemonId_; }
            set { this.SetProperty(ref pokemonId_, value); }
        }

        /// <summary>ポケモンの名前 を取得、設定</summary>
        private string pokemonName_;
        /// <summary>ポケモンの名前 を取得、設定</summary>
        public string PokemonName
        {
            get { return this.pokemonName_; }
            set { this.SetProperty(ref pokemonName_, value); }
        }

        /// <summary>技コレクション を取得、設定</summary>
        private ObservableCollection<TrickEntity> trickCollection_;
        /// <summary>技コレクション を取得、設定</summary>
        public ObservableCollection<TrickEntity> TrickCollection
        {
            get { return this.trickCollection_; }
            set { this.SetProperty(ref trickCollection_, value); }
        }

        /// <summary>技検索 を取得、設定</summary>
        private PictureBookFilter trickFilter_;
        /// <summary>技検索 を取得、設定</summary>
        public PictureBookFilter TrickFilter
        {
            get { return this.trickFilter_; }
            set { this.SetProperty(ref trickFilter_, value); }
        }

        /// <summary>技検索 を取得、設定</summary>
        private PictureBookFilter linkTrickFilter_;
        /// <summary>技検索 を取得、設定</summary>
        public PictureBookFilter LinkTrickFilter
        {
            get { return this.linkTrickFilter_; }
            set { this.SetProperty(ref linkTrickFilter_, value); }
        }

        /// <summary>選択中の技 を取得、設定</summary>
        private TrickEntity currentEntity_;
        /// <summary>選択中の技 を取得、設定</summary>
        public TrickEntity CurrentEntity
        {
            get { return this.currentEntity_ ?? (this.currentEntity_ = new TrickEntity()); }
            set { this.SetProperty(ref currentEntity_, value); }
        }

        /// <summary>覚える技一覧 を取得、設定</summary>
        private ObservableCollection<LinkTrickEntity> learnCollection_;
        /// <summary>覚える技一覧 を取得、設定</summary>
        public ObservableCollection<LinkTrickEntity> LearnCollection
        {
            get { return this.learnCollection_; }
            set { this.SetProperty(ref learnCollection_, value); }
        }

        /// <summary>選択中の覚える技 を取得、設定</summary>
        private LinkTrickEntity currentLinkEntity_;
        /// <summary>選択中の覚える技 を取得、設定</summary>
        public LinkTrickEntity CurrentLinkEntity
        {
            get { return this.currentLinkEntity_ ?? (this.currentLinkEntity_ = new LinkTrickEntity()); }
            set { this.SetProperty(ref currentLinkEntity_, value); }
        }
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // コマンド
        /// <summary>技追加コマンド を取得、設定</summary>
        private DelegateCommand addCommand_;
        /// <summary>技追加コマンド を取得、設定</summary>
        public DelegateCommand AddCommand { get { return this.addCommand_ ?? (this.addCommand_ = new DelegateCommand(this.MoveToRight)); } }

        /// <summary>技削除コマンド を取得、設定</summary>
        private DelegateCommand deleteCommand_;
        /// <summary>技削除コマンド を取得、設定</summary>
        public DelegateCommand DeleteCommand { get { return this.deleteCommand_ ?? (this.deleteCommand_ = new DelegateCommand(this.MoveToLeft)); } }

        /// <summary>登録コマンド を取得、設定</summary>
        private DelegateCommand registCommand_;
        /// <summary>登録コマンド を取得、設定</summary>
        public DelegateCommand RegistCommand { get { return this.registCommand_ ?? (this.registCommand_ = new DelegateCommand(this.Regist)); } }
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // コマンド用メソッド

        private void MoveToRight()
        {
            this.LearnCollection.Add(new LinkTrickEntity() { TrickEntity = this.CurrentEntity, IsAdded = true });
            this.TrickCollection.Remove(this.CurrentEntity);
        }

        private void MoveToLeft()
        {
            using (var repository = new Repository()) {
                this.TrickCollection.Add(this.CurrentLinkEntity.TrickEntity);
                this.LearnCollection.Remove(this.CurrentLinkEntity);
                if (this.CurrentLinkEntity.LinkTrickId != 0) {
                    repository.Context.link_tricks.Remove(repository.Context.link_tricks.FirstOrDefault(x => x.link_trick_id == CurrentLinkEntity.LinkTrickId));
                }
            }
        }

        private void Regist()
        {
            this.DataBaseService.Regist(this.domain_.Regist);
        }
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // リクエスト
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // オーバーライドメソッド
        public override void OnDialogOpened(IDialogParameters parameters)
        {
            base.OnDialogOpened(parameters);
            this.PokemonId = parameters.GetValue<int>("PokemonId");
            this.PokemonName = parameters.GetValue<string>("PokemonName");
        }
        public override void OnInitialize()
        {
            base.OnInitialize();
            using (var repository = new Repository()) {
                this.TrickCollection.AddRange(PictureBookDataBase.FindTrickList(repository.Context));
                this.LearnCollection.AddRange(PictureBookDataBase.FindLearnTrick(repository.Context, this.PokemonId));
            }
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
        private readonly LeranTrickLinkDomain domain_;
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // 構築・破棄
        public LearnTrickLinkViewModel()
        {
            this.domain_ = new LeranTrickLinkDomain();
            this.TrickCollection = new ObservableCollection<TrickEntity>();
            this.LearnCollection = this.domain_.LinkTrickColection;
        }
        #endregion
    }
}
