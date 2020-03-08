using Dragablz;
using MaterialDesignThemes.Wpf;
using NLog;
using PokemonApp.Core.Interfaces;
using PokemonApp.Core.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Unity;

namespace PokemonApp.Core.Bases
{
    public class BaseWindowViewModel : BindableBase, IViewModelBaseable
    {
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // プロパティ
        [Dependency]
        public IWindowManagerService WindowManager { get; set; }
        [Dependency]
        public IDataBaseService DataBaseService { get; set; }
        [Dependency]
        public IRegionManager RegionManager { get; set; }
        [Dependency]
        public IInterTabClient TabClient { get; set; }
        [Dependency]
        public ICustomDialogService CustomDialogService { get; set; }

        protected virtual Logger Logger => LogManager.GetCurrentClassLogger();

        /// <summary>タイトル を取得、設定</summary>
        private string title_;
        /// <summary>タイトル を取得、設定</summary>
        public string Title
        {
            get => this.title_;

            set => this.SetProperty(ref this.title_, value);
        }

        /// <summary>ダイアログ用Openフラグ を取得、設定</summary>
        private bool isOpen_;
        /// <summary>ダイアログ用Openフラグ を取得、設定</summary>
        public bool IsOpen
        {
            get => this.isOpen_;

            set => this.SetProperty(ref this.isOpen_, value);
        }

        /// <summary>読み込み中 を取得、設定</summary>
        private bool isLoading_;
        /// <summary>読み込み中 を取得、設定</summary>
        public bool IsLoading
        {
            get => this.isLoading_;

            set => this.SetProperty(ref this.isLoading_, value);
        }

        /// <summary>開いているタブ を取得、設定</summary>
        private object currentView_;
        /// <summary>開いているタブ を取得、設定</summary>
        public object CurrentView
        {
            get => this.currentView_;

            set => this.SetProperty(ref this.currentView_, value);
        }
        /// <summary>マスター を取得、設定</summary>
        private Master master_;
        /// <summary>マスター を取得、設定</summary>
        public Master Master
        {
            get => this.master_;

            set => this.SetProperty(ref this.master_, value);
        }
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // コマンド
        /// <summary>ロードコマンド を取得、設定</summary>
        private DelegateCommand loadedCommand_;
        /// <summary>ロードコマンド を取得、設定</summary>
        public DelegateCommand LoadedCommand => this.loadedCommand_ ?? (this.loadedCommand_ = new DelegateCommand(this.OnInitialize));
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // コマンド用メソッド
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // リクエスト
        public event Action<IDialogResult> RequestClose;
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // オーバーライドメソッド
        protected override void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnPropertyChanged(args);
            if (args.PropertyName == nameof(this.IsLoading)) {
                if (this.IsLoading == true && this.IsOpen == false) {
                    this.Logger.Info("プログレスバーを表示します(嘘です)");
                    //this.CustomDialogService?.ShowProgress();
                }
                else if (this.IsLoading == false) {
                    this.Logger.Info("プログレスバーを消します");
                    this.CustomDialogService?.CloseProgress();
                    while (this.IsOpen == true) {
                        this.Logger.Info("IsOpenを直接falseにします。");
                        this.IsOpen = false;
                    }
                    this.RaisePropertyChanged(nameof(this.IsOpen));
                }
            }

            if (args.PropertyName == nameof(this.IsOpen)) {
                this.Logger.Info($"{this.IsOpen.ToString()} IsOpenが切り替わりました。");
            }

            if (args.PropertyName == nameof(this.CurrentView) && this.CurrentView is TabItem tabItem) {
                if (tabItem.DataContext is IViewModelBaseable context) {
                    WeakEventManager<INotifyPropertyChanged, PropertyChangedEventArgs>.RemoveHandler(
                        context, nameof(INotifyPropertyChanged.PropertyChanged), this.OnCurrentViewPropertyChanged);
                    WeakEventManager<INotifyPropertyChanged, PropertyChangedEventArgs>.AddHandler(
                        context, nameof(INotifyPropertyChanged.PropertyChanged), this.OnCurrentViewPropertyChanged);
                }
            }

        }
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // プライベートメソッド
        private void OnIsLoadingPropertyChenged(Object sender, PropertyChangedEventArgs e)
        {
            if (sender is IDataBaseService service) {
                if (e.PropertyName == nameof(IDataBaseService.IsLoading)) {
                    this.Logger.Info("データベースサービスのIsLoadingが切り替わりました。");
                    this.IsLoading = service.IsLoading;
                }
            }
        }

