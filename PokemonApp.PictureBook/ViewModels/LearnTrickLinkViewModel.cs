using PokemonApp.Core.Bases;
using PokemonApp.Core.Collections;
using PokemonApp.DataBase.Models;
using PokemonApp.PictureBook.DataBase;
using PokemonApp.PictureBook.Models;
using Prism.Commands;
using Prism.Services.Dialogs;
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
            get => this.pokemonId_;

            set => this.SetProperty(ref this.pokemonId_, value);
        }

        /// <summary>ポケモンの名前 を取得、設定</summary>
        private string pokemonName_;
        /// <summary>ポケモンの名前 を取得、設定</summary>
        public string PokemonName
        {
            get => this.pokemonName_;

            set => this.SetProperty(ref this.pokemonName_, value);
        }

        /// <summary>技コレクション を取得、設定</summary>
        private MTObservableCollection<TrickEntity> trickCollection_;
        /// <summary>技コレクション を取得、設定</summary>
        public MTObservableCollection<TrickEntity> TrickCollection
        {
            get => this.trickCollection_;

            set => this.SetProperty(ref this.trickCollection_, value);
        }

        /// <summary>技検索 を取得、設定</summary>
        private PictureBookFilter trickFilter_;
        /// <summary>技検索 を取得、設定</summary>
        public PictureBookFilter TrickFilter
        {
            get => this.trickFilter_;

            set => this.SetProperty(ref this.trickFilter_, value);
        }

        /// <summary>技検索 を取得、設定</summary>
        private PictureBookFilter linkTrickFilter_;
        /// <summary>技検索 を取得、設定</summary>
        public PictureBookFilter LinkTrickFilter
        {
            get => this.linkTrickFilter_;

            set => this.SetProperty(ref this.linkTrickFilter_, value);
        }


        /// <summary>覚える技一覧 を取得、設定</summary>
        private MTObservableCollection<LinkTrickEntity> learnCollection_;
        /// <summary>覚える技一覧 を取得、設定</summary>
        public MTObservableCollection<LinkTrickEntity> LearnCollection
        {
            get => this.learnCollection_;

            set => this.SetProperty(ref this.learnCollection_, value);
        }


        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // コマンド
        /// <summary>技追加コマンド を取得、設定</summary>
        private DelegateCommand<IList<object>> addCommand_;
        /// <summary>技追加コマンド を取得、設定</summary>
        public DelegateCommand<IList<object>> AddCommand => this.addCommand_ ?? (this.addCommand_ = new DelegateCommand<IList<object>>(this.MoveToRight));

        /// <summary>技削除コマンド を取得、設定</summary>
        private DelegateCommand<IList<object>> deleteCommand_;
        /// <summary>技削除コマンド を取得、設定</summary>
        public DelegateCommand<IList<object>> DeleteCommand => this.deleteCommand_ ?? (this.deleteCommand_ = new DelegateCommand<IList<object>>(this.MoveToLeft));

        /// <summary>登録コマンド を取得、設定</summary>
        private DelegateCommand registCommand_;
        /// <summary>登録コマンド を取得、設定</summary>
        public DelegateCommand RegistCommand => this.registCommand_ ?? (this.registCommand_ = new DelegateCommand(this.Regist));
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // コマンド用メソッド

        private void MoveToRight(IList<object> tricks)
        {
            var collection = new List<TrickEntity>(tricks.Cast<TrickEntity>()).AsEnumerable();
            using (var repository = new Repository()) {
                foreach (var move in collection) {
                    this.LearnCollection.Add(new LinkTrickEntity() { TrickEntity = move, IsAdded = true });
                    this.TrickCollection.Remove(move);
                    var linkTricks = repository.Context.link_tricks.Where(x => x.trick_id == move.TrickId);
                    foreach (var linkTrick in linkTricks) {
                        repository.Context.Remove(linkTrick);
                    }
                }
            }
        }

        private void MoveToLeft(IList<object> tricks)
        {
            var collection = new List<LinkTrickEntity>(tricks.Cast<LinkTrickEntity>()).AsEnumerable();
            foreach (var move in collection) {
                this.TrickCollection.Add(move.TrickEntity);
                this.LearnCollection.Remove(move);
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
            this.TrickCollection = new MTObservableCollection<TrickEntity>();
            this.LearnCollection = this.domain_.LinkTrickColection;
        }
        #endregion
    }
}
