using MaterialDesignThemes.Wpf;
using NLog;
using PokemonApp.Core.Dialogs;
using PokemonApp.Core.Interfaces;
using Prism.Mvvm;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace PokemonApp.Core.Services
{
    public class CustomDialogService : BindableBase, ICustomDialogService
    {
        private Logger Logger => LogManager.GetCurrentClassLogger();

        /// <summary>ダイアログOpenフラグ を取得、設定</summary>
        private bool isOpen_;
        /// <summary>ダイアログOpenフラグ を取得、設定</summary>
        public bool IsOpen
        {
            get => this.isOpen_;

            set => this.SetProperty(ref this.isOpen_, value);
        }
        public async Task<bool> ShowMessege(string message, string identifir = "")
        {
            var dialog = new DialogWindow()
            {
                DataContext = new DialogWindowViewModel
                {
                    Message = message
                }
            };
            if (identifir == "") {
                object result = await DialogHost.Show(dialog, "TabWindowHost");
                return (result is bool selectedResult) && selectedResult;
            }
            else {
                object result = await DialogHost.Show(dialog);
                return (result is bool selectedResult) && selectedResult;
            }
            //throw new NotImplementedException();
        }

        public void ShowProgress()
        {
            this.Logger.Info("プログレスバーを表示します。");
            var progress = new ProgressBar();
            DialogHost.Show(progress, "ProgressHost");
        }

        public void CloseProgress()
        {
            // await Application.Current.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Background, new Action(() => { DialogHost.CloseDialogCommand.Execute(null, null); }) );
            this.Logger.Info("プログレスバーを閉じます。");
            DialogHost.CloseDialogCommand.Execute(null, null);
        }

        public void CloseDialog(object parameter, IInputElement target)
        {
            DialogHost.CloseDialogCommand.Execute(parameter, target);
        }

        public CustomDialogService()
        {

        }

    }
}