        protected virtual void OnMasterPropertyChanged(Object sender, PropertyChangedEventArgs e)
        {

        }

        protected virtual void OnCurrentViewPropertyChanged(Object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(IViewModelBaseable.IsLoading) && sender is IViewModelBaseable context) {
                this.Logger.Info("タブアイテムのIsLoadingが切り替わりました。");
                this.IsLoading = context.IsLoading;
            }
        }

        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // パブリックメソッド
        public void Close()
        {
            this.Logger.Info("画面を閉じました。");
            this.RequestClose?.Invoke(new DialogResult());
        }

        public virtual bool CanCloseDialog()
        {
            return !this.IsLoading;
        }

        public virtual void OnDialogClosed()
        {
            this.Dispose();
        }

        public virtual void OnDialogOpened(IDialogParameters parameters)
        {
            this.Title = parameters.GetValue<string>("Title");
        }

        public virtual void OnInitialize()
        {
            this.Logger.Info($"{this.Title}画面を開きました。");
            if (this.DataBaseService is INotifyPropertyChanged service) {
                WeakEventManager<INotifyPropertyChanged, PropertyChangedEventArgs>.RemoveHandler(
                service, nameof(INotifyPropertyChanged.PropertyChanged), this.OnIsLoadingPropertyChenged);
                WeakEventManager<INotifyPropertyChanged, PropertyChangedEventArgs>.AddHandler(
                service, nameof(INotifyPropertyChanged.PropertyChanged), this.OnIsLoadingPropertyChenged);
            }
            WeakEventManager<INotifyPropertyChanged, PropertyChangedEventArgs>.RemoveHandler(
                this.Master, nameof(INotifyPropertyChanged.PropertyChanged), this.OnMasterPropertyChanged);
            WeakEventManager<INotifyPropertyChanged, PropertyChangedEventArgs>.AddHandler(
                this.Master, nameof(INotifyPropertyChanged.PropertyChanged), this.OnMasterPropertyChanged);
        }
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // メンバ変数
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // 構築・破棄
        public BaseWindowViewModel()
        {
            this.Master = Master.Current;
        }

        #region IDisposable Support
        private bool disposedValue = false; // 重複する呼び出しを検出するには

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue) {
                if (disposing) {
                    // TODO: マネージ状態を破棄します (マネージ オブジェクト)。
                    this.Logger.Info("Dispose プログレスバーを閉じます");
                    this.CustomDialogService?.CloseProgress();
                }

                // TODO: アンマネージ リソース (アンマネージ オブジェクト) を解放し、下のファイナライザーをオーバーライドします。
                // TODO: 大きなフィールドを null に設定します。

                this.disposedValue = true;
            }
        }

        // TODO: 上の Dispose(bool disposing) にアンマネージ リソースを解放するコードが含まれる場合にのみ、ファイナライザーをオーバーライドします。
        // ~BaseWindowViewModel()
        // {
        //   // このコードを変更しないでください。クリーンアップ コードを上の Dispose(bool disposing) に記述します。
        //   Dispose(false);
        // }

        // このコードは、破棄可能なパターンを正しく実装できるように追加されました。
        public void Dispose()
        {
            // このコードを変更しないでください。クリーンアップ コードを上の Dispose(bool disposing) に記述します。
            this.Dispose(true);
            // TODO: 上のファイナライザーがオーバーライドされる場合は、次の行のコメントを解除してください。
            // GC.SuppressFinalize(this);
        }
        #endregion
        #endregion
    }
}
