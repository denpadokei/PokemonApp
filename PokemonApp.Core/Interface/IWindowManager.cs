using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.Core.Interface
{
    public interface IWindowManager
    {
        IDialogService DialogService { get; set; }
        void Show(string windowname, DialogParameters parameter, Action<IDialogResult> action);

        void ShowDialog(string windowname, DialogParameters parameter, Action<IDialogResult> action);
    }
}
