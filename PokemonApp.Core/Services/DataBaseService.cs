﻿using MaterialDesignThemes.Wpf;
using NLog;
using PokemonApp.Core.Interfaces;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using Unity;

namespace PokemonApp.Core.Services
{
    public class DataBaseService : BindableBase, IDataBaseService
    {
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // プロパティ
        [Dependency]
        public IDialogService DialogService { get; set; }
        [Dependency]
        public IWindowManagerService WindowManager { get; set; }

        /// <summary>読み込み中かどうか を取得、設定</summary>
        private bool isLoading_;
        /// <summary>読み込み中かどうか を取得、設定</summary>
        public bool IsLoading
        {
            get => this.isLoading_;

            set => this.SetProperty(ref this.isLoading_, value);
        }

        private Logger Logger => LogManager.GetCurrentClassLogger();
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
        private void StartLoading()
        {
            lock (this.lockingObject_) {
                this.Logger.Info("読み込みを開始します。");
                this.lockingCount_++;
                this.IsLoading = true;
            }
        }
        private void EndLoading()
        {
            lock (this.lockingObject_) {
                this.lockingCount_--;
                if (this.lockingCount_ == 0) {
                    this.Logger.Info("読み込みを終了します。");
                    this.IsLoading = false;
                    //DialogHost.CloseDialogCommand.Execute(null, null);
                }
            }
        }
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // パブリックメソッド
        public async void Load(Action action)
        {
            try {
                this.StartLoading();
                await this.dispatcher_?.InvokeAsync(() => action?.Invoke());
            }
            catch (Exception e) {
                this.Logger.Error(e);
                this.DialogService?.ShowDialog("ConfirmationWindowView", new DialogParameters() { { "Title", "情報" }, { "Content", $"{e}" } }, _ => { });
                //throw;
            }
            finally {
                this.EndLoading();
            }
        }

        public async void Regist(Func<bool> func)
        {
            try {
                this.StartLoading();
                var result = await this.dispatcher_?.InvokeAsync(() => func?.Invoke());
                if (result == true) {
                    //this.DialogService.ShowDialog("ConfirmationWindowView", new DialogParameters() { { "Title", "情報" }, { "Content", "登録に成功しました" } }, _ => { });
                    this.WindowManager?.ShowMessage("登録に成功しました");
                }
                else {
                    this.DialogService?.ShowDialog("ConfirmationWindowView", new DialogParameters() { { "Title", "情報" }, { "Content", "登録するデータはありませんでした" } }, _ => { });
                }
            }
            catch (Exception e) {
                this.Logger.Error(e);
                this.DialogService?.ShowDialog("ConfirmationWindowView", new DialogParameters() { { "Title", "情報" }, { "Content", $"{e}" } }, _ => { });
                //throw;
            }
            finally {
                this.EndLoading();
            }
        }

        public void Regist(Func<int, bool> func, int num)
        {
            this.Regist(() => func.Invoke(num));
        }

        public void Regist(Func<int, bool?> func, int num)
        {
            this.Regist(() => func.Invoke(num).Value);
        }

        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // メンバ変数
        private readonly Dispatcher dispatcher_;
        private readonly Object lockingObject_ = new Object();
        private int lockingCount_;
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // 構築・破棄
        public DataBaseService()
        {
            // スレッドを起動して、そこで dispatcher を実行する
            var dispatcherSource = new TaskCompletionSource<Dispatcher>();
            var thread = new Thread(new ThreadStart(() =>
            {
                dispatcherSource.SetResult(Dispatcher.CurrentDispatcher);
                Dispatcher.Run();
            }));
            thread.Start();
            this.dispatcher_ = dispatcherSource.Task.Result; // メンバ変数に dispatcher を保存

            // 表のディスパッチャーが終了するタイミングで、こちらのディスパッチャーも終了する
            Dispatcher.CurrentDispatcher.ShutdownStarted += (s, e) => this.dispatcher_.BeginInvokeShutdown(DispatcherPriority.Normal);
        }
        #endregion
    }
}
