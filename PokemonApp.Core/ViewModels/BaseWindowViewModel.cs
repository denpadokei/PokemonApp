using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonApp.Core.ViewModels
{
    public class BaseWindowViewModel : BindableBase, IDialogAware
    {
        public BaseWindowViewModel()
        {

        }

        public void Close()
        {
            this.RequestClose?.Invoke(new DialogResult());
        }

        public string Title => "Test";

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
