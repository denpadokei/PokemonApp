using MahApps.Metro.Controls.Dialogs;
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
        ICustomDialogService CustomDialogService { get; set; }
        void Show(string windowname, IDialogParameters parameter, Action<IDialogResult> action);
        void Show(object viewmodel, string title, string content);
        void ShowMessage(string message);
        void ShowDialog(string windowname, IDialogParameters parameter, Action<IDialogResult> action);
    }
}
