using PokemonApp.Core.Interface;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using Unity;

namespace PokemonApp.Core.ViewModels
{
    public class BaseWindowViewModel : BindableBase, IDialogAware
    {
        [Dependency]
        public IWindowManager WindowManager { get; set; }

        public BaseWindowViewModel()
        {
            this.Title = "Test";
        }

        public void Close()
        {
            this.RequestClose?.Invoke(new DialogResult());
        }

        /// <summary>タイトル を取得、設定</summary>
        private string title_;
        /// <summary>タイトル を取得、設定</summary>
        public string Title
        {
            get { return this.title_; }
            set { this.SetProperty(ref title_, value); }
        }

        public event Action<IDialogResult> RequestClose;

        public virtual bool CanCloseDialog()
        {
            return true;
        }

        public virtual void OnDialogClosed()
        {
            
        }

        public virtual void OnDialogOpened(IDialogParameters parameters)
        {
            
        }
    }
}
