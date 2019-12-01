using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonApp.ViewModels
{
    public class BaseWindowViewModel : BindableBase, IDialogAware
    {
        protected virtual void Close()
        {
            this.RequestClose?.Invoke(new DialogResult(ButtonResult.None));
        }

        public BaseWindowViewModel()
        {

        }
        public string Title => "";

        public event Action<IDialogResult> RequestClose;

        public virtual bool CanCloseDialog()
        {
            return true;
        }

        public virtual void OnDialogClosed()
        {
            return;
        }

        public virtual void OnDialogOpened(IDialogParameters parameters)
        {
            return;
        }
    }
}
