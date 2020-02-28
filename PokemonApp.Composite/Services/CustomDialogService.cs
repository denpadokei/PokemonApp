using MaterialDesignThemes.Wpf;
using Prism.Mvvm;
using PokemonApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PokemonApp.Composite.Services
{
    public class CustomDialogService : BindableBase, ICustomDialogService
    {
        /// <summary>ダイアログOpenフラグ を取得、設定</summary>
        private bool isOpen_;
        /// <summary>ダイアログOpenフラグ を取得、設定</summary>
        public bool IsOpen
        {
            get { return this.isOpen_; }
            set { this.SetProperty(ref this.isOpen_, value); }
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

        public async Task ShowProgress()
        {
            var progress = new ProgressBar();
            await DialogHost.Show(progress);
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
